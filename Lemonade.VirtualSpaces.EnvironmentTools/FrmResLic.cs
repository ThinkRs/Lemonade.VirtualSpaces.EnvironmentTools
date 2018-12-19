using Lemonade.Accredit;
using Lemonade.Frame;
using Lemonade.Frame.LicSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lemonade.VirtualSpaces.EnvironmentTools
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmResLic : Form
    {
        ILicenseManager licmanager = null;
        string tagfile = "";
        /// <summary>
        /// 
        /// </summary>
        public FrmResLic(string tagfile)
        {
            this.tagfile = tagfile;
            this.licmanager = Lemon.GetLicenseManager();
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        public void setLic(string FileName)
        {
            LcPack lcp = new LcPack();
            string temp = lcp.ExPk(FileName);
            this.copyFiles(temp);
            this.licmanager.RunCheckLicenses();
        }

        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="tagpath"></param>
        private void copyFiles(string tagpath)
        {
            if (!Directory.Exists(tagpath))
                return;

            string[]  delfiles=Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string tftmp in delfiles)
            {
                if (Path.GetExtension(tftmp).ToLower() == ".license")
                {
                    File.Delete(tftmp);
                } 
            }
            List<string> files = this.findFile(tagpath);
            foreach (string tmps in files)
            {
                this.copySmLic(tmps);
                this.copyLic(tmps);
            }
        } /// <summary>
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmResLic_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(runLicPtc);
            thread.Start(); 
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual void runLicPtc()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(runLicPtc));
            }
            else
            {
                this.setLic(this.tagfile);
                this.Close();
            } 
        }
    }
}
