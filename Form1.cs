using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            panel.Location = new Point(10, 10);
            panel.Size = new Size(ClientRectangle.Width - 20, ClientRectangle.Height - 20);
            panel.BackColor = Color.Gray;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    Application.Exit();
                }
                else
                {
                    if (panel.ClientRectangle.Contains(e.Location))
                    {
                        MessageBox.Show("The point is inside the rectangle.");
                    }
                    else if (e.X >= panel.Left && e.X <= panel.Right && e.Y >= panel.Top && e.Y <= panel.Bottom)
                    {
                        MessageBox.Show("The point is on the border of the rectangle.");
                    }
                    else
                    {
                        MessageBox.Show("The point is outside the rectangle.");
                    }
                }
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X = {e.X}, Y = {e.Y}";
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Text = $"Width = {panel.ClientRectangle.Width}, Height = {panel.ClientRectangle.Height}";
            }
        }
    }
}