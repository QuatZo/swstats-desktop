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
        /// <summary>
        /// Adds the font resources to the memory
        /// </summary>
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        /// <summary>
        /// Stores the last state of the window
        /// </summary>
        private FormWindowState? LastWindowState = null;

        #region Properties
        /// <summary>
        /// Font family used in the app
        /// </summary>
        public FontFamily FF { get; set; }
        /// <summary>
        /// Font used in the app
        /// </summary>
        public Font Fnt { get; set; }
        /// <summary>
        /// Summary Tab
        /// </summary>
        public ISummaryView SummaryView => summary1;
        /// <summary>
        /// Menu
        /// </summary>
        public IMenuView MenuView =>  menu1;
        /// <summary>
        /// Monsters Tab
        /// </summary>
        public IMonstersView MonstersView => monsters1;
        /// <summary>
        /// Runes Tab
        /// </summary>
        public IRunesView RunesView => runes1;
        /// <summary>
        /// Dim Hole Tab
        /// </summary>
        public IDimHoleView DimHoleView => dimHole1;
        /// <summary>
        /// Guild Tab
        /// </summary>
        public IGuildView GuildView => guild1;
        /// <summary>
        /// Inventory Tab
        /// </summary>
        public IOtherView OtherView => other1;

        /// <summary>
        /// Visibility of the Menu
        /// </summary>
        public bool MenuViewVisibility
        {
            get => menu1.Visible;
            set => menu1.Visible = value;
        }
        /// <summary>
        /// Visibility of the Summary Tab
        /// </summary>
        public bool SummaryViewVisibility
        {
            get => summary1.Visible;
            set => summary1.Visible = value;
        }
        /// <summary>
        /// Visibility of the Monsters Tab
        /// </summary>
        public bool MonstersViewVisibility
        {
            get => monsters1.Visible;
            set => monsters1.Visible = value;
        }
        /// <summary>
        /// Visibility of the Runes Tab
        /// </summary>
        public bool RunesViewVisibility
        {
            get => runes1.Visible;
            set => runes1.Visible = value;
        }
        /// <summary>
        /// Visibility of the Dim Hole Tab
        /// </summary>
        public bool DimHoleViewVisibility
        {
            get => dimHole1.Visible;
            set => dimHole1.Visible = value;
        }
        /// <summary>
        /// Visibility of the Guild Tab
        /// </summary>
        public bool GuildViewVisibility
        {
            get => guild1.Visible;
            set => guild1.Visible = value;
        }
        /// <summary>
        /// Visibility of the Other Tab
        /// </summary>
        public bool OtherViewVisibility
        {
            get => other1.Visible;
            set => other1.Visible = value;
        }

        /// <summary>
        /// Open File Dialog
        /// </summary>
        public OpenFileDialog OpenFile
        {
            get => openFileDialog;
            set => openFileDialog = value;
        }
        #endregion

        #region Events
        /// <summary>
        /// Clicked button which opens the Open File Dialog
        /// </summary>
        public event Action SelectFileButtonClicked;
        /// <summary>
        /// Clicked button which uses the test JSON file
        /// </summary>
        public event Action TestFileButtonClicked;
        /// <summary>
        /// 1st load of the app
        /// </summary>
        public event Action Loaded;
        /// <summary>
        /// Event, which triggers when initialization failed (invalid JSON File)
        /// </summary>
        public event Action InitFailed;
        #endregion

        public FormMain()
        {
            InitializeComponent();
            MenuView.WindowWidth = Size.Width;
        }

        #region Methods
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

        /// <summary>
        /// Shows the Alert Message
        /// </summary>
        public void ShowMessage(string message, MessageBoxIcon messageBoxIcon, Exception e = null)
        {
            string tab = "Unknown";
            if(e != null)
            {
                Logger.log.Error($"Initializer encountered a problem. It won't load more data.");
                string stackTrace = e.StackTrace;
                Logger.log.Error(stackTrace);

                if (stackTrace.Contains("Summary")) { tab = "Summary"; }
                else if (stackTrace.Contains("Monsters")) { tab = "Monsters"; }
                else if (stackTrace.Contains("Runes")) { tab = "Runes"; }
                else if (stackTrace.Contains("DimHole")) { tab = "Dim Hole"; }
                else if (stackTrace.Contains("Other")) { tab = "Other"; }
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
            if(caption == "Error") { message = $"{message}\nError occured while trying to init {tab} tab.\n\nMore info in log file."; }
            MessageBox.Show(message, caption, buttons, messageBoxIcon);
        }

        /// <summary>
        /// Hide all views
        /// </summary>
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

        /// <summary>
        /// Triggers when initialization failed
        /// </summary>
        public void InitFail()
        {
            InitFailed?.Invoke();
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
            FormMain_SizeChanged(null, EventArgs.Empty);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                FormMain_SizeChanged(null, EventArgs.Empty);
            }
           
        }
        #endregion

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxSelectJson.Padding = new Padding((pictureBoxSelectJson.Size.Width - pictureBoxSelectJson.Image.Size.Width) / 2, 10, 0, 0);
            MenuView.WindowWidth = Size.Width;

            if (SummaryViewVisibility) { SummaryView.Summary_Resize(null, EventArgs.Empty); }
            else if (MonstersViewVisibility) { MonstersView.Monsters_Resize(null, EventArgs.Empty); }
            else if (RunesViewVisibility) { RunesView.Runes_Resize(null, EventArgs.Empty); }
            else if (DimHoleViewVisibility) { DimHoleView.DimHole_Resize(null, EventArgs.Empty); }
            else if (GuildViewVisibility) { GuildView.Guild_Resize(null, EventArgs.Empty); }
            else if (OtherViewVisibility) { OtherView.Other_Resize(null, EventArgs.Empty); }
            Refresh();
        }

        private void FormMain_ResizeBegin(object sender, EventArgs e)
        {
            RunesView.FlowPanel.SuspendLayout();
        }

        private void PictureBoxTestJson_Click(object sender, EventArgs e)
        {
            TestFileButtonClicked?.Invoke();
        }
    }
}
