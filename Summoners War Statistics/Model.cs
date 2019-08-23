using System;
using System.Collections.Generic;
using System.Linq;

namespace Summoners_War_Statistics
{
    internal class Model
    {
        public string DimHoleCalculateTime(ushort energyNeeded, short energy, DateTime energyGainStart, bool listView)
        {
            string date;

            if (listView) { date = "You have enough dimensional energy to 2A this unit."; }
            else { date = "Your dimensional energy has reached out the limit. You are wasting potential dimensional energy!"; }

            short energyToGet = (short)(energyNeeded - energy);
            if (energyToGet > 0)
            {
                DateTime energyGain = energyGainStart;
                energyGain = energyGain.AddHours(2 * energyToGet);

                if (listView) { date = energyGain.ToString("dd-MMMM-yyyy HH:mm:ss"); }
                else { date = $"{energyGain.ToString("dd-MMMM-yyyy HH:mm:ss")} you'll have {energyNeeded} dimensional energy if you don't use any."; }
            }

            return date;
        }

        public List<MonstersToLockRow> MonstersToLock(List<Monster> monsters, List<long> monstersLocked, int stars)
        {
            List<MonstersToLockRow> mons = new List<MonstersToLockRow>();

            List<Monster> monstersToLock = new List<Monster>();
            foreach (Monster monster in monsters)
            {
                if (monster.UnitId == null) { continue; }

                // 14314 - rainbowmon
                // 15105 - devilmon
                if (((monster.Class >= stars && monster.UnitMasterId != 14314) || monster.UnitMasterId == 15105) && !monstersLocked.Contains((long)monster.UnitId)) { monstersToLock.Add(monster); }
            }

            foreach (Monster monsterToLock in monstersToLock)
            {
                Dictionary<string, byte> runesOfSpecificSet = new Dictionary<string, byte>();
                foreach (Rune rune in monsterToLock.Runes)
                {
                    string runeSetName = Mapping.Instance.GetRuneSet((int)rune.SetId);
                    if (runesOfSpecificSet.Keys.Contains(runeSetName))
                    {
                        runesOfSpecificSet[runeSetName]++;
                    }
                    else { runesOfSpecificSet.Add(runeSetName, 1); }
                }

                string sets = "";
                foreach (KeyValuePair<string, byte> runesOnMonster in runesOfSpecificSet)
                {
                    byte tempRunesOnMonster = runesOnMonster.Value;
                    while (tempRunesOnMonster >= byte.Parse(Mapping.Instance.GetRuneSetAmount(runesOnMonster.Key)))
                    {
                        sets += $"{runesOnMonster.Key}, ";
                        tempRunesOnMonster -= byte.Parse(Mapping.Instance.GetRuneSetAmount(runesOnMonster.Key));
                    }
                }
                if (sets.Length == 0) { sets = "-"; }
                else { sets = sets.Remove(sets.Length - 2, 2); }

                mons.Add(new MonstersToLockRow(
                        Mapping.Instance.GetMonsterName((int)monsterToLock.UnitMasterId), 
                        (byte)monsterToLock.Class, 
                        (byte)monsterToLock.UnitLevel, 
                        (byte)monsterToLock.Runes.Count, 
                        sets
                    )
                );
            }
            return mons;
        }

        public List<FriendsRow> FriendsList(List<Friend> friendsList)
        {
            List<FriendsRow> friends = new List<FriendsRow>();

            foreach (Friend friend in friendsList)
            {
                friends.Add(
                    new FriendsRow(
                        friend.WizardName,
                        DateTimeOffset.FromUnixTimeSeconds((long)friend.LastLoginTimestamp).DateTime.ToString("dd-MMMM-yyyy HH:mm:ss"),
                        Mapping.Instance.GetMonsterName((int)friend.RepUnitMasterId),
                        (byte)friend.RepUnitClass,
                        (byte)friend.RepUnitLevel
                    )
                );
            }

            return friends;
        }

        public List<GuildMembersRow> GuildMembersList(GuildMap guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList)
        {
            List<GuildMembersRow> members = new List<GuildMembersRow>();
            List<long> membersInGuildwar = new List<long>();

            foreach (var guildwarMember in guildwarMemberList)
            {
                membersInGuildwar.Add((long)guildwarMember.WizardId);
            }

            foreach (var member in guild.GuildMembers)
            {
                string defenseFirst = "-";
                string defenseSecond = "-";

                foreach (var guildMemberDefense in guildMemberDefenseList)
                {
                    if (guildMemberDefense.WizardId == member.Value.WizardId && membersInGuildwar.Contains((long)guildMemberDefense.WizardId))
                    {
                        defenseFirst = guildMemberDefense.UnitList[0].Count.ToString();
                        defenseSecond = guildMemberDefense.UnitList[1].Count.ToString();
                        break;
                    }
                }

                members.Add(
                    new GuildMembersRow
                    (
                        member.Value.WizardName,
                        DateTimeOffset.FromUnixTimeSeconds((long)member.Value.JoinTimestamp).DateTime.ToString("dd-MMMM-yyyy HH:mm:ss"),
                        DateTimeOffset.FromUnixTimeSeconds((long)member.Value.LastLoginTimestamp).DateTime.ToString("dd-MMMM-yyyy HH:mm:ss"),
                        defenseFirst,
                        defenseSecond
                    )
                );
            }

            return members;
        }

        public List<GuildSiegeDefensesRow> GuildSiegeDefensesList(List<long> siegeDefenses, List<Monster> monsters)
        {
            List<GuildSiegeDefensesRow> comps = new List<GuildSiegeDefensesRow>();

            for(int i = 0; i < siegeDefenses.Count; i+= 3)
            {
                string[] units = { "-", "-", "-" };
                foreach(var unit in monsters)
                {
                    if (siegeDefenses[i] == unit.UnitId) { units[i % 3] = Mapping.Instance.GetMonsterName((int)unit.UnitMasterId); }
                    if (siegeDefenses[i + 1] == unit.UnitId) { units[(i % 3) + 1] = Mapping.Instance.GetMonsterName((int)unit.UnitMasterId); }
                    if (siegeDefenses[i + 2] == unit.UnitId) { units[(i % 3) + 2] = Mapping.Instance.GetMonsterName((int)unit.UnitMasterId); }
                    if (!units.Contains("-")) { break; }
                }

                comps.Add(
                    new GuildSiegeDefensesRow
                    (
                        units[0],
                        units[1],
                        units[2]
                    )
                );
            }

            return comps;
        }

        public List<Rune> RunesEvenEquipped(List<Rune> runesArg, List<Monster> monsters)
        {
            List<Rune> runes = runesArg;

            foreach (var monster in monsters)
            {
                foreach (var rune in monster.Runes)
                {
                    runes.Add(rune);
                }
            }

            return runes;
        }

        public Dictionary<long, int> MonstersMasterId(List<Monster> monsters)
        {
            Dictionary<long, int> monstersMasterId = new Dictionary<long, int>();

            foreach (var monster in monsters)
            {
                if (!monstersMasterId.ContainsKey((long)monster.UnitId)) { monstersMasterId.Add((long)monster.UnitId, (int)monster.UnitMasterId); }
            }

            return monstersMasterId;
        }

        private bool RuneMeetsRequirements(Rune rune, List<byte> filters, double runeEfficiency)
        {
            if (filters[0] != 0 && rune.SetId != filters[0]) { return false; } // set

            bool runeAncient = rune.Class > 10;
            byte runeClass =  runeAncient? (byte)(rune.Class - 10) : (byte)rune.Class;

            if (filters[2] == 0 && runeClass != filters[1]) { return false; } // stars
            if (filters[2] == 1 && runeClass > filters[1]) { return false; }
            if (filters[2] == 2 && runeClass < filters[1]) { return false; }
            if (filters[2] == 3 && runeClass >= filters[1]) { return false; }
            if (filters[2] == 4 && runeClass <= filters[1]) { return false; }

            if (filters[3] != 0 && rune.PriEff[0] != filters[3]) { return false; } // mainstat

            if (filters[4] == 98 && rune.PrefixEff[0] == 0) { return false; }
            else if (filters[4] == 99 && rune.PrefixEff[0] > 0) { return false; } // innate
            else if (filters[4] != 99 && filters[4] != 98 && filters[4] != 0 && rune.PrefixEff[0] != filters[4]) { return false; } // innate

            if (filters[5] != 0 && rune.Rank != filters[5]) { return false; } // quality
            if (filters[6] != 0 && rune.Extra != filters[6]) { return false; } // original quality
            if (filters[7] != 0 && rune.SlotNo != filters[7]) { return false; } // slot

            if (filters[8] == 1 && !runeAncient) { return false; } // ancient
            else if(filters[8] == 2 && runeAncient) { return false; }

            if (filters[10] == 0 && rune.UpgradeCurr != filters[9]) { return false; } // level
            if (filters[10] == 1 && rune.UpgradeCurr > filters[9]) { return false; }
            if (filters[10] == 2 && rune.UpgradeCurr < filters[9]) { return false; }
            if (filters[10] == 3 && rune.UpgradeCurr >= filters[9]) { return false; }
            if (filters[10] == 4 && rune.UpgradeCurr <= filters[9]) { return false; }

            if (filters[12] == 0 && runeEfficiency != filters[11]) { return false; } // efficiency
            if (filters[12] == 1 && runeEfficiency > filters[11]) { return false; }
            if (filters[12] == 2 && runeEfficiency < filters[11]) { return false; }
            if (filters[12] == 3 && runeEfficiency >= filters[11]) { return false; }
            if (filters[12] == 4 && runeEfficiency <= filters[11]) { return false; }

            // substats filter
            List<(byte Substat, byte YesNo)> substatFilters = new List<(byte Substat, byte YesNo)>()
                {
                    (filters[13], filters[14]),
                    (filters[15], filters[16]),
                    (filters[17], filters[18]),
                    (filters[19], filters[20])
                };
            bool shouldSkipRune = false;
            foreach ((byte Substat, byte YesNo) in substatFilters)
            {
                if (Substat != 0)
                {
                    bool hasSubstat = false;
                    foreach (var substat in rune.SecEff)
                    {
                        if (Substat == substat[0]) { hasSubstat = true; break; }
                    }
                    if ((!hasSubstat && YesNo != 0) || (hasSubstat && YesNo == 0)) { shouldSkipRune = true; break; }
                }
            }
            if (shouldSkipRune) { return false; }
            return true;
        }

        public List<RuneRow> RunesList(List<Rune> runes, Dictionary<long, int> monstersMasterId, List<byte> filters)
        {
            List<RuneRow> runesToReturn = new List<RuneRow>();
            try
            {
                var x = runes.Count;
            }
            catch (NullReferenceException) { return runesToReturn; }

            foreach (var rune in runes)
            {
                double runeEfficiency = Mapping.Instance.GetRuneEfficiency(rune).Current;

                if(!RuneMeetsRequirements(rune, filters, runeEfficiency)) { continue; }

                Dictionary<int, string> effect = new Dictionary<int, string>();

                foreach(KeyValuePair<int, string> runeEffectType in Mapping.Instance.GetAllRuneEffectTypes())
                {
                    effect.Add(runeEffectType.Key, "-");
                }

                foreach (var eff in rune.SecEff)
                {
                    effect[(int)eff[0]] = (eff[1] + eff[3]).ToString();
                }

                string origin = "Inventory";
                if (rune.OccupiedId != 0) { origin = Mapping.Instance.GetMonsterName(monstersMasterId[(long)rune.OccupiedId]); }

                byte runeClass = rune.Class > 10 ? (byte)(rune.Class - 10) : (byte)rune.Class;

                runesToReturn.Add(
                    new RuneRow
                    (
                        Mapping.Instance.GetRuneSet((int)rune.SetId),
                        runeClass,
                        (byte)rune.SlotNo,
                        (byte)rune.UpgradeCurr,
                        origin,
                        Mapping.Instance.GetRuneEffect(rune), // main
                        Mapping.Instance.GetRuneInnateEffect(rune), // innate
                        effect[1], // atk flat
                        effect[2], // atk %
                        effect[3], // hp flat
                        effect[4], // hp %
                        effect[5], // def flat
                        effect[6], // def %
                        effect[8], // spd
                        effect[9], // crate
                        effect[10], // cdmg
                        effect[11], // res
                        effect[12], // acc
                        runeEfficiency.ToString(), // eff.%
                        Mapping.Instance.GetRuneAncientStatus(rune) // ancient
                    )
                );
            }
            return runesToReturn;
        }

        public List<DecksRow> SummaryDecks(List<Monster> monsters, List<Deck> decks)
        {
            List<DecksRow> decksRows = new List<DecksRow>();

            foreach(var deck in decks)
            {
                string place = Mapping.Instance.GetDeckPlace((int)deck.DeckType);
                List<string> monstersDecks = new List<string>();

                bool isLeader = false;
                string leader = "-";

                foreach(var unit in deck.UnitIdList)
                {
                    if(unit == 0) { monstersDecks.Add("-"); continue; }
                    foreach(var monster in monsters)
                    {
                        if(monster.UnitId == unit)
                        {
                            string monsterName = Mapping.Instance.GetMonsterName((int)monster.UnitMasterId);
                            monstersDecks.Add(monsterName);
                            if (!isLeader && monster.UnitId == deck.LeaderUnitId) { leader = monsterName; isLeader = true; }
                            break;
                        }
                    }
                }

                decksRows.Add(new DecksRow
                    (
                        place,
                        monstersDecks,
                        leader
                    )
                );
            }

            return decksRows;
        }

        public Dictionary<(int Stars, string Attribute), int> GetSummonersMonstersCollection(List<Monster> monsters)
        {
            Dictionary<(int Stars, string Attribute), int> monstersSummonerCollection = new Dictionary<(int Stars, string Attribute), int>();

            List<int> monstersInCollection = new List<int>();
            foreach (var monster in monsters)
            {
                int monsterId = (int)monster.UnitMasterId;
                int baseClass = Mapping.Instance.GetMonsterBaseClass(monsterId);
                if (monstersInCollection.Contains(monsterId) || baseClass < 3) { continue; }
                monstersInCollection.Add(monsterId);

                string attribute = Mapping.Instance.GetMonsterAttribute(monsterId);
                if (!monstersSummonerCollection.ContainsKey((baseClass, attribute)))
                {
                    monstersSummonerCollection.Add((baseClass, attribute), 1);
                }
                else
                {
                    monstersSummonerCollection[(baseClass, attribute)]++;
                }
            }
            return monstersSummonerCollection;
        }

        public int GetMonstersAmountInCollection(Dictionary<(int Stars, string Attribute), int> collectionArg, bool specificStar, bool specificAttribute, List<int> stars, List<string> attributes)
        {
            int amount = 0;
            foreach (var collection in collectionArg)
            {
                if (specificStar && specificAttribute)
                {
                    foreach (var star in stars)
                    {
                        foreach (var attribute in attributes)
                        {
                            if (collection.Key == (star, attribute)) { amount += collection.Value; }
                        }
                    }
                }
                else if (specificStar)
                {
                    foreach (var star in stars)
                    {
                        if (collection.Key.Stars == star) { amount += collection.Value; }
                    }
                }
                else if (specificAttribute)
                {
                    foreach (var attribute in attributes)
                    {
                        if (collection.Key.Attribute == attribute) { amount += collection.Value; }
                    }
                }
                else
                {
                    amount += collection.Value;
                }
            }

            return amount;
        }

        public List<BuildingRow> TowersFlags(List<Decoration> decorations, List<Building> buildings, ushort arenaRanking, byte arenaWings, ushort guildRanking, byte guildBattlesWon, ushort siegeRanking, byte siegeFirstBattle, byte siegeSecondBattle)
        {
            List<BuildingRow> towersFlags = new List<BuildingRow>();
            foreach (var building in buildings)
            {
                foreach (var decoration in decorations)
                {
                    if (decoration.MasterId == building.Id)
                    {
                        building.ActualLevel = (int)decoration.Level;
                        break;
                    }
                }
                string bonus = "-";

                if (building.Type.Contains("%")) { bonus = building.Type.Replace("%", "") + building.Bonus[building.ActualLevel] + "%"; }
                else if (building.Type.Contains("Time/Energy")) { bonus = "Energy every " + Math.Floor((double)(building.Bonus[building.ActualLevel] / 60)) + ":" + building.Bonus[building.ActualLevel] % 60 + " minutes"; }
                else { bonus = building.Type + " +" + building.Bonus[building.ActualLevel]; }

                towersFlags.Add(
                    new BuildingRow(
                        building.Area,
                        building.Name,
                        bonus,
                        (byte)building.ActualLevel,
                        (ushort)(building.ActualLevel < 10 ? building.UpgradeCost[building.ActualLevel + 1] : 0),
                        (ushort)building.CalcRemainingUpgradeCost(),
                        TowersFlagsCalculateDays(building, arenaRanking, arenaWings, guildRanking, guildBattlesWon, siegeRanking, siegeFirstBattle, siegeSecondBattle)
                    )
                );
            }
            return towersFlags;
        }

        private string TowersFlagsCalculateDays(Building building, ushort arenaRanking, byte arenaWings, ushort guildRanking, byte guildBattlesWon, ushort siegeRanking, byte siegeFirstBattle, byte siegeSecondBattle)
        {
            int remainingUpgradeCost = building.CalcRemainingUpgradeCost();
            if ( remainingUpgradeCost < 1) { return "0"; }

            if (building.Area == Mapping.BuildingArea.Arena)
            {
                int gloryPointsPerWin = (arenaRanking / 1000 + 2);
                if (arenaRanking > 5000) { gloryPointsPerWin--; } // Legend gets same amount as Guardian

                double gloryPointsWeek = gloryPointsPerWin * arenaWings * 7;
                double gloryPointsDay = Math.Max((gloryPointsWeek - 180) / 7, 0); // devilmon

                return Math.Ceiling(remainingUpgradeCost / gloryPointsDay).ToString();
            }
            else
            {
                int guildPointsPerFight = (guildRanking / 1000 + 2);
                if (guildRanking > 5000) { guildPointsPerFight--; } // Legend gets same amount as Guardian

                int guildPointsPerBattle = guildPointsPerFight * 6 + 12; // 12 -> +6 rule

                SiegeRewards guildSiege = Mapping.Instance.GetSiegeRewards()[0];
                foreach (var siege in Mapping.Instance.GetSiegeRewards())
                {
                    if (siege.Id == siegeRanking) { guildSiege = siege; break; }
                }

                int guildPointsSiegeFirst;
                switch (siegeFirstBattle)
                {
                    case 1:
                        guildPointsSiegeFirst = (int)((double)guildSiege.FirstPlace.GuildPoints / 100 * 20000 * .05);
                        break;
                    case 2:
                        guildPointsSiegeFirst = (int)((double)guildSiege.SecondPlace.GuildPoints / 100 * 15000 * .05);
                        break;
                    case 3:
                        guildPointsSiegeFirst = (int)((double)guildSiege.ThirdPlace.GuildPoints / 100 * 10000 * .05);
                        break;
                    default:
                        guildPointsSiegeFirst = 0;
                        break;
                }

                int guildPointsSiegeSecond;
                switch (siegeSecondBattle)
                {
                    case 1:
                        guildPointsSiegeSecond = (int)((double)guildSiege.FirstPlace.GuildPoints / 100 * 20000 * .05);
                        break;
                    case 2:
                        guildPointsSiegeSecond = (int)((double)guildSiege.SecondPlace.GuildPoints / 100 * 15000 * .05);
                        break;
                    case 3:
                        guildPointsSiegeSecond = (int)((double)guildSiege.ThirdPlace.GuildPoints / 100 * 10000 * .05);
                        break;
                    default:
                        guildPointsSiegeSecond = 0;
                        break;
                }

                double gloryPointsWeek = Math.Max((guildPointsPerBattle * 12 + guildPointsPerBattle * guildBattlesWon) + guildPointsSiegeFirst + guildPointsSiegeSecond - 150, 0);
                return Math.Ceiling(remainingUpgradeCost * 7 / gloryPointsWeek).ToString();
            }
        }
    }
}
