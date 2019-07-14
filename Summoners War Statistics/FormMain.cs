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

namespace Summoners_War_Statistics
{
    public partial class FormMain : Form, IView
    {
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
        public event Action FormOnLoad;
        public event Action SelectFileButtonClicked;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        #region Methods
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormOnLoad?.Invoke();
        }

        private void introduction1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxSelectJson_Click(object sender, EventArgs e)
        {
            SelectFileButtonClicked?.Invoke();
        }
    }
}
