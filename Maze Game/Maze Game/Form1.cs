using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GoToStart();
        }

        private void GoToStart()
        {
            Point Start = panel1.Location;
            Start.Offset(15, 15);
            Cursor.Position = PointToScreen(Start);
            DoorButton.Text = "OFF";
            LockedDoor.Enabled = true;
            LockedDoor.Visible = true;
        }

        private void Obstacle_MouseEnter(object sender, EventArgs e)
        {
            GoToStart();
        }

        private void EXIT_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Win! Flawless escape!");
            Close();
        }

        bool TrapsActivated = false;
        private void TrapsTimer_Tick(object sender, EventArgs e)
        {
            if (TrapsActivated == false)
            {
                trap1.Enabled = true;
                trap1.Visible = true;
                trap2.Enabled = true;
                trap2.Visible = true;
                trap3.Enabled = true;
                trap3.Visible = true;
                TrapsActivated = true;
            }
            else
            {
                trap1.Enabled = false;
                trap1.Visible = false;
                trap2.Enabled = false;
                trap2.Visible = false;
                trap3.Enabled = false;
                trap3.Visible = false;
                TrapsActivated = false;
            }
        }

        private void DoorButton_MouseClick(object sender, MouseEventArgs e)
        {
            LockedDoor.Enabled = false;
            LockedDoor.Visible = false;
            DoorButton.Text = "ON";
        }
    }
}
