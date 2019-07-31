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
        public Size SizeWindow => Size;

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
                    labelGuildPoints,
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
                    objectListViewDecks
                };
        public Image SummonerCountry
        {
            get => pictureBoxCountry.Image;
            set => pictureBoxCountry.Image = value;
        }

        public string SummonerName
        {
            get => labelSummonerName.Text;
            set => labelSummonerName.Text = value;
        }
        public byte SummonerLevel
        {
            get => byte.Parse(labelLevel.Text);
            set => labelLevel.Text = value.ToString();
        }

        public ulong SummonerMana
        {
            get => ulong.Parse(labelMana.Text);
            set => labelMana.Text = value.ToString("N0");
        }
        public uint SummonerCrystals
        {
            get => uint.Parse(labelCrystals.Text);
            set => labelCrystals.Text = value.ToString("N0");
        }
        public byte SummonerEnergy
        {
            get => byte.Parse(labelEnergy.Text);
            set => labelEnergy.Text = value.ToString();
        }
        public byte SummonerEnergyMax
        {
            get => byte.Parse(labelEnergyMax.Text);
            set => labelEnergyMax.Text = value.ToString();
        }
        public byte SummonerArenaEnergy
        {
            get => byte.Parse(labelArenaWings.Text);
            set => labelArenaWings.Text = value.ToString();
        }
        public byte SummonerArenaEnergyMax
        {
            get => byte.Parse(labelArenaWingsMax.Text);
            set => labelArenaWingsMax.Text = value.ToString();
        }
        public byte SummonerDimensionalCrystals
        {
            get => byte.Parse(labelDimensionalCrystals.Text);
            set => labelDimensionalCrystals.Text = value.ToString();
        }
        public byte SummonerDimensionalCrystalsMax
        {
            get => byte.Parse(labelDimensionalCrystalsMax.Text);
            set => labelDimensionalCrystalsMax.Text = value.ToString();
        }

        public uint SummonerGloryPoints
        {
            get => uint.Parse(labelGloryPoints.Text);
            set => labelGloryPoints.Text = value.ToString("N0");
        }
        public uint SummonerGuildPoints
        {
            get => uint.Parse(labelGuildPoints.Text);
            set => labelGuildPoints.Text = value.ToString("N0");
        }
        public ushort SummonerShapeshiftingStones
        {
            get => ushort.Parse(labelShapeshiftingStones.Text);
            set => labelShapeshiftingStones.Text = value.ToString("N0");
        }
        public uint SummonerRTAMedals
        {
            get => uint.Parse(labelRTAMedals.Text);
            set => labelRTAMedals.Text = value.ToString("N0");
        }

        public byte SummonerDimensionalHoleEnergy
        {
            get => byte.Parse(labelDimensionalHoleEnergy.Text);
            set => labelDimensionalHoleEnergy.Text = value.ToString();
        }
        public byte SummonerDimensionalHoleEnergyMax
        {
            get => byte.Parse(labelDimensionalHoleEnergyMax.Text);
            set => labelDimensionalHoleEnergyMax.Text = value.ToString();
        }
        public ushort SummonerMonstersAmount
        {
            get => ushort.Parse(labelMons.Text);
            set => labelMons.Text = value.ToString("N0");
        }
        public ushort SummonerMonstersLocked
        {
            get => ushort.Parse(labelMonsLocked.Text);
            set => labelMonsLocked.Text = value.ToString("N0");
        }

        public ushort SummonerRunes
        {
            get => ushort.Parse(labelRnes.Text);
            set => labelRnes.Text = value.ToString("N0");
        }
        public ushort SummonerRunesLocked
        {
            get => ushort.Parse(labelRnesLocked.Text.Replace(",", ""));

            set => labelRnesLocked.Text = value.ToString("N0");
        }

        public ushort SummonerSocialPoints
        {
            get => ushort.Parse(labelSocialPoints.Text);
            set => labelSocialPoints.Text = value.ToString("N0");
        }
        public ushort SummonerAncientCoins
        {
            get => ushort.Parse(labelAncientCoins.Text);
            set => labelAncientCoins.Text = value.ToString("N0");
        }

        public string JsonModifcationDate
        {
            get => labelJsonModified.Text;
            set => labelJsonModified.Text = value;
        }

        public ObjectListView SummaryDecksListView
        {
            get => objectListViewDecks;
            set => objectListViewDecks = value;
        }
        #endregion

        #region Events
        public event Action<Summoner, DimensionHoleInfo, List<Monster>, List<long>, List<Rune>, DateTime, string, List<Deck>, RaidDeck> InitSummary;
        public event Action Resized;
        public event Action Loaded;
        #endregion

        public Summary()
        {
            InitializeComponent();
        }

        #region Methods
        public void Init(Summoner wizardInfo, DimensionHoleInfo dimensionHoleInfo, List<Monster> monsters, List<long> monstersLocked, List<Rune> runes, DateTime jsonModificationTime, string country, List<Deck> decks, RaidDeck raidDeck)
        {
            InitSummary?.Invoke(wizardInfo, dimensionHoleInfo, monsters, monstersLocked, runes, jsonModificationTime, country, decks, raidDeck);
        }

        public void Front()
        {
            BringToFront();
        }

        private void Summary_Resize(object sender, EventArgs e)
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
