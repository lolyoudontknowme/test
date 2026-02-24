/*
 * Created by Ranorex
 * User: z-plat
 * Date: 11/24/2023
 * Time: 3:37 PM
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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AOI_CRM_Eddie.Class
{
	/// <summary>
	/// Description of ManualInsp.
	/// </summary>
	public class AOIInsp
	{
		public static void ManualInsp(string strCompName)
		{
			try
        	{
        		AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("855;16");
        		
	            Keyboard.PrepareFocus(AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640);
            	Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640.TextValue= strCompName;
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button.Click();
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button1.Click();
	            Delay.Seconds(3);
	            
	            if (AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1262.TextValue != "Running (SIM LM)")
	            {
	            	AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button1.Click();
	            }
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element5006Info.WaitForExists(22222);
	            Delay.Seconds(1);
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element5006.Click();
	            Delay.Seconds(1);
        	}
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Check Manual Inspection error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
		}
		
		public static void ManualInspHold(string strCompName)
		{
			try
        	{
        		AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("855;16");
	            
	            Keyboard.PrepareFocus(AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640);
            	Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640.TextValue= strCompName;
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button.Click();
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button1.Click();
	            Delay.Seconds(3);
	            
	            if (AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1262.TextValue != "Running (SIM LM)")
	            {
	            	AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button1.Click();
	            }
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element5006Info.WaitForExists(22222);
	            Delay.Seconds(1);
	            
	            if (AOI_CRM_EddieRepository.Instance.SCrossTag1.SelfInfo.Exists(3333))
	            {
	            	AOI_CRM_EddieRepository.Instance.SCrossTag1.Button닫기.Click();
	            }
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element3000.Click("399;399");
	            Delay.Seconds(1);
        	}
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Check Manual Inspection (Hold) error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
		}
		
		public static void AutoInsp()
        {
        	try
        	{
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("126;18");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button4.Click();
	            AOI_CRM_EddieRepository.Instance.Settings.Result.Click();
	            
	        	if (AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Checked == true)
	        	{
	        		AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Click();
	        		AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Click();
	        	}
	        	else
	        	{
	        		AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Click();
	        	}
	        	
	            AOI_CRM_EddieRepository.Instance.Settings.Apply.Click();
	            AOI_CRM_EddieRepository.Instance.AOIGUI1.Button확인.Click();
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("126;18");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button3.Click();
	            Delay.Seconds(3);
	            
	            if (AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1262.TextValue != "Running (SIM LM)")
	            {
	            	AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button3.Click();
	            }
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element5004Info.WaitForExists(123456);
	            Delay.Seconds(3);
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element5004.Click();
	            Delay.Seconds(1);
            }
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Check Auto Inspection error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
        }
		
		public static void AutoInspHold()
        {
        	try
        	{
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("126;18");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button4.Click();
	            AOI_CRM_EddieRepository.Instance.Settings.Result.Click();
	            
	        	if (AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Checked == true)
	        	{
	        		AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Click();
	        		AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Click();
	        	}
	        	else
	        	{
	        		AOI_CRM_EddieRepository.Instance.Settings.ResultDebug.Click();
	        	}
	        	
	            AOI_CRM_EddieRepository.Instance.Settings.Apply.Click();
	            AOI_CRM_EddieRepository.Instance.AOIGUI1.Button확인.Click();
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("126;18");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button3.Click();
	            Delay.Seconds(3);
	            
	            if (AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1262.TextValue != "Running (SIM LM)")
	            {
	            	AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button3.Click();
	            }
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element5004Info.WaitForExists(123456);
	            Delay.Seconds(3);
	            
	            if (AOI_CRM_EddieRepository.Instance.SCrossTag1.SelfInfo.Exists(3333))
	            {
	            	AOI_CRM_EddieRepository.Instance.SCrossTag1.Button닫기.Click();
	            }
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUI.Element3000.Click("399;399");
	            Delay.Seconds(1);
            }
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Check Auto Inspection (Hold) error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
        }
	}
}
