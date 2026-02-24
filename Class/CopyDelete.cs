/*
 * Created by Ranorex
 * User: z-plat
 * Date: 11/23/2023
 * Time: 4:12 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AOI_CRM_Eddie.Class
{
	/// <summary>
	/// Description of CopyFile.
	/// </summary>
	public class CopyDelete
	{
		//Backup the file that to be editing to bin\CompareText folder  
		public void BackupFile(string strBakFileName)
		{
			string strTxtPath = Directory.GetCurrentDirectory().Replace(@"\Release", "").Replace(@"\Debug", "") + @"\CompareText";
			//string strTxtPath = @"...\CompareText";
		    DirectoryInfo di = new DirectoryInfo(strTxtPath);
		    string strBakPath = di.FullName;
		    string strAoiPath = @"C:\Kohyoung\AOI\";
		    
		    foreach (var fileInfo in new DirectoryInfo(strAoiPath).GetFiles())
		    {
		        string strSourceFile = Path.Combine(strAoiPath, fileInfo.Name);
		        string strDestFile = Path.Combine(strBakPath, fileInfo.Name);
		        
		        //Check if the strBakFileName value is exist or not then copy to bin\CompareText
		        if (fileInfo.Exists && fileInfo.Name == strBakFileName)
		        {
		            File.Copy(strSourceFile, strDestFile, true);
		        }
		    }
		}
		
		//Restore the file that has been edited to AOI folder
		public void RestoreFile(string strResFileName)
		{
			string strTxtPath = Directory.GetCurrentDirectory().Replace(@"\Release", "").Replace(@"\Debug", "") + @"\CompareText";
			//string strTxtPath = @"...\CompareText";
		    DirectoryInfo di = new DirectoryInfo(strTxtPath);
		    string strResPath = di.FullName;
		    string strAoiPath = @"C:\Kohyoung\AOI\";
		    
		    foreach (var fileInfo in new DirectoryInfo(strResPath).GetFiles())
		    {
		        string strSourceFile = Path.Combine(strResPath, fileInfo.Name);
		        string strDestFile = Path.Combine(strAoiPath, fileInfo.Name);
		        
		        //Check if the strResFileName value is exist or not then restore to AOI
		        if (fileInfo.Exists && fileInfo.Name == strResFileName)
		        {
		            File.Copy(strSourceFile, strDestFile, true);
		        }
		    }
		}
		
		public void BackupFolder(string strFolderName, string strDFolderPath)
        {
			string strFolderPath = Directory.GetCurrentDirectory().Replace(@"\Release", "").Replace(@"\Debug", "") + @"\TestFiles";
            DirectoryInfo di = new DirectoryInfo(strFolderPath + @"\" + strFolderName);
            
            if (di.Exists)
            {
            	string a = strDFolderPath.ToString();
            	FileSystem.CopyDirectory(strDFolderPath + @"\" + strFolderName + @"\", strFolderPath + @"\" + strFolderName, true);
            }
            else if (!di.Exists)
            {
            	Directory.CreateDirectory(di.ToString());
            	string a = strDFolderPath.ToString();
            	FileSystem.CopyDirectory(strDFolderPath + @"\" + strFolderName + @"\", strFolderPath + @"\" + strFolderName, true);
            }
            else
            {
            	Class.AOILog.LogWrite("Unable to perform Backup Folder" + strFolderName.ToString());
            }
        }
		
		public void RestoreFolder(string strFolderName, string strDFolderPath)
        {
			string strFolderPath = Directory.GetCurrentDirectory().Replace(@"\Release", "").Replace(@"\Debug", "") + @"\TestFiles";
            DirectoryInfo di = new DirectoryInfo(strFolderPath + @"\" + strFolderName);
            DirectoryInfo diF = new DirectoryInfo(strDFolderPath + @"\" + strFolderName);
            
            if (diF.Exists)
            {
            	string a = strDFolderPath.ToString();
            	FileSystem.CopyDirectory(strFolderPath + @"\" + strFolderName, strDFolderPath + @"\" + strFolderName + @"\", true);
            }
            else if (!diF.Exists)
            {
            	Directory.CreateDirectory(di.ToString());
            	string a = strDFolderPath.ToString();
            	FileSystem.CopyDirectory(strFolderPath + @"\" + strFolderName, strDFolderPath + @"\" + strFolderName + @"\", true);
            }
            else
            {
            	Class.AOILog.LogWrite("Unable to perform Restore Folder" + strFolderName.ToString());
            }
        }
		
		public void DeleteFolder(string strDFolderPath)
		{
			//string strFolderPath = Directory.GetCurrentDirectory().Replace(@"\Release", "").Replace(@"\Debug", "") + @"\TestFiles";
        	Directory.Delete(strDFolderPath,true);
		}
		
		public void DeleteExtension(string strExtension)
		{
			string strFolderPath = Directory.GetCurrentDirectory().Replace(@"\Release", "").Replace(@"\Debug", "") + @"\TestFiles";
        	string strExt = "." + strExtension;
        	string[] strABC = Directory.GetFiles(strFolderPath + @"\license", $"*{strExt}");
        	foreach (string item in strABC)
        	{
        		File.Delete(item);
        	}
		}
	}
}
