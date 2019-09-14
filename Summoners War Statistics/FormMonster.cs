using Summoners_War_Statistics.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class FormMonster : Form
    {
        private readonly Monster monster;

        /// <summary>
        /// Font family used in the app
        /// </summary>
        public FontFamily FF { get; set; }
        /// <summary>
        /// Font used in the app
        /// </summary>
        public Font Fnt { get; set; }

        public FormMonster(Monster monster)
        {
            InitializeComponent();

            LoadFont();
            SetFont();

            ResourceManager rm = Resources.ResourceManager;

            this.monster = monster;
            Text = Mapping.Instance.GetMonsterName((int)this.monster.UnitMasterId);

            labelName.Text = Mapping.Instance.GetMonsterName((int)this.monster.UnitMasterId);
            (int Rank, int Spd) spdRank = Ranking.Instance.GetRankingSpeed(this.monster);
            labelSpeedRank.Text = $"#{spdRank.Rank} ({spdRank.Spd})";

            string monsterName = Mapping.Instance.GetMonsterName((int)this.monster.UnitMasterId);
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
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Image = img;
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        /// <summary>
        /// Loads the font
        /// </summary>
        private void LoadFont()
        {
            byte[] fontArray = Properties.Resources.coolvetica_condensed_rg;
            int dataLength = Properties.Resources.coolvetica_condensed_rg.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            FF = pfc.Families[0];
            Fnt = new Font(FF, 14f, FontStyle.Regular);
        }

        private void SetFont()
        {
            foreach(Control control in Controls)
            {
                control.Font = new Font(FF, 14, FontStyle.Regular);
                control.ForeColor = Color.FromArgb(255, 124, 0);
            }

        }
    }
}
