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
        [Browsable(false)] 
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<PictureBox> Buttons
        {
            get => new List<PictureBox>
                {
                    pictureBoxSummary,
                    pictureBoxMonsters,
                    pictureBoxRunes,
                    pictureBoxDimHole,
                    pictureBoxGuild,
                    pictureBoxOther
                };
            set
            {
                pictureBoxSummary = value[0];
                pictureBoxMonsters = value[1];
                pictureBoxRunes = value[2];
                pictureBoxDimHole = value[3];
                pictureBoxGuild = value[4];
                pictureBoxOther = value[5];
            }
        }

        public List<Control> ControlList
        {
            get
            {
                List<Control> controls = new List<Control>();
                foreach(Control control in Controls)
                {
                    controls.Add(control);
                }
                return controls;
            }
        }
        public bool IsMouseDown { get; set; } = false;
        public Point MouseLocation { get; set; } = new Point(-1, -1);
        #endregion

        #region Events
        public event Action<object> ButtonClicked;
        public event Action MousePressed;
        public event Action MouseUnpressed;
        public event Action<Point> MouseMoved;
        #endregion

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(sender);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed?.Invoke();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUnpressed?.Invoke();
        }
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoved?.Invoke(e.Location);
        }
    }
}
