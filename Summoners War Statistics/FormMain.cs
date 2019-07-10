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
        public string Test
        {
            get
            {
                return labelAccountInfo.Text;
            }
            set
            {
                labelAccountInfo.Text = value;
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

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormOnLoad?.Invoke();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            SelectFileButtonClicked?.Invoke();
        }
    }
}
