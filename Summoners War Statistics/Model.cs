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

                mons.Add(new MonstersToLockRow(Mapping.Instance.GetMonsterName((int)monsterToLock.UnitMasterId), (byte)monsterToLock.Class, (byte)monsterToLock.UnitLevel, (byte)monsterToLock.Runes.Count, sets));
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

        public List<GuildRow> GuildMembersList(Guild guild, GuildWarParticipationInfo guildwarParticipationInfo, List<GuildWarMember> guildwarMemberList, List<GuildMemberDefense> guildMemberDefenseList)
        {
            List<GuildRow> members = new List<GuildRow>();
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
                    new GuildRow
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

        public List<RuneRow> RunesList(List<Rune> runes, Dictionary<long, int> monstersMasterId, List<string> columns, List<byte> filters)
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

                if (filters[0] != 0 && rune.SetId != filters[0]) { continue; }
                if (filters[1] != 0 && rune.PriEff[0] != filters[1]) { continue; }
                if (filters[2] != 0 && rune.Rank != filters[2]) { continue; }
                if (filters[3] != 0 && rune.Extra != filters[3]) { continue; }
                if (filters[4] != 0 && rune.SlotNo != filters[4]) { continue; }

                if (filters[6] == 0 && rune.UpgradeCurr != filters[5]) { continue; }
                if (filters[6] == 1 && rune.UpgradeCurr > filters[5]) { continue; }
                if (filters[6] == 2 && rune.UpgradeCurr < filters[5]) { continue; }
                if (filters[6] == 3 && rune.UpgradeCurr >= filters[5]) { continue; }
                if (filters[6] == 4 && rune.UpgradeCurr <= filters[5]) { continue; }

                if (filters[8] == 0 && runeEfficiency != filters[7]) { continue; }
                if (filters[8] == 1 && runeEfficiency > filters[7]) { continue; }
                if (filters[8] == 2 && runeEfficiency < filters[7]) { continue; }
                if (filters[8] == 3 && runeEfficiency >= filters[7]) { continue; }
                if (filters[8] == 4 && runeEfficiency <= filters[7]) { continue; }

                Dictionary<int, string> effect = new Dictionary<int, string>();

                for (int i = 0; i <= 12; i++)
                {
                    if (i == 7) { continue; }
                    effect.Add(i, "-");
                }

                foreach (var eff in rune.SecEff)
                {
                    effect[(int)eff[0]] = (eff[1] + eff[3]).ToString();
                }

                string origin = "Inventory";
                if (rune.OccupiedId != 0) { origin = Mapping.Instance.GetMonsterName(monstersMasterId[(long)rune.OccupiedId]); }

                runesToReturn.Add(
                    new RuneRow
                    (
                        Mapping.Instance.GetRuneSet((int)rune.SetId),
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
                        runeEfficiency.ToString() // eff.%
                    )
                );
            }
            return runesToReturn;
        }
    }
}
