using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade.VirtualSpaces.EnvironmentTools
{
    public class EnvirSet
    {
        /// <summary>
        /// 将当前路径添加到PATH环境变量中
        /// </summary>
        public static void AddDirectoryToPath()
        {
            string path = Directory.GetCurrentDirectory();
            SetPathBefore(path);
        }

        /// <summary>
        /// 获取机器码
        /// </summary>
        /// <returns></returns>
        public static string GetMachineName()
        {
            return System.Environment.MachineName;
        }


        private static void SetPathBefore(string strHome)
        {
            string pathlist;
            pathlist = GetSysEnvironmentByName("PATH");
            string[] list = pathlist.Split(';');
            bool isPathExist = false;

            foreach (string item in list)
            {
                if (item == strHome)
                    isPathExist = true;
            }
            if (!isPathExist)
            {
                SetSysEnvironment("PATH", strHome + ";" + pathlist);
            }
        }

        /// <summary>
        /// 获取系统环境变量
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string GetSysEnvironmentByName(string name)
        {
            string result = string.Empty;
            try
            {
                result = OpenSysEnvironment().GetValue(name).ToString();//读取
            }
            catch (Exception)
            {
                return string.Empty;
            }
            return result;
        }

        /// <summary>
        /// 打开系统环境变量注册表
        /// </summary>
        /// <returns>RegistryKey</returns>
        private static RegistryKey OpenSysEnvironment()
        {
            RegistryKey regLocalMachine = Registry.LocalMachine;
            RegistryKey regSYSTEM = regLocalMachine.OpenSubKey("SYSTEM", true);//打开HKEY_LOCAL_MACHINE下的SYSTEM 
            RegistryKey regControlSet001 = regSYSTEM.OpenSubKey("ControlSet001", true);//打开ControlSet001 
            RegistryKey regControl = regControlSet001.OpenSubKey("Control", true);//打开Control 
            RegistryKey regManager = regControl.OpenSubKey("Session Manager", true);//打开Control 
            RegistryKey regEnvironment = regManager.OpenSubKey("Environment", true);
            return regEnvironment;
        }

        /// <summary>
        /// 设置系统环境变量
        /// </summary>
        /// <param name="name">变量名</param>
        /// <param name="strValue">值</param>
        private static void SetSysEnvironment(string name, string strValue)
        {
            OpenSysEnvironment().SetValue(name, strValue);
        }

    }
}
