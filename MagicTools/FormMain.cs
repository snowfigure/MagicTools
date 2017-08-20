﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTool.Util;

namespace MagicTool
{
    public partial class FormMain : Form
    {
        private Point FormPostion = new Point();
        private List<Panel> TabPagePanelList = new List<Panel>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.LabelMainTitle.Text = Util.App.Title;
            this.TabPagePanelList.Add(this.Panel_ToDoList);
            this.TabPagePanelList.Add(this.Panel_Conn);
            this.TabPagePanelList.Add(this.Panel_Tools);
            this.TabPagePanelList.Add(this.Panel_Add);
        }

        private void MainClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainClose_MouseHover(object sender, EventArgs e)
        {
            this.PanelMainClose.BackColor = Const.ColorCloseBackHover;
        }

        private void MainClose_MouseLeave(object sender, EventArgs e)
        {
            this.PanelMainClose.BackColor = Const.ColorCloseBackDefault;
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
            record.ShowDialog();
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void PicBox_SelectChange(Int16 tab_idx)
        {
            foreach(Panel panel in this.TabPagePanelList)
            {
                panel.BackColor = Const.TabControlDefault;
            }

            if (tab_idx >= this.TabPagePanelList.Count)
            {
                return;
            }
            this.TabPagePanelList[tab_idx].BackColor = Const.TabControlSelected;
        }
        private void PicBox_ToDoList_Click(object sender, EventArgs e)
        {
            this.TabControlMain.SelectedTab = this.TabPage_ToDoList;
            this.PicBox_SelectChange(0);
        }

        private void PicBox_Conn_Click(object sender, EventArgs e)
        {
            this.TabControlMain.SelectedTab = this.TabPage_Conn;
            this.PicBox_SelectChange(1);
        }

        private void PicBox_Tools_Click(object sender, EventArgs e)
        {
            this.TabControlMain.SelectedTab = this.TabPage_Tools;
            this.PicBox_SelectChange(2);
        }

        
        private void PicBox_Add_Click(object sender, EventArgs e)
        {
            this.TabControlMain.SelectedTab = this.TabPage_Add;
            this.PicBox_SelectChange(3);
        }
    }
}
