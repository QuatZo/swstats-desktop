using BrightIdeasSoftware;
using Summoners_War_Statistics.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class Summary : UserControl, ISummaryView
    {
        #region Properties
        /// <summary>
        /// Size of the window
        /// </summary>
        public Size SizeWindow => Size;

        /// <summary>
        /// List of controls used in Dynamic UI
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> Cntrls => new List<Control>()
                {
                    labelAncientCoins,
                    labelArenaWings,
                    labelArenaWingsMax,
                    labelArenaWingsSlash,
                    labelCrystals,
                    labelDimensionalCrystals,
                    labelDimensionalCrystalsMax,
                    labelDimensionalCrystalsSlash,
                    labelDimensionalHoleEnergy,
                    labelDimensionalHoleEnergyMax,
                    labelDimensionalHoleEnergySlash,
                    labelEnergy,
                    labelEnergyMax,
                    labelEnergySlash,
                    labelGloryPoints,
                    labelGldPoints,
                    labelJsonCreatedText,
                    labelJsonModified,
                    labelLevel,
                    labelMana,
                    labelMons,
                    labelMonsLocked,
                    labelRTAMedals,
                    labelRnes,
                    labelRnesLocked,
                    labelShapeshiftingStones,
                    labelSocialPoints,
                    labelSummonerName,
                    pictureBoxAncientCoins,
                    pictureBoxArenaWings,
                    pictureBoxCountry,
                    pictureBoxCrystals,
                    pictureBoxDimensionalCrystals,
                    pictureBoxDimensionalHoleEnergy,
                    pictureBoxEnergy,
                    pictureBoxGloryPoints,
                    pictureBoxGuildPoints,
                    pictureBoxMana,
                    pictureBoxMonsters,
                    pictureBoxMonstersLocked,
                    pictureBoxRTAMedals,
                    pictureBoxRunes,
                    pictureBoxRunesLocked,
                    pictureBoxShapeshiftingStones,
                    pictureBoxSocialPoints,
                    panelContent,
                    panelContentLeft,
                    panelContentMid,
                    panelContentRight,
                    panelDecks,
                    panelFooter,
                    panelHeader,
                    objectListViewDecks,
                    labelSummaryDecks
                };

        /// <summary>
        /// Image of the Summoner registration country
        /// </summary>
        public Image SummonerCountry
        {
            get => pictureBoxCountry.Image;
            set => pictureBoxCountry.Image = value;
        }

        /// <summary>
        /// Summoner's name
        /// </summary>
        public string SummonerName
        {
            get => labelSummonerName.Text;
            set => labelSummonerName.Text = value;
        }
        /// <summary>
        /// Summoner's level
        /// </summary>
        public byte SummonerLevel
        {
            get => byte.Parse(labelLevel.Text);
            set => labelLevel.Text = value.ToString();
        }

        /// <summary>
        /// Summoner's mana
        /// </summary>
        public ulong SummonerMana
        {
            get => ulong.Parse(labelMana.Text);
            set => labelMana.Text = value.ToString("N0");
        }
        /// <summary>
        /// Summoner's crystals
        /// </summary>
        public uint SummonerCrystals
        {
            get => uint.Parse(labelCrystals.Text);
            set => labelCrystals.Text = value.ToString("N0");
        }
        /// <summary>
        /// Summoner's energy
        /// </summary>
        public int SummonerEnergy
        {
            get => int.Parse(labelEnergy.Text);
            set => labelEnergy.Text = value.ToString();
        }
        /// <summary>
        /// Summoner's max amount of energy (depends on the level and arena towers upgrades)
        /// </summary>
        public byte SummonerEnergyMax
        {
            get => byte.Parse(labelEnergyMax.Text);
            set => labelEnergyMax.Text = value.ToString();
        }
        /// <summary>
        /// Summoner's arena wings
        /// </summary>
        public byte SummonerArenaEnergy
        {
            get => byte.Parse(labelArenaWings.Text);
            set => labelArenaWings.Text = value.ToString();
        }
        /// <summary>
        /// Summoner's max arena wings (should be static 10)
        /// </summary>
        public byte SummonerArenaEnergyMax
        {
            get => byte.Parse(labelArenaWingsMax.Text);
            set => labelArenaWingsMax.Text = value.ToString();
        }
        /// <summary>
        /// Summoner's dimensional rift crystals
        /// </summary>
        public byte SummonerDimensionalCrystals
        {
            get => byte.Parse(labelDimensionalCrystals.Text);
            set => labelDimensionalCrystals.Text = value.ToString();
        }
        /// <summary>
        /// Summoner's max dimensional rift crystals (should be static 10)
        /// </summary>
        public byte SummonerDimensionalCrystalsMax
        {
            get => byte.Parse(labelDimensionalCrystalsMax.Text);
            set => labelDimensionalCrystalsMax.Text = value.ToString();
        }

        /// <summary>
        /// Summoner's glory points
        /// </summary>
        public uint SummonerGloryPoints
        {
            get => uint.Parse(labelGloryPoints.Text);
            set => labelGloryPoints.Text = value.ToString("N0");
        }
        /// <summary>
        /// Summoner's guild points
        /// </summary>
        public uint SummonerGuildPoints
        {
            get => uint.Parse(labelGldPoints.Text);
            set => labelGldPoints.Text = value.ToString("N0");
        }
        /// <summary>
        /// Summoner's shapeshifting stones
        /// </summary>
        public ushort SummonerShapeshiftingStones
        {
            get => ushort.Parse(labelShapeshiftingStones.Text);
            set => labelShapeshiftingStones.Text = value.ToString("N0");
        }
        /// <summary>
        /// Summoner's RTA medals / points
        /// </summary>
        public uint SummonerRTAMedals
        {
            get => uint.Parse(labelRTAMedals.Text);
            set => labelRTAMedals.Text = value.ToString("N0");
        }

        /// <summary>
        /// Summoner's Dim Hole energy
        /// </summary>
        public byte SummonerDimensionalHoleEnergy
        {
            get => byte.Parse(labelDimensionalHoleEnergy.Text);
            set => labelDimensionalHoleEnergy.Text = value.ToString();
        }
        /// <summary>
        /// Summoner's max Dim Hole energy (should be static 100)
        /// </summary>
        public byte SummonerDimensionalHoleEnergyMax
        {
            get => byte.Parse(labelDimensionalHoleEnergyMax.Text);
            set => labelDimensionalHoleEnergyMax.Text = value.ToString();
        }
        /// <summary>
        /// Size of Summoner's monsters collection (w/ dupes)
        /// </summary>
        public ushort SummonerMonstersAmount
        {
            get => ushort.Parse(labelMons.Text);
            set => labelMons.Text = value.ToString("N0");
        }
        /// <summary>
        /// Size of Summoner's locked monsters collection (w/ dupes)
        /// </summary>
        public ushort SummonerMonstersLocked
        {
            get => ushort.Parse(labelMonsLocked.Text);
            set => labelMonsLocked.Text = value.ToString("N0");
        }

        /// <summary>
        /// Size of Summoner's runes inventory
        /// </summary>
        public ushort SummonerRunes
        {
            get => ushort.Parse(labelRnes.Text);
            set => labelRnes.Text = value.ToString("N0");
        }

        /// <summary>
        /// Size of Summoner's locked (equipped) runes inventory
        /// </summary>
        public ushort SummonerRunesLocked
        {
            get => ushort.Parse(labelRnesLocked.Text.Replace(",", ""));

            set => labelRnesLocked.Text = value.ToString("N0");
        }

        /// <summary>
        /// Summoner's social points
        /// </summary>
        public ushort SummonerSocialPoints
        {
            get => ushort.Parse(labelSocialPoints.Text);
            set => labelSocialPoints.Text = value.ToString("N0");
        }
        /// <summary>
        /// Summoner's ancient points
        /// </summary>
        public ushort SummonerAncientCoins
        {
            get => ushort.Parse(labelAncientCoins.Text);
            set => labelAncientCoins.Text = value.ToString("N0");
        }

        /// <summary>
        /// JSON modification date (when was downloaded by using SWEX)
        /// </summary>
        public string JsonModifcationDate
        {
            get => labelJsonModified.Text;
            set => labelJsonModified.Text = value;
        }

        /// <summary>
        /// Decks table
        /// </summary>
        public ObjectListView SummaryDecksListView
        {
            get => objectListViewDecks;
            set => objectListViewDecks = value;
        }
        #endregion

        #region Events
        /// <summary>
        /// Initialize whole Summary tab
        /// </summary>
        public event Action<Summoner, DimensionHoleInfo, List<Monster>, List<long>, List<Rune>, DateTime, string, List<Deck>> InitSummary;
        /// <summary>
        /// Resize window
        /// </summary>
        public event Action Resized;
        /// <summary>
        /// App 1st load
        /// </summary>
        public event Action Loaded;
        #endregion

        public Summary()
        {
            InitializeComponent();
        }

        #region Methods
        /// <summary>
        /// Initialize Summary tab
        /// </summary>
        public void Init(Summoner wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<Monster> monsters, List<long> monstersLocked, List<Rune> runes, DateTime jsonModificationTime, string country, 
            List<Deck> decks)
        {
            InitSummary?.Invoke(wizardInfo, dimensionHoleInfo, monsters, monstersLocked, runes, jsonModificationTime, country, decks);
        }

        /// <summary>
        /// Bring Summary tab to front
        /// </summary>
        public void Front()
        {
            BringToFront();
        }

        /// <summary>
        /// Reset everything to the default state, when provided JSON file was invalid
        /// </summary>
        public void ResetOnFail()
        {
            SummonerName = "QuatZo";
            SummonerMana = SummonerCrystals = SummonerGuildPoints = SummonerGloryPoints = SummonerRTAMedals = SummonerShapeshiftingStones = SummonerMonstersAmount = SummonerMonstersLocked = SummonerRunes = 
                SummonerRunesLocked = SummonerSocialPoints = SummonerAncientCoins = SummonerLevel = SummonerEnergyMax = SummonerArenaEnergy = SummonerArenaEnergyMax = SummonerDimensionalHoleEnergy =
                SummonerDimensionalHoleEnergyMax = SummonerDimensionalCrystals = SummonerDimensionalCrystalsMax  = 0;
            SummonerEnergy = 0;
            JsonModifcationDate = "Initialization failed.";
            SummaryDecksListView.Items.Clear();
            Resized?.Invoke();
        }

        public void Summary_Resize(object sender, EventArgs e)
        {
            Resized?.Invoke();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            Loaded?.Invoke();
        }
        #endregion

    }
}
