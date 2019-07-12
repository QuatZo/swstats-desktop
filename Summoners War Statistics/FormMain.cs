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
        public ISummaryView IntroductionView
        {
            get
            {
                return introduction1;
            }
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
            if (messageBoxIcon == MessageBoxIcon.Error) { caption = "Error"; }
            else if (messageBoxIcon == MessageBoxIcon.Information) { caption = "Information"; }
            else if (messageBoxIcon == MessageBoxIcon.Exclamation) { caption = "Exclamation"; }
            else if (messageBoxIcon == MessageBoxIcon.Question) { caption = "Question"; buttons = MessageBoxButtons.YesNoCancel; }
            else if (messageBoxIcon == MessageBoxIcon.Warning) { caption = "Warning"; buttons = MessageBoxButtons.OKCancel; }
            else { caption = "Error"; messageBoxIcon = MessageBoxIcon.Error; }

            MessageBox.Show(message, caption, buttons, messageBoxIcon);
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
