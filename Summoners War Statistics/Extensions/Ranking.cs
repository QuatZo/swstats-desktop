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
        private Dictionary<int, (Monster Mon, int HP)> TopHP = new Dictionary<int, (Monster Mon, int HP)>();
        private Dictionary<int, (Monster Mon, int DEF)> TopDEF = new Dictionary<int, (Monster Mon, int DEF)>();
        private Dictionary<int, (Monster Mon, int ATK)> TopATK = new Dictionary<int, (Monster Mon, int ATK)>();
        private Dictionary<int, (Monster Mon, int CDMG)> TopCDMG = new Dictionary<int, (Monster Mon, int CDMG)>();
        private Dictionary<int, (Monster Mon, double Eff)> TopEff = new Dictionary<int, (Monster Mon, double Eff)>();
        #endregion

        #region Methods
        private void ResetRanking()
        {
            TopSpeed = new Dictionary<int, (Monster Mon, int Spd)>();
            TopHP = new Dictionary<int, (Monster Mon, int HP)>();
            TopDEF = new Dictionary<int, (Monster Mon, int DEF)>();
            TopATK = new Dictionary<int, (Monster Mon, int ATK)>();
            TopCDMG = new Dictionary<int, (Monster Mon, int CDMG)>();
            TopEff = new Dictionary<int, (Monster Mon, double Eff)>();
        }

        public void Create(List<Monster> monsters, bool force=false)
        {
            if (force && (TopATK.Count > 1 || TopCDMG.Count > 1 || TopDEF.Count > 1 || TopEff.Count > 1 || TopHP.Count > 1 || TopSpeed.Count > 1))
            {
                ResetRanking();
            }
            else if (TopATK.Count > 1 || TopCDMG.Count > 1 || TopDEF.Count > 1 || TopEff.Count > 1 || TopHP.Count > 1 || TopSpeed.Count > 1)
            {
                throw new RankingAlreadyExistsException("If you want to force new Ranking, please use \"force\" argument.");
            }

            if (monsters.Count < 1) { throw new InvalidJSONException(); }

            Dictionary<int, (Monster Mon, int Spd)> topSpeed = new Dictionary<int, (Monster Mon, int Spd)>();
            Dictionary<int, (Monster Mon, int HP)> topHP = new Dictionary<int, (Monster Mon, int HP)>();
            Dictionary<int, (Monster Mon, int DEF)> topDEF = new Dictionary<int, (Monster Mon, int DEF)>();
            Dictionary<int, (Monster Mon, int ATK)> topATK = new Dictionary<int, (Monster Mon, int ATK)>();
            Dictionary<int, (Monster Mon, int CDMG)> topCDMG = new Dictionary<int, (Monster Mon, int CDMG)>();
            Dictionary<int, (Monster Mon, double Eff)> topEff = new Dictionary<int, (Monster Mon, double Eff)>();

            for (int i = 1; i <= monsters.Count; i++)
            {
                Dictionary<string, byte> runesOfSpecificSet = new Dictionary<string, byte>();
                foreach (Rune rune in monsters[i - 1].Runes)
                {
                    string runeSetName = Mapping.Instance.GetRuneSet((int)rune.SetId);
                    if (runesOfSpecificSet.Keys.Contains(runeSetName))
                    {
                        runesOfSpecificSet[runeSetName]++;
                    }
                    else { runesOfSpecificSet.Add(runeSetName, 1); }
                }

                int baseSpd = (int)monsters[i - 1].Spd;
                int spd = baseSpd;
                int baseHp = (int)monsters[i - 1].Con * 15;
                int hp = baseHp;
                int baseDef = (int)monsters[i - 1].Def;
                int def = baseDef;
                int baseAtk = (int)monsters[i - 1].Atk;
                int atk = baseAtk;
                int cdmg = (int)monsters[i - 1].CriticalDamage;
                double eff = 0.0;

                foreach (Rune rune in monsters[i - 1].Runes)
                {
                    string runeMainStatType = Mapping.Instance.GetRuneEffectType((int)rune.PriEff[0]);
                    string runeInnateStatType = Mapping.Instance.GetRuneInnateEffect(rune);

                    if (runeMainStatType == "SPD") { spd += (int)rune.PriEff[1]; }
                    else if(runeMainStatType == "HP flat") { hp += (int)rune.PriEff[1]; }
                    else if (runeMainStatType == "HP%") { hp += baseHp * (int)rune.PriEff[1] / 100; }
                    else if (runeMainStatType == "DEF flat") { def += (int)rune.PriEff[1]; }
                    else if (runeMainStatType == "DEF%") { def += baseDef * (int)rune.PriEff[1] / 100; }
                    else if (runeMainStatType == "ATK flat") { atk += (int)rune.PriEff[1]; }
                    else if (runeMainStatType == "ATK%") { atk += baseAtk * (int)rune.PriEff[1] / 100; }
                    else if (runeMainStatType == "CDmg") { cdmg += (int)rune.PriEff[1]; }


                    if (runeInnateStatType == "SPD") { spd += (int)rune.PrefixEff[1]; }
                    else if (runeInnateStatType == "HP flat") { hp += (int)rune.PrefixEff[1]; }
                    else if (runeInnateStatType == "HP%") { hp += baseHp * (int)rune.PrefixEff[1] / 100; }
                    else if (runeInnateStatType == "DEF flat") { def += (int)rune.PrefixEff[1]; }
                    else if (runeInnateStatType == "DEF%") { def += baseDef * (int)rune.PrefixEff[1] / 100; }
                    else if (runeInnateStatType == "ATK flat") { atk += (int)rune.PrefixEff[1]; }
                    else if (runeInnateStatType == "ATK%") { atk += baseAtk * (int)rune.PrefixEff[1] / 100; }
                    else if (runeInnateStatType == "CDmg") { cdmg += (int)rune.PrefixEff[1]; }

                    foreach (var substat in rune.SecEff)
                    {
                        string runeSubStatType = Mapping.Instance.GetRuneEffectType((int)substat[0]);
                        if (runeSubStatType == "SPD")
                        {
                            spd += (int)substat[1];
                            if (substat.Count > 3 && substat[3] > 0) { spd += (int)substat[3]; }
                        }
                        else if (runeSubStatType == "HP flat")
                        {
                            hp += (int)substat[1];
                            if (substat.Count > 3 && substat[3] > 0) { hp += (int)substat[3]; }
                        }
                        else if (runeSubStatType == "HP%")
                        {
                            hp += baseHp * (int)substat[1] / 100;
                            if (substat.Count > 3 && substat[3] > 0) { hp += baseHp * (int)substat[3] / 100; }
                        }
                        else if (runeSubStatType == "DEF flat")
                        {
                            def += (int)substat[1];
                            if (substat.Count > 3 && substat[3] > 0) { def += (int)substat[3]; }
                        }
                        else if (runeSubStatType == "DEF%")
                        {
                            def += baseDef * (int)substat[1] / 100;
                            if (substat.Count > 3 && substat[3] > 0) { def += baseDef * (int)substat[3] / 100; }
                        }
                        else if (runeSubStatType == "ATK flat")
                        {
                            atk += (int)substat[1];
                            if (substat.Count > 3 && substat[3] > 0) { atk += (int)substat[3]; }
                        }
                        else if (runeSubStatType == "ATK%")
                        {
                            atk += baseAtk * (int)substat[1] / 100;
                            if (substat.Count > 3 && substat[3] > 0) { atk += baseAtk * (int)substat[3] / 100; }
                        }
                        else if (runeSubStatType == "CDmg")
                        {
                            cdmg += (int)substat[1];
                            if (substat.Count > 3 && substat[3] > 0) { cdmg += (int)substat[3]; }
                        }
                    }
                    eff += Mapping.Instance.GetRuneEfficiency(rune).Current;
                }

                if (runesOfSpecificSet.Keys.Contains("Swift")) { spd += (int)(baseSpd * (runesOfSpecificSet["Swift"] / Mapping.Instance.GetRuneSetAmount("Swift")) * .25); }
                if (runesOfSpecificSet.Keys.Contains("Energy")) { hp += (int)(baseHp * (runesOfSpecificSet["Energy"] / Mapping.Instance.GetRuneSetAmount("Energy")) * .15); }
                if (runesOfSpecificSet.Keys.Contains("Guard")) { def += (int)(baseDef * (runesOfSpecificSet["Guard"] / Mapping.Instance.GetRuneSetAmount("Guard")) * .15); }
                if (runesOfSpecificSet.Keys.Contains("Fatal")) { atk += (int)(baseAtk * (runesOfSpecificSet["Fatal"] / Mapping.Instance.GetRuneSetAmount("Fatal")) * .35); }
                if (runesOfSpecificSet.Keys.Contains("Rage")) { cdmg += runesOfSpecificSet["Rage"] / Mapping.Instance.GetRuneSetAmount("Rage"); }

                topSpeed.Add(i, (monsters[i - 1], spd));
                topHP.Add(i, (monsters[i - 1], hp));
                topDEF.Add(i, (monsters[i - 1], def));
                topATK.Add(i, (monsters[i - 1], atk));
                topCDMG.Add(i, (monsters[i - 1], cdmg));
                topEff.Add(i, (monsters[i - 1], eff / 6));
            }

            KeyValuePair<int, (Monster Mon, int Spd)>[] topSpeedArray = topSpeed.ToArray();
            KeyValuePair<int, (Monster Mon, int HP)>[] topHPArray = topHP.ToArray();
            KeyValuePair<int, (Monster Mon, int DEF)>[] topDEFArray = topDEF.ToArray();
            KeyValuePair<int, (Monster Mon, int ATK)>[] topATKArray = topATK.ToArray();
            KeyValuePair<int, (Monster Mon, int CDMG)>[] topCDMGArray = topCDMG.ToArray();
            KeyValuePair<int, (Monster Mon, double Eff)>[] topEffArray = topEff.ToArray();
            Array.Sort(topSpeedArray, (a, b) => a.Value.Spd.CompareTo(b.Value.Spd));
            Array.Sort(topHPArray, (a, b) => a.Value.HP.CompareTo(b.Value.HP));
            Array.Sort(topDEFArray, (a, b) => a.Value.DEF.CompareTo(b.Value.DEF));
            Array.Sort(topATKArray, (a, b) => a.Value.ATK.CompareTo(b.Value.ATK));
            Array.Sort(topCDMGArray, (a, b) => a.Value.CDMG.CompareTo(b.Value.CDMG));
            Array.Sort(topEffArray, (a, b) => a.Value.Eff.CompareTo(b.Value.Eff));

            for (int i = 0; i < monsters.Count; i++)
            {
                TopSpeed.Add(monsters.Count - i, (topSpeedArray[i].Value.Mon, topSpeedArray[i].Value.Spd));
                TopHP.Add(monsters.Count - i, (topHPArray[i].Value.Mon, topHPArray[i].Value.HP));
                TopDEF.Add(monsters.Count - i, (topDEFArray[i].Value.Mon, topDEFArray[i].Value.DEF));
                TopATK.Add(monsters.Count - i, (topATKArray[i].Value.Mon, topATKArray[i].Value.ATK));
                TopCDMG.Add(monsters.Count - i, (topCDMGArray[i].Value.Mon, topCDMGArray[i].Value.CDMG));
                TopEff.Add(monsters.Count - i, (topEffArray[i].Value.Mon, topEffArray[i].Value.Eff));
            }
        }

        public (int Rank, int Spd) GetRankingSpeed(Monster monster)
        {
            KeyValuePair<int, (Monster Mon, int Spd)> rank = TopSpeed.Where(item => item.Value.Mon == monster).First();
            return (rank.Key, rank.Value.Spd);
        }
        public (int Rank, int HP) GetRankingHP(Monster monster)
        {
            KeyValuePair<int, (Monster Mon, int HP)> rank = TopHP.Where(item => item.Value.Mon == monster).First();
            return (rank.Key, rank.Value.HP);
        }
        public (int Rank, int DEF) GetRankingDEF(Monster monster)
        {
            KeyValuePair<int, (Monster Mon, int DEF)> rank = TopDEF.Where(item => item.Value.Mon == monster).First();
            return (rank.Key, rank.Value.DEF);
        }
        public (int Rank, int ATK) GetRankingATK(Monster monster)
        {
            KeyValuePair<int, (Monster Mon, int ATK)> rank = TopATK.Where(item => item.Value.Mon == monster).First();
            return (rank.Key, rank.Value.ATK);
        }
        public (int Rank, int CDMG) GetRankingCDMG(Monster monster)
        {
            KeyValuePair<int, (Monster Mon, int CDMG)> rank = TopCDMG.Where(item => item.Value.Mon == monster).First();
            return (rank.Key, rank.Value.CDMG);
        }
        public (int Rank, double Eff) GetRankingEff(Monster monster)
        {
            KeyValuePair<int, (Monster Mon, double Eff)> rank = TopEff.Where(item => item.Value.Mon == monster).First();
            return (rank.Key, rank.Value.Eff);
        }
        #endregion
    }
}
