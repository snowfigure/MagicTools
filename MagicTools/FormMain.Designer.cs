namespace MagicTool
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMainClose = new System.Windows.Forms.Panel();
            this.LabelMainClose = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.PanelMainTitle = new System.Windows.Forms.Panel();
            this.LabelMainTitle = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelMainRecord = new System.Windows.Forms.Label();
            this.PictureBoxRecordButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TLP_Main.SuspendLayout();
            this.PanelMainClose.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.PanelMainTitle.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRecordButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 640);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.TLP_Main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 36);
            this.panel1.TabIndex = 0;
            // 
            // TLP_Main
            // 
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
            this.TLP_Main.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 1;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Size = new System.Drawing.Size(900, 36);
            this.TLP_Main.TabIndex = 0;
            this.TLP_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.TLP_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // PanelMainClose
            // 
            this.PanelMainClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.PanelMainClose.Controls.Add(this.LabelMainClose);
            this.PanelMainClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainClose.Location = new System.Drawing.Point(849, 0);
            this.PanelMainClose.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMainClose.Name = "PanelMainClose";
            this.PanelMainClose.Size = new System.Drawing.Size(51, 36);
            this.PanelMainClose.TabIndex = 0;
            this.PanelMainClose.Click += new System.EventHandler(this.MainClose_Click);
            this.PanelMainClose.MouseLeave += new System.EventHandler(this.MainClose_MouseLeave);
            this.PanelMainClose.MouseHover += new System.EventHandler(this.MainClose_MouseHover);
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
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::MagicTool.Properties.Resources.sd_tools_24px;
            this.PictureBoxIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxIcon.InitialImage")));
            this.PictureBoxIcon.Location = new System.Drawing.Point(14, 6);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(24, 24);
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
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
            // LabelMainTitle
            // 
            this.LabelMainTitle.AutoSize = true;
            this.LabelMainTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMainTitle.ForeColor = System.Drawing.Color.Black;
            this.LabelMainTitle.Location = new System.Drawing.Point(4, 10);
            this.LabelMainTitle.Name = "LabelMainTitle";
            this.LabelMainTitle.Size = new System.Drawing.Size(80, 17);
            this.LabelMainTitle.TabIndex = 1;
            this.LabelMainTitle.Text = "Magic Tools";
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.PanelMain.Controls.Add(this.tableLayoutPanel2);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 36);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(900, 568);
            this.PanelMain.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 568);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(585, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 568);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.LabelMainRecord);
            this.panel6.Controls.Add(this.PictureBoxRecordButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(585, 568);
            this.panel6.TabIndex = 1;
            // 
            // LabelMainRecord
            // 
            this.LabelMainRecord.AutoSize = true;
            this.LabelMainRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.LabelMainRecord.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMainRecord.ForeColor = System.Drawing.Color.White;
            this.LabelMainRecord.Location = new System.Drawing.Point(235, 171);
            this.LabelMainRecord.Name = "LabelMainRecord";
            this.LabelMainRecord.Size = new System.Drawing.Size(69, 25);
            this.LabelMainRecord.TabIndex = 1;
            this.LabelMainRecord.Text = "记个事";
            this.LabelMainRecord.MouseLeave += new System.EventHandler(this.RecordButton_MouseLeave);
            this.LabelMainRecord.MouseHover += new System.EventHandler(this.RecordButton_MouseHover);
            // 
            // PictureBoxRecordButton
            // 
            this.PictureBoxRecordButton.Image = global::MagicTool.Properties.Resources.CycleButton;
            this.PictureBoxRecordButton.Location = new System.Drawing.Point(169, 83);
            this.PictureBoxRecordButton.Name = "PictureBoxRecordButton";
            this.PictureBoxRecordButton.Size = new System.Drawing.Size(201, 201);
            this.PictureBoxRecordButton.TabIndex = 0;
            this.PictureBoxRecordButton.TabStop = false;
            this.PictureBoxRecordButton.MouseLeave += new System.EventHandler(this.RecordButton_MouseLeave);
            this.PictureBoxRecordButton.MouseHover += new System.EventHandler(this.RecordButton_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 604);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 36);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(166, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "0x1 Record New Code Snippet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(166, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "0x2 Create New ToDo Work List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(166, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "0x3 Write New Blog";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(315, 568);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(166, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "0x4 Add New Product Rule";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TLP_Main.ResumeLayout(false);
            this.PanelMainClose.ResumeLayout(false);
            this.PanelMainClose.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.PanelMainTitle.ResumeLayout(false);
            this.PanelMainTitle.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRecordButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.Panel PanelMainClose;
        private System.Windows.Forms.Label LabelMainClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Panel PanelMainTitle;
        private System.Windows.Forms.Label LabelMainTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox PictureBoxRecordButton;
        private System.Windows.Forms.Label LabelMainRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
    }
}

