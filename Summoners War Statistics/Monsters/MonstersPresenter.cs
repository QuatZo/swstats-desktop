using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using Summoners_War_Statistics.Properties;
using System.Drawing.Imaging;
using System.Reflection;
using System.IO;

namespace Summoners_War_Statistics
{
    class MonstersPresenter
    {
        IMonstersView view;
        Model model;

        public MonstersPresenter(IMonstersView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.InitMonsters += View_InitMonsters;

            this.view.CanSeeMonstersTab += View_CanSeeMonstersTab;

            this.view.Resized += View_Resized;

            this.view.MonstersCollectionItemChecked += View_MonstersCollectionItemChecked;

        }

        /// <summary>
        /// Event that triggers when someone check/uncheck one of the comboboxes which represent monster collection
        /// </summary>
        private void View_MonstersCollectionItemChecked()
        {
            view.MonstersCollectionSummoner = view.MonstersCollectionWhole = 0;
            bool specificStar = false;
            bool specificAttribute = false;
            if (view.MonstersCollectionCheckedStars.Count > 0) { specificStar = true; }
            if (view.MonstersCollectionCheckedAttributes.Count > 0) { specificAttribute = true; }

            view.MonstersCollectionSummoner = model.GetMonstersAmountInCollection(model.GetSummonersMonstersCollection(view.MonstersList), specificStar, specificAttribute,
                view.MonstersCollectionCheckedStars, view.MonstersCollectionCheckedAttributes);

            view.MonstersCollectionWhole = model.GetMonstersAmountInCollection(Mapping.Instance.GetMonstersCollection(), specificStar, specificAttribute,
                view.MonstersCollectionCheckedStars, view.MonstersCollectionCheckedAttributes);

            View_Resized();
            Logger.log.Info($"[Monsters] Monsters Collection done");

            InitMonstersList();

            try
            {
                Ranking.Instance.Create(view.MonstersListAffectedByCollection, force: true);
                Logger.log.Info("[Monsters] Ranking done");
            }
            catch (InvalidJSONException)
            {
                _ = MessageBox.Show("The JSON file you provided is invalid OR you didn't provide any JSON file at all.", "Invalid JSON File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Method that makes the static part of UI
        /// </summary>
        private void View_CanSeeMonstersTab()
        {
            // panelHeader
            int headerHeightFirstLevel = 10;
            // left
            int height = view.Cntrls[28].Size.Height + 2;
            int headerWidthFirstLevel = 10;
            view.Cntrls[24].Location = new Point(headerWidthFirstLevel, headerHeightFirstLevel);
            view.Cntrls[16].Location = new Point(headerWidthFirstLevel + view.Cntrls[24].Size.Width, headerHeightFirstLevel);

            int headerHeightSecondLevel = headerHeightFirstLevel + height;
            view.Cntrls[25].Location = new Point(headerWidthFirstLevel, headerHeightSecondLevel);
            view.Cntrls[5].Location = new Point(headerWidthFirstLevel + view.Cntrls[25].Size.Width, headerHeightSecondLevel);

            int headerHeightThirdLevel = headerHeightSecondLevel + height;
            view.Cntrls[26].Location = new Point(headerWidthFirstLevel, headerHeightThirdLevel);
            view.Cntrls[17].Location = new Point(headerWidthFirstLevel + view.Cntrls[26].Size.Width, headerHeightThirdLevel);

            int headerHeightFourthLevel = headerHeightThirdLevel + height;
            view.Cntrls[27].Location = new Point(headerWidthFirstLevel, headerHeightFourthLevel);
            view.Cntrls[7].Location = new Point(headerWidthFirstLevel + view.Cntrls[27].Size.Width, headerHeightFourthLevel);

            int headerHeightFifthLevel = headerHeightFourthLevel + height;
            view.Cntrls[28].Location = new Point(headerWidthFirstLevel, headerHeightFifthLevel);
            view.Cntrls[2].Location = new Point(headerWidthFirstLevel + view.Cntrls[28].Size.Width, headerHeightFifthLevel);

            // right
            view.Cntrls[0].Location = new Point(view.Cntrls[0].Location.X, headerHeightFirstLevel);
            view.Cntrls[18].Location = new Point(view.Cntrls[18].Location.X, headerHeightFirstLevel);
            view.Cntrls[19].Location = new Point(view.Cntrls[19].Location.X, headerHeightFirstLevel);
            view.Cntrls[9].Location = new Point(view.Cntrls[9].Location.X, headerHeightFirstLevel);

            view.Cntrls[20].Location = new Point(view.Cntrls[20].Location.X, headerHeightSecondLevel);
            view.Cntrls[4].Location = new Point(view.Cntrls[4].Location.X, headerHeightSecondLevel);

            view.Cntrls[1].Location = new Point(view.Cntrls[1].Location.X, headerHeightThirdLevel);
            view.Cntrls[21].Location = new Point(view.Cntrls[21].Location.X, headerHeightThirdLevel);
            view.Cntrls[22].Location = new Point(view.Cntrls[22].Location.X, headerHeightThirdLevel);
            view.Cntrls[6].Location = new Point(view.Cntrls[6].Location.X, headerHeightThirdLevel);

            view.Cntrls[23].Location = new Point(view.Cntrls[23].Location.X, headerHeightFourthLevel);
            view.Cntrls[3].Location = new Point(view.Cntrls[3].Location.X, headerHeightFourthLevel);
        }

        /// <summary>
        /// Event, which triggers when window is being resized
        /// </summary>
        private void View_Resized()
        {
            //labelNat5s                    - 0
            //labelLDNat4sPlus              - 1
            //labelDark                     - 2
            //labelDaysLDLightning          - 3
            //labelDaysNat5                 - 4
            //labelFire                     - 5
            //labelLDNat4Plus               - 6
            //labelLight                    - 7
            //labelMonsterStats             - 8
            //labelNat5                     - 9
            //labelStarsFiveAmount          - 10
            //labelStarsFourAmount          - 11
            //labelStarsOneAmount           - 12
            //labelStarsSixAmount           - 13
            //labelStarsThreeAmount         - 14
            //labelStarsTwoAmount           - 15
            //labelWater                    - 16
            //labelWind                     - 17
            //pictureBoxStarFives           - 18
            //pictureBoxElementalNat5       - 19
            //pictureBoxElementalNat5Clock  - 20
            //pictureBoxStarsFourPlus       - 21
            //pictureBoxLDNat4Plus          - 22
            //pictureBoxLDNat4PlusClock     - 23
            //pictureBoxWater               - 24
            //pictureBoxFire                - 25
            //pictureBoxWind                - 26
            //pictureBoxLight               - 27
            //pictureBoxDark                - 28
            //pictureBoxStars6              - 29
            //pictureBoxStars5              - 30
            //pictureBoxStars4              - 31
            //pictureBoxStars3              - 32
            //pictureBoxStars2              - 33
            //pictureBoxStars1              - 34
            //panelHeader                   - 35
            //panelHeaderLeft               - 36
            //panelHeaderMid                - 37
            //panelHeaderRight              - 38
            //labelCollectionStars          - 39
            //checkedListBoxCollectionStars - 40
            //labelCollectionAttribute      - 41
            //checkListBoxCol[...]Attribute - 42
            //labelCollection               - 43
            //labelCollectionSummoner       - 54
            //labelCollectionSlash          - 55
            //labelCollectionWhole          - 56

            // panelHeader
            int headerHeightFirstLevel = 10;
            // left
            int height = view.Cntrls[24].Size.Height + 2;
            int headerHeightSecondLevel = headerHeightFirstLevel + height;
            int headerHeightThirdLevel = headerHeightSecondLevel + height;
            int headerHeightFourthLevel = headerHeightThirdLevel + height;
            int headerHeightFifthLevel = headerHeightFourthLevel + height;

            // mid
            int headerWidthSecondLevel = view.Cntrls[37].Size.Width / 10;
            int headerWidthSecondHalfLevel = headerWidthSecondLevel + view.Cntrls[29].Size.Width;
            view.Cntrls[29].Location = new Point(headerWidthSecondLevel, headerHeightFirstLevel);
            view.Cntrls[13].Location = new Point(headerWidthSecondHalfLevel, headerHeightFirstLevel);

            view.Cntrls[30].Location = new Point(headerWidthSecondLevel, headerHeightSecondLevel);
            view.Cntrls[10].Location = new Point(headerWidthSecondHalfLevel, headerHeightSecondLevel);

            view.Cntrls[31].Location = new Point(headerWidthSecondLevel, headerHeightThirdLevel);
            view.Cntrls[11].Location = new Point(headerWidthSecondHalfLevel, headerHeightThirdLevel);

            view.Cntrls[32].Location = new Point(headerWidthSecondLevel, headerHeightFourthLevel);
            view.Cntrls[14].Location = new Point(headerWidthSecondHalfLevel, headerHeightFourthLevel);

            view.Cntrls[33].Location = new Point(headerWidthSecondLevel, headerHeightFifthLevel);
            view.Cntrls[15].Location = new Point(headerWidthSecondHalfLevel, headerHeightFifthLevel);

            int headerWidthThirdLevel = view.Cntrls[37].Size.Width * 5 / 10;
            int headerWidthThirdHalfLevel = headerWidthThirdLevel + view.Cntrls[39].Size.Width;
            int headerHeightSecondListBox = headerHeightFirstLevel + view.Cntrls[40].Size.Height;
            int headerHeightAfterListBox = headerHeightSecondListBox + view.Cntrls[42].Size.Height;

            view.Cntrls[39].Location = new Point(headerWidthThirdLevel, headerHeightFirstLevel);
            view.Cntrls[40].Location = new Point(headerWidthThirdHalfLevel, headerHeightFirstLevel);

            view.Cntrls[41].Location = new Point(headerWidthThirdLevel, headerHeightSecondListBox);
            view.Cntrls[42].Location = new Point(headerWidthThirdHalfLevel, headerHeightSecondListBox);

            view.Cntrls[43].Location = new Point(headerWidthThirdLevel, headerHeightAfterListBox);
            view.Cntrls[44].Location = new Point(headerWidthThirdHalfLevel, headerHeightAfterListBox);
            view.Cntrls[45].Location = new Point(view.Cntrls[44].Location.X + view.Cntrls[44].Size.Width, headerHeightAfterListBox);
            view.Cntrls[46].Location = new Point(view.Cntrls[45].Location.X + view.Cntrls[45].Size.Width, headerHeightAfterListBox);

            int headerHeightSixthLevel = headerHeightFifthLevel + height;
            view.Cntrls[34].Location = new Point(headerWidthSecondLevel, headerHeightSixthLevel);
            view.Cntrls[12].Location = new Point(headerWidthSecondHalfLevel, headerHeightSixthLevel);
        }

        //https://web.archive.org/web/20110827032809/http://www.switchonthecode.com/tutorials/csharp-tutorial-convert-a-color-image-to-grayscale
        private static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        private void InitMonstersList()
        {
            view.MonstersListView.Controls.Clear();

            List<MonstersToLockRow> monstersToLock = model.MonstersToLock(view.MonstersList, view.MonstersLocked);
            ResourceManager rm = Resources.ResourceManager;

            List<Monster> monsters = new List<Monster>();
            int monsterCounter = 0;
            for (int i = 0; i < view.MonstersList.Count; i++)
            {
                if(view.MonstersCollectionCheckedStars.Count > 0 && !view.MonstersCollectionCheckedStars.Contains(Mapping.Instance.GetMonsterBaseClass((int)view.MonstersList[i].UnitMasterId)) || view.MonstersCollectionCheckedAttributes.Count > 0 && !view.MonstersCollectionCheckedAttributes.Contains(Mapping.Instance.GetMonsterAttribute((int)view.MonstersList[i].UnitMasterId))) { continue; }

                monsterCounter++;
                monsters.Add(view.MonstersList[i]);
                PictureBox mon = new PictureBox();
                string monsterName = Mapping.Instance.GetMonsterName((int)view.MonstersList[i].UnitMasterId);
                string monsterAwakened = "monster_awakened_";
                string monsterFileName = monsterName.ToLower().Replace(" ", "").Replace("(", "_").Replace(")", "").Replace(".", "_").Replace("-", "_").Replace("'", "_");

                if (monsterName.Contains("(2A)"))
                {
                    monsterAwakened = "monster_secondawakened_";
                    monsterFileName = monsterFileName.Remove(monsterFileName.Length - 1 - 2);
                }

                object obj = rm.GetObject(monsterAwakened + monsterFileName.ToLower());
                if (obj == null)
                {
                    obj = rm.GetObject("monster_" + monsterFileName.ToLower());
                    if (obj == null)
                    {
                        obj = rm.GetObject("monster_unknown");
                    }
                }
                Image img;
                img = (Image)obj;
                mon.BorderStyle = BorderStyle.FixedSingle;

                if (monstersToLock.Where(shouldBeLocked => shouldBeLocked.ID == view.MonstersList[i].UnitId).Any())
                {
                    img = MakeGrayscale3((Bitmap)img);
                    view.SetInfoOnHover(mon, monsterName + " (This unit is in grayscale, because it should be locked!)");
                }
                else
                {
                    view.SetInfoOnHover(mon, monsterName);
                }

                mon.Image = img;
                mon.Size = img.Size;
                mon.Tag = view.MonstersList[i].UnitId;
                mon.Name = i.ToString();
                mon.Click += Test_Click;

                view.MonstersListView.Controls.Add(mon);
            }
            view.MonstersListAffectedByCollection = monsters;
            view.MonstersListHeader = "Monsters (" + monsterCounter + ")";
            Logger.log.Info($"[Monsters] Monsters list done");
        }

        private void SortByAttribute()
        {
            view.MonstersList = view.MonstersList.OrderBy(p => p.Attribute).ThenBy(q=>Mapping.Instance.GetMonsterBaseClass((int)q.UnitMasterId)).ThenBy(r=>r.UnitMasterId).ToList();
        }

        /// <summary>
        /// Method that initializes the whole Monster Tab
        /// </summary>
        private void View_InitMonsters(List<long> monstersLocked)
        {
            SortByAttribute();

            view.MonstersLocked = monstersLocked;
            Logger.log.Info($"[Monsters] Monsters locked done");

            view.ResetMonstersStats();
            Logger.log.Info($"[Monsters] Stats reseted");

            Dictionary<string, ushort> monsterAttributes = new Dictionary<string, ushort>();
            Dictionary<byte, ushort> monsterStars = new Dictionary<byte, ushort>();

            int daysSinceNat5 = 18250; // ~50 years
            int daysSinceLDLightning = 18250; // ~50 years
            DateTime now = DateTime.UtcNow;

            foreach (var monster in view.MonstersList)
            {
                int monsterBaseClass = Mapping.Instance.GetMonsterBaseClass((int)monster.UnitMasterId);
                bool isHoH = Mapping.Instance.GetMonsterHoHStatus((int)monster.UnitMasterId) || Mapping.Instance.GetMonsterHoHStatus((int)monster.UnitMasterId + 10);
                bool isFusion = Mapping.Instance.GetMonsterFusionStatus((int)monster.UnitMasterId) || Mapping.Instance.GetMonsterFusionStatus((int)monster.UnitMasterId + 10);
                string monsterName = Mapping.Instance.GetMonsterName((int)monster.UnitMasterId);
                
                if (monsterBaseClass >= 4 && !isHoH && !isFusion)
                {
                    int daysSinceSummon = (now - monster.CreateTime.Value.UtcDateTime).Days;
                    if (monster.Attribute == 4 || monster.Attribute == 5) {
                        view.MonstersLDNat4PlusAmount++;
                        if(daysSinceSummon < daysSinceLDLightning) { daysSinceLDLightning = daysSinceSummon; }
                        Logger.log.Info($"[Monsters] Monster {monsterName} (Master ID: {monster.UnitMasterId}) added to L&D nat4+ monsters");
                    }
                    else if(monsterBaseClass == 5)
                    {
                        view.MonstersNat5Amount++;
                        if (daysSinceSummon < daysSinceNat5) { daysSinceNat5 = daysSinceSummon; }
                        Logger.log.Info($"[Monsters] Monster {monsterName} (Master ID: {monster.UnitMasterId}) added to elemental nat5 monsters");
                    }
                }
                string monsterAttribute = Mapping.Instance.GetMonsterAttribute((int)monster.Attribute);
                byte monsterClass = (byte)monster.Class;
                if (monsterAttributes.Keys.Contains(monsterAttribute)){ monsterAttributes[monsterAttribute]++; }
                else { monsterAttributes.Add(monsterAttribute, 1); }

                if (monsterStars.Keys.Contains(monsterClass)) { monsterStars[monsterClass]++; }
                else { monsterStars.Add(monsterClass, 1); }
            }

            view.DaysSinceLastLDLightning = (ushort)daysSinceLDLightning;
            Logger.log.Info($"[Monsters] Days since last L&D lightning done");
            view.DaysSinceNat5 = (ushort)daysSinceNat5;
            Logger.log.Info($"[Monsters] Days since last nat5 done");

            if (monsterAttributes.Keys.Contains("Water")) { view.MonsterAttributeWater = monsterAttributes["Water"]; }
            if (monsterAttributes.Keys.Contains("Fire")) { view.MonsterAttributeFire = monsterAttributes["Fire"]; }
            if (monsterAttributes.Keys.Contains("Wind")) { view.MonsterAttributeWind = monsterAttributes["Wind"]; }
            if (monsterAttributes.Keys.Contains("Light")) { view.MonsterAttributeLight = monsterAttributes["Light"]; }
            if (monsterAttributes.Keys.Contains("Dark")) { view.MonsterAttributeDark = monsterAttributes["Dark"]; }
            Logger.log.Info($"[Monsters] Attributes done");

            if (monsterStars.Keys.Contains((byte)6)) { view.MonsterStarsSix = monsterStars[6]; }
            if (monsterStars.Keys.Contains((byte)5)) { view.MonsterStarsFive = monsterStars[5]; }
            if (monsterStars.Keys.Contains((byte)4)) { view.MonsterStarsFour = monsterStars[4]; }
            if (monsterStars.Keys.Contains((byte)3)) { view.MonsterStarsThree = monsterStars[3]; }
            if (monsterStars.Keys.Contains((byte)2)) { view.MonsterStarsTwo = monsterStars[2]; }
            if (monsterStars.Keys.Contains((byte)1)) { view.MonsterStarsOne = monsterStars[1]; }
            Logger.log.Info($"[Monsters] Stars done");

            View_MonstersCollectionItemChecked();
        }
        private void Test_Click(object sender, EventArgs e)
        {
            foreach (PictureBox control in view.MonstersListView.Controls)
            {
                if (control.Tag == ((PictureBox)sender).Tag)
                {
                    FormMonster.Instance.Display(view.MonstersList[int.Parse(control.Name)]);
                    break;
                }
            }
        }
    }
}
