using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Management_Studio
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void activateButton_Click(object sender, EventArgs e)
        {


            this.DesktopBounds = this.setFullScreen();
            this.hideFormAndCursor();
        }

        private Rectangle setFullScreen()
        {
            int minx, miny, maxx, maxy;
            minx = miny = int.MaxValue;
            maxx = maxy = int.MinValue;

            foreach (Screen screen in Screen.AllScreens)
            {
                var bounds = screen.Bounds;
                minx = Math.Min(minx, bounds.X);
                miny = Math.Min(miny, bounds.Y);
                maxx = Math.Max(maxx, bounds.Right);
                maxy = Math.Max(maxy, bounds.Bottom);
            }

            MainForm fs = new MainForm();
            this.FormBorderStyle = FormBorderStyle.None;
            fs.Activate();
            return new Rectangle(0, 0, maxx, maxy);
        }

        private void hideFormAndCursor()
        {
            this.ActivateButton.Hide();
            this.SettingsButton.Hide();
            this.HelpButton.Hide();
            this.Drop1.Hide();
            this.Drop2.Hide();
            this.Drop3.Hide();
            this.Drop4.Hide();
            this.Drop5.Hide();
            this.Drop6.Hide();
            this.Label1.Hide();
            this.Label2.Hide();
            this.Label3.Hide();
            this.Label4.Hide();
            this.Label5.Hide();
            this.Label6.Hide();
            Cursor.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
