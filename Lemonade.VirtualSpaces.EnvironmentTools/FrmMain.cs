
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lemonade.Frame;
using Lemonade.Frame.LicSys;
using Lemonade.Accredit;
using Newtonsoft.Json;
using Lemonade.Accredit.Data;
using System.Threading;
using System.Diagnostics;

namespace Lemonade.VirtualSpaces.EnvironmentTools
{
    /// <summary>
    /// 环境配置工具
    /// </summary>
    public partial class FrmMain : Form
    {
        ILicenseManager licmanager = null;
        /// <summary>
        /// 
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            btn_UpdateLic.Visible = false; 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "许可文件|*.vsl"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FrmResLic fwait = new FrmResLic(dialog.FileName);
                    fwait.ShowDialog(this); 
                    //LcPack lcp = new LcPack();
                    //string temp = lcp.ExPk(dialog.FileName); 
                    //this.copyFiles(temp);
                    //this.licmanager.RunCheckLicenses();
                    //fwait.Close();
                    MessageBox.Show(  "设置完成。", "提示");
                } 
            }
            catch(Exception ex) {
                MessageBox.Show("设置失败:" +ex.StackTrace, "提示");
            }
        }
         
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sSourcePath"></param>
        /// <returns></returns>
        private List<string> findFile(string sSourcePath) 
        {

            List<String> list = new List<string>();
            //在指定目录及子目录下查找文件,在list中列出子目录及文件 
            DirectoryInfo Dir = new DirectoryInfo(sSourcePath); 
            DirectoryInfo[] DirSub = Dir.GetDirectories(); 
            if (DirSub.Length <= 0) 
            { 
                foreach (FileInfo f in Dir.GetFiles("*.*", SearchOption.TopDirectoryOnly)) //查找文件 
                {  
                    list.Add(Dir + @"\" + f.ToString()); 
                } 
            } 
            int t = 1; 
            foreach (DirectoryInfo d in DirSub)//查找子目录  
            {
                findFile(Dir + @"\" + d.ToString()); 
                list.Add(Dir + @"\" + d.ToString()); 
                if (t == 1) 
                { 
                    foreach (FileInfo f in Dir.GetFiles("*.*", SearchOption.TopDirectoryOnly)) //查找文件 
                    { 
                        list.Add(Dir + @"\" + f.ToString()); 
                    } 
                    t = t + 1; 
                } 
            } 
            return list; 
        }
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="tagpath"></param>
        private void copyFiles(string tagpath)
        {
            if (!Directory.Exists(tagpath))
                return;
            List<string> files = this.findFile(tagpath);
            foreach (string tmps in files)
            {
                this.copySmLic(tmps);
                this.copyLic(tmps);
            }
        }
        /// <summary>
        /// 复制超图许可文件
        /// </summary>
        /// <param name="tagpath"></param>
        private void copySmLic(string tmps)
        { 
            if (tmps.EndsWith("lic9d", StringComparison.CurrentCultureIgnoreCase))
            {
                string destFileName_9D = string.Empty;
                string str2 = tmps.Substring(tmps.LastIndexOf(@"\") + 1);
                string path = @"C:\Program Files\Common Files\SuperMap\License\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    foreach (string tftmp in Directory.GetFiles(path))
                    {
                        File.Delete(tftmp);
                    }
                }
                destFileName_9D = path + str2;
                File.Copy(tmps, destFileName_9D, true);
            }   
        } 
        /// <summary>
        /// 复制其他许可文件
        /// </summary>
        /// <param name="tagpath"></param> 
        private void copyLic(string tmps)
        { 
            if (!tmps.EndsWith("lic9d", StringComparison.CurrentCultureIgnoreCase))
            {
                string destFileName_lic = string.Empty;
                string str20 = tmps.Substring(tmps.LastIndexOf(@"\") + 1);
                destFileName_lic = Directory.GetCurrentDirectory() + "\\" + str20;
                File.Copy(tmps, destFileName_lic, true);
            }  
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "许可文件|*.lic9d"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
 
            } 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        { 
            tabControl1.SelectedIndex = 0;
            label4.ForeColor = Color.Orange;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label8.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {
 
            tabControl1.SelectedIndex = 2;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.Orange;
            label6.ForeColor = Color.White;
            label8.ForeColor = Color.White;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            //label4.ForeColor = Color.Orange;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            //label4.ForeColor = Color.White;
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
            //label5.ForeColor = Color.Orange;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            //label5.ForeColor = Color.White;
        }

        private void btn_OpenLicFile_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "许可文件|*.lic"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
 
            }
        }

        private void btn_GetMacName_Click(object sender, EventArgs e)
        {
            tb_MacName.Text = Environment.MachineName;
        }

        private void btn_SetPath_Click(object sender, EventArgs e)
        {
            EnvirSet.AddDirectoryToPath();
            MessageBox.Show( "环境变量配置完成。", "提示");
        }

        private void btn_ExpMcInfo_Click(object sender, EventArgs e)
        { 
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                VSSD vssd = new VSSD();
                vssd.MacCode = tb_MacCode.Text;
                vssd.MacName = tb_MacName.Text;
                vssd.GangName = label7.Text;
                //foreach (DataItem item in this.checkedListBox1.CheckedItems)
                //{
                //    foreach (ProductInfo pinfo in ((List<ProductInfo>)item.Info))
                //    {
                //        vssd.ProductNames.Add(pinfo.ProductName);
                //    }
                //}
                VSSD.WriteVSSD(dlg.SelectedPath,vssd); 
                MessageBox.Show( "保存完成。", "提示");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.Orange;
            label8.ForeColor = Color.White;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_MouseHover(object sender, EventArgs e)
        {
            //label6.ForeColor = Color.Orange;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_MouseLeave(object sender, EventArgs e)
        { 
            //label6.Cursor = Cursor.h;  
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void readSellShapes()
        {
            this.checkedListBox1.Items.Clear();
            string path = @"lemon.lpe";
            if (!File.Exists(path))
                return;
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            String line;
            //List<ProductInfo> mlics = new List<ProductInfo>();  
            LemonProductSell lps=new LemonProductSell();
            while ((line = sr.ReadLine()) != null)
            {
                lps = JsonConvert.DeserializeObject<LemonProductSell>(line);
                break;
            }
            sr.Close();
            sr.Dispose();
            if (lps != null)
            {
                this.label7.Text = lps.GangName;
            }
            else
            {
                this.label7.Text ="null";
            }
            //Dictionary<string, List<ProductInfo>> tmpdic = new Dictionary<string, List<ProductInfo>>();

            //foreach (ProductInfo pur in mlics)
            //{
            //    if (!tmpdic.ContainsKey(pur.SellShape))
            //    {
            //        List<ProductInfo> nprdinfo = new List<ProductInfo>();
            //        nprdinfo.Add(pur);
            //        tmpdic.Add(pur.SellShape, nprdinfo);
            //    }
            //    else
            //    {
            //        tmpdic[pur.SellShape].Add(pur);
            //    }
            //}

            //foreach (string selname in tmpdic.Keys)
            //{
            //    DataItem ditem = new DataItem(tmpdic[selname], selname);
            //    this.checkedListBox1.Items.Add(ditem);
            //    if (tmpdic[selname][0].Necessity)
            //    {
            //        this.checkedListBox1.SetItemChecked(this.checkedListBox1.Items.Count - 1, true); 
            //    }
            //}

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            System.Windows.Forms.CheckedListBox tdclb = (System.Windows.Forms.CheckedListBox)sender;
            if (tdclb.SelectedItem != null)
            {
                DataItem selitem = (DataItem)tdclb.SelectedItem;
                if (((List<ProductInfo>)selitem.Info)[0].Necessity)
                {
                    e.NewValue = CheckState.Checked;
                }
            } 
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        { 
            Thread thread = new Thread(openWin);
            thread.Start(); 
        }

        private void openWin()
        {
            FrmResMain frm = new FrmResMain(this);
            frm.ShowDialog();
        }
        public void initMain()
        {
            runLicPtc();
        }

        protected virtual void runLicPtc()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(runLicPtc));
            }
            else
            {
                this.readSellShapes();
                this.licmanager = Lemon.GetLicenseManager();
                if (this.licmanager == null)
                {
                    MessageBox.Show( "许可管理器运行失败，无法配置程序环境。", "提示");
                    Application.Exit();
                }
                tb_MacName.Text = Environment.MachineName;
                tb_MacCode.Text = this.licmanager.GetMachineCode();
                this.label4.ForeColor = Color.Orange;
            }
        }

        protected virtual void label8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label8.ForeColor = Color.Orange;
        }

        protected virtual void btn_OpenHelp_Click(object sender, EventArgs e)
        {
            string helpPath = Lemon.GetRootDirectory() + "help.chm";
            if (File.Exists(helpPath))
            {
                Process.Start(helpPath);
            }
        }
    }
}
