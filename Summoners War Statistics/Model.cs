using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    class Model
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
                energyGain = energyGain.AddHours(2*energyToGet);

                if (listView) { date = energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss"); }
                else { date = $"{energyGain.ToString("dddd, dd-MMMM-yyyy HH:mm:ss")} you'll have {energyNeeded} dimensional energy if you don't use any."; }
            }

            return date;
        }

        public List<string[]> MonstersToLock(List<PurpleUnitList> monsters, List<long> monstersLocked, int stars)
        {
            List<string[]> mons = new List<string[]>();

            List<PurpleUnitList> monstersToLock = new List<PurpleUnitList>();
            foreach (var monster in monsters)
            {
                if (monster.UnitId == null) { continue; }
                
                // 14314 - rainbowmon
                // 15105 - devilmon
                if (((monster.Class >= stars && monster.UnitMasterId != 14314) || monster.UnitMasterId == 15105) && !monstersLocked.Contains((long)monster.UnitId)) { monstersToLock.Add(monster); }
            }
            foreach (var monsterToLock in monstersToLock)
            {
                Dictionary<string, byte> runesOfSpecificSet = new Dictionary<string, byte>();
                foreach (var rune in monsterToLock.Runes)
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

            foreach(var friend in friendsList)
            {
                friends.Add(new string[] { friend.WizardName, DateTimeOffset.FromUnixTimeSeconds((long)friend.LastLoginTimestamp).DateTime.ToString("dddd, dd-MMMM-yyyy HH:mm:ss"), Mapping.Instance.GetMonsterName((int)friend.RepUnitMasterId), friend.RepUnitLevel.ToString() });
            }

            return friends;
        }
    }
}
