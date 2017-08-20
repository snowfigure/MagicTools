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
        private String _sortIdx = "1";
        private String _title;
        private String _ctime;
        private int key;

        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                if (_selected)
                {
                    this.Set_Select();
                }
                else
                {
                    this.Set_Not_Select();
                }
                
            }
        }
        public String SortIdx
        {
            get { return _sortIdx; }
            set
            {
                _sortIdx = value;

                if (value == null)
                {
                    this.Label_No.Text = "";
                }
                else
                {
                    this.Label_No.Text = value.ToString();
                }
               
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;

                if (value == null)
                {
                    this.Label_Title.Text = "";
                }
                else
                {
                    if (_title.ToString().Length > 22)
                    {
                        this.Label_Title.Text = value.ToString().Substring(1, 20) + "...";
                    }
                    else
                    {
                        this.Label_Title.Text = value.ToString();
                    }
                }
                
                
            }
        }
        public string Ctime
        {
            get { return _ctime; }
            set
            {
                _ctime = value;
                if (value == null)
                {
                    this.Label_Ctime.Text = "";
                }
                else
                {
                    this.Label_Ctime.Text = value.ToString();
                }
                
            }
        }

        public int Key { get => key; set => key = value; }

        private void TLP_MAIN_Paint(object sender, PaintEventArgs e)
        {
            /*ControlPaint.DrawBorder(e.Graphics, this.TLP_MAIN.ClientRectangle,
                 Color.White, 0, ButtonBorderStyle.Solid, //左边
                 Color.White, 0, ButtonBorderStyle.Solid, //上边
                 Color.DimGray, 0, ButtonBorderStyle.Solid, //右边
                 Color.Gray, 1, ButtonBorderStyle.Solid);//底边*/
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

        private void Set_Select()
        {
            this.TLP_MAIN.BackColor = Colors.ToDoListItemSelected;
        }

        private void Set_Not_Select()
        {
            this.TLP_MAIN.BackColor = Colors.ToDoListItemDefault;
        }

    }
}
