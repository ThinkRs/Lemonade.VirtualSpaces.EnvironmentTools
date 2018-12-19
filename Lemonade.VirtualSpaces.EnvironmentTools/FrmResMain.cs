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
    public partial class FrmResMain : Form
    {
        FrmMain fmain = null;
        /// <summary>
        /// 
        /// </summary>
        public FrmResMain(FrmMain mfrm)
        {
            this.fmain = mfrm;
            InitializeComponent();
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

        protected virtual void runLicPtc()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(runLicPtc));
            }
            else
            {
                this.fmain.initMain();
                this.Close();
            }
        }

    }
}
