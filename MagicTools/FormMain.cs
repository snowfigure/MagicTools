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
    }
}
