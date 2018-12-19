using HardInfoAndSecurity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lemonade.VirtualSpaces.EnvironmentTools
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl_Lic1.Visible = false;
            btn_OpenLicFile_1.Visible = false;
            btn_UpdateLic.Visible = false;
            pl_LicFile_1.Visible = true;
            tb_Lic1.Text = System.Environment.MachineName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "许可文件|*.lic9d"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tb_Lic1.Text = dialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UpdateInfoByFile(tb_Lic1.Text,tb_Lic2.Text);
        }


        /// <summary>
        /// 将两个许可文件拷贝到相应位置
        /// </summary>
        /// <param name="filePath_lic9D"></param>
        /// <param name="filePath_lic"></param>
        private void UpdateInfoByFile(string filePath_lic9D,string filePath_lic)
        {
            if (tb_Lic1.Text == ""|| tb_Lic2.Text == "")
            {
                return;
            }

            if (filePath_lic9D.EndsWith("lic9d", StringComparison.CurrentCultureIgnoreCase)&&filePath_lic.EndsWith("lic", StringComparison.CurrentCultureIgnoreCase))
            {
                try
                {
                    string destFileName_9D = string.Empty;
                    string str2 = filePath_lic9D.Substring(filePath_lic9D.LastIndexOf(@"\") + 1);
                    string path = @"C:\Program Files\Common Files\SuperMap\License\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    destFileName_9D = path + str2;
                    File.Copy(filePath_lic9D, destFileName_9D, true);


                    string destFileName_lic = string.Empty;
                    string str20 = filePath_lic.Substring(filePath_lic.LastIndexOf(@"\") + 1);
                    destFileName_lic = Directory.GetCurrentDirectory() + "\\"+str20;
                    File.Copy(filePath_lic, destFileName_lic, true);
                    MessageBox.Show("许可更新成功");
                }
                catch
                {
                    MessageBox.Show("更新失败");
                }
            }
            else
            {
                MessageBox.Show("文件格式不正确");
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "许可文件|*.lic9d"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tb_Lic1.Text = dialog.FileName;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        { 
            tabControl1.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        { 
            GetHardwareInfo ghi = new GetHardwareInfo();  
            tabControl1.SelectedIndex = 1;
            tb_MacName.Text = Environment.MachineName;
            tb_MacCode.Text = ghi.GetCpuID() + ghi.GetDiskSerialNumber();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Orange;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
           // lbl_MacName.ForeColor = Color.Orange;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
          //  lbl_MacName.ForeColor = Color.White;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Orange;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void btn_OpenLicFile_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "许可文件|*.lic"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tb_Lic2.Text = dialog.FileName;
            }
        }

        private void btn_GetMacName_Click(object sender, EventArgs e)
        {
            tb_MacName.Text = Environment.MachineName;
        }

        private void btn_SetPath_Click(object sender, EventArgs e)
        {
            EnvirSet.AddDirectoryToPath();
            MessageBox.Show("环境变量配置成功");
        }

        private void btn_ExpMcInfo_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.SelectedPath + @"\VSSD.txt";
                File.Delete(path); 
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(tb_MacName.Text);//开始写入值
                    sw.WriteLine(tb_MacCode.Text);
                }
                MessageBox.Show("保存成功");
            }

        }
    }
}
