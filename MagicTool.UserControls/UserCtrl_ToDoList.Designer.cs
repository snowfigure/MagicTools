namespace MagicTool.UserControls
{
    partial class UserCtrl_ToDoList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TLP_MAIN = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_No = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Ctime = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.TLP_MAIN.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_MAIN
            // 
            this.TLP_MAIN.ColumnCount = 2;
            this.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_MAIN.Controls.Add(this.panel3, 0, 0);
            this.TLP_MAIN.Controls.Add(this.panel1, 1, 0);
            this.TLP_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_MAIN.Location = new System.Drawing.Point(0, 0);
            this.TLP_MAIN.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.TLP_MAIN.Name = "TLP_MAIN";
            this.TLP_MAIN.RowCount = 1;
            this.TLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_MAIN.Size = new System.Drawing.Size(300, 48);
            this.TLP_MAIN.TabIndex = 1;
            this.TLP_MAIN.Paint += new System.Windows.Forms.PaintEventHandler(this.TLP_MAIN_Paint);
            this.TLP_MAIN.MouseLeave += new System.EventHandler(this.TLP_MAIN_MouseLeave);
            this.TLP_MAIN.MouseHover += new System.EventHandler(this.TLP_MAIN_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 47);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label_No);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 47);
            this.panel2.TabIndex = 0;
            // 
            // Label_No
            // 
            this.Label_No.AutoSize = true;
            this.Label_No.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_No.Location = new System.Drawing.Point(10, 14);
            this.Label_No.Name = "Label_No";
            this.Label_No.Size = new System.Drawing.Size(17, 20);
            this.Label_No.TabIndex = 0;
            this.Label_No.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_Ctime);
            this.panel1.Controls.Add(this.Label_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(36, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 47);
            this.panel1.TabIndex = 2;
            this.panel1.MouseLeave += new System.EventHandler(this.TLP_MAIN_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.TLP_MAIN_MouseHover);
            // 
            // Label_Ctime
            // 
            this.Label_Ctime.AutoSize = true;
            this.Label_Ctime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Ctime.ForeColor = System.Drawing.Color.Black;
            this.Label_Ctime.Location = new System.Drawing.Point(138, 31);
            this.Label_Ctime.Name = "Label_Ctime";
            this.Label_Ctime.Size = new System.Drawing.Size(126, 17);
            this.Label_Ctime.TabIndex = 1;
            this.Label_Ctime.Text = "2017-01-02 14:22:00";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Title.ForeColor = System.Drawing.Color.Blue;
            this.Label_Title.Location = new System.Drawing.Point(2, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(123, 19);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "To do list item title";
            // 
            // UserCtrl_ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP_MAIN);
            this.Name = "UserCtrl_ToDoList";
            this.Size = new System.Drawing.Size(300, 48);
            this.TLP_MAIN.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_MAIN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_No;
        private System.Windows.Forms.Label Label_Ctime;
    }
}
