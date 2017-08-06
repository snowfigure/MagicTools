using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTool
{
    public partial class FormMain : Form
    {
        private Point FormPostion = new Point();
        public FormMain()
        {
            InitializeComponent();
        }

        private void MainClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainClose_MouseHover(object sender, EventArgs e)
        {
            this.PanelMainClose.BackColor = Util.Const.ColorCloseBackHover;
        }

        private void MainClose_MouseLeave(object sender, EventArgs e)
        {
            this.PanelMainClose.BackColor = Util.Const.ColorCloseBackDefault;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.LabelMainTitle.Text = Util.App.Title;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormPostion.X = e.X;
            this.FormPostion.Y = e.Y;

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

        private void RecordButton_MouseHover(object sender, EventArgs e)
        {
            FontFamily ff = this.LabelMainRecord.Font.FontFamily;
            float fs = this.LabelMainRecord.Font.Size;
            this.LabelMainRecord.Font = new Font(ff, fs, FontStyle.Bold);

        }

        private void RecordButton_MouseLeave(object sender, EventArgs e)
        {
            FontFamily ff = this.LabelMainRecord.Font.FontFamily;
            float fs = this.LabelMainRecord.Font.Size;
            this.LabelMainRecord.Font = new Font(ff, fs, FontStyle.Regular);
        }

        private void PictureBoxRecordButton_Click(object sender, EventArgs e)
        {
            Record.FormMain record = new Record.FormMain();
            record.ShowInTaskbar = true;
            record.Show();
        }
    }
}
