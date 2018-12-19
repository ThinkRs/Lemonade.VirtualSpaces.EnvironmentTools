 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade.VirtualSpaces.EnvironmentTools
{
    /// <summary>
    /// 
    /// </summary>
    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        object info = null;
        /// <summary>
        /// 
        /// </summary>
        string labtext = "";
        /// <summary>
        /// 
        /// </summary>
        public object Info {
            get {
                return info;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="labtext"></param>
        public DataItem(object info,string labtext)
        {
            this.info = info;
            this.labtext = labtext;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.labtext;
        }
    }
}
