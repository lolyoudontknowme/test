/*
 * Created by Ranorex
 * User: z-plat
 * Date: 11/21/2023
 * Time: 5:53 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AOI_CRM_Eddie.Class
{
	/// <summary>
	/// Description of RunAOIGUI.
	/// </summary>
	public class RunAOIGUI
	{
        public static void RunAOI()
        {
        	try
        	{
        		if (AOI_CRM_EddieRepository.Instance.AOIGUIV2.SelfInfo.Exists())
        		{
        			Host.Current.KillApplication(AOI_CRM_EddieRepository.Instance.AOIGUIV2.Self);
        		}
        		
	        	ProcessStartInfo psA = new ProcessStartInfo();
	            psA.FileName = @"C:\Kohyoung\AOI\AOIGUI.exe";
	            psA.Arguments = @" /sim";
	            //ps.Arguments = @" /sim /jobpath=""E:\\LMJOB\KOHYOUNG7 1ARRAY\KOHYOUNG7 1ARRAY.kyjob";
	            Process.Start(psA);
	            //Process pr = Process.Start(ps);
	            //pr.WaitForExit();
        	}
        	catch (Exception e)
        	{
        		Class.AOILog.LogWrite("Run AOIGUI error");
        		Class.AOILog.LogWrite(e.ToString());
        	}
        }
        
        public static void RunWinMCS()
        {
        	try
        	{
	        	ProcessStartInfo psM = new ProcessStartInfo();
	            psM.FileName = @"C:\KohYoung\AOI\WinMCS.exe";
	            Process.Start(psM);
        	}
        	catch (Exception e)
        	{
        		Class.AOILog.LogWrite("Run WinMCS error");
        		Class.AOILog.LogWrite(e.ToString());
        	}
        }
        
        public static string strPt = "PopUpTurret";
        
        public static void OpenAOILoadJOB()
        {
        	try
        	{
        		if (AOI_CRM_EddieRepository.Instance.AOIGUIV2.SelfInfo.Exists())
        		{
        			Host.Current.KillApplication(AOI_CRM_EddieRepository.Instance.AOIGUIV2.Self);
        		}
	        	
        		Class.RunAOIGUI.RunWinMCS();
	        	
	        	if (AOI_CRM_EddieRepository.Instance.WinMCS.Button확인Info.Exists(5555))
	        	{
	        		AOI_CRM_EddieRepository.Instance.WinMCS.Button확인.Click();
	        	}
	        	
	        	Class.RunAOIGUI.RunAOI();
	        	PopupTurretRun();
	        	
	        	AOI_CRM_EddieRepository.Instance.AOGUILMLOGINDLG.SelfInfo.WaitForExists(66666);
	        	
	        	PopupTurretKill();
	        	LogInLoadJOB();
	        	chkCTCpopup();
	        	Delay.Seconds(2);
        	}
        	catch (Exception e)
            {
            	Class.AOILog.LogWrite("Open AOIGUI & Load JOB error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
        }
        
        public static void PopupTurretRun()
        {
            Process[] prList = Process.GetProcessesByName(strPt);
            if (prList.Length < 1)
            {
                Process.Start(strPt + ".exe");
            }
        }
        
        public static void PopupTurretKill()
        {
            Process[] prList = Process.GetProcessesByName(strPt);
			foreach (Process item in prList)
			{
				item.Kill();
			}
        }
        
        public static void LogInLoadJOB()
        {
            AOI_CRM_EddieRepository.Instance.AOGUILMLOGINDLG.Text1004.TextValue="kyadmin";
            AOI_CRM_EddieRepository.Instance.AOGUILMLOGINDLG.Text1005.TextValue="21077421!";
            AOI_CRM_EddieRepository.Instance.AOGUILMLOGINDLG.Button.Click();
            
            if (AOI_CRM_EddieRepository.Instance.AOIGUI1.Button확인Info.Exists(13579))
            {
            	AOI_CRM_EddieRepository.Instance.AOIGUI1.Button확인.Click();
            }
            
            AOI_CRM_EddieRepository.Instance.AOIGUI.Text10251Info.WaitForExists(66666);
            Delay.Seconds(2);
            AOI_CRM_EddieRepository.Instance.AOIGUI.Self.Click("93;233");
            AOI_CRM_EddieRepository.Instance.AOIGUI1.Text57029.TextValue="kohyoung7 1array";
            AOI_CRM_EddieRepository.Instance.AOIGUI1.Search.Click();
            AOI_CRM_EddieRepository.Instance.AOIGUI1.Element8103.Click("279;35");
            AOI_CRM_EddieRepository.Instance.AOIGUI1.Element8103.Click("279;35");
            AOI_CRM_EddieRepository.Instance.List1000.NotUse.Click();
            AOI_CRM_EddieRepository.Instance.AOIGUI1.ButtonOK.Click();
            
            //Delay.Seconds(10);
        }
        
        public static void chkCTCpopup()
        {
        	// sau khi login , pcb setting infor window ko xuat hien
            AOI_CRM_EddieRepository.Instance.PCBSettingsInfo.CancelInfo.WaitForExists(33333);
            Delay.Seconds(2);
        	if (AOI_CRM_EddieRepository.Instance.AOIGUI1.Element201Info.Exists(3333))
        	{
        		AOI_CRM_EddieRepository.Instance.AOIGUI1.Element201.Click();
        		AOI_CRM_EddieRepository.Instance.PCBSettingsInfo.Cancel.Click();
        	}
        	/*else if (AOI_CRM_EddieRepository.Instance.PCBSettingsInfo.CancelInfo.Exists(3333))
        	{
        		AOI_CRM_EddieRepository.Instance.PCBSettingsInfo.Cancel.Click();
        	}*/
        	else
        	{
        		AOI_CRM_EddieRepository.Instance.PCBSettingsInfo.Cancel.Click();
        	}

        	//AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("379;16");
        	//AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("123;16");
        }
        
        public static void CloseAOI()
        {
        	try
        	{
        		Delay.Seconds(3);
	        	AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button5.Click();
	        		        	
	        	if (AOI_CRM_EddieRepository.Instance.AOIGUI1.예YInfo.Exists(3333))
	        	{
	        		AOI_CRM_EddieRepository.Instance.AOIGUI1.예Y.Click();
	        	}
	        	else
	        	{
	        		AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button5.Click();
	        		AOI_CRM_EddieRepository.Instance.AOIGUI1.예Y.Click();
	        	}
	        	if (AOI_CRM_EddieRepository.Instance.AOIGUI1.아니요NInfo.Exists(5555))
	        	{
	        		AOI_CRM_EddieRepository.Instance.AOIGUI1.아니요N.Click();
	        	}
	        	Delay.Seconds(3);
        	}
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Close AOIGUI error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
        }
	}
}
