namespace MagicTool.Record
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelMainTitle = new System.Windows.Forms.Label();
            this.PanelMainTitle = new System.Windows.Forms.Panel();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelMainClose = new System.Windows.Forms.Label();
            this.PanelMainClose = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.panel4.SuspendLayout();
            this.PanelMainClose.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TLP_Main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 602);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 36);
            this.panel3.TabIndex = 2;
            // 
            // LabelMainTitle
            // 
            this.LabelMainTitle.AutoSize = true;
            this.LabelMainTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMainTitle.ForeColor = System.Drawing.Color.White;
            this.LabelMainTitle.Location = new System.Drawing.Point(4, 10);
            this.LabelMainTitle.Name = "LabelMainTitle";
            this.LabelMainTitle.Size = new System.Drawing.Size(80, 17);
            this.LabelMainTitle.TabIndex = 1;
            this.LabelMainTitle.Text = "Magic Tools";
            // 
            // PanelMainTitle
            // 
            this.PanelMainTitle.Controls.Add(this.LabelMainTitle);
            this.PanelMainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainTitle.Location = new System.Drawing.Point(48, 0);
            this.PanelMainTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMainTitle.Name = "PanelMainTitle";
            this.PanelMainTitle.Size = new System.Drawing.Size(184, 36);
            this.PanelMainTitle.TabIndex = 2;
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::MagicTool.Record.Properties.Resources.sd_tools_24px;
            this.PictureBoxIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxIcon.InitialImage")));
            this.PictureBoxIcon.Location = new System.Drawing.Point(14, 6);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(24, 24);
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PictureBoxIcon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 36);
            this.panel4.TabIndex = 1;
            // 
            // LabelMainClose
            // 
            this.LabelMainClose.AutoSize = true;
            this.LabelMainClose.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMainClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.LabelMainClose.Location = new System.Drawing.Point(15, 7);
            this.LabelMainClose.Name = "LabelMainClose";
            this.LabelMainClose.Size = new System.Drawing.Size(22, 21);
            this.LabelMainClose.TabIndex = 0;
            this.LabelMainClose.Text = "✖";
            this.LabelMainClose.Click += new System.EventHandler(this.MainClose_Click);
            this.LabelMainClose.MouseHover += new System.EventHandler(this.MainClose_MouseHover);
            // 
            // PanelMainClose
            // 
            this.PanelMainClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(238)))));
            this.PanelMainClose.Controls.Add(this.LabelMainClose);
            this.PanelMainClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainClose.Location = new System.Drawing.Point(847, 0);
            this.PanelMainClose.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMainClose.Name = "PanelMainClose";
            this.PanelMainClose.Size = new System.Drawing.Size(51, 36);
            this.PanelMainClose.TabIndex = 0;
            this.PanelMainClose.Click += new System.EventHandler(this.MainClose_Click);
            this.PanelMainClose.MouseLeave += new System.EventHandler(this.MainClose_MouseLeave);
            this.PanelMainClose.MouseHover += new System.EventHandler(this.MainClose_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.TLP_Main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 36);
            this.panel1.TabIndex = 0;
            // 
            // TLP_Main
            // 
            this.TLP_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(238)))));
            this.TLP_Main.ColumnCount = 5;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TLP_Main.Controls.Add(this.PanelMainClose, 4, 0);
            this.TLP_Main.Controls.Add(this.panel4, 0, 0);
            this.TLP_Main.Controls.Add(this.PanelMainTitle, 1, 0);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Margin = new System.Windows.Forms.Padding(1);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 1;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Size = new System.Drawing.Size(898, 36);
            this.TLP_Main.TabIndex = 0;
            this.TLP_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.TLP_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 638);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 36);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(898, 566);
            this.PanelMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.PanelMainTitle.ResumeLayout(false);
            this.PanelMainTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.PanelMainClose.ResumeLayout(false);
            this.PanelMainClose.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TLP_Main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelMainTitle;
        private System.Windows.Forms.Panel PanelMainTitle;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelMainClose;
        private System.Windows.Forms.Panel PanelMainClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelMain;
    }
}

