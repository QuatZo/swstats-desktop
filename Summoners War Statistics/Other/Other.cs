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
        /// <summary>
        /// Size of the tab
        /// </summary>
        public Size TabSize
        {
            get => Size;
            set => Size = new Size(value.Width, value.Height);
        }

        /// <summary>
        /// List of the controls used in Dynamic UI
        /// </summary>
        public List<Control> Cntrls => new List<Control>()
        {
            labelOtherActiveFriends,
            objectListViewFriends,
            panelFriends,
            objectListViewTowersFlags,
            panelTowersFlags,
            labelMaxedFlags,
            labelMaxedFlagsText,
            labelMaxedTowers,
            labelMaxedTowersText,
            labelGuildBattlesWon,
            labelOtherTowerFlags,
            labelRankingArena,
            labelRankingGuild,
            labelSiegeContribution1,
            labelSiegeContribution2,
            labelRankingSige,
            labelSiegeResult1,
            labelSiegeResult2,
            labelWingsPerWeek,
            comboBoxGuildBattlesWon,
            comboBoxRankingArena,
            comboBoxRankingGuild,
            comboBoxRankingSiege,
            comboBoxSiegeResult1,
            comboBoxSiegeResult2,
            numericUpDownSiegeContribution1,
            numericUpDownSiegeContribution2,
            numericUpDownWingsPerDay
        };

        /// <summary>
        /// Friends List table
        /// </summary>
        public ObjectListView SummonerFriendsList
        {
            get => objectListViewFriends;
            set => objectListViewFriends = value;
        }
        /// <summary>
        /// Towers & Flags calculator table
        /// </summary>
        public ObjectListView SummonerTowersFlagsList
        {
            get => objectListViewTowersFlags;
            set => objectListViewTowersFlags = value;
        }

        /// <summary>
        /// Chosen arena ranking
        /// </summary>
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
        /// <summary>
        /// Chosen amount of wings used per day
        /// </summary>
        public byte ChosenArenaWingsPerDay => (byte)numericUpDownWingsPerDay.Value;

        /// <summary>
        /// Chosen guild ranking
        /// </summary>
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
        /// <summary>
        /// Chosen amount of won guild battles per week
        /// </summary>
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

        /// <summary>
        /// Chosen siege ranking
        /// </summary>
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
        /// <summary>
        /// Chosen result of the 1st siege battle during week
        /// </summary>
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
        /// <summary>
        /// Chosen contribution of the 1st siege battle during week
        /// </summary>
        public byte ChosenSiegeFirstBattleContribution => (byte)numericUpDownSiegeContribution1.Value;
        /// <summary>
        /// Chosen result of the 2nd siege battle during week
        /// </summary>
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
        /// <summary>
        /// Chosen contribution of the 2nd siege battle during week
        /// </summary>
        public byte ChosenSiegeSecondBattleContribution => (byte)numericUpDownSiegeContribution2.Value;

        /// <summary>
        /// List of buildings
        /// </summary>
        public List<Decoration> Decorations { get; set; }

        /// <summary>
        /// Days needed to max ALL towers, from the current state
        /// </summary>
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
                labelMaxedTowers.Text = value;
            }
        }
        /// <summary>
        /// Days needed to max ALL flags, from the current state
        /// </summary>
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
                labelMaxedFlags.Text = value;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Initialize whole Other tab
        /// </summary>
        public event Action<List<Friend>, List<Decoration>> InitOther;
        /// <summary>
        /// Resize the window
        /// </summary>
        public event Action Resized;
        /// <summary>
        /// Initialize Towers & Flags (w/ table)
        /// </summary>
        public event Action InitTowersFlags;
        #endregion

        public Other()
        {
            InitializeComponent();
            objectListViewFriends.DoubleBuffering(true);
            objectListViewTowersFlags.DoubleBuffering(true);
        }

        #region Methods
        /// <summary>
        /// Initialize comboboxes
        /// </summary>
        private void InitComboBoxes(long arenaRanking, double? guildRanking)
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

            comboBoxRankingGuild.SelectedValue = guildRanking != null ? (int)guildRanking : 0;

            Dictionary<int, string> towersFlagsRankingSiege = Mapping.Instance.GetAllGuildRankings(); // siege ranks
            towersFlagsRankingSiege = towersFlagsRankingSiege.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            comboBoxRankingSiege.DataSource = new BindingSource(towersFlagsRankingSiege, null);
            comboBoxRankingSiege.DisplayMember = "Value";
            comboBoxRankingSiege.ValueMember = "Key";

            comboBoxRankingSiege.SelectedValue = guildRanking != null ? (int)guildRanking : 0;

            numericUpDownWingsPerDay.Value = 10;
            comboBoxGuildBattlesWon.SelectedIndex = 12;
            comboBoxSiegeResult1.SelectedIndex = 0;
            numericUpDownSiegeContribution1.Value = 0;
            comboBoxSiegeResult2.SelectedIndex = 0;
            numericUpDownSiegeContribution2.Value = 0;
        }

        /// <summary>
        /// Initialize whole Other tab
        /// </summary>
        public void Init(List<Friend> friendsList, List<Decoration> decorations, long arenaRatingId, GuildWarRankingStat guildWarRankingStat)
        {
            objectListViewTowersFlags.Items.Clear();
            Decorations = decorations;

            if (guildWarRankingStat == null) { InitComboBoxes(arenaRatingId, Mapping.Instance.GetAllGuildRankings().Keys.First()); }
            else { InitComboBoxes(arenaRatingId, guildWarRankingStat.Current["rating_id"]); }

            InitOther?.Invoke(friendsList, decorations);
        }

        /// <summary>
        /// Bring Other tab to front
        /// </summary>
        public void Front()
        {
            BringToFront();
        }

        /// <summary>
        /// Reset Other tab to the default state, when the provided JSON file is invalid
        /// </summary>
        public void ResetOnFail()
        {
            SummonerFriendsList.Items.Clear();
            SummonerTowersFlagsList.Items.Clear();
            InitComboBoxes(0, 0);
            numericUpDownWingsPerDay.Value = numericUpDownSiegeContribution1.Value = numericUpDownSiegeContribution2.Value = comboBoxGuildBattlesWon.SelectedIndex = comboBoxRankingArena.SelectedIndex = comboBoxRankingGuild.SelectedIndex = comboBoxRankingSiege.SelectedIndex = comboBoxSiegeResult1.SelectedIndex = 
                comboBoxSiegeResult2.SelectedIndex = 0;
            DaysToMaxFlags = DaysToMaxTowers = "Never";
        }

        public void Other_Resize(object sender, EventArgs e)
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
