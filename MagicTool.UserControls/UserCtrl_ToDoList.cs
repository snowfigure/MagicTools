using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTool.Util;

namespace MagicTool.UserControls
{
    public partial class UserCtrl_ToDoList : UserControl
    {
        public UserCtrl_ToDoList()
        {
            InitializeComponent();
        }

        private bool _selected = false;
        private int _sortIdx = 1;
        private String _title;
        private String _ctime;

        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                this.TLP_MAIN_Set_Select();
            }
        }
        public int SortIdx
        {
            get { return _sortIdx; }
            set
            {
                _sortIdx = value;
                this.Label_No.Text = _sortIdx.ToString();
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                if (_title.Length > 22)
                {
                    this.Label_Title.Text = _title.Substring(1, 20) + "...";
                }
                else
                {
                    this.Label_Title.Text = _title;
                }
                
            }
        }
        public string Ctime
        {
            get { return _ctime; }
            set
            {
                _ctime = value;
                this.Label_Ctime.Text = _ctime;
            }
        }

        private void TLP_MAIN_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.TLP_MAIN.ClientRectangle,
                 Color.White, 0, ButtonBorderStyle.Solid, //左边
                 Color.White, 0, ButtonBorderStyle.Solid, //上边
                 Color.DimGray, 0, ButtonBorderStyle.Solid, //右边
                 Color.Gray, 1, ButtonBorderStyle.Solid);//底边
        }

        private void TLP_MAIN_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Selected)
            {
                this.TLP_MAIN.BackColor = Colors.ToDoListItemDefault;
            }
        }

        private void TLP_MAIN_MouseHover(object sender, EventArgs e)
        {
            if (!this.Selected)
            {
                this.TLP_MAIN.BackColor = Colors.ToDoListItemHover;
            }
        }

        private void TLP_MAIN_Click(object sender, EventArgs e)
        {
            if (!this.Selected)
            {
                this.Selected = true;
                this.TLP_MAIN.BackColor = Colors.ToDoListItemSelected;

            }
        }

        private void TLP_MAIN_Set_Select()
        {
            if (!this.Selected)
            {
                this.Selected = true;
                this.TLP_MAIN.BackColor = Colors.ToDoListItemSelected;

            }
            else
            {
                this.Selected = false;
                this.TLP_MAIN.BackColor = Colors.ToDoListItemDefault;
            }
            
        }

        
    }
}
