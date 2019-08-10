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

        #region Properties
        public FontFamily FF { get; set; }
        public Font Fnt { get; set; }
        public ISummaryView SummaryView => summary1;
        public IMenuView MenuView =>  menu1;
        public IMonstersView MonstersView => monsters1;
        public IRunesView RunesView => runes1;
        public IDimHoleView DimHoleView => dimHole1;
        public IGuildView GuildView => guild1;
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
        public bool GuildViewVisibility
        {
            get => guild1.Visible;
            set => guild1.Visible = value;
        }
        public bool OtherViewVisibility
        {
            get => other1.Visible;
            set => other1.Visible = value;
        }

        public OpenFileDialog OpenFile
        {
            get => openFileDialog;
            set => openFileDialog = value;
        }
        #endregion

        #region Events
        public event Action SelectFileButtonClicked;
        public event Action Loaded;
        #endregion

        public FormMain()
        {
            InitializeComponent();
            MenuView.WindowWidth = Size.Width;
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

            FF = pfc.Families[0];
            Fnt = new Font(FF, 14f, FontStyle.Regular);
        }

        public void ShowMessage(string message, MessageBoxIcon messageBoxIcon, Exception e = null)
        {
            if(e != null)
            {
                Logger.log.Error($"Initializer encountered a problem. It won't load more data.");
                Logger.log.Error(e.StackTrace);
            }

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
            GuildViewVisibility = false;
            OtherViewVisibility = false;
        }

        // Flickering while bringing something to front https://stackoverflow.com/a/2613272
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void pictureBoxSelectJson_Click(object sender, EventArgs e)
        {
            SelectFileButtonClicked?.Invoke();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadFont();
            Loaded?.Invoke();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            pictureBoxSelectJson.Padding = new Padding((pictureBoxSelectJson.Size.Width - pictureBoxSelectJson.Image.Size.Width) / 2, 10, 0, 0);
            MenuView.WindowWidth = Size.Width;
            Refresh();
        }
        #endregion
    }
}
