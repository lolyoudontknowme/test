/*
 * Created by Ranorex
 * User: z-plat
 * Date: 11/21/2023
 * Time: 5:54 PM
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
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AOI_CRM_Eddie.Class
{
	/// <summary>
	/// Description of SetAOIConfig.
	/// </summary>
	public class SetAOIConfig
	{
		[DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string strFilePath);
               
		public static void SetDefault()
		{
			try
			{
	            string strIniPath = @"C:\Kohyoung\AOI\AOIGUISetup.ini";
	            WritePrivateProfileString("VISION", "Use_GPU", "0", strIniPath);
	            WritePrivateProfileString("VISION", "Use_Camera_Rot_CAL_V2", "0", strIniPath);
	            WritePrivateProfileString("DEBUG", "CompareCompCountOnFovAndResult", "0", strIniPath);
	            WritePrivateProfileString("RESULT", "ShowGood", "1", strIniPath);
	            WritePrivateProfileString("RESULT", "DBUse", "1", strIniPath);
	            WritePrivateProfileString("LIBRARY", "UseLibMngV2", "1", strIniPath);
	            WritePrivateProfileString("LANGUAGE", "Language", "0", strIniPath);
	            WritePrivateProfileString("SWPLATFORM", "DecisionCNTFromReview", "0", strIniPath);
	            WritePrivateProfileString("CUSTOMER", "CustomerNumber", "3918", strIniPath);
	            WritePrivateProfileString("CTC", "UseCheckTheChecker", "0", strIniPath);
	            WritePrivateProfileString("BARCODE", "Type", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 1", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 2", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 3", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 4", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 6", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 7", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 8", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 9", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 10", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 11", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 12", "0", strIniPath);
	            WritePrivateProfileString("UI", "AUTO_JOB_LOAD", "0", strIniPath);
			}
			catch (Exception e)
			{
				Class.AOILog.LogWrite("Set AOIConfig Default error");
				Class.AOILog.LogWrite(e.ToString());
			}
		}
		
        public void SetModelMark()
        {
			try
			{
	        	string strIniPath = @"C:\Kohyoung\AOI\AOIGUISetup.ini";
	        	WritePrivateProfileString("VISION", "Use_GPU", "0", strIniPath);
	        	WritePrivateProfileString("VISION", "Use_Camera_Rot_CAL_V2", "0", strIniPath);
	            WritePrivateProfileString("DEBUG", "CompareCompCountOnFovAndResult", "0", strIniPath);
	        	WritePrivateProfileString("RESULT", "ShowGood", "1", strIniPath);
	            WritePrivateProfileString("RESULT", "DBUse", "1", strIniPath);
	            WritePrivateProfileString("LIBRARY", "UseLibMngV2", "1", strIniPath);
	            WritePrivateProfileString("LANGUAGE", "Language", "0", strIniPath);
	            WritePrivateProfileString("SWPLATFORM", "DecisionCNTFromReview", "1", strIniPath);
	            WritePrivateProfileString("CUSTOMER", "CustomerNumber", "5960", strIniPath);
	            WritePrivateProfileString("CTC", "UseCheckTheChecker", "0", strIniPath);
	            WritePrivateProfileString("BARCODE", "Type", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 1", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 2", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 3", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 4", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 6", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 7", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 8", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 9", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 10", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 11", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 12", "0", strIniPath);
	            WritePrivateProfileString("UI", "AUTO_JOB_LOAD", "0", strIniPath);
			}
			catch (Exception e)
			{
				Class.AOILog.LogWrite("Set AOIConfig Model Mark error");
				Class.AOILog.LogWrite(e.ToString());
			}
        }
        
        public void SetCTC()
        {
			try
			{
	        	string strIniPath = @"C:\Kohyoung\AOI\AOIGUISetup.ini";
	        	WritePrivateProfileString("VISION", "Use_GPU", "0", strIniPath);
	        	WritePrivateProfileString("VISION", "Use_Camera_Rot_CAL_V2", "0", strIniPath);
	            WritePrivateProfileString("DEBUG", "CompareCompCountOnFovAndResult", "0", strIniPath);
	        	WritePrivateProfileString("RESULT", "ShowGood", "1", strIniPath);
	            WritePrivateProfileString("RESULT", "DBUse", "1", strIniPath);
	            WritePrivateProfileString("LIBRARY", "UseLibMngV2", "1", strIniPath);
	            WritePrivateProfileString("LANGUAGE", "Language", "0", strIniPath);
	            WritePrivateProfileString("SWPLATFORM", "DecisionCNTFromReview", "0", strIniPath);
	            WritePrivateProfileString("CUSTOMER", "CustomerNumber", "3918", strIniPath);
	            WritePrivateProfileString("CTC", "UseCheckTheChecker", "-1", strIniPath);
	            WritePrivateProfileString("BARCODE", "Type", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 1", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 2", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 3", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 4", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 6", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 7", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 8", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 9", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 10", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 11", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 12", "0", strIniPath);
	            WritePrivateProfileString("UI", "AUTO_JOB_LOAD", "0", strIniPath);
			}
			catch (Exception e)
			{
				Class.AOILog.LogWrite("Set AOIConfig CTC error");
				Class.AOILog.LogWrite(e.ToString());
			}
        }
        
        public void SetGPU()
        {
        	try
			{
	            string strIniPath = @"C:\Kohyoung\AOI\AOIGUISetup.ini";
	            WritePrivateProfileString("VISION", "Use_GPU", "1", strIniPath);
	            WritePrivateProfileString("VISION", "Use_Camera_Rot_CAL_V2", "0", strIniPath);
	            WritePrivateProfileString("DEBUG", "CompareCompCountOnFovAndResult", "0", strIniPath);
	            WritePrivateProfileString("RESULT", "ShowGood", "1", strIniPath);
	            WritePrivateProfileString("RESULT", "DBUse", "1", strIniPath);
	            WritePrivateProfileString("LIBRARY", "UseLibMngV2", "1", strIniPath);
	            WritePrivateProfileString("LANGUAGE", "Language", "0", strIniPath);
	            WritePrivateProfileString("SWPLATFORM", "DecisionCNTFromReview", "0", strIniPath);
	            WritePrivateProfileString("CUSTOMER", "CustomerNumber", "3918", strIniPath);
	            WritePrivateProfileString("CTC", "UseCheckTheChecker", "0", strIniPath);
	            WritePrivateProfileString("VISION", "Use_GPU", "1", strIniPath);
	            WritePrivateProfileString("BARCODE", "Type", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 1", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 2", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 3", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 4", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 6", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 7", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 8", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 9", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 10", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 11", "0", strIniPath);
	            WritePrivateProfileString("Verification", "Verification Type 12", "0", strIniPath);
	            WritePrivateProfileString("UI", "AUTO_JOB_LOAD", "0", strIniPath);
        	}
			catch (Exception e)
			{
				Class.AOILog.LogWrite("Set AOIConfig CTC error");
				Class.AOILog.LogWrite(e.ToString());
			}
        }
	}
}
