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
        private bool fullscreen = false;
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;
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
            fullscreen = true;
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

        private Rectangle unSetFullScreen()
        {
            fullscreen = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            return new Rectangle(0, 0, 875, 575);
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

        private void showFormAndCursor()
        {
            this.ActivateButton.Show();
            this.SettingsButton.Show();
            this.HelpButton.Show();
            this.Drop1.Show();
            this.Drop2.Show();
            this.Drop3.Show();
            this.Drop4.Show();
            this.Drop5.Show();
            this.Drop6.Show();
            this.Label1.Show();
            this.Label2.Show();
            this.Label3.Show();
            this.Label4.Show();
            this.Label5.Show();
            this.Label6.Show();
            Cursor.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.FileDrop);
            Application.Exit();
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 27)
            {
                if (fullscreen)
                {
                    this.DesktopBounds = this.unSetFullScreen();
                    this.showFormAndCursor();
                }
            }
        }

    }
}
