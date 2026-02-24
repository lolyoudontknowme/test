/*
 * Created by Ranorex
 * User: z-plat
 * Date: 11/21/2023
 * Time: 5:52 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

using RanorexDateTime = Ranorex.DateTime;
using SystemDateTime = System.DateTime;

namespace AOI_CRM_Eddie.Class
{
	/// <summary>
	/// Description of AOILog.
	/// </summary>
	public class AOILog
	{
        private static string strFilePath = "";
        private static string strDirPath = "";
        public AOILog()
        {
            
        }
        public static void LogWrite(string str)
        {
            string strTemp;
            //strFilePath = Environment.CurrentDirectory + @"\Log\Log_" + SystemDateTime.Today.ToString("yyyyMMdd") + ".log";
            //strDirPath = Environment.CurrentDirectory + @"\Log";
            strFilePath = @"...\Log\Log_" + SystemDateTime.Today.ToString("yyyyMMdd") + ".log";
            strDirPath = @"...\Log";
            DirectoryInfo di = new DirectoryInfo(strDirPath);
            FileInfo fi = new FileInfo(strFilePath);
            try
            {
                if (!di.Exists) Directory.CreateDirectory(strDirPath);
                if (!fi.Exists)
                {
                    using (StreamWriter sw = new StreamWriter(strFilePath))
                    {
                        strTemp = string.Format("[{0}] {1}", SystemDateTime.Now, str);
                        sw.WriteLine(strTemp);
                        sw.WriteLine("");
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(strFilePath))
                    {
                        strTemp = string.Format("[{0}] {1}", SystemDateTime.Now, str);
                        sw.WriteLine(strTemp);
                        sw.WriteLine("");
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Create Log error");
        		Class.AOILog.LogWrite(e.ToString());
            }
        }
	}
}
