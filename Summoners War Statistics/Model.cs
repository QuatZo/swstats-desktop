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

        public List<string[]> MonstersToLock(List<PurpleUnitList> monsters, List<long> monstersLocked, int stars)
        {
            List<string[]> mons = new List<string[]>();

            List<PurpleUnitList> monstersToLock = new List<PurpleUnitList>();
            foreach (PurpleUnitList monster in monsters)
            {
                if (monster.UnitId == null) { continue; }

                // 14314 - rainbowmon
                // 15105 - devilmon
                if (((monster.Class >= stars && monster.UnitMasterId != 14314) || monster.UnitMasterId == 15105) && !monstersLocked.Contains((long)monster.UnitId)) { monstersToLock.Add(monster); }
            }
            foreach (PurpleUnitList monsterToLock in monstersToLock)
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

                mons.Add(new string[] { Mapping.Instance.GetMonsterName((int)monsterToLock.UnitMasterId), monsterToLock.Class.ToString(), monsterToLock.UnitLevel.ToString(), monsterToLock.Runes.Count.ToString(), sets });
            }
            return mons;
        }

        public List<string[]> FriendsList(List<FriendListElement> friendsList)
        {
            List<string[]> friends = new List<string[]>();

            foreach (FriendListElement friend in friendsList)
            {
                friends.Add(
                    new string[] {
                        friend.WizardName,
                        DateTimeOffset.FromUnixTimeSeconds((long)friend.LastLoginTimestamp).DateTime.ToString("dd-MMMM-yyyy HH:mm:ss"),
                        Mapping.Instance.GetMonsterName((int)friend.RepUnitMasterId),
                        friend.RepUnitClass.ToString(),
                        friend.RepUnitLevel.ToString()
                    }
                );
            }

            return friends;
        }

        public List<string[]> GuildMembersList(Guild guild, GuildwarParticipationInfo guildwarParticipationInfo, List<GuildwarMemberList> guildwarMemberList, List<GuildMemberDefenseList> guildMemberDefenseList)
        {
            List<string[]> members = new List<string[]>();
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
                    new string[]
                    {
                        member.Value.WizardName,
                        DateTimeOffset.FromUnixTimeSeconds((long)member.Value.JoinTimestamp).DateTime.ToString("dd-MMMM-yyyy HH:mm:ss"),
                        DateTimeOffset.FromUnixTimeSeconds((long)member.Value.LastLoginTimestamp).DateTime.ToString("dd-MMMM-yyyy HH:mm:ss"),
                        defenseFirst,
                        defenseSecond
                    }
                );
            }

            return members;

        }
    }
}
