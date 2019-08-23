using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Summoners_War_Statistics
{
    public partial class Other : UserControl, IOtherView
    {
        #region Properties
        public Size TabSize
        {
            get => Size;
            set => Size = new Size(value.Width, value.Height);
        }

        public List<Control> Cntrls => new List<Control>()
        {
            labelOtherActiveFriends,
            objectListViewFriends,
            panelFriends,
            objectListViewTowersFlags,
            panelTowersFlags
        };

        public ObjectListView SummonerFriendsList
        {
            get => objectListViewFriends;
            set => objectListViewFriends = value;
        }
        public ObjectListView SummonerTowersFlagsList
        {
            get => objectListViewTowersFlags;
            set => objectListViewTowersFlags = value;
        }

        public ushort ChosenArenaRanking
        {
            get
            {
                try
                {
                    return ushort.Parse(comboBoxRankingArena.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenArenaWingsPerDay
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxWingsPerDay.SelectedItem.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }

        public ushort ChosenGuildRanking
        {
            get
            {
                try
                {
                    return ushort.Parse(comboBoxRankingGuild.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }

            }
        }
        public byte ChosenGuildBattlesWon
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxGuildBattlesWon.SelectedItem.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }

        public ushort ChosenSiegeRanking
        {
            get
            {
                try
                {
                    return ushort.Parse(comboBoxRankingSiege.SelectedValue.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenSiegeFirstBattleResult
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxSiegeResult1.SelectedItem.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }
        public byte ChosenSiegeSecondBattleResult
        {
            get
            {
                try
                {
                    return byte.Parse(comboBoxSiegeResult2.SelectedItem.ToString());
                }
                catch (NullReferenceException) { return 0; }
                catch (FormatException) { return 0; }
            }
        }

        public List<Decoration> Decorations { get; set; }

        public string DaysToMaxTowers
        {
            get
            {
                if (labelMaxedTowers.Text.Contains("days"))
                {
                    return labelMaxedTowers.Text.Remove(labelMaxedTowers.Text.Length - 5);
                }
                return "Never";
            }
            set
            {
                try
                {
                    if (double.IsInfinity(double.Parse(value))){
                        labelMaxedTowers.Text = "Never";
                    }
                    else
                    {
                        labelMaxedTowers.Text = value;
                    }
                }
                catch (FormatException) { }
            }
        }
        public string DaysToMaxFlags
        {
            get
            {
                if (labelMaxedFlags.Text.Contains("days"))
                {
                    return labelMaxedFlags.Text.Remove(labelMaxedFlags.Text.Length - 5);
                }
                return "Never";
            }
            set
            {
                try
                {
                    if (double.IsInfinity(double.Parse(value)))
                    {
                        labelMaxedFlags.Text = "Never";
                    }
                    else
                    {
                        labelMaxedFlags.Text = value;
                    }
                }
                catch (FormatException) { }
            }
        }
        #endregion

        #region Events
        public event Action<List<Friend>, List<Decoration>> InitOther;
        public event Action Resized;
        public event Action InitTowersFlags;
        #endregion

        public Other()
        {
            InitializeComponent();
            objectListViewFriends.DoubleBuffering(true);
            objectListViewTowersFlags.DoubleBuffering(true);
        }

        #region Methods
        private void InitComboBoxes(long arenaRanking, double guildRanking)
        {
            Dictionary<int, string> towersFlagsRankingArena = Mapping.Instance.GetAllArenaRankings(); // arena ranks
            towersFlagsRankingArena = towersFlagsRankingArena.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRankingArena.DataSource = new BindingSource(towersFlagsRankingArena, null);
            comboBoxRankingArena.DisplayMember = "Value";
            comboBoxRankingArena.ValueMember = "Key";

            comboBoxRankingArena.SelectedValue = (int)arenaRanking;

            Dictionary<int, string> towersFlagsRankingGuild = Mapping.Instance.GetAllGuildRankings(); // guild ranks
            towersFlagsRankingGuild = towersFlagsRankingGuild.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRankingGuild.DataSource = new BindingSource(towersFlagsRankingGuild, null);
            comboBoxRankingGuild.DisplayMember = "Value";
            comboBoxRankingGuild.ValueMember = "Key";

            comboBoxRankingGuild.SelectedValue = (int)guildRanking;

            Dictionary<int, string> towersFlagsRankingSiege = Mapping.Instance.GetAllGuildRankings(); // siege ranks
            towersFlagsRankingSiege = towersFlagsRankingSiege.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRankingSiege.DataSource = new BindingSource(towersFlagsRankingSiege, null);
            comboBoxRankingSiege.DisplayMember = "Value";
            comboBoxRankingSiege.ValueMember = "Key";

            comboBoxRankingSiege.SelectedValue = (int)guildRanking;

            comboBoxWingsPerDay.SelectedIndex = 2;
            comboBoxGuildBattlesWon.SelectedIndex = 12;
            comboBoxSiegeResult1.SelectedIndex = 0;
            comboBoxSiegeResult2.SelectedIndex = 0;
        }

        public void Init(List<Friend> friendsList, List<Decoration> decorations, GuildWarRankingStat guildWarRankingStat, long arenaRatingId)
        {
            objectListViewTowersFlags.Items.Clear();
            Decorations = decorations;

            InitComboBoxes(arenaRatingId, guildWarRankingStat.Current["rating_id"]);
            InitOther?.Invoke(friendsList, decorations);
        }

        public void Front()
        {
            BringToFront();
        }

        public void ResetOnFail()
        {
            SummonerFriendsList.Items.Clear();
        }
        private void Other_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }
        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            objectListViewTowersFlags.Items.Clear();
            InitTowersFlags?.Invoke();
        }
        #endregion


    }
}
