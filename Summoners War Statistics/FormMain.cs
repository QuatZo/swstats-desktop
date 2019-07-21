using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Summoners_War_Statistics
{
    public partial class FormMain : Form, IView
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        #region Properties
        public ISummaryView SummaryView => summary1;
        public IMenuView MenuView =>  menu1;
        public IMonstersView MonstersView => monsters1;
        public IRunesView RunesView => runes1;
        public IDimHoleView DimHoleView => dimHole1;
        public IOtherView OtherView => other1;

        public bool MenuViewVisibility
        {
            get => menu1.Visible;
            set => menu1.Visible = value;
        }
        public bool SummaryViewVisibility
        {
            get => summary1.Visible;
            set => summary1.Visible = value;
        }
        public bool MonstersViewVisibility
        {
            get => monsters1.Visible;
            set => monsters1.Visible = value;
        }
        public bool RunesViewVisibility
        {
            get => runes1.Visible;
            set => runes1.Visible = value;
        }
        public bool DimHoleViewVisibility
        {
            get => dimHole1.Visible;
            set => dimHole1.Visible = value;
        }
        public bool OtherViewVisibility
        {
            get => other1.Visible;
            set => other1.Visible = value;
        }

        public OpenFileDialog OpenFile
        {
            get
            {
                return openFileDialog;
            }
            set
            {
                openFileDialog = value;
            }
        }
        #endregion

        #region Events
        public event Action SelectFileButtonClicked;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        #region Methods
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

            ff = pfc.Families[0];
            font = new Font(ff, 14f, FontStyle.Regular);
        }

        public void ShowMessage(string message, MessageBoxIcon messageBoxIcon)
        {
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            switch (messageBoxIcon)
            {
                default:
                    caption = "Error";
                    break;
                case MessageBoxIcon.Information:
                    caption = "Information";
                    break;
                case MessageBoxIcon.Question:
                    caption = "Question";
                    buttons = MessageBoxButtons.YesNoCancel;
                    break;
                case MessageBoxIcon.Warning:
                    caption = "Warning";
                    buttons = MessageBoxButtons.OKCancel;
                    break;
            }

            MessageBox.Show(message, caption, buttons, messageBoxIcon);
        }

        public void HideViews()
        {
            MenuViewVisibility = true;
            SummaryViewVisibility = false;
            MonstersViewVisibility = false;
            RunesViewVisibility = false;
            DimHoleViewVisibility = false;
            OtherViewVisibility = false;
        }
        #endregion

        private void pictureBoxSelectJson_Click(object sender, EventArgs e)
        {
            SelectFileButtonClicked?.Invoke();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadFont();
            foreach(var control in SummaryView.ControlsSummary)
            {
                if (control.Name.Contains("SummonerName"))
                {
                    control.Font = new Font(ff, 32, FontStyle.Regular);
                    continue;
                }
                
                if (control.Name.Contains("Country") || control.Name.Contains("Language") || control.Name.Contains("Level"))
                {
                    control.Font = new Font(ff, 20, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(ff, 14, FontStyle.Regular);
            }

            foreach (var control in MonstersView.ControlsMonster)
            {
                if (control.Name.Contains("Stats") || control.Name == "labelMonsters")
                {
                    control.Font = new Font(ff, 24, FontStyle.Regular);
                    continue;
                }
                if (control.Name.Contains("listView"))
                {
                    control.Font = new Font(ff, 10, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(ff, 14, FontStyle.Regular);
            }

            foreach (var control in RunesView.ControlsRunes)
            {
                if (control.Name.Contains("listView"))
                {
                    control.Font = new Font(ff, 10, FontStyle.Regular);
                    continue;
                }
                if (control.Name == "labelRunes")
                {
                    control.Font = new Font(ff, 24, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(ff, 14, FontStyle.Regular);
            }

            foreach (var control in DimHoleView.ControlsDimHole)
            {
                if (control.Name.Contains("listView"))
                {
                    control.Font = new Font(ff, 10, FontStyle.Regular);
                    continue;
                }
                if (control.Name.Contains("DimHole"))
                {
                    control.Font = new Font(ff, 24, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(ff, 14, FontStyle.Regular);
            }

            foreach (var control in OtherView.ControlsOther)
            {
                if (control.Name.Contains("listView"))
                {
                    control.Font = new Font(ff, 10, FontStyle.Regular);
                    continue;
                }
                if (control.Name.Contains("Other"))
                {
                    control.Font = new Font(ff, 24, FontStyle.Regular);
                    continue;
                }
                control.Font = new Font(ff, 14, FontStyle.Regular);
            }
        }
    }
}
