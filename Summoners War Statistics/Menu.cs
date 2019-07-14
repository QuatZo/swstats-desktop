using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summoners_War_Statistics
{
    public partial class Menu : UserControl, IMenuView
    {
        #region Properties
        public List<PictureBox> Buttons
        {
            get => new List<PictureBox>()
                {
                    pictureBoxSummary,
                    pictureBoxMonsters,
                    pictureBoxRunes,
                    pictureBoxDimHole,
                    pictureBoxOther
                };
            set
            {
                pictureBoxSummary = value[0];
                pictureBoxMonsters = value[1];
                pictureBoxRunes = value[2];
                pictureBoxDimHole = value[3];
                pictureBoxOther = value[4];
            }
        }
        #endregion

        #region Events
        public event Action<object> ButtonClicked;
        #endregion

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(sender);
        }
    }
}
