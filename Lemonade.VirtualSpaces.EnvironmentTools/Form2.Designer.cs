namespace Lemonade.VirtualSpaces.EnvironmentTools
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tb_Lic1 = new System.Windows.Forms.TextBox();
            this.btn_UpdateLic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pl_LicFile_1 = new System.Windows.Forms.Panel();
            this.lbl_Lic1 = new System.Windows.Forms.Label();
            this.btn_OpenLicFile_1 = new System.Windows.Forms.Button();
            this.pl_MCName = new System.Windows.Forms.Panel();
            this.tb_MacName = new System.Windows.Forms.TextBox();
            this.pl_LicFile_2 = new System.Windows.Forms.Panel();
            this.tb_Lic2 = new System.Windows.Forms.TextBox();
            this.btn_OpenLicFile_2 = new System.Windows.Forms.Button();
            this.lbl_Lic2 = new System.Windows.Forms.Label();
            this.btn_ExpMcInfo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_SetPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_MCCode = new System.Windows.Forms.Panel();
            this.tb_MacCode = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pl_LicFile_1.SuspendLayout();
            this.pl_MCName.SuspendLayout();
            this.pl_LicFile_2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pl_MCCode.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Lic1
            // 
            this.tb_Lic1.BackColor = System.Drawing.Color.White;
            this.tb_Lic1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Lic1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Lic1.Location = new System.Drawing.Point(-1, 3);
            this.tb_Lic1.Name = "tb_Lic1";
            this.tb_Lic1.ReadOnly = true;
            this.tb_Lic1.Size = new System.Drawing.Size(390, 22);
            this.tb_Lic1.TabIndex = 0;
            // 
            // btn_UpdateLic
            // 
            this.btn_UpdateLic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.btn_UpdateLic.FlatAppearance.BorderSize = 2;
            this.btn_UpdateLic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateLic.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UpdateLic.Location = new System.Drawing.Point(442, 171);
            this.btn_UpdateLic.Name = "btn_UpdateLic";
            this.btn_UpdateLic.Size = new System.Drawing.Size(112, 33);
            this.btn_UpdateLic.TabIndex = 1;
            this.btn_UpdateLic.Text = "确定";
            this.btn_UpdateLic.UseVisualStyleBackColor = true;
            this.btn_UpdateLic.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 39);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(149, 7);
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
            // pl_LicFile_1
            // 
            this.pl_LicFile_1.BackColor = System.Drawing.Color.Transparent;
            this.pl_LicFile_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_LicFile_1.Controls.Add(this.tb_Lic1);
            this.pl_LicFile_1.Location = new System.Drawing.Point(138, 86);
            this.pl_LicFile_1.Name = "pl_LicFile_1";
            this.pl_LicFile_1.Size = new System.Drawing.Size(390, 30);
            this.pl_LicFile_1.TabIndex = 6;
            // 
            // lbl_Lic1
            // 
            this.lbl_Lic1.AutoSize = true;
            this.lbl_Lic1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Lic1.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lic1.Location = new System.Drawing.Point(16, 91);
            this.lbl_Lic1.Name = "lbl_Lic1";
            this.lbl_Lic1.Size = new System.Drawing.Size(87, 20);
            this.lbl_Lic1.TabIndex = 10;
            this.lbl_Lic1.Text = "许可文件1：";
            this.lbl_Lic1.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // btn_OpenLicFile_1
            // 
            this.btn_OpenLicFile_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenLicFile_1.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenLicFile_1.Image")));
            this.btn_OpenLicFile_1.Location = new System.Drawing.Point(534, 82);
            this.btn_OpenLicFile_1.Name = "btn_OpenLicFile_1";
            this.btn_OpenLicFile_1.Size = new System.Drawing.Size(31, 31);
            this.btn_OpenLicFile_1.TabIndex = 11;
            this.btn_OpenLicFile_1.UseVisualStyleBackColor = true;
            this.btn_OpenLicFile_1.Click += new System.EventHandler(this.button2_Click);
            // 
            // pl_MCName
            // 
            this.pl_MCName.BackColor = System.Drawing.Color.Transparent;
            this.pl_MCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_MCName.Controls.Add(this.tb_MacName);
            this.pl_MCName.Location = new System.Drawing.Point(138, 15);
            this.pl_MCName.Name = "pl_MCName";
            this.pl_MCName.Size = new System.Drawing.Size(390, 30);
            this.pl_MCName.TabIndex = 12;
            // 
            // tb_MacName
            // 
            this.tb_MacName.BackColor = System.Drawing.Color.White;
            this.tb_MacName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MacName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_MacName.Location = new System.Drawing.Point(-1, 3);
            this.tb_MacName.Name = "tb_MacName";
            this.tb_MacName.ReadOnly = true;
            this.tb_MacName.Size = new System.Drawing.Size(390, 22);
            this.tb_MacName.TabIndex = 0;
            // 
            // pl_LicFile_2
            // 
            this.pl_LicFile_2.BackColor = System.Drawing.Color.Transparent;
            this.pl_LicFile_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_LicFile_2.Controls.Add(this.tb_Lic2);
            this.pl_LicFile_2.Location = new System.Drawing.Point(138, 126);
            this.pl_LicFile_2.Name = "pl_LicFile_2";
            this.pl_LicFile_2.Size = new System.Drawing.Size(390, 30);
            this.pl_LicFile_2.TabIndex = 13;
            // 
            // tb_Lic2
            // 
            this.tb_Lic2.BackColor = System.Drawing.Color.White;
            this.tb_Lic2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Lic2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Lic2.Location = new System.Drawing.Point(-1, 3);
            this.tb_Lic2.Name = "tb_Lic2";
            this.tb_Lic2.ReadOnly = true;
            this.tb_Lic2.Size = new System.Drawing.Size(390, 22);
            this.tb_Lic2.TabIndex = 0;
            // 
            // btn_OpenLicFile_2
            // 
            this.btn_OpenLicFile_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenLicFile_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenLicFile_2.Image")));
            this.btn_OpenLicFile_2.Location = new System.Drawing.Point(534, 126);
            this.btn_OpenLicFile_2.Name = "btn_OpenLicFile_2";
            this.btn_OpenLicFile_2.Size = new System.Drawing.Size(31, 30);
            this.btn_OpenLicFile_2.TabIndex = 14;
            this.btn_OpenLicFile_2.UseVisualStyleBackColor = true;
            this.btn_OpenLicFile_2.Click += new System.EventHandler(this.btn_OpenLicFile_2_Click);
            // 
            // lbl_Lic2
            // 
            this.lbl_Lic2.AutoSize = true;
            this.lbl_Lic2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Lic2.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lic2.Location = new System.Drawing.Point(16, 129);
            this.lbl_Lic2.Name = "lbl_Lic2";
            this.lbl_Lic2.Size = new System.Drawing.Size(87, 20);
            this.lbl_Lic2.TabIndex = 15;
            this.lbl_Lic2.Text = "许可文件2：";
            // 
            // btn_ExpMcInfo
            // 
            this.btn_ExpMcInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(171)))));
            this.btn_ExpMcInfo.FlatAppearance.BorderSize = 2;
            this.btn_ExpMcInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExpMcInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ExpMcInfo.Location = new System.Drawing.Point(18, 171);
            this.btn_ExpMcInfo.Name = "btn_ExpMcInfo";
            this.btn_ExpMcInfo.Size = new System.Drawing.Size(112, 33);
            this.btn_ExpMcInfo.TabIndex = 17;
            this.btn_ExpMcInfo.Text = "导出机器信息";
            this.btn_ExpMcInfo.UseVisualStyleBackColor = true;
            this.btn_ExpMcInfo.Click += new System.EventHandler(this.btn_ExpMcInfo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.label1.Location = new System.Drawing.Point(137, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "提示：此功能可能被杀毒软件拦截，请允许操作";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pl_MCCode);
            this.tabPage2.Controls.Add(this.btn_ExpMcInfo);
            this.tabPage2.Controls.Add(this.pl_MCName);
            this.tabPage2.Controls.Add(this.btn_UpdateLic);
            this.tabPage2.Controls.Add(this.btn_OpenLicFile_2);
            this.tabPage2.Controls.Add(this.lbl_Lic2);
            this.tabPage2.Controls.Add(this.pl_LicFile_2);
            this.tabPage2.Controls.Add(this.lbl_Lic1);
            this.tabPage2.Controls.Add(this.pl_LicFile_1);
            this.tabPage2.Controls.Add(this.btn_OpenLicFile_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "机器码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "机器名称：";
            // 
            // pl_MCCode
            // 
            this.pl_MCCode.BackColor = System.Drawing.Color.Transparent;
            this.pl_MCCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_MCCode.Controls.Add(this.tb_MacCode);
            this.pl_MCCode.Location = new System.Drawing.Point(138, 51);
            this.pl_MCCode.Name = "pl_MCCode";
            this.pl_MCCode.Size = new System.Drawing.Size(390, 30);
            this.pl_MCCode.TabIndex = 19;
            // 
            // tb_MacCode
            // 
            this.tb_MacCode.BackColor = System.Drawing.Color.White;
            this.tb_MacCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MacCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_MacCode.Location = new System.Drawing.Point(-1, 3);
            this.tb_MacCode.Name = "tb_MacCode";
            this.tb_MacCode.ReadOnly = true;
            this.tb_MacCode.Size = new System.Drawing.Size(390, 22);
            this.tb_MacCode.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(582, 212);
            this.panel5.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 251);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "平台运行环境配置工具";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pl_LicFile_1.ResumeLayout(false);
            this.pl_LicFile_1.PerformLayout();
            this.pl_MCName.ResumeLayout(false);
            this.pl_MCName.PerformLayout();
            this.pl_LicFile_2.ResumeLayout(false);
            this.pl_LicFile_2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pl_MCCode.ResumeLayout(false);
            this.pl_MCCode.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Lic1;
        private System.Windows.Forms.Button btn_UpdateLic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pl_LicFile_1;
        private System.Windows.Forms.Label lbl_Lic1;
        private System.Windows.Forms.Button btn_OpenLicFile_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pl_MCName;
        private System.Windows.Forms.TextBox tb_MacName;
        private System.Windows.Forms.Panel pl_LicFile_2;
        private System.Windows.Forms.TextBox tb_Lic2;
        private System.Windows.Forms.Button btn_OpenLicFile_2;
        private System.Windows.Forms.Label lbl_Lic2;
        private System.Windows.Forms.Button btn_ExpMcInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_SetPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pl_MCCode;
        private System.Windows.Forms.TextBox tb_MacCode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}