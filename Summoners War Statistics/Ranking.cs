using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summoners_War_Statistics
{
    internal class Ranking
    {
        #region Singleton
        private static Ranking instance = null;

        public static Ranking Instance => instance ?? (instance = new Ranking());
        #endregion

        private Ranking()
        {
        }

        #region Properties
        private Dictionary<int, (Monster Mon, int Spd)> TopSpeed = new Dictionary<int, (Monster Mon, int Spd)>();
        #endregion

        #region Methods
        private void ResetRanking()
        {
            TopSpeed = new Dictionary<int, (Monster Mon, int Spd)>();
        }

        public void Create(List<Monster> monsters)
        {
            ResetRanking();

            Dictionary<int, (Monster Mon, int Spd)> topSpeed = new Dictionary<int, (Monster Mon, int Spd)>();
            if (monsters.Count < 1) { throw new InvalidJSONException(); }

            for(int i = 1; i <= monsters.Count; i++) {
                int swiftRunes = 0;
                string monsterName = Mapping.Instance.GetMonsterName((int)monsters[i - 1].UnitMasterId);

                int spd = (int)monsters[i - 1].Spd;
                foreach(Rune rune in monsters[i - 1].Runes)
                {
                    if(rune.SlotNo == 2)
                    {
                        if (Mapping.Instance.GetRuneEffectType((int)rune.PriEff[0]).Contains("SPD")) { spd += (int)rune.PriEff[1]; }
                        else if (Mapping.Instance.GetRuneInnateEffect(rune).Contains("SPD")) { spd += (int)rune.PrefixEff[1]; }
                        else
                        {
                            foreach(var substat in rune.SecEff)
                            {
                                if (Mapping.Instance.GetRuneEffectType((int)substat[0]).Contains("SPD"))
                                {
                                    spd += (int)substat[1];
                                    if (substat.Count > 3 && substat[3] > 0) { spd += (int)substat[3];  }

                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Mapping.Instance.GetRuneInnateEffect(rune).Contains("SPD")) {  spd += (int)rune.PrefixEff[1];  }
                        else
                        {
                            foreach (var substat in rune.SecEff)
                            {
                                if (Mapping.Instance.GetRuneEffectType((int)substat[0]).Contains("SPD"))
                                {
                                    spd += (int)substat[1];
                                    
                                    if (substat.Count > 3 && substat[3] > 0) { spd += (int)substat[3];  }
                                    break;
                                }
                            }
                        }
                    }

                    if(Mapping.Instance.GetRuneSet((int)rune.SetId).ToLower() == "swift") { swiftRunes++; }
                    
                }
                if (swiftRunes >= 4) { spd += (int)Math.Ceiling((double)monsters[i - 1].Spd * .25); }
                
                topSpeed.Add(i, (monsters[i - 1], spd));
            }

            KeyValuePair<int, (Monster Mon, int Spd)>[] topSpeedArray = topSpeed.ToArray();
            Array.Sort(topSpeedArray, (a, b) => a.Value.Spd.CompareTo(b.Value.Spd));

            for (int i = 0; i < monsters.Count; i++)
            {
                TopSpeed.Add(monsters.Count - i, (topSpeedArray[i].Value.Mon, topSpeedArray[i].Value.Spd));
            }

            // ALL RANKS
            //foreach (var rank in TopSpeed)
            //{
            //    Console.WriteLine($"#{rank.Key}: {rank.Value.Spd} ({Mapping.Instance.GetMonsterName((int)rank.Value.Mon.UnitMasterId)})");
            //}
            // #1
            //Console.WriteLine($"#1: {TopSpeed[1].Spd} ({Mapping.Instance.GetMonsterName((int)TopSpeed[1].Mon.UnitMasterId)})");
        }

        public (int Rank, int Spd) GetRankingSpeed(Monster monster)
        {
            KeyValuePair<int, (Monster Mon, int Spd)> rank = TopSpeed.Where(item => item.Value.Mon == monster).First();
            return (rank.Key, rank.Value.Spd);
        }
        #endregion
    }
}
