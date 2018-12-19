namespace Lemonade.VirtualSpaces.EnvironmentTools
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn_UpdateLic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MacName = new System.Windows.Forms.TextBox();
            this.btn_ExpMcInfo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_SetPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_OpenHelp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_MacCode = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_UpdateLic
            // 
            this.btn_UpdateLic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateLic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.btn_UpdateLic.FlatAppearance.BorderSize = 2;
            this.btn_UpdateLic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateLic.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UpdateLic.Location = new System.Drawing.Point(204, 79);
            this.btn_UpdateLic.Name = "btn_UpdateLic";
            this.btn_UpdateLic.Size = new System.Drawing.Size(163, 36);
            this.btn_UpdateLic.TabIndex = 1;
            this.btn_UpdateLic.Text = "设置许可";
            this.btn_UpdateLic.UseVisualStyleBackColor = true;
            this.btn_UpdateLic.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 39);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(328, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "帮助";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(140, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "运行文件";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(234, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "许可配置";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "环境变量配置";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // tb_MacName
            // 
            this.tb_MacName.BackColor = System.Drawing.Color.White;
            this.tb_MacName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MacName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_MacName.Location = new System.Drawing.Point(159, 308);
            this.tb_MacName.Name = "tb_MacName";
            this.tb_MacName.ReadOnly = true;
            this.tb_MacName.Size = new System.Drawing.Size(390, 22);
            this.tb_MacName.TabIndex = 0;
            // 
            // btn_ExpMcInfo
            // 
            this.btn_ExpMcInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExpMcInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.btn_ExpMcInfo.FlatAppearance.BorderSize = 2;
            this.btn_ExpMcInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExpMcInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ExpMcInfo.Location = new System.Drawing.Point(204, 79);
            this.btn_ExpMcInfo.Name = "btn_ExpMcInfo";
            this.btn_ExpMcInfo.Size = new System.Drawing.Size(163, 36);
            this.btn_ExpMcInfo.TabIndex = 17;
            this.btn_ExpMcInfo.Text = "生成运行文件";
            this.btn_ExpMcInfo.UseVisualStyleBackColor = true;
            this.btn_ExpMcInfo.Click += new System.EventHandler(this.btn_ExpMcInfo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-8, -27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 290);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_SetPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_SetPath
            // 
            this.btn_SetPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SetPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.btn_SetPath.FlatAppearance.BorderSize = 2;
            this.btn_SetPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetPath.Location = new System.Drawing.Point(204, 79);
            this.btn_SetPath.Name = "btn_SetPath";
            this.btn_SetPath.Size = new System.Drawing.Size(163, 36);
            this.btn_SetPath.TabIndex = 17;
            this.btn_SetPath.Text = "配置环境变量";
            this.btn_SetPath.UseVisualStyleBackColor = true;
            this.btn_SetPath.Click += new System.EventHandler(this.btn_SetPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(137, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "提示：此功能可能被杀毒软件拦截，请允许操作";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.btn_ExpMcInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "提示：请将生成的运行文件发送给我们的技术支持人员即获取许可文件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ColumnWidth = 280;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "sfdsdf",
            "水电费水电费",
            "水电费水电费是"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 53);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(97, 112);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_UpdateLic);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(652, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "提示：点击按钮选择许可文件完成运行环境配置，此功能可能被杀毒软件拦截，请允许操作";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_OpenHelp);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(652, 264);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_OpenHelp
            // 
            this.btn_OpenHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.btn_OpenHelp.FlatAppearance.BorderSize = 2;
            this.btn_OpenHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenHelp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenHelp.Location = new System.Drawing.Point(204, 79);
            this.btn_OpenHelp.Name = "btn_OpenHelp";
            this.btn_OpenHelp.Size = new System.Drawing.Size(163, 36);
            this.btn_OpenHelp.TabIndex = 19;
            this.btn_OpenHelp.Text = "查看帮助";
            this.btn_OpenHelp.UseVisualStyleBackColor = true;
            this.btn_OpenHelp.Click += new System.EventHandler(this.btn_OpenHelp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(158, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "提示：此功能打开中海达数据管家帮助手册";
            // 
            // tb_MacCode
            // 
            this.tb_MacCode.BackColor = System.Drawing.Color.White;
            this.tb_MacCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MacCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_MacCode.Location = new System.Drawing.Point(159, 340);
            this.tb_MacCode.Name = "tb_MacCode";
            this.tb_MacCode.ReadOnly = true;
            this.tb_MacCode.Size = new System.Drawing.Size(390, 22);
            this.tb_MacCode.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tb_MacCode);
            this.panel5.Controls.Add(this.tb_MacName);
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 191);
            this.panel5.TabIndex = 19;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 230);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "平台运行环境配置工具";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_UpdateLic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_MacName;
        private System.Windows.Forms.Button btn_ExpMcInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_SetPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_MacCode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_OpenHelp;
        private System.Windows.Forms.Label label9;
    }
}