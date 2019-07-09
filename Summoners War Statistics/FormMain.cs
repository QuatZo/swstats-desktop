using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        #endregion

        #region Events
        public event Action FormOnLoad;
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
    }
}
