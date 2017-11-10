using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTool.Util;

namespace MagicTool.Record
{
    public partial class FormMain : Form
    {
        private Point FormPostion = new Point();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.LabelMainTitle.Text = Util.AppRecord.Title;
        }

        private void MainClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Current_Postion = MousePosition;
                Current_Postion.Offset(-this.FormPostion.X, -this.FormPostion.Y);
                this.Location = Current_Postion;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormPostion.X = e.X;
            this.FormPostion.Y = e.Y;
        }

        private void MainClose_MouseHover(object sender, EventArgs e)
        {
            this.PanelMainClose.BackColor = Colors.RecoreCloseBackHover;
        }

        private void MainClose_MouseLeave(object sender, EventArgs e)
        {
            this.PanelMainClose.BackColor = Colors.RecoreCloseBackDefault;
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ;
        }
    }
}
