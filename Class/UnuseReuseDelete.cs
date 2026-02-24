/*
 * Created by Ranorex
 * User: z-plat
 * Date: 11/30/2023
 * Time: 4:31 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AOI_CRM_Eddie.Class
{
	/// <summary>
	/// Description of UnuseReuse.
	/// </summary>
	public class UnuseReuseDelete
	{
		public UnuseReuseDelete()
		{
			
		}
		
		public void UnuseComponents()
        {
        	try
        	{
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("850;18");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.ComboBox1873.Click("97;11");
	            AOI_CRM_EddieRepository.Instance.List1000.Unuse.Click("33;9");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element269.Click("333;222");
	            Delay.Milliseconds(200);
	            
	            Mouse.ScrollWheel(3600);
	            Delay.Milliseconds(500);
	           
	            Mouse.ScrollWheel(3600);
	            Delay.Milliseconds(500);
	            
	            Mouse.ScrollWheel(3600);
	            Delay.Milliseconds(500);
	            
	            Mouse.ScrollWheel(3600);
	            Delay.Milliseconds(500);
	            
	            Mouse.ScrollWheel(3600);
	            Delay.Milliseconds(500);
	            
	            Mouse.ScrollWheel(3600);
	            Delay.Milliseconds(500);
	            
	            mouseDragUnuse();
	            Delay.Milliseconds(1);
        	}
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Unuse Components error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
        }
        
        public void mouseDragUnuse()
        {
        	//Trong bat ky truong hop, su dung toa do cua Element lam dich den (MoveTo > ButtonUp) deu se khong hoat dong
        	
        	AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element269.Click("50;45");
        	//Mouse.Click(64,210);
        	Delay.Milliseconds(500);
        	Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
        	Delay.Milliseconds(500);
        	
        	//AOI_CRM_EddieRepository.Instance.AOIGUIV2.AOIGUI.Element269.MoveTo("626;436");
        	Mouse.MoveTo(1266,616);
        	Delay.Milliseconds(500);
        	Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        	Delay.Milliseconds(500);
        }
        
        public void ReuseComponents(string strCompName)
        {
        	try
        	{
        		AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("855;16");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.InspectionCondition.Click();
	            
	            Keyboard.PrepareFocus(AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640);
            	Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640.TextValue= strCompName;
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button.Click();
	            

	            AOI_CRM_EddieRepository.Instance.Element100.Click("46;46");
	            Delay.Milliseconds(200);
	            AOI_CRM_EddieRepository.Instance.Element100.Click(System.Windows.Forms.MouseButtons.Right, "46;46");
	            Delay.Milliseconds(200);
	            AOI_CRM_EddieRepository.Instance.AOIGUI2.Reuse.Click();
	            AOI_CRM_EddieRepository.Instance.AOIGUI3.Component.Click();
        	}
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Reuse Components error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
        }
        
        public void DeletePkg(string strCompName)
        {
        	try
        	{
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Element11026.Click("857;17");
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.EditPackage.Click();
	            
	            Keyboard.PrepareFocus(AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640);
            	Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Text1640.TextValue= strCompName;
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Button.Click();
	            
	            AOI_CRM_EddieRepository.Instance.AOIGUIV2.Delete.Click();
	            AOI_CRM_EddieRepository.Instance.Delete.Package.Click();
	            AOI_CRM_EddieRepository.Instance.Delete.Delete.Click();
        	}
            catch (Exception e)
            {
            	Class.AOILog.LogWrite("Check Delete Package error");
        		Class.AOILog.LogWrite(e.ToString());
        		Validate.Fail();
            }
        }
	}
}
