/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 11/08/2009
 * Time: 11:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 /*
  * Features required:
  * Comparing Multiple files.
  * Two pane transfer window.
  * Backup (archive) utility.
  * Screenshots managing utility.
  * Custom Commands Utility. Users should be able to bind some action to specific nodes.
  * Provide proper icon for app and other things.
  */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Text.RegularExpressions;

using ManianSettings;
using XMLUtils;
using HostUtil;
using GameCommunicator;
using WebRequestHelperNS;
using DataGenerate;
using STAFAL;

namespace TesterBuddy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
//		bool RSConnected=false;
		ASCIIEncoding ae;
		//byte[] body;
		//TcpClient tc;
		LinkedList<TcpClient> teamclient=new LinkedList<TcpClient>();
		//TcpListener tl;
		GSocket teamSocket;
		
		//string cmd,arg;
		//int lengthcmd,lengtharg;
		//StreamReader sr;
		//string line;
		string TodayString;
		//string[] cmdFiles;
		//List<string> currentCommand;
		IPRecord[] ipl;
		//DateTime RestoreTime;
		string hostsFile=@"c:\windows\system32\drivers\etc\hosts";
		public Settings settings;
		//AutoCompleteStringCollection hostnameacsc=new AutoCompleteStringCollection();
		
		string ud_APIXML="", ud_APITemplate="", ud_CriteriaParams="";
		List<string> ipPrefix=new List<string>();
		List<string> additionalHosts=null;
		string SettingsFileName="TesterBuddy.settings.xml";
		string selectedhost="localhost";
		string APIDirectory="api";
		List<string> apiList=new List<string> ();
		string previousScreenshotText="";
		
		List<KeyValuePair<string,string>> otherBrowsers=new List<KeyValuePair<string, string>>();
		
		public MainForm()
		{
			ipPrefix.Add("9.");
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//HostNameTextBox.AutoCompleteMode= AutoCompleteMode.SuggestAppend;			
			
			if(File.Exists("TesterBuddy.settings.xml"))
			{
				//Settings s2=new Settings("TesterBuddy.settings");
				
				WC_StoreID_ComboBox.SelectedIndex=-1;
				StoreName_ComboBox.SelectedIndex=-1;
				CatalogIDComboBox.SelectedIndex=-1;
				
				InitSettings(true);				
				
			}
			
			/*if(File.Exists("TesterBuddy.hosts"))
			{
				additionalHosts=new List<string>(FileItemReaderWriter.ReadItems("TesterBuddy.hosts"));
				InitSettings(false);				
			}*/
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void InitSettings(bool useDefSetting)
		{				
			if((!useDefSetting)&&File.Exists(selectedhost+".TB.Settings.xml"))
			{
				settings=new Settings(selectedhost+".TB.Settings.xml");
			}
			else
			{
					settings=new Settings(SettingsFileName);
			}
			
			if(settings.settingExists("IP Prefix"))
			{
				
				string []ipPrefixes=settings.getSetting("IP Prefix").Split('|');
				
				if(ipPrefixes.Length>0)
				{
					ipPrefix.Clear();
					foreach(string ipPre in ipPrefixes)
					{
						ipPrefix.Add(ipPre);
					}
				}
			}
			if(settings.settingExists("ie_path"))
			{
				IEPathTextBox.Text=settings.getSetting("ie_path");
			}
			if(settings.settingExists("firefox_path"))
			{
				FireFoxPathTextBox.Text=settings.getSetting("firefox_path");
			}
			
			//Setting for other browsers
			if(settings.settingExists("other_browser_count"))
			{
				otherBrowsers.Clear();
				int nOB=int.Parse(settings.getSetting("other_browser_count"));
				
				otherBrowsersComboBox.Items.Clear();
				
				for(int i=1;i<=nOB;i++)
				{
					if(!settings.settingExists("other_browser"+i+"_name")||!settings.settingExists("other_browser"+i+"_path"))
					{
						MessageBox.Show("Browser settings are incorrect","Err!!");
						break;
					}
					
					otherBrowsers.Add(new KeyValuePair<string, string>(settings.getSetting(("other_browser"+i+"_name")),settings.getSetting(("other_browser"+i+"_path"))));
					otherBrowsersComboBox.Items.Add(settings.getSetting(("other_browser"+i+"_name")));					
				}
				
				otherBrowserRadioButton.Enabled=true;
				otherBrowsersComboBox.Enabled=true;
				
				if(settings.settingExists("other_browser_defaultindex"))
				{
					if(otherBrowsersComboBox.Items.Count>int.Parse(settings.getSetting("other_browser_defaultindex")))
					{
						otherBrowsersComboBox.SelectedIndex=int.Parse(settings.getSetting("other_browser_defaultindex"));
					}
				}
			}
			
			
			if(settings.settingExists("putty_path"))
			{
				Putty_Path_textbox.Text=settings.getSetting("putty_path");
			}
			if(settings.settingExists("winscp_path"))
			{
				WinSCP_Path_textbox.Text=settings.getSetting("winscp_path");
			}
			if(settings.settingExists("vnc_path"))
			{
				VNC__Path_textbox.Text=settings.getSetting("vnc_path");
			}
			if(settings.settingExists("staf_path"))
			{
				StafpathTextBox.Text=settings.getSetting("staf_path");
			}
			if(settings.settingExists("jmeter_path"))
			{
				JMeterPathTextBox.Text=settings.getSetting("jmeter_path");
			}
			if(settings.settingExists("default_storeId"))
			{
				//WC_StoreID_TextBox.Text=settings.getSetting("default_storeId");
				string storeIdsFromSettings=settings.getSetting("default_storeId").Trim(' ','\t');
				
				if(storeIdsFromSettings.Equals("")||(!storeIdsFromSettings.Contains(",")))
				{
					WC_StoreID_ComboBox.Items.Clear();
					WC_StoreID_ComboBox.Items.Add("10152");
				}
				else
				{
					string []storeIds=storeIdsFromSettings.Split(',');
					
					WC_StoreID_ComboBox.Items.Clear();
					
					foreach(string storeId in storeIds)
					{
						if(!storeId.Trim(' ','\t').Equals(""))
							WC_StoreID_ComboBox.Items.Add(storeId.Trim(' ','\t'));
					}
				}
			}
			if(settings.settingExists("default_catalogId"))
			{
				string catalogIdsFromSettings=settings.getSetting("default_catalogId").Trim(' ','\t');
				
				if(catalogIdsFromSettings.Equals("")||(!catalogIdsFromSettings.Contains(",")))
				{
					CatalogIDComboBox.Items.Clear();
					WC_StoreID_ComboBox.Items.Add("");
				}
				else
				{
					string []catalogIds=catalogIdsFromSettings.Split(',');
					
					CatalogIDComboBox.Items.Clear();
					
					foreach(string catalogId in catalogIds)
					{
						if(!catalogId.Trim(' ','\t').Equals(""))
							CatalogIDComboBox.Items.Add(catalogId.Trim(' ','\t'));
					}
				}
			}
			if(settings.settingExists("default_storeName"))
			{
				string storeNamesFromSettings=settings.getSetting("default_storeName").Trim(' ','\t');
				
				if(string.IsNullOrEmpty(storeNamesFromSettings))
				{
					StoreName_ComboBox.Items.Clear();
					WC_StoreID_ComboBox.Items.Add("Madisons");
				}
				else if(!storeNamesFromSettings.Contains(","))
				{
					StoreName_ComboBox.Items.Clear();
					WC_StoreID_ComboBox.Items.Add(storeNamesFromSettings);
				}
				else
				{
					string []storeNames=storeNamesFromSettings.Split(',');
					
					StoreName_ComboBox.Items.Clear();
					
					foreach(string storeName in storeNames)
					{
						if(!storeName.Trim(' ','\t').Equals(""))
							StoreName_ComboBox.Items.Add(storeName.Trim(' ','\t'));
					}
				}
			}
			if(settings.settingExists("default_UserCredentials"))
			{
				string storeNamesFromSettings=settings.getSetting("default_UserCredentials").Trim(' ','\t');
				
				if(string.IsNullOrEmpty(storeNamesFromSettings))
				{
					StoreName_ComboBox.Items.Clear();
					WC_StoreID_ComboBox.Items.Add("Madisons");
				}
				else if(!storeNamesFromSettings.Contains(","))
				{
					StoreName_ComboBox.Items.Clear();
					WC_StoreID_ComboBox.Items.Add(storeNamesFromSettings);
				}
				else
				{
					string []storeNames=storeNamesFromSettings.Split(',');
					
					StoreName_ComboBox.Items.Clear();
					
					foreach(string storeName in storeNames)
					{
						if(!storeName.Trim(' ','\t').Equals(""))
							StoreName_ComboBox.Items.Add(storeName.Trim(' ','\t'));
					}
				}
			}
			if(settings.settingExists("default_AppServer_Port"))
			{
				string appServerPortsFromSettings=settings.getSetting("default_AppServer_Port").Trim(' ','\t');
			
				AppServer_Port_ComboBox.Items.Clear();					
				
				if(string.IsNullOrEmpty(appServerPortsFromSettings))
				{					
					AppServer_Port_ComboBox.Items.Add("7001");
				}
				else if(!appServerPortsFromSettings.Contains(","))
				{
					AppServer_Port_ComboBox.Items.Add(appServerPortsFromSettings);
				}			
				else
				{
					string []appServerPorts=appServerPortsFromSettings.Split(',');
										
					foreach(string appServerPort in appServerPorts)
					{
						if(!appServerPort.Trim(' ','\t').Equals(""))
							AppServer_Port_ComboBox.Items.Add(appServerPort.Trim(' ','\t'));
					}
				}
				
				if(AppServer_Port_ComboBox.Items.Count>0)
					AppServer_Port_ComboBox.SelectedIndex=0;
			}
			/*if(settings.settingExists("default_AppServer_Port"))
			{
				AppServer_Port_ComboBox.Text=settings.getSetting("default_AppServer_Port");
			}*/
			if(settings.settingExists("TesterBuddy_DefaultURL"))
			{
				Default_URL_TextBox.Text=settings.getSetting("TesterBuddy_DefaultURL");
			}
			if(settings.settingExists("TesterBuddy_Logs_Path"))
			{
				LogsPathTextBox.Text=settings.getSetting("TesterBuddy_Logs_Path");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Path"))
			{
				ScreenShotDirectory.Text=settings.getSetting("TesterBuddy_ScreenShots_Path");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Prefix"))
			{
				ScreenShotPrefixTextBox.Text=settings.getSetting("TesterBuddy_ScreenShots_Prefix");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_X"))
			{
				ScreenShot_x1.Text=settings.getSetting("TesterBuddy_ScreenShots_X");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Y"))
			{
				ScreenShot_y1.Text=settings.getSetting("TesterBuddy_ScreenShots_Y");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Length"))
			{
				ScreenShot_Length.Text=settings.getSetting("TesterBuddy_ScreenShots_Length");
			}
			if(settings.settingExists("TesterBuddy_ScreenShots_Width"))
			{
				ScreenShot_Width.Text=settings.getSetting("TesterBuddy_ScreenShots_Width");
			}
			if(settings.settingExists("System_hosts_file_path"))
			{
				hostsFile=settings.getSetting("System_hosts_file_path");
			}
			if(settings.settingExists("TesterBuddy_Links_AdditonalHosts"))
			{
				additionalHosts=new List<string>(settings.getSetting("TesterBuddy_Links_AdditonalHosts").Split('|'));
				
				foreach(string host in additionalHosts)
				{
					AddHostToComboBox(host);
				}
			}
			if(settings.settingExists("Selected_Host"))
			{
				HostName2TextBox.Text=settings.getSetting("Selected_Host");
				AddHostToComboBox(HostName2TextBox.Text);
			}
			if(settings.settingExists("defaulHostUserName"))
			{
				HostUserNameTextBox.Text=settings.getSetting("defaulHostUserName");
			}
			if(settings.settingExists("defaultHostPassword"))
			{
				HostPasswordTextBox.Text=settings.getSetting("defaultHostPassword");
			}
			if(settings.settingExists("api_directory"))
			{
				APIDirectory=settings.getSetting("api_directory");
				
				if(Directory.Exists(APIDirectory))
				{				
					APIRunner_APINamesComboBox.Items.Clear();
					
					string []apiFiles=Directory.GetFiles(APIDirectory,"*.xml");
					string xmlfilename;
					string toAddApi="";
					
					foreach(string apiFile in apiFiles)
					{
						//APIRunner_APINamesComboBox.Items.Add(apiFile.Substring(apiFile.LastIndexOf("\\")+1,apiFile.ToLower().IndexOf(".xml")-4));
						xmlfilename=apiFile.Substring(apiFile.LastIndexOf("\\")+1);
						xmlfilename=xmlfilename.Substring(0,xmlfilename.ToLower().IndexOf(".xml"));
						
						if(xmlfilename.EndsWith("_input"))
						{
							toAddApi=xmlfilename.Substring(0,xmlfilename.IndexOf("_input"));
						}
						else if(xmlfilename.EndsWith("_template"))
						{
							toAddApi=xmlfilename.Substring(0,xmlfilename.IndexOf("_template"));
						}
						else
						{
							toAddApi=xmlfilename;
						}
						APIRunner_APINamesComboBox.Items.Add(toAddApi);
					}
				}				
			}
		}
		
		
		Settings GatherSettings()
		{
			Settings nsettings=new Settings();
					
			nsettings.AddSetting("ie_path",IEPathTextBox.Text);
			nsettings.AddSetting("firefox_path",FireFoxPathTextBox.Text);
			nsettings.AddSetting("putty_path",Putty_Path_textbox.Text);
			nsettings.AddSetting("winscp_path",WinSCP_Path_textbox.Text);
			nsettings.AddSetting("vnc_path",VNC__Path_textbox.Text);
			nsettings.AddSetting("staf_path",StafpathTextBox.Text);
			nsettings.AddSetting("jmeter_path",JMeterPathTextBox.Text);
			nsettings.AddSetting("defaulHostUserName",HostUserNameTextBox.Text);
			nsettings.AddSetting("defaultHostPassword",HostPasswordTextBox.Text);
			
			string default_storeIds="";
			foreach(string s in WC_StoreID_ComboBox.Items)
			{
				default_storeIds=default_storeIds+s+",";
			}
			default_storeIds.TrimEnd(' ');
			
			nsettings.AddSetting("default_storeId",default_storeIds);
			
			
			string default_catalogIds="";
			foreach(string s in CatalogIDComboBox.Items)
			{
				default_catalogIds=default_catalogIds+s+",";
			}
			default_catalogIds.TrimEnd(' ');
			
			nsettings.AddSetting("default_catalogId",default_catalogIds);
			
			
			string default_storeNames="";
			foreach(string s in StoreName_ComboBox.Items)
			{
				default_storeNames=default_storeNames+s+",";
			}
			default_storeNames.TrimEnd(' ');
			
			nsettings.AddSetting("default_storeName",default_storeNames);
			
			
			string default_AppServer_Ports="";
			foreach(string s in AppServer_Port_ComboBox.Items)
			{
				default_AppServer_Ports=default_AppServer_Ports+s+",";
			}
			default_AppServer_Ports.TrimEnd(' ');
			nsettings.AddSetting("default_AppServer_Port",default_AppServer_Ports);
			
			
			nsettings.AddSetting("default_AppServer_Port",AppServer_Port_ComboBox.Text);
			nsettings.AddSetting("TesterBuddy_DefaultURL",Default_URL_TextBox.Text);
			nsettings.AddSetting("TesterBuddy_Logs_Path",LogsPathTextBox.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_Path",ScreenShotDirectory.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_Prefix",ScreenShotPrefixTextBox.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_X",ScreenShot_x1.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_Y",ScreenShot_y1.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_Length",ScreenShot_Length.Text);
			nsettings.AddSetting("TesterBuddy_ScreenShots_Width",ScreenShot_Width.Text);
			nsettings.AddSetting("System_hosts_file_path",hostsFile);
			
			string TesterBuddy_Links_AdditonalHostss="";
			
			if((additionalHosts!=null)&&(additionalHosts.Count>0))
			{
				foreach(string s in additionalHosts)
				{
					TesterBuddy_Links_AdditonalHostss=TesterBuddy_Links_AdditonalHostss+s+"|";
				}
				TesterBuddy_Links_AdditonalHostss.TrimEnd(' ');
				
				nsettings.AddSetting("TesterBuddy_Links_AdditonalHosts",TesterBuddy_Links_AdditonalHostss);
			}
				
			nsettings.AddSetting("Selected_Host",selectedhost);					
			return nsettings;
		}
		
		void BuildAdditionalHostsSettings()
		{
			List<string> additonalHostsInSettings=new List<string>();;
			
			if(settings.settingExists("TesterBuddy_Links_AdditonalHosts"))
			{
				additonalHostsInSettings=new List<string>(settings.getSetting("TesterBuddy_Links_AdditonalHosts").Split('|'));
			}
			
			if(additionalHosts.Count>0)
			{
				if(!settings.settingExists("TesterBuddy_Links_AdditonalHosts"))
				{
					settings.AddSetting("TesterBuddy_Links_AdditonalHosts");
				}
				   
				foreach(string ahost in additionalHosts)
				{
					if(!additonalHostsInSettings.Contains(ahost))
					{
						additonalHostsInSettings.Add(ahost);
					}
				}
				
				string []settingArrayFinal=new string[additonalHostsInSettings.Count];
				
				additonalHostsInSettings.CopyTo(settingArrayFinal);
				settings.setSetting("TesterBuddy_Links_AdditonalHosts",string.Join("|",settingArrayFinal));
			}
			
			//Selected Host setting is also handled here
			if(!settings.settingExists("Selected_Host"))
			{
				settings.AddSetting("Selected_Host");
			}
			settings.setSetting("Selected_Host",selectedhost);
			
			settings.SaveSettingsToXMLFile(SettingsFileName);
		}
		
		void AddHostToolStripMenuItemClick(object sender, EventArgs e)
		{
			Button1Click(sender,e);
		}
		
		void AddHostToComboBox(string host)
		{
			if(!HostNameComboBox.Items.Contains(host))
			{
					HostNameComboBox.Items.Add(host);
			}
		}
		
		//The OK|ADD button in the ADD HOST tab.
		void Button1Click(object sender, EventArgs e)
		{
			ASCIIEncoding ae=new ASCIIEncoding();
			IPRecord hi;
			
			if((textBox2.Text.Length>3)||(textBox3.Text.Length>3)
			   ||(textBox4.Text.Length>3)||(textBox5.Text.Length>3)
			   ||(int.Parse(textBox2.Text)>255)||(int.Parse(textBox3.Text)>255)
			   ||(int.Parse(textBox4.Text)>255)||(int.Parse(textBox5.Text)>255)
			   ||(int.Parse(textBox2.Text)<0)||(int.Parse(textBox3.Text)<0)
			   ||(int.Parse(textBox4.Text)<0)||(int.Parse(textBox5.Text)<0))
			{
				MessageBox.Show("Please enter a valid IP.","Wrong User Input!!!");
				return;
			}					
			
			hi=new IPRecord(textBox2.Text+"."+textBox3.Text+"."+textBox4.Text+"."+textBox5.Text,HostNameTextBox.Text,textBox6.Text);
			
			if(!string.IsNullOrEmpty(CommentsTextBox.Text))
			{
				hi.AddComments(CommentsTextBox.Text);
			}
			
			try
			{
				IPRecord.AddRecords(hi,hostsFile);
				//MessageBox.Show("The host information was successfully added.","Result-OK");
				
				ipl=IPRecord.GetRecords(hostsFile);
				//listBox1.Items.Clear();
				comboBox1.Items.Clear();
				
				foreach(IPRecord ipr in ipl)		
				{
					//listBox1.Items.Add(ipr.hostname);
					comboBox1.Items.Add(ipr.hostname);
					AddHostToComboBox(ipr.hostname);
				}
			}
			catch(Exception exp)
			{
				MessageBox.Show("Exception occured:"+exp.Message,"Exception!!!");
			}
			RefreshHostButtonClick(sender,e);
			
			MessageBox.Show("The host was added to host file",":)");
		}		
		
		private void StartInIE(String url)
		{
			Process a=new Process();
			a.StartInfo.FileName=IEPathTextBox.Text;
			a.StartInfo.Arguments=url;
			a.Start();
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			if(YantraVersion9Type.Checked)
			{
				StartInIE("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/smcfs/console/home.detail");
			}
			else
			{
				StartInIE("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/yantra/console/login.jsp");
			}
		}
		
		void Button16Click(object sender, EventArgs e)
		{					
			UrlHit("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/sbc/sbc/launch.jsp");
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			if(RunTimeRadioButton.Checked)
				StartInIE("https://"+HostNameTextBox.Text+":8002/adminconsole");
			else 
				StartInIE("https://"+HostNameTextBox.Text+":8002/webapp/wcs/admin/servlet/ToolsLogon?XMLFile=adminconsole.AdminConsoleLogon");
		}
		
		void Button18Click(object sender, EventArgs e)
		{
			if(WebSphereCheckBox.Checked)
			{
				StartInIE("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/ibm/console");
			}
			else if(WebLogicCheckBox.Checked)
			{
				StartInIE("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/console");
			}
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			if(RunTimeRadioButton.Checked)
				StartInIE("https://"+HostNameTextBox.Text+":8004/orgadminconsole");
			else
				StartInIE("https://"+HostNameTextBox.Text+"8004/webapp/wcs/orgadmin/servlet/ToolsLogon?XMLFile=buyerconsole.BuyAdminConsoleLogon");
		}
		
		void Button21Click(object sender, EventArgs e)
		{				
			if(YantraVersion9Type.Checked)
			{
				UrlHit("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/smcfs/yfshttpapi/yantrahttpapitester.jsp");
			}
			else
			{
				UrlHit("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/yantra/yfshttpapi/yantrahttpapitester.jsp");
			}
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			UrlHit("http://cinnamon.torolab.ibm.com/wcschema/initNew.do?dbtype=db2&dbname=trident&release=Trident");
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			string urlstring;
			string store_id, catalog_id;
			
			if(WC_StoreID_ComboBox.SelectedIndex!=-1)
				store_id=(string)WC_StoreID_ComboBox.Items[WC_StoreID_ComboBox.SelectedIndex];
			else if(!string.IsNullOrEmpty(WC_StoreID_ComboBox.Text))
				store_id=WC_StoreID_ComboBox.Text;
			else
				store_id=(string)WC_StoreID_ComboBox.Items[0];
			
			if(CatalogIDComboBox.SelectedIndex!=-1)
				catalog_id=(string)CatalogIDComboBox.Items[CatalogIDComboBox.SelectedIndex];
			else if(CatalogIDComboBox.Text!=string.Empty)
				catalog_id=CatalogIDComboBox.Text;
			else
				catalog_id="";
			
			if((catalog_id!="<na>")&&(catalog_id!=""))
				urlstring="http://"+HostNameTextBox.Text+"/webapp/wcs/stores/servlet/StoreView?storeId="+store_id+"&catalogId="+catalog_id;
			else
				urlstring="http://"+HostNameTextBox.Text+"/webapp/wcs/stores/servlet/StoreView?storeId="+store_id;
			UrlHit(urlstring);
		}
		
		void Button20Click(object sender, EventArgs e)
		{
			UrlHit("http://artec.torolab.ibm.com/DefectWebSite/index.html");
		}
		
		void Button23Click(object sender, EventArgs e)
		{
			UrlHit("https://welcome.coremetrics.com/marketforce/Login?auth=2");
		}
		
		void Button24Click(object sender, EventArgs e)
		{
			Process cmd=new Process();
			cmd.StartInfo.FileName="mstsc.exe";
			
			if(HostSpecificCheckBox.Checked)
			{			
				cmd.StartInfo.Arguments="/v "+HostNameTextBox.Text+" -console";
			}
			
			cmd.Start();
		}
	
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			radioButton1.Text=radioButton1.Checked?("Open in browser."):("Open in TesterBuddy itself.");
		}
		
		//Telnet
		void Button27Click(object sender, EventArgs e)
		{
			Process cmd=new Process();
			cmd.StartInfo.FileName=Environment.SystemDirectory+"\\telnet.exe";
			
			if(HostSpecificCheckBox.Checked)
			{			
				cmd.StartInfo.Arguments=HostNameTextBox.Text;
			}
			
			cmd.Start();
		}
		
		void Button28Click(object sender, EventArgs e)
		{
			Process cmd=new Process();
			cmd.StartInfo.FileName="ping";
			cmd.StartInfo.Arguments=HostNameTextBox.Text;
			cmd.Start();
		}
		
		void Button30Click(object sender, EventArgs e)
		{
			UrlHit(Default_URL_TextBox.Text);
		}
		
		void LoadSettings(string filename)
		{
			string []setttingData=File.ReadAllLines("Settings.dat");
		}
		
		void AutoCorrectSettings()
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			ipl=IPRecord.GetRecords(hostsFile);
			TodayString=DateTime.Today.Date.Day.ToString()+"_"+DateTime.Today.Date.Month.ToString()+"_"+DateTime.Today.Date.Year.ToString();
			
			//TreeNode a=new TreeNode();
			
			foreach(IPRecord ipr in ipl)		
			{
				comboBox1.Items.Add(ipr.hostname);
				AddHostToComboBox(ipr.hostname);
			}

			LogFolders.Items.Clear();
			
			if(!Directory.Exists(LogsPathTextBox.Text))
				Directory.CreateDirectory(LogsPathTextBox.Text);
			
			string[] dirlist=Directory.GetDirectories(LogsPathTextBox.Text);
			
			foreach(string s in dirlist)
			{
				LogFolders.Items.Add(s.Remove(0,s.LastIndexOf("\\")+1));
			}
			
			if(!Directory.Exists(LogsPathTextBox.Text+TodayString))
			{
				Directory.CreateDirectory(LogsPathTextBox.Text+TodayString);
			}
			else
			{
				string[] filelist=Directory.GetFiles(LogsPathTextBox.Text+TodayString+"\\");
				
				foreach(string s in filelist)
					LogFiles.Items.Add(s.Remove(0,s.LastIndexOf("\\")+1));
			}
			ScreenShotDirectory.Text=LogsPathTextBox.Text+TodayString+"\\";
			
			/*
			//Directory for command templates.
			if(!Directory.Exists(CommandPathTextBox.Text))
				Directory.CreateDirectory(CommandPathTextBox.Text);
			else
			{
				cmdFiles=Directory.GetFiles(CommandPathTextBox.Text,"*.cmd");
				foreach(string fl in cmdFiles)
					CommandTreeView.Nodes.Add(fl);
			}
			*/
			tabControl1.SelectedIndex=2;
			
			//Code below gets the additional and selected hosts
		}
		
		void LoadIP(string ipstring)
		{
			string[] ipa=ipstring.Split('.');
			textBox2.Text=ipa[0];
			textBox3.Text=ipa[1];
			textBox4.Text=ipa[2];
			textBox5.Text=ipa[3];
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			HostName2TextBox.Text=comboBox1.Text;
			textBox6.Text=ipl[comboBox1.SelectedIndex].alias;
			CommentsTextBox.Text=ipl[comboBox1.SelectedIndex].comments;
			LoadIP(ipl[comboBox1.SelectedIndex].IP);
			InitSettings(false);
		}
		
		//VNC
		void Button29Click(object sender, EventArgs e)
		{
			Process cmd=new Process();
			cmd.StartInfo.FileName=VNC__Path_textbox.Text;
			
			if(HostSpecificCheckBox.Checked)
			{			
				cmd.StartInfo.Arguments=HostNameTextBox.Text;
			}
			
			cmd.Start();
		}
		
		//Putty
		void Button31Click(object sender, EventArgs e)
		{
			Process cmd=new Process();
			cmd.StartInfo.FileName=Putty_Path_textbox.Text;
			
			if(HostSpecificCheckBox.Checked)
			{
				if(AutoCredential_CheckBox.Checked)
				{
					cmd.StartInfo.Arguments= "-ssh -l "+HostUserNameTextBox.Text+" -pw "+HostPasswordTextBox.Text+" "+HostNameTextBox.Text;
				}
				else
				{
					cmd.StartInfo.Arguments="-ssh "+HostNameTextBox.Text;
				}
			}
			
			cmd.Start();
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Tester Buddy Sterling Version. This tool is used to help testers. Please contact manianvss@in.ibm.com for any enhancemetns/queries.","Information");
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
			Clipboard.SetImage(pictureBox1.Image);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int x,y,l,w;
			
			x=int.Parse(ScreenShot_x1.Text);
			y=int.Parse(ScreenShot_y1.Text);
			l=int.Parse(ScreenShot_Length.Text);
			w=int.Parse(ScreenShot_Width.Text);

            FormWindowState earlierState = this.WindowState;
			this.WindowState=FormWindowState.Minimized;	
			Thread.Sleep(500);
			Bitmap bm=CaptureScreen.GetDesktopImage(x,y,l,w);
			pictureBox1.Image=bm;//CaptureScreen.GetDesktopImage(0,0,300,200);
            this.WindowState = earlierState;
			
			if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
			
			Clipboard.SetImage(bm);
			//this.Show();			
			//Process.GetCurrentProcess();		
			//Control c =Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle);
			
		}
		
		//Screen shot receive utility.
		void Button4Click(object sender, EventArgs e)
		{
			//int length,width;
			//byte[] buff;
			//byte r,g,b,a;
			//int i,j;
			//NetworkStream ns;
			
			//try
			//{
				
				
		//		buff=new byte[4];
			//	buff[0]=3;
				
				//Protocol for screenshot
				//Send: [1 byte type=3 for screenshot][4 byte x][4 byte y][4 byte l][4 byte w]
				//Receive: [4 byte length][4 byte width] [3*length*width bytes of rgb data]
			
				//Image jpegimage=new Bitmap(ns);
				
				/*Bitmap bmp=new Bitmap(length,width,PixelFormat.Format32bppRgb);
				
				for(i=0;i<length;i++)
				{
					for(j=0;j<width;j++)
					{
						ns.Read(buff,0,1);
						r=buff[0];
						ns.Read(buff,0,1);
						g=buff[0];
						ns.Read(buff,0,1);
						b=buff[0];
						bmp.SetPixel(i,j,Color.FromArgb(r,g,b));
					}
				}
				*/
				//ns.Close();
				//tc.Close();
				//pictureBox1.Image=jpegimage;
			//}
			//catch(Exception exp)
			//{
			//	MessageBox.Show("Exception: "+exp.Message,"Grr!!!");
			//}
			
		}
		
		//winscp
		void Button5Click(object sender, EventArgs e)
		{
			/*Process cmd=new Process();
			cmd.StartInfo.FileName=WinSCP_Path_textbox.Text;
			
			if(HostSpecificCheckBox.Checked)
			{			
				cmd.StartInfo.Arguments=HostNameTextBox.Text;
			}
			
			
			cmd.Start();*/
			
			if(HostSpecificCheckBox.Checked)
			{
				if(AutoCredential_CheckBox.Checked)
				{
					Process.Start("sftp://"+HostUserNameTextBox.Text+":"+HostPasswordTextBox.Text+"@"+HostNameTextBox.Text);
				}
				else
				{
					Process.Start("sftp://"+HostNameTextBox.Text);
				}
			}
			else
			{
				Process.Start("sftp://");
			}
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			string urlstring=@"\\"+HostNameTextBox.Text+@"\";
			Process.Start(urlstring);
		}
		
		void ClipRingTreeViewKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control&&(e.KeyCode== Keys.V))
			{
				if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
			}
			
			if(e.Control&&(e.KeyCode== Keys.C))
			{
				if(ClipRingTreeView.SelectedNode != null)
				{
					if(ClipRingTreeView.SelectedNode.Text!=null)
						Clipboard.SetText(ClipRingTreeView.SelectedNode.Text);
				}
			}
			
			if(e.Control&&(e.KeyCode== Keys.O))
			{
				if(ClipRingTreeView.SelectedNode != null)
				{
					string[] lines= ClipRingTreeView.SelectedNode.Text.Split('\n');
					
					foreach(string s in lines)
					{
						ClipRingTreeView.SelectedNode.Nodes.Add(s);
					}
				}
			}
			
			if(e.Control&&(e.KeyCode== Keys.S))
			{
				if(ClipRingTreeView.SelectedNode != null)
				{
					ae=new ASCIIEncoding();
					saveFileDialog1.InitialDirectory=LogsPathTextBox.Text;
					saveFileDialog1.DefaultExt="txt";
					saveFileDialog1.ShowDialog();
					string fname=saveFileDialog1.FileName;
					FileStream fs=new FileStream(fname,FileMode.Create);
					fs.Write(ae.GetBytes(ClipRingTreeView.SelectedNode.Text),0,ae.GetByteCount(ClipRingTreeView.SelectedNode.Text));
					fs.Close();
				}
			}
			
			if(e.KeyCode==Keys.Delete)
			{
				if(ClipRingTreeView.SelectedNode != null)
				{
					ClipRingTreeView.Nodes.Remove(ClipRingTreeView.SelectedNode);
				}
			}
		}
		
		void ClipRingTreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
            //The following code copies the currently selected item in clipring to clipboard
            /*
			if(ClipRingTreeView.SelectedNode != null)
					Clipboard.SetText(ClipRingTreeView.SelectedNode.Text);
             */
		}
		
		string GetTimeStamp()
		{
			return DateTime.Now.Ticks.ToString();
		}
		
		void ScreenShotSaveButtonClick(object sender, EventArgs e)
		{
			if(pictureBox1.Image!=null)
			{
				pictureBox1.Image.Save(ScreenShotDirectory.Text+ScreenShotPrefixTextBox.Text+GetTimeStamp()+".jpg");
				previousScreenshotText=ScreenShotDirectory.Text+ScreenShotPrefixTextBox.Text+GetTimeStamp()+".jpg";
			}
			
			//ScreenShotCounter.Text=(int.Parse(ScreenShotCounter.Text)+1).ToString();			
		}

        void RefreshHosts()
        {
            ipl = IPRecord.GetRecords(hostsFile);

            comboBox1.Items.Clear();

            foreach (IPRecord ipr in ipl)
            {
                comboBox1.Items.Add(ipr.hostname);
                AddHostToComboBox(ipr.hostname);
            }
        }
		void RefreshHostButtonClick(object sender, EventArgs e)
		{
            RefreshHosts();
		}
		
		void ToOneLineButtonClick(object sender, EventArgs e)
		{
			ProcessTextRTB2.Text= ProcessTextRTB1.Text.Replace("\n"," ");
		}
		
		void OneWordPerLineButtonClick(object sender, EventArgs e)
		{
			//char[] sep={' ','\t'};
			//string[] words=ProcessTextRTB1.Text.Split(sep,2);
			string[] words=ProcessTextRTB1.Text.Split(' ');
			ProcessTextRTB2.Text="";
			foreach(string s in words)
				ProcessTextRTB2.Text=ProcessTextRTB2.Text+s+"\r\n";
		}
		
		
		void LogFoldersSelectedIndexChanged(object sender, EventArgs e)
		{
			if(LogFolders.SelectedIndex!=-1)
			{
				LogFiles.Items.Clear();
				string newpath=LogsPathTextBox.Text+(string)(LogFolders.Items[LogFolders.SelectedIndex]);
				string[] filelist=Directory.GetFiles(newpath);
				
				foreach(string s in filelist)
					LogFiles.Items.Add(s.Remove(0,s.LastIndexOf("\\")+1));
			}
		}
		
		void LogFilesMouseDoubleClick(object sender, MouseEventArgs e)
		{
			if((LogFiles.SelectedIndex!=-1)&&(LogFolders.SelectedIndex!=-1))
			{
				string processString=LogsPathTextBox.Text+(string)LogFolders.Items[LogFolders.SelectedIndex]+"\\"+(string)LogFiles.Items[LogFiles.SelectedIndex];
				Process.Start(processString);
			}
		}
		
		void LogFoldersMouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(LogFolders.SelectedIndex!=-1)
			{
				string processString=LogsPathTextBox.Text+(string)LogFolders.Items[LogFolders.SelectedIndex];
				Process.Start(processString);
			}
		}
		
		void NewTextLogButtonClick(object sender, EventArgs e)
		{
			if(LogFolders.SelectedIndex!=-1)
			{
				string processString=LogsPathTextBox.Text+(string)LogFolders.Items[LogFolders.SelectedIndex]+"\\new.log";
				Process a =new Process();
				a.StartInfo.FileName="notepad";
				a.StartInfo.Arguments=processString;
				a.Start();
			}
		}
		
		void CopyLogPathButtonClick(object sender, EventArgs e)
		{
			if((LogFiles.SelectedIndex!=-1)&&(LogFolders.SelectedIndex!=-1))
			{
				if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
				
				Clipboard.SetText(LogsPathTextBox.Text+(string)LogFolders.Items[LogFolders.SelectedIndex]+"\\"+(string)LogFiles.Items[LogFiles.SelectedIndex]);
			}
		}	
		
		void RefreshClick(object sender, EventArgs e)
		{
			
			ipl=IPRecord.GetRecords(hostsFile);
			String TodayString=DateTime.Today.Date.Day.ToString()+"_"+DateTime.Today.Date.Month.ToString()+"_"+DateTime.Today.Date.Year.ToString();
			
			LogFolders.Items.Clear();
			LogFiles.Items.Clear();
			
			string[] dirlist=Directory.GetDirectories(LogsPathTextBox.Text);
			
			foreach(string s in dirlist)
			{
				LogFolders.Items.Add(s.Remove(0,s.LastIndexOf("\\")+1));
			}
			
			if(!Directory.Exists(LogsPathTextBox.Text+TodayString))
			{
				Directory.CreateDirectory(LogsPathTextBox.Text+TodayString);
			}
			else
			{
				string[] filelist=Directory.GetFiles(LogsPathTextBox.Text+TodayString+"\\");
				
				foreach(string s in filelist)
					LogFiles.Items.Add(s.Remove(0,s.LastIndexOf("\\")+1));
			}
			ScreenShotDirectory.Text=LogsPathTextBox.Text+TodayString+"\\";
		}
		
		/*
		
		void Button32Click(object sender, EventArgs e)
		{
			LinksCollectionTreeView.Nodes.Clear();
			string baseWCSPath="WebSphere/CommerceServer70/bin/";
			string baseDemoBinPath="WebSphere/AppServer/profiles/demo/bin/";
			string baseLogsPath="WebSphere/AppServer/profiles/demo/logs/server1/";
			
			if(WindowsOSRadioButton.Checked)
			{
				LinksCollectionTreeView.Nodes.Add("startserver server1");
				LinksCollectionTreeView.Nodes.Add("stopserver server1 -username configadmin -password config1mgr");
			}
			
			if(XLinuxOSRadioButton.Checked||AIXOSRadioButton.Checked)
			{
				LinksCollectionTreeView.Nodes.Add("./startServer.sh server1");
				LinksCollectionTreeView.Nodes.Add("./stopServer.sh server1 -username configadmin -password config1mgr");
			}
			if(WindowsOSRadioButton.Checked)
			{
				LinksCollectionTreeView.Nodes.Add("c:/"+baseWCSPath);
				LinksCollectionTreeView.Nodes.Add("c:/"+baseDemoBinPath);
				LinksCollectionTreeView.Nodes.Add("c/"+baseLogsPath);	
			}
			if(XLinuxOSRadioButton.Checked)
			{
				LinksCollectionTreeView.Nodes.Add("/opt/"+baseWCSPath);
				LinksCollectionTreeView.Nodes.Add("/opt/"+baseDemoBinPath);
				LinksCollectionTreeView.Nodes.Add("/opt/"+baseLogsPath);	
			}
			if(AIXOSRadioButton.Checked)
			{
				LinksCollectionTreeView.Nodes.Add("/usr/"+baseWCSPath);
				LinksCollectionTreeView.Nodes.Add("/usr/"+baseDemoBinPath);
				LinksCollectionTreeView.Nodes.Add("/usr/"+baseLogsPath);	
			}
			
			ClipRingTreeView.Nodes.Add("Custom Links");
			for(int i=0;i<LinksCollectionTreeView.Nodes.Count;i++)
				ClipRingTreeView.Nodes[ClipRingTreeView.Nodes.Count-1].Nodes.Add(LinksCollectionTreeView.Nodes[i].Text);
		}
		*/
		
		
		void WorkspaceAdminConsoleLinkButtonClick(object sender, EventArgs e)
		{
			StartInIE("https://"+HostNameTextBox.Text+":8000/workspaceadmin");
		}
		
		
		void HttpsCheckButtonClick(object sender, EventArgs e)
		{
			UrlHit("https://"+HostNameTextBox.Text+":"+HttpsCheckPortTextBox.Text+"/");
		}
		
		void HttpCheckButtonClick(object sender, EventArgs e)
		{
			UrlHit("http://"+HostNameTextBox.Text+":"+HttpCheckPortTextBox.Text+"/");
		}
		
		void InfoCenterVisitButtonClick(object sender, EventArgs e)
		{
			UrlHit("https://ut-ilnx-r4.hursley.ibm.com/websphere/commerce/v7/help/index.jsp");
		}
		
		void UrlHit(string urlstring)
		{
			Process a;
			
			if(radioButton2.Checked)
			{
				a=new Process();
				a.StartInfo.FileName=FireFoxPathTextBox.Text;
				a.StartInfo.Arguments=urlstring;
				a.Start();
			}
			else if(radioButton1.Checked)
			{
				webBrowser1.Url=new Uri(urlstring);
				tabControl1.SelectTab(tabPage8);
			}
			else if(otherBrowsersComboBox.Enabled)
			{
				a=new Process();
				a.StartInfo.FileName=otherBrowsers[otherBrowsersComboBox.SelectedIndex!=-1?otherBrowsersComboBox.SelectedIndex:0].Value;
				a.StartInfo.Arguments=urlstring;
				a.Start();
			}
			else
			{
				StartInIE(urlstring);
			}
		}
		
		void LogFilesKeyDown(object sender, KeyEventArgs e)
		{
			Process a;
			
			if(e.Control&&(e.KeyCode== Keys.V))
			{
				if(Clipboard.ContainsFileDropList())
				{
					foreach(string s in Clipboard.GetFileDropList())
					{
						//Process.Start("xcopy "+s+LogsPathTextBox.Text);
						a=new Process();
						a.StartInfo.FileName="xcopy";
						a.StartInfo.Arguments=s+LogsPathTextBox.Text;
						a.Start();
						ClipRingTreeView.Nodes.Add(s);
					}
				}
			}
		}
		
		void FTPBrowserButtonClick(object sender, EventArgs e)
		{
			UrlHit("ftp://"+HostNameTextBox.Text);
		}
		
		void PictureBox1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(Clipboard.ContainsImage())
				pictureBox1.Image=Clipboard.GetImage();
		}
		
		void OpenHostFileClick(object sender, EventArgs e)
		{
			Process a=new Process();
			a.StartInfo.FileName=@"c:\windows\system32\notepad.exe";
			a.StartInfo.Arguments=hostsFile;
			a.Start();
		}
		
		//Helper functions to read and write bytes to stream.
		byte[] ReadLengthAndBytes(Stream s)
		{
			byte[] buff=new byte[4];
			s.Read(buff,0,4);
			int len=BitConverter.ToInt32(buff,0);
			
			buff=new byte[len];
			s.Read(buff,0,len);
			return buff;
		}
		
		void WriteLengthAndBytes(Stream s, int len,byte[] buff)
		{
			s.Write(BitConverter.GetBytes(len),0,4);
			s.Write(buff,0,len);
		}
		
		void SendMsgToStream(Stream s, string msg)
		{
			ASCIIEncoding ae=new ASCIIEncoding();
			WriteLengthAndBytes(s,(byte)ae.GetByteCount(msg),ae.GetBytes(msg));					
		}
		
		String GetMsgFromStream(Stream s)
		{
			ASCIIEncoding ae=new ASCIIEncoding();
			return ae.GetString(ReadLengthAndBytes(s));
		}
		
		void OpenTodayLogButtonClick(object sender, EventArgs e)
		{
			Process.Start(LogsPathTextBox.Text+"\\"+TodayString);
		}
		
		void AddPrefixButtonClick(object sender, EventArgs e)
		{
			string prefix=ProcessTextFixTextBox.Text;
			ProcessTextRTB2.Clear();
			string[] lines=ProcessTextRTB1.Text.Split('\n');
			foreach(string line in lines)
				ProcessTextRTB2.AppendText(prefix+line+'\n');
		}
		
		
		
		void MainFormKeyUp(object sender, KeyEventArgs e)
		{
			if(e.Control&&(e.KeyData==Keys.L))
			{
				tabControl1.SelectedTab=tabPage6;
			}
		}
		
		
		void LaunchStoreByNameClick(object sender, EventArgs e)
		{
			Process a=new Process();
			string urlstring, storeName;
			
			if(StoreName_ComboBox.SelectedIndex!=-1)
				storeName=(string)StoreName_ComboBox.Items[StoreName_ComboBox.SelectedIndex];
			else if(!string.IsNullOrEmpty(StoreName_ComboBox.Text))
				storeName=StoreName_ComboBox.Text;
			else
				storeName=(string)StoreName_ComboBox.Items[0];
			
			if(!SEOTypeUrlCheckBox.Checked)
			{
				urlstring="http://"+HostNameTextBox.Text+"/webapp/wcs/stores/servlet/"+storeName+"/index.jsp";
			}
			else
			{
				urlstring="http://"+HostNameTextBox.Text+"/webapp/wcs/stores/servlet/en/"+storeName;
			}
			
			/*if(radioButton2.Checked)
			{
				a.StartInfo.FileName=textBox28.Text;
				a.StartInfo.Arguments=urlstring;
				a.Start();
			}
			else if(radioButton1.Checked)
			{
				webBrowser1.Url=new Uri(urlstring);
				tabControl1.SelectTab(tabPage8);
			}
			else
			{
				Process.Start(urlstring);
			}*/
			UrlHit(urlstring);
		}
		/*
		void AddParamButtonClick(object sender, EventArgs e)
		{
			if(CommandBuilderTreeView.SelectedNode==null)
			{
				CommandBuilderTreeView.Nodes.Add(ParameterTextBox.Text);
			}
			else
			{
				CommandBuilderTreeView.SelectedNode.Nodes.Add(ParameterTextBox.Text);
			}
		}
		
		void RefreshCommandFilesButtonClick(object sender, EventArgs e)
		{
			cmdFiles=Directory.GetFiles(CommandPathTextBox.Text,"*.cmd");
			
			CommandTreeView.Nodes.Clear();
			
			foreach(string fl in cmdFiles)
				CommandTreeView.Nodes.Add(fl);
		}
		
		void CommandTreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
			if(CommandTreeView.SelectedNode!=null)
				currentCommand=CommandBuilder.Load(CommandTreeView.SelectedNode.Text);
		}
		
		void CommandBuilderTreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
			if(CommandBuilderTreeView.SelectedNode!=null)
				ParameterTextBox.Text=CommandBuilderTreeView.SelectedNode.Text;
		}
		
		void SaveCommandButtonClick(object sender, EventArgs e)
		{
			currentCommand.Clear();
			foreach(TreeNode tn in CommandTreeView.Nodes)
				currentCommand.Add(tn.Text);
			CommandBuilder.SaveFile(CommandPathTextBox.Text+"\\"+CommandNameTextBox.Text,currentCommand);
			RefreshCommandFilesButtonClick(sender,e);
		}
		
		void CommandBuilderTreeViewKeyDown(object sender, KeyEventArgs e)
		{
			if(CommandBuilderTreeView.SelectedNode!=null)
			{	
				if(e.Control&&(e.KeyData==Keys.Delete))
					CommandBuilderTreeView.Nodes.Clear();
				if(e.KeyData==Keys.Delete)
					CommandBuilderTreeView.Nodes.Remove(CommandBuilderTreeView.SelectedNode);
			}
		}
		*/
		
		//Copies Ip from split textbox
		public string getIPFromUI()
		{
			if((textBox2.Text.Length>3)||(textBox3.Text.Length>3)
			   ||(textBox4.Text.Length>3)||(textBox5.Text.Length>3)
			   ||(int.Parse(textBox2.Text)>255)||(int.Parse(textBox3.Text)>255)
			   ||(int.Parse(textBox4.Text)>255)||(int.Parse(textBox5.Text)>255)
			   ||(int.Parse(textBox2.Text)<0)||(int.Parse(textBox3.Text)<0)
			   ||(int.Parse(textBox4.Text)<0)||(int.Parse(textBox5.Text)<0))
			{
				MessageBox.Show("Please enter a valid IP.","Wrong User Input!!!");
				return "";
			}		
			
			return textBox2.Text+"."+textBox3.Text+"."+textBox4.Text+"."+textBox5.Text;
		}
		
		//Copy IP Button on Clicked function below.
		void CopyIPButtonClick(object sender, EventArgs e)
		{
			if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
			Clipboard.SetText(getIPFromUI());//ipl[comboBox1.SelectedIndex].IP);
		}
		
		//Copy Details Button on Clicked function below.
		void Button33Click(object sender, EventArgs e)
		{
			if(comboBox1.SelectedIndex==-1)
			{
				if(comboBox1.Items.Count>0)
					comboBox1.SelectedIndex=0;
			}
			
			if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
			Clipboard.SetText(ipl[comboBox1.SelectedIndex].IP+" "+ipl[comboBox1.SelectedIndex].hostname+" "+ipl[comboBox1.SelectedIndex].alias);
		}
		
		void PasteIPButtonClick(object sender, EventArgs e)
		{
			String ip=Clipboard.GetText();
			String[] ipstr=ip.Split('.');
			textBox2.Text=ipstr[0];
			textBox3.Text=ipstr[1];
			textBox4.Text=ipstr[2];
			textBox5.Text=ipstr[3];
		}
		/*
		
		void AutoTimeShiftButtonClick(object sender, EventArgs e)
		{
			if(!AutoTimeIncrementTimer.Enabled)
			{
				AutoTimeIncrementTimer.Enabled=true;
				AutoTimeIncrementTimer.Interval=(int)TimeToChangeTimeNumericUpDown.Value;
				AutoTimeIncrementTimer.Start();
				AutoTimeShiftButton.Text="Stop Time Shift";
				RestoreTime=DateTime.Now;
			}
			else
			{
				AutoTimeIncrementTimer.Enabled=false;
				AutoTimeIncrementTimer.Interval=(int)TimeToChangeTimeNumericUpDown.Value;
				AutoTimeIncrementTimer.Stop();
				AutoTimeShiftButton.Text="Stop Time Shift";
			}
		}
		
		
		void ResetTimeButtonClick(object sender, EventArgs e)
		{
			if(RestoreTime!=null)
			{
				
			}
		}
		*/
		
		void SSHConnectionTrial()
		{
			/*Routrek.SSHC.SSHConnectionParameter param= new Routrek.SSHC.SSHConnectionParameter();
			//Routrek.SSHC.i
			param.UserName="root";
			param.Password="diet4coke";
			Routrek.SSHC.ISSHConnectionEventReceiver icer;
			Routrek.SSHC.SSHConnection ssc;//=new Routrek.SSHC.SSHConnection(param,icer);
			*/
			//ssh2
			
		}
		
		void OpenScreenshotButtonClick(object sender, EventArgs e)
		{
			string[] files=Directory.GetFiles(ScreenShotDirectory.Text,"*.jpg");
			
			if(files.Length>0)
				Process.Start(files[0]);
		}
		
		/*
		void HostTeamSessionButtonClick(object sender, EventArgs e)
		{
			teamSocket=new GSocket(int.Parse(HostTeamSessionPortTextBox.Text));
			
			if(!teamSocket.hostConnection())
			{
				MessageBox.Show("Could not host team session.","Connection Error!!!");
				teamSocket=null;
				return;
			}
			TeamSessionTimer.Start();
		}
		
		void TeamSessionTimerTick(object sender, EventArgs e)
		{
			if(teamSocket.isConnected()&&teamSocket.isMessageAvailable())
			{
				GMessage gm;
				
				while(!string.IsNullOrEmpty((gm=teamSocket.GetNextMessage()).getString()))
				{
					TeamTreeView.Nodes.Add(gm.getString());
				}				
			}
		}
		
		*/
		//IPconfig click
		void Button87Click(object sender, EventArgs e)
		{
			Process cmd=new Process();
			//StreamWriter sw=cmd.StandardInput;
			cmd.StartInfo.FileName="c:\\windows\\system32\\ipconfig.exe";
			cmd.StartInfo.Arguments=" /all";
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.UseShellExecute=false;
			cmd.Start();
			StreamReader sr=cmd.StandardOutput;
			string []output =(sr.ReadToEnd()).Split('\n');
			string fetchIP="";
			string tempIp;
			
			//Get IP with prefix in settings only.
			foreach(string s in output)
			{
				if(s.Contains("IP") && s.Contains("Address") && (!s.Contains("IPv6")))
				{
					foreach(string ipPre in ipPrefix)
					{
						if(s.Contains(ipPre))
						{
							tempIp=s.Substring(s.IndexOf(ipPre));
							
							//Regex.IsMatch(
							for(int i=0;i<tempIp.Length;i++)
							{
								if(!(char.IsDigit(tempIp[i])||(tempIp[i]=='.')))
								{
									tempIp=tempIp.Substring(0,i);
									break;
								}
							}
							
							fetchIP=fetchIP+tempIp+" ";
							
							if(Clipboard.ContainsText())
							{
								ClipRingTreeView.Nodes.Add(Clipboard.GetText());
							}
							
							if(Clipboard.ContainsText())
								ClipRingTreeView.Nodes.Add(Clipboard.GetText());
							Clipboard.SetText(tempIp);
						}
					}
				}
			}
			
			MessageBox.Show("Ipconfig Info:\r"+fetchIP,"Ipconfig");
		}
		
		void GetParamFromURLButtonClick(object sender, EventArgs e)
		{
			string pstr=ProcessTextRTB1.Text.Substring(ProcessTextRTB1.Text.IndexOf('?')+1);
			ProcessTextRTB2.Clear();
			string[] lines=pstr.Split('&');
			foreach(string line in lines)
				ProcessTextRTB2.AppendText(line+'\n');
		}
		
		void CacheMonitorButtonClick(object sender, EventArgs e)
		{
			UrlHit("http://"+HostNameTextBox.Text+"/cachemonitor/");
		}
		
		void StartJmeterButtonClick(object sender, EventArgs e)
		{
			Process cmd=new Process();
			cmd.StartInfo.FileName=JMeterPathTextBox.Text;
			cmd.StartInfo.WorkingDirectory=JMeterPathTextBox.Text.Substring(0,JMeterPathTextBox.Text.LastIndexOf("\\")+1);
			cmd.Start();
		}
		
		void HostName2TextBoxTextChanged(object sender, EventArgs e)
		{
			//hostnameacsc.Add(HostName2TextBox.Text);
			
			HostNameTextBox.Text=HostName2TextBox.Text;
			selectedhost=HostNameTextBox.Text;
			
			
			//WCLinks_HostnameTextBox.Text=HostNameTextBox.Text;
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			//HostName2TextBox.Text=HostNameTextBox.Text;

			this.Text=HostNameTextBox.Text; //"TesterBuddy 2.1.4 Beta"+": "+
			selectedhost=HostNameTextBox.Text;
			
			if(comboBox1.Items.Contains(HostNameTextBox.Text))
			{
				int index=comboBox1.Items.IndexOf(HostNameTextBox.Text);
				
				textBox6.Text=ipl[index].alias;
				CommentsTextBox.Text=ipl[index].comments;
				LoadIP(ipl[index].IP);
			}
		}
		
		/*
		void GetSampleFileButtonClick(object sender, EventArgs e)
		{
			String basefilename;
			int baseindex;
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=StafpathTextBox.Text;
			
			if(ArguementTextBox.Text.Contains("\\"))
			{
				baseindex=ArguementTextBox.Text.LastIndexOf('\\');			
			}
			else if(ArguementTextBox.Text.Contains("/"))
			{
				baseindex=ArguementTextBox.Text.LastIndexOf('/');
			}
			else
				baseindex=0;
			basefilename=ArguementTextBox.Text.Substring(baseindex,ArguementTextBox.Text.Length-baseindex);
			
			saveFileDialog1.InitialDirectory=LogsPathTextBox.Text+"\\"+TodayString+"\\";
			saveFileDialog1.ShowDialog();
			
			cmd.StartInfo.Arguments=HostNameTextBox.Text +" FS COPY FILE "+ArguementTextBox.Text+" TOFILE "+saveFileDialog1.FileName;
			cmd.Start();
		}
		
		void SendFileButtonClick(object sender, EventArgs e)
		{
			String basefilename;
			int baseindex;
			string hostname=Environment.MachineName.ToLower();
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=StafpathTextBox.Text;
			
			if(ArguementTextBox.Text.Contains("\\"))
			{
				baseindex=ArguementTextBox.Text.LastIndexOf('\\');			
			}
			else if(ArguementTextBox.Text.Contains("/"))
			{
				baseindex=ArguementTextBox.Text.LastIndexOf('/');
			}
			else
				baseindex=0;
			basefilename=ArguementTextBox.Text.Substring(baseindex,ArguementTextBox.Text.Length-baseindex);
			
			openFileDialog1.InitialDirectory="c:\\";
			openFileDialog1.ShowDialog();
			
			cmd.StartInfo.Arguments= hostname + " FS COPY FILE "+openFileDialog1.FileName+" TOFILE "+ArguementTextBox.Text+" TOMACHINE "+HostNameTextBox.Text;
			cmd.Start();
		}
		
		void ExecuteRemoteProcessButtonClick(object sender, EventArgs e)
		{
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=StafpathTextBox.Text;			
			cmd.StartInfo.Arguments= HostNameTextBox.Text +" PROCESS START COMMAND "+RemoteCommandTextBox.Text;

			if(ArguementTextBox.Text.CompareTo("")!=0)
				cmd.StartInfo.Arguments= cmd.StartInfo.Arguments +" PARMS \""+ArguementTextBox.Text+"\"";
			
			cmd.StartInfo.Arguments=cmd.StartInfo.Arguments+" wait";
			
			cmd.Start();
		}
		*/
		void RunStafProcess(string host, string app, string args, string workingdir, bool waitforcompletion)
		{
			Process cmd=new Process();
			
			cmd.StartInfo.FileName=StafpathTextBox.Text;			
			cmd.StartInfo.Arguments= host +" PROCESS START COMMAND "+app;

			if(args!=null)
				cmd.StartInfo.Arguments=args;
			
			if(waitforcompletion)
				cmd.StartInfo.Arguments=cmd.StartInfo.Arguments+" wait";
			
			cmd.Start();
		}
		
		void PasteHostDetailsButtonClick(object sender, EventArgs e)
		{
			string []words=Clipboard.GetText().Split(' ','\t');
			string ip;
			string[] ipstr;
			bool hostnamedone=false;
			bool oneAliasDone=false;
			
			textBox6.Clear();
			
			foreach(string word in words)
			{
				if(char.IsDigit(word[0]))
				{
					ip=word;
					ipstr=ip.Split('.');
					textBox2.Text=ipstr[0];
					textBox3.Text=ipstr[1];
					textBox4.Text=ipstr[2];
					textBox5.Text=ipstr[3];
				}
				else
				{
					if(!hostnamedone)
					{
						hostnamedone=true;
						HostNameTextBox.Text=word;
					}
					else
					{
						if(word.Length==1)
						{
							if(char.IsWhiteSpace(word[0]))
								continue;
						}
						
						word.TrimStart('\t',' ');
						word.TrimEnd('\t',' ');
						
						if(oneAliasDone)
						{
							textBox6.Text=textBox6.Text+"\t";
						}
						textBox6.Text=textBox6.Text+word;
						
						oneAliasDone=true;
					}
				}
			}
		}
		
		void HostNameComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			if(HostNameComboBox.SelectedIndex==-1)
				return;
			HostName2TextBox.Text=(string)HostNameComboBox.Items[HostNameComboBox.SelectedIndex];
			
			if(!HostNameComboBox.Items.Contains(HostName2TextBox.Text)&&(HostName2TextBox.Text!=null)&&(HostName2TextBox.Text.CompareTo("")!=0))
			{
				HostNameComboBox.Items.Add(HostName2TextBox.Text);
				
				if(!additionalHosts.Contains(HostName2TextBox.Text))
				{
					additionalHosts.Add(HostName2TextBox.Text);
				}
			}
			HostName2TextBox.Text=(string)HostNameComboBox.Items[HostNameComboBox.SelectedIndex];
			selectedhost=HostName2TextBox.Text;
			InitSettings(false);
			
			//Sync wc links hostname combobox
			//WCLinks_HostnameComboBox.Items.Clear();
			//foreach(string s in HostNameComboBox.Items)
			//{
			//	WCLinks_HostnameComboBox.Items.Add(s);
			//}
			//WCLinks_HostnameComboBox.SelectedIndex=HostNameComboBox.SelectedIndex;
		}
		
		void ProcessText_RemoveLeadingWhiteSpacesClick(object sender, EventArgs e)
		{
			string []lines=ProcessTextRTB1.Text.Split('\n');
			ProcessTextRTB2.Clear();
			
			foreach(string line in lines)
			{
				ProcessTextRTB2.AppendText(line.TrimStart(' ', '\t')+"\n");
			}
		}
		/*
		void Remote_OS_WindowsCheckedChanged(object sender, EventArgs e)
		{
			if(WindowsOSRadioButton.Checked)
			{
				WinSCP_Button.Enabled=false;
				Putty_button.Enabled=false;
			}
		}
		*/
		void ProcessText_ToJavaStringButtonClick(object sender, EventArgs e)
		{
			//char[] sep={' ','\t'};
			//string[] words=ProcessTextRTB1.Text.Split(sep,2);
			String temp="\""+ProcessTextRTB1.Text.Replace("\"","\\\"");
			temp=temp.Replace("\n\n","\n\\n");
			temp=temp.Replace("\n","\\n\"\n+\"");
			temp=temp.Replace("\t","\\t");
			temp=temp.Replace("\r","\\r");
			ProcessTextRTB2.Text=temp+"\"";
		}
		
		void CopyScreenshotButtonClick(object sender, EventArgs e)
		{
			/*int x,y,l,w;
			
			x=int.Parse(ScreenShot_x1.Text);
			y=int.Parse(ScreenShot_y1.Text);
			l=int.Parse(ScreenShot_Length.Text);
			w=int.Parse(ScreenShot_Width.Text);
			
			this.WindowState=FormWindowState.Minimized;	
			Thread.Sleep(500);
			Bitmap bm=CaptureScreen.GetDesktopImage(x,y,l,w);
			pictureBox1.Image=bm;//CaptureScreen.GetDesktopImage(0,0,300,200);
			this.WindowState=FormWindowState.Normal;
			*/
			if(pictureBox1.Image!=null)
			{
				if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
				Clipboard.SetImage(pictureBox1.Image);
			}
			//this.Show();			
			//Process.GetCurrentProcess();		
			//Control c =Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle);		
		}
		
		void PasteScreenshotButtonClick(object sender, EventArgs e)
		{
			if(Clipboard.ContainsImage())
			{
				pictureBox1.Image=Clipboard.GetImage();
			}
		}
		
		void Remote_OS_CheckedChanged(object sender, EventArgs e)
		{
			if(Remote_OS_XLinux.Checked)
			{
				HostUserNameTextBox.Text="root";
				HostPasswordTextBox.Text="diet4coke";
			}
			else if(Remote_OS_AIX.Checked)
			{
				HostUserNameTextBox.Text="root";
				HostPasswordTextBox.Text="passw0rd";
			}
			else
			{
				HostUserNameTextBox.Text="administrator";
				HostPasswordTextBox.Text="diet4coke@";
			}
		}
		
		void RefreshConfigButtonClick(object sender, EventArgs e)
		{
			if(HostSpecificSettingsCheckBox.Checked && File.Exists(selectedhost+".TB.Settings.xml"))
			{				
				//Settings s2=new Settings("TesterBuddy.settings");
				
				WC_StoreID_ComboBox.SelectedIndex=-1;
				StoreName_ComboBox.SelectedIndex=-1;
				CatalogIDComboBox.SelectedIndex=-1;
				
				settings=new Settings(selectedhost+".TB.Settings.xml");
				InitSettings(false);			
			}
			else if(File.Exists("TesterBuddy.settings.xml"))
			{
				//Settings s2=new Settings("TesterBuddy.settings");
				
				WC_StoreID_ComboBox.SelectedIndex=-1;
				StoreName_ComboBox.SelectedIndex=-1;
				CatalogIDComboBox.SelectedIndex=-1;
				
				//s2.getSettingsFromXML("TesterBuddy.settings.xml");
				settings=new Settings("TesterBuddy.settings.xml");
				InitSettings(false);				
				
			}
			else
			{
				settings.SaveSettingsToXMLFile(SettingsFileName);
			}
		}
		
		bool ValidateAppPath(string appPath)
		{
			return File.Exists(appPath);
		}
		
		void ValidateConfigButtonClick(object sender, EventArgs e)
		{
			if(!ValidateAppPath(IEPathTextBox.Text))
			{
				MessageBox.Show("IE path incorrect","Settings Error!");
			}
			
			if(!ValidateAppPath(FireFoxPathTextBox.Text))
			{
				MessageBox.Show("FireFox path incorrect","Settings Error!");
			}
			
			if(!ValidateAppPath(Putty_Path_textbox.Text))
			{
				MessageBox.Show("Putty path incorrect","Settings Error!");
			}
			
			if(!ValidateAppPath(WinSCP_Path_textbox.Text))
			{
				MessageBox.Show("WinSCP path incorrect","Settings Error!");
			}
			
			if(!ValidateAppPath(VNC__Path_textbox.Text))
			{
				MessageBox.Show("VNC path incorrect","Settings Error!");
			}
			
			if(!ValidateAppPath(StafpathTextBox.Text))
			{
				MessageBox.Show("STAF path incorrect","Settings Error!");
			}
			
			if(!ValidateAppPath(JMeterPathTextBox.Text))
			{
				MessageBox.Show("JMeter path incorrect","Settings Error!");
			}
		}
		
		void SortHostsButtonClick(object sender, EventArgs e)
		{
			IPRecord.SortRecordsBasedOnHostName(hostsFile);
			RefreshHostButtonClick(sender, e);
		}
		
		public List<string> GetIP()
		{
			
			Process cmd=new Process();
			//StreamWriter sw=cmd.StandardInput;
			cmd.StartInfo.FileName="c:\\windows\\system32\\ipconfig.exe";
			cmd.StartInfo.Arguments=" /all";
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.UseShellExecute=false;
			cmd.Start();
			StreamReader sr=cmd.StandardOutput;
			string []output =(sr.ReadToEnd()).Split('\n');
			string tempIp;
			List<string> iplist=new List<string>();
				
			foreach(string s in output)
			{
				if(s.Contains("IP") && s.Contains("Address") && (!s.Contains("IPv6")))
				{
					foreach(string ipPre in ipPrefix)
					{
						if(s.Contains(ipPre))
						{
							tempIp=s.Substring(s.IndexOf(ipPre));
							
							//Regex.IsMatch(
							for(int i=0;i<tempIp.Length;i++)
							{
								if(!(char.IsDigit(tempIp[i])||(tempIp[i]=='.')))
								{
									tempIp=tempIp.Substring(0,i);
									break;
								}
							}
							
							iplist.Add(tempIp);
						}
					}
				}
			}
			
			return iplist;
		}
		
		void FixHostsButtonClick(object sender, EventArgs e)
		{
			string hostname=Environment.MachineName.ToLower();
			string domainname=System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
		
			//MessageBox.Show("Hostname: "+hostname+"."+domainname,"Info");
			List<string> iplist=GetIP();
			
			if(iplist.Count<1)
			{
				MessageBox.Show("Please provide appropriate \"IP Prefix\" in the settings file or check the network setting for system IP.\n", "Error with IP resolution");
			}
			
			IPRecord.AddRecords(new IPRecord("127.0.0.1","localhost.localdomain","localhost"),hostsFile);
			IPRecord.AddRecords(new IPRecord(iplist[0],hostname+"."+domainname,hostname),hostsFile);
			RefreshHostButtonClick(sender, e);
		}
		
		void AutoHostAddButtonClick(object sender, EventArgs e)
		{
			string HostToAdd=HostNameTextBox.Text;
			
			Process cmd=new Process();
			//StreamWriter sw=cmd.StandardInput;
			cmd.StartInfo.FileName="c:\\windows\\system32\\ping.exe";
			cmd.StartInfo.Arguments=" "+HostToAdd;
			cmd.StartInfo.RedirectStandardOutput=true;
			cmd.StartInfo.UseShellExecute=false;
			cmd.Start();
			StreamReader sr=cmd.StandardOutput;
			string []output =(sr.ReadToEnd()).Split('\n');
			 
			IPRecord.DeleteHostByName(HostToAdd,hostsFile);
			
			int startIndex=output[1].IndexOf('[')+1, endIndex=output[1].IndexOf(']')-startIndex;
			
			string ip=output[1].Substring(startIndex,endIndex);
			
			IPRecord newRecord=new IPRecord(ip,HostToAdd,"");
			
			IPRecord.AddRecords(newRecord,hostsFile);
			
			RefreshHostButtonClick(sender,e);
		}
		
		void DeleteHostButtonClick(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(HostNameTextBox.Text))
			{
				IPRecord.DeleteHostByName(HostNameTextBox.Text,hostsFile);
                RefreshHosts();
			}
		}
		
		/*
		void GetWCSInfoButtonClick(object sender, EventArgs e)
		{
			DBInvoker dbi=new DBInvoker(HostNameTextBox.Text);
			
			dbi.GetCatalogs();
		}*/
		
		void AdditionalHostAddButtonClick(object sender, EventArgs e)
		{
			selectedhost=HostName2TextBox.Text;
			AddHostToComboBox(selectedhost);
			additionalHosts.Add(selectedhost);
			BuildAdditionalHostsSettings();
			InitSettings(false);
		}
		
		void SaveConfigurationButtonClick(object sender, EventArgs e)
		{			
			//TO:DO Gather settings before saving
			//
			if(settings==null)
			{
				settings=new Settings();
			}
				
			Settings nsettings=new Settings(settings);
			
			nsettings=GatherSettings();
			
			if(HostSpecificSettingsCheckBox.Checked)
			{
				nsettings.RemoveSetting("Selected_Host");
				nsettings.SaveSettingsToXMLFile(selectedhost+".TB.Settings.xml");
			}
			else
			{
				nsettings.SaveSettingsToXMLFile(SettingsFileName);
			}
									
			settings=nsettings;
		}

        private void FormatXMLButton_Click(object sender, EventArgs e)
        {
            ProcessTextRTB2.Text = XMLFormatter.IndentXML(ProcessTextRTB1.Text);
        }

        private void AddSuffixButton_Click(object sender, EventArgs e)
        {
            string suffix = ProcessTextFixTextBox.Text;
            ProcessTextRTB2.Clear();
            string[] lines = ProcessTextRTB1.Text.Split('\n');
            foreach (string line in lines)
                ProcessTextRTB2.AppendText(line + suffix + '\n');
        }       
		
		void RemoveNullParamXMLButtonClick(object sender, EventArgs e)
		{
			ProcessTextRTB2.Text=XMLFormatter.RemoveNullValueParameters(ProcessTextRTB1.Text);
		}			
		
		void IncrementValuesButtonClick(object sender, EventArgs e)
		{
			string initialText=ProcessTextRTB1.Text;
			string criteria=ProcessTextFixTextBox.Text;
			//string finalText;
			
			//If no criteria mentioned, increment all numbers
			if(string.IsNullOrEmpty(criteria))
			{
					
			}
			
			//Else increment postfixed numbers eg Order1 will become Order2
			else
			{
			
			}
		}		
		
		void AppServer_Port_ComboBoxTextChanged(object sender, EventArgs e)
		{
			/*if(AppServer_Port_ComboBox.SelectedIndex!=-1)
			{
				AppServer_Port_ComboBox.Items[AppServer_Port_ComboBox.SelectedIndex]=AppServer_Port_ComboBox.Text;
			}*/
		}
		
		void EndTeamSessionButtonClick(object sender, EventArgs e)
		{
			teamSocket.resolvePendingActions();
			teamSocket.DisconnectGame();
			teamSocket=null;
			TeamSessionTimer.Stop();
		}
		
		void SaveConfigAsButtonClick(object sender, EventArgs e)
		{
			saveFileDialog1.DefaultExt=".xml";
			saveFileDialog1.ShowDialog();			
			
			SettingsFileName=saveFileDialog1.FileName;
			bool temp=HostSpecificCheckBox.Checked;
			HostSpecificCheckBox.Checked=false;
			SaveConfigurationButtonClick(sender,e);
			HostSpecificCheckBox.Checked=temp;
			
		}
		
		void LoadConfigButtonClick(object sender, EventArgs e)
		{
			openFileDialog1.CheckFileExists=true;
			openFileDialog1.DefaultExt=".xml";
			openFileDialog1.ShowDialog();
			
			SettingsFileName=openFileDialog1.FileName;
			InitSettings(true);
		}
		
		/*
		void TeamTreeViewKeyDown(object sender, KeyEventArgs e)
		{
			if(!teamSocket.isConnected())
			{
				return;
			}
			
			if(e.Control&&(e.KeyCode== Keys.V))
			{
				if(Clipboard.ContainsText())
				{
					TeamTreeView.Nodes.Add(Clipboard.GetText());
					teamSocket.SendMessage(new GMessage(Clipboard.GetText()));
				}
			}
		}
		
		void JoinTeamSessionButtonClick(object sender, EventArgs e)
		{
			if((teamSocket!=null) && teamSocket.isConnected())
			{
				teamSocket.DisconnectGame();
			}
			
			teamSocket=new GSocket(int.Parse(HostTeamSessionPortTextBox.Text));
						
			if(!teamSocket.attemptConnection(TeamSyncHostName.Text))
			{
				MessageBox.Show("Could not connect to the team sync server.","Error!!!");
				teamSocket=null;
			}
		}
		*/
		void HTTPPostParamListBoxKeyDown(object sender, KeyEventArgs e)
		{
			//param=value pairs demilted by either & or whitespace
			if(e.Control&&(e.KeyCode== Keys.V))
			{
				if(Clipboard.ContainsText())
				{
					string paramListToAdd=Clipboard.GetText();
					//List<KeyValuePair<string,string>> paramToAdd=new List<KeyValuePair<string, string>>();
					string []paramPairs;
					
					if(!paramListToAdd.Contains("="))
					{
						//Should contain atleast one parameter
						return;						
					}
					
					paramPairs=paramListToAdd.Split('&');// split only based on &, ' ','\n','\t');
					
					foreach(string parampair in paramPairs)
					{
						
						if(!parampair.StartsWith("=") && parampair.Contains("=") )// Don't chekc multiple equals&& (parampair.IndexOf("=")==parampair.LastIndexOf("=")))
						{
							AddParamValueToHTTPPostList(parampair.Substring(0,parampair.IndexOf("=")),parampair.Substring(parampair.IndexOf("=")+1));
						}				
					}
				}
			}
		}
		
		public void AddParamValueToHTTPPostList(string param, string value)
		{
			//Update if existing parameter.
			for(int i=0;i<HTTPPostParamListBox.Items.Count;i++)
			{
				if (((string)HTTPPostParamListBox.Items[i]).StartsWith(param+"="))
				{
					HTTPPostParamListBox.Items[i]=param+"="+value;
					return;
				}
			}
			
			HTTPPostParamListBox.Items.Add(param+"="+value);
		}
		
		void HTTPPostAddParamToListButtonClick(object sender, EventArgs e)
		{			
			if(!string.IsNullOrEmpty(HTTPPostParameterTextBox.Text))
			{							
				//Add new parameter if not found for updation.
				AddParamValueToHTTPPostList(HTTPPostParameterTextBox.Text,HTTPPostValueTextBox.Text);
			}
		}
		
		void HTTPPostRunButtonClick(object sender, EventArgs e)
		{
			List<KeyValuePair<string,string>> postParams=new List<KeyValuePair<string, string>>();
			
			foreach(string param in HTTPPostParamListBox.Items)
			{
				postParams.Add(new KeyValuePair<string, string> (param.Substring(0,param.IndexOf("=")),param.Substring(param.IndexOf("=")+1)));
			}
			string webresponse=WebRequestHelper.GetURLResultPOST(HTTPPostURLTextBox.Text,postParams);
			
			HTTPPostResultBrowser.DocumentText="<html><body> webresponse </body> </html>";
		}
		
		void HTTPPost_DeleteParamButtonClick(object sender, EventArgs e)
		{
			if(HTTPPostParamListBox.SelectedIndex!=-1)
			{
				HTTPPostParamListBox.Items.Remove(HTTPPostParamListBox.SelectedItem);
			}
		}
		
		void HTTPPost_ClearParamButtonClick(object sender, EventArgs e)
		{
			HTTPPostParamListBox.Items.Clear();
		}
		
		void HTTPPostParamListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			string paramvalue;
			
			if(HTTPPostParamListBox.SelectedIndex!=-1)
			{				
				paramvalue=(string)HTTPPostParamListBox.SelectedItem;
				HTTPPostParameterTextBox.Text=paramvalue.Substring(0,paramvalue.IndexOf("="));
				HTTPPostValueTextBox.Text=paramvalue.Substring(paramvalue.IndexOf("=")+1);
			}
		}
		
		void OpenConfigXMLButtonClick(object sender, EventArgs e)
		{
			if(HostSpecificSettingsCheckBox.Checked && File.Exists(selectedhost+".TB.Settings.xml"))
			{
				Process.Start(selectedhost+".TB.Settings.xml");
			}
			else
			{
				Process.Start(SettingsFileName);
			}
		}
		
		
		private void IncrementCounters(ref string instring, ref string counterString)
		{
			ASCIIEncoding ae=new ASCIIEncoding();
			
			string []counters=counterString.Split('\n');
			
			for(int i=0;i<counters.Length;i++)
			{
				counters[i]=counters[i].Trim('\r',' ','\t');
				
				//Debug Messages
				//ProcessTextRTB2.AppendText("\n Counters["+i+"]="+counters[i]);
			}
			
			string []replaceCounters=new string[counters.Length];
			
			for(int i=0;i<counters.Length;i++)
			{
				replaceCounters[i]=counters[i];
			}
			
			//bool carry;
			char tempChar,tempchar2;
			
			for(int i=0;i<replaceCounters.Length;i++)
			{
				for(int j=replaceCounters[i].Length-1;j>=0;j--)
				{
					tempChar=replaceCounters[i][j];
					tempchar2=replaceCounters[i][j];
					tempchar2++;
					
					string str1=replaceCounters[i].Substring(0,j);
					string str2;
					
					if(char.IsDigit(replaceCounters[i][j]))
					{						
						tempchar2=(char)( ((tempChar+1)-'0')%10+'0');
						str2=tempchar2.ToString();
					}
					else if(char.IsLetter(replaceCounters[i][j]))
					{
						char addchar;
						
						if(char.IsLower(replaceCounters[i][j]))
						{
							addchar='a';
						}
						else
						{
							addchar='A';
						}
						
						tempchar2=(char)( ((tempChar+1)-addchar)%26+addchar);
						str2=tempchar2.ToString();
					}
					else
					{
						//Don't have to increment on non alpha numerical character.
						//str2=((char)(replaceCounters[i][j]+1)).ToString();
						continue;
					}
					string str3=replaceCounters[i].Substring(j+1,replaceCounters[i].Length-j-1);
				    
					//Debug messages
					//ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(0,j)="+str1);
					//ProcessTextRTB2.AppendText("\n ((char)replaceCounters[i][j]+1)).ToString()="+str2);
					//ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(j+1,replaceCounters[i].Length-j-1)="+str3);
					
					replaceCounters[i]=str1+str2+str3;
					
					//Debug messages
					//ProcessTextRTB2.AppendText("\n replaceCounters["+i+"]="+replaceCounters[i]);
					
					if(tempChar<tempchar2)
					{
						break;
					}
				}				
			}
			
			for(int i=0;i<counters.Length;i++)
			{
				if(string.IsNullOrEmpty(replaceCounters[i]))
				{
					continue;
				}
				
				instring=instring.Replace(counters[i],replaceCounters[i]);
				counterString=counterString.Replace(counters[i],replaceCounters[i]);
			}
		}
		
		void ProcessText_IncrementCountersButtonClick(object sender, EventArgs e)
		{
			ASCIIEncoding ae=new ASCIIEncoding();
			
			string []counters=ProcessTextRTB2.Text.Split('\n');
			
			for(int i=0;i<counters.Length;i++)
			{
				counters[i]=counters[i].Trim('\r',' ','\t');
				
				//Debug Messages
				//ProcessTextRTB2.AppendText("\n Counters["+i+"]="+counters[i]);
			}
			
			string []replaceCounters=new string[counters.Length];
			
			for(int i=0;i<counters.Length;i++)
			{
				replaceCounters[i]=counters[i];
			}
			
			//bool carry;
			char tempChar,tempchar2;
			
			for(int i=0;i<replaceCounters.Length;i++)
			{
				for(int j=replaceCounters[i].Length-1;j>=0;j--)
				{
					tempChar=replaceCounters[i][j];
					tempchar2=replaceCounters[i][j];
					tempchar2++;
					
					string str1=replaceCounters[i].Substring(0,j);
					string str2;
					
					if(char.IsDigit(replaceCounters[i][j]))
					{						
						tempchar2=(char)( ((tempChar+1)-'0')%10+'0');
						str2=tempchar2.ToString();
					}
					else if(char.IsLetter(replaceCounters[i][j]))
					{
						char addchar;
						
						if(char.IsLower(replaceCounters[i][j]))
						{
							addchar='a';
						}
						else
						{
							addchar='A';
						}
						
						tempchar2=(char)( ((tempChar+1)-addchar)%26+addchar);
						str2=tempchar2.ToString();
					}
					else
					{
						//Don't have to increment on non alpha numerical character.
						//str2=((char)(replaceCounters[i][j]+1)).ToString();
						continue;
					}
					string str3=replaceCounters[i].Substring(j+1,replaceCounters[i].Length-j-1);
				    
					//Debug messages
					//ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(0,j)="+str1);
					//ProcessTextRTB2.AppendText("\n ((char)replaceCounters[i][j]+1)).ToString()="+str2);
					//ProcessTextRTB2.AppendText("\n replaceCounters[i].Substring(j+1,replaceCounters[i].Length-j-1)="+str3);
					
					replaceCounters[i]=str1+str2+str3;
					
					//Debug messages
					//ProcessTextRTB2.AppendText("\n replaceCounters["+i+"]="+replaceCounters[i]);
					
					if(tempChar<tempchar2)
					{
						break;
					}
				}				
			}
			
			for(int i=0;i<counters.Length;i++)
			{
				if(string.IsNullOrEmpty(replaceCounters[i]))
				{
					continue;
				}
				
				ProcessTextRTB1.Text=ProcessTextRTB1.Text.Replace(counters[i],replaceCounters[i]);
				ProcessTextRTB2.Text=ProcessTextRTB2.Text.Replace(counters[i],replaceCounters[i]);
			}
		}
		
		void WCLink_AcceleratorButtonClick(object sender, EventArgs e)
		{
			if(RunTimeRadioButton.Checked)
				StartInIE("https://"+HostNameTextBox.Text+":8000/accelerator");
			else
				StartInIE("https://"+HostNameTextBox.Text+":8000/webapp/wcs/tools/servlet/ToolsLogon?XMLFile=common.mcLogon");
		}
		
		void WCLinks_CMCButtonClick(object sender, EventArgs e)
		{
			UrlHit("https://"+HostNameTextBox.Text+":8000/lobtools");
		}
		
		void WC_openinIERBCheckedChanged(object sender, EventArgs e)
		{
			radioButton3.Checked=true;
		}
		
		void WC_openinFFRBCheckedChanged(object sender, EventArgs e)
		{
			radioButton2.Checked=true;
		}
		
		void WC_openinTBRBCheckedChanged(object sender, EventArgs e)
		{
			radioButton1.Checked=true;
		}			
		
		public void ExtractArchivesInDirectory(string directory,int maxRecurse, bool recursive,bool delarchive)
		{
			string []archiveFiles=Directory.GetFiles(directory,"*.*ar");
			
			foreach(string archiveFile in archiveFiles)
			{
				//FileAttributes fileattr=File.GetAttributes(directory);
				
				//if((fileattr&FileAttributes.Archive)==FileAttributes.Archive)
				//{
				ExtractArchiveFile(archiveFile,false,maxRecurse-1,recursive,delarchive);
				//}
			}
		
			if((recursive)&&(maxRecurse>0))
			{
				string []directories=Directory.GetDirectories(directory);
			
				foreach(string dir in directories)
				{				
					ExtractArchivesInDirectory(dir,maxRecurse-1,recursive,delarchive);
				}
			}
		}
		
		public void ExtractArchiveFile(string file, bool firstcall, int maxRecurse, bool recursive,bool delarchive)
		{				
			if(!firstcall)
			{
				string pfile=file;
				
				pfile=file.Substring(ExtractArchivePathTextBox.Text.Substring(0,ExtractArchivePathTextBox.Text.LastIndexOf('.')).Length);
				
				//If there is atleast one remove term associated then check for file name term remove and exception files.
				if(ExtractArchiveRemoveTermsComboBox.Items.Count>0)
				{			
					bool fileExcluded=false;
					
					//Check if file falls in one of the exception category only if there is atleast one exception
					if(ExtractArchiveExcludedFilesComboBox.Items.Count>0)
					{
						foreach(string s in ExtractArchiveExcludedFilesComboBox.Items)
						{					
							if(Regex.IsMatch(pfile,s))
							{
								fileExcluded=true;
								break;
							}
						}
					}
					
					//Check for remove terms and remove them from file/folder names.
					if(!fileExcluded)
					{
						foreach(string s in ExtractArchiveRemoveTermsComboBox.Items)
						{					
							if(pfile.Contains(s))
							{
								pfile=pfile.Replace(s,"");
							}
						}	
					}
				}
				pfile=ExtractArchivePathTextBox.Text.Substring(0,ExtractArchivePathTextBox.Text.LastIndexOf('.'))+"\\"+pfile;
				File.Move(file,pfile);
			
				file=pfile;
			}				
			
			string dirname=file.Substring(0,file.LastIndexOf('.'));
			
			if(dirname.Length>250)
			{
				return;
			}
									
			Process p=new Process();
			p.StartInfo.FileName=ZipToolPathTextBox.Text;
			p.StartInfo.Arguments="x "+file+" -o"+dirname;
		
			p.Start();			
			p.WaitForExit();
			      
			if(recursive)
			{
				if(maxRecurse>0)	
				{
					ExtractArchivesInDirectory(file.Substring(0,file.LastIndexOf('.')),maxRecurse-1,recursive,recursive);
				}	
				else
				{
					string []allfiles=Directory.GetFiles(file.Substring(0,file.LastIndexOf('.')));
						//Directory.GetFiles(file.Substring(0,file.LastIndexOf('.')), "*.*")
            //.Where(s => s.EndsWith(".jar") || s.EndsWith(".ear") || s.EndsWith(".war") || s.EndsWith(".sar") || s.EndsWith(".zip") || s.EndsWith(".7z") || s.EndsWith(".rar") || s.EndsWith(".tar")  || s.EndsWith(".gzip") || s.EndsWith(".gz")   );
						//Directory.GetFiles(file.Substring(0,file.LastIndexOf('.')),"*.*ar");
					List<string> dirFiles=new List<string>();
						
					foreach(string s in allfiles)
					{
						if(s.ToLower().EndsWith(".jar") || s.ToLower().EndsWith(".rar")  
						   || s.ToLower().EndsWith(".tar") || s.ToLower().EndsWith(".ear") 
						   || s.ToLower().EndsWith(".war") || s.ToLower().EndsWith(".sar") 
						   || s.ToLower().EndsWith(".zip") || s.ToLower().EndsWith(".7z")
						   || s.ToLower().EndsWith(".gzip") || s.ToLower().EndsWith(".bz")
						   || s.ToLower().EndsWith(".gz") 						   
						  )
						{
							dirFiles.Add(s);
						}
					}
					
					foreach(string dirFile in dirFiles)
					{
						string pdirFile=dirFile;
						
						foreach(string s in ExtractArchiveRemoveTermsComboBox.Items)
						{
							if(pdirFile.Contains(s))
							{
								pdirFile=pdirFile.Replace(s,"");
							}
						}
						File.Move(dirFile,pdirFile);
					}
				}
			}
				
			if(delarchive)
			{
				File.Delete(file);
			}
		}
		
		void BrowseArchiveFileButtonClick(object sender, EventArgs e)
		{
			//ExtractArchivePathTextBox.
			//openFileDialog1.Filter="";
			openFileDialog1.ShowDialog();
			
			string archiveFileName=openFileDialog1.FileName;
			ExtractArchivePathTextBox.Text=archiveFileName;
			
			//ExtractArchiveFile(archiveFileName,RecursivelyExtractArchiveCheckBox.Checked);
		}
		
		void ArchiveExtractButtonClick(object sender, EventArgs e)
		{	
			int maxrecurse=0;
			
			if(!string.IsNullOrEmpty(ExtractArchiveMaxNestingTextBox.Text))
			{
				maxrecurse=int.Parse(ExtractArchiveMaxNestingTextBox.Text);
			}
			
			ExtractArchiveFile(ExtractArchivePathTextBox.Text,true,maxrecurse,RecursivelyExtractArchiveCheckBox.Checked,false);
		}
		
		void ExtractArchiveAddRemoveTermButtonClick(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(ExtractArchiveAddRemoveTermTextBox.Text)&& !ExtractArchiveRemoveTermsComboBox.Items.Contains(ExtractArchiveAddRemoveTermTextBox.Text))
			{
				ExtractArchiveRemoveTermsComboBox.Items.Add(ExtractArchiveAddRemoveTermTextBox.Text);
			}
		}
				
		void ExtractArchiveRemoveTermsComboBoxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Delete)
			{
				if(ExtractArchiveRemoveTermsComboBox.SelectedIndex!=-1)
				{
					ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(ExtractArchiveRemoveTermsComboBox.SelectedIndex);
				}
				else if(ExtractArchiveRemoveTermsComboBox.Items.Count>0)
				{
					ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(0);
				}
				//else do nothing
			}
		}
		
		void LaunchSFSButtonClick(object sender, EventArgs e)
		{
			UrlHit("http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/sfs/sfs/launch.jsp");
		}
		
		void UserCredentialsComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void HTTPPost_PasteParamDataButtonClick(object sender, EventArgs e)
		{					
			string []lines=Clipboard.GetText().Split('\r','\n');
			
			foreach(string line in lines)
			{
				if(line.Trim('\r','\n').Length>0)
				{
					AddParamValueToHTTPPostList(line.Substring(0,line.IndexOf('=')), line.Substring(line.IndexOf('=')+1));
				}
			}												
		}
		
		public List<KeyValuePair<string,string>> GetAPIRunnerParms(string apiname, string user, string pass, string inputxml, string template)
		{
			List<KeyValuePair<string, string >>  postParamList=new List<KeyValuePair<string, string>>();
			
			postParamList.Add(new KeyValuePair<string,string> ("YFSEnvironment.progId","TB"));
			postParamList.Add(new KeyValuePair<string,string> ("InteropApiName",apiname));
			postParamList.Add(new KeyValuePair<string,string> ("ApiName",apiname));
			postParamList.Add(new KeyValuePair<string,string> ("IsFlow","N"));
			postParamList.Add(new KeyValuePair<string,string> ("ServiceName",""));
			postParamList.Add(new KeyValuePair<string,string> ("YFSEnvironment.userId",user));
			postParamList.Add(new KeyValuePair<string,string> ("YFSEnvironment.password",pass));
			postParamList.Add(new KeyValuePair<string,string> ("YFSEnvironment.version",""));
			postParamList.Add(new KeyValuePair<string,string> ("YFSEnvironment.locale",""));
			postParamList.Add(new KeyValuePair<string,string> ("InteropApiData",inputxml));
			postParamList.Add(new KeyValuePair<string,string> ("TemplateData",template));
			
			return postParamList;
		}
		
		public void RunConfiguredAPI()
		{
			List<KeyValuePair<string, string >>  postParamList= new List<KeyValuePair<string, string>>();
			string urlstring="";
			
			if(YantraVersion9Type.Checked)
			{
				urlstring= "http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/smcfs/interop/InteropHttpServlet";
			}
			else
			{
				urlstring = "http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/yantra/interop/InteropHttpServlet";
			}
			
			//Run once unconditional			
			postParamList=GetAPIRunnerParms(APIRunner_APINamesComboBox.Text,APIRunner_UserNameTextBox.Text,
				                                                                    APIRunner_PasswordTextbox.Text,APIRunner_APIXMLTextBox.Text,
				                                                                   APIRunner_APITemplateTextBox.Text);
			//APIRunner_ResultsTextBox.Text=WebRequestHelper.GetURLResultPOST(urlstring,postParamList);
			APIRunner_ResultsTreeView.Nodes.Add(WebRequestHelper.GetURLResultPOST(urlstring,postParamList));
			Thread.CurrentThread.Abort();
		}
		
		void APIRunner_RunAPIButtonClick(object sender, EventArgs e)
		{
			List<KeyValuePair<string, string >>  postParamList=GetAPIRunnerParms(APIRunner_APINamesComboBox.Text,APIRunner_UserNameTextBox.Text,
			                                                                    APIRunner_PasswordTextbox.Text,APIRunner_APIXMLTextBox.Text,
			                                                                   APIRunner_APITemplateTextBox.Text);
			string changedxml, changedcriteria, templatexml, changedcriteria2;
			
			string urlstring="";
			int maxThread=1;
			
			if(YantraVersion9Type.Checked)
			{
				urlstring= "http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/smcfs/interop/InteropHttpServlet";
			}
			else
			{
				urlstring = "http://"+HostNameTextBox.Text+":"+AppServer_Port_ComboBox.Text+"/yantra/interop/InteropHttpServlet";
			}
			
			try
			{
				//Clear results before running 	
				//APIRunner_ResultsTreeView.Nodes.Clear();
				
				//Run once unconditional			
				postParamList=GetAPIRunnerParms(APIRunner_APINamesComboBox.Text,APIRunner_UserNameTextBox.Text,
				                                                                    APIRunner_PasswordTextbox.Text,APIRunner_APIXMLTextBox.Text,
				                                                                   APIRunner_APITemplateTextBox.Text);
				//APIRunner_ResultsTextBox.Text=WebRequestHelper.GetURLResultPOST(urlstring,postParamList);
				//APIRunner_ResultsTreeView.Nodes.Add(WebRequestHelper.GetURLResultPOST(urlstring,postParamList));
				APIRunner_ResultsTreeView.Nodes.Add(DateTime.Now.ToShortDateString()+" "+APIRunner_APINamesComboBox.Text+": First Run:");
				APIRunner_ResultsTreeView.SelectedNode=APIRunner_ResultsTreeView.Nodes[APIRunner_ResultsTreeView.Nodes.Count-1];
				APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Input:\n"+APIRunner_APIXMLTextBox.Text);
				APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Template:\n"+APIRunner_APITemplateTextBox.Text);
				APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Output:\n"+XMLFormatter.IndentXML(WebRequestHelper.GetURLResultPOST(urlstring,postParamList)));
							
				
				if(APIRunner_RepeatCountersCheckBox.Checked)
				{										
					//ud_CriteriaParams=api					
					APIRunner_ProgressBar.Minimum=0;				
					APIRunner_ProgressBar.Maximum=(int)APIRunner_IncrementCounter_N.Value;					
					APIRunner_ProgressBar.Value=0;
					APIRunner_ProgressBar.Step=1;
					
					if(API_RunnerThreadCountNumericUpDown.Value>1)
					{
						maxThread=(int)API_RunnerThreadCountNumericUpDown.Value;
						Thread []threads=new Thread[maxThread];
						
						for(int i=0;i<maxThread;i++)
						{
							threads[i]=new Thread(RunConfiguredAPI);
							threads[i].Start();
						}

						while(true)
						{
							bool running=false;
							
							for(int i=0;i<maxThread;i++)
							{
								if(threads[i].IsAlive)
								{
									running=true;
									break;
								}
							}
							
							if(!running)
							{
								break;
							}
							
							this.Refresh();
						}
					}
					
					else
					{
						for(int i=0;i<APIRunner_IncrementCounter_N.Value;i++)
						{					
							postParamList=GetAPIRunnerParms(APIRunner_APINamesComboBox.Text,APIRunner_UserNameTextBox.Text,
				                                                                    APIRunner_PasswordTextbox.Text,APIRunner_APIXMLTextBox.Text,
				                                                                   APIRunner_APITemplateTextBox.Text);
							//APIRunner_ResultsTextBox.Text=APIRunner_ResultsTextBox.Text+"\n"+WebRequestHelper.GetURLResultPOST(urlstring,postParamList);					
							APIRunner_ResultsTreeView.Nodes.Add(DateTime.Now.ToShortDateString()+" "+APIRunner_APINamesComboBox.Text+": Repeat ["+(i+1)+"]:");
							APIRunner_ResultsTreeView.SelectedNode=APIRunner_ResultsTreeView.Nodes[APIRunner_ResultsTreeView.Nodes.Count-1];
							APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Input:\n"+APIRunner_APIXMLTextBox.Text);
							APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Template:\n"+APIRunner_APITemplateTextBox.Text);
							APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Output:\n"+XMLFormatter.IndentXML(WebRequestHelper.GetURLResultPOST(urlstring,postParamList)));
							
							APIRunner_ProgressBar.Increment(1);
							this.Refresh();
						}	
					}
					
					APIRunner_ProgressBar.Value=0;
				}
				else if(APIRunner_IncrementCountersCheckBox.Checked)
				{
					//Save data to reset
					ud_APIXML=APIRunner_APIXMLTextBox.Text;
					ud_APITemplate=APIRunner_APITemplateTextBox.Text;
					ud_CriteriaParams=APIRunner_IncrementCriteriaTextBox.Text;					
					APIRunner_APIResetButton.Enabled=true;
					
					
					APIRunner_ProgressBar.Minimum=0;				
					APIRunner_ProgressBar.Maximum=(int)APIRunner_IncrementCounter_N.Value;					
					APIRunner_ProgressBar.Value=0;
					APIRunner_ProgressBar.Step=1;
					
					
					for(int i=0;i<APIRunner_IncrementCounter_N.Value;i++)
					{
						changedxml=APIRunner_APIXMLTextBox.Text;
						templatexml=APIRunner_APITemplateTextBox.Text;
						changedcriteria=APIRunner_IncrementCriteriaTextBox.Text;
						changedcriteria2=changedcriteria;
						IncrementCounters(ref changedxml,ref changedcriteria);
						IncrementCounters(ref templatexml,ref changedcriteria2);
						APIRunner_APIXMLTextBox.Text=changedxml;
						APIRunner_IncrementCriteriaTextBox.Text=changedcriteria;	
						APIRunner_APITemplateTextBox.Text=templatexml;
						
						
						postParamList=GetAPIRunnerParms(APIRunner_APINamesComboBox.Text,APIRunner_UserNameTextBox.Text,
			                                                                    APIRunner_PasswordTextbox.Text,APIRunner_APIXMLTextBox.Text,
			                                                                   APIRunner_APITemplateTextBox.Text);
						//APIRunner_ResultsTextBox.Text=APIRunner_ResultsTextBox.Text+"\n"+WebRequestHelper.GetURLResultPOST(urlstring,postParamList);					
						//APIRunner_ResultsTreeView.Nodes.Add(WebRequestHelper.GetURLResultPOST(urlstring,postParamList));
						APIRunner_ResultsTreeView.Nodes.Add(DateTime.Now.ToShortDateString()+" "+APIRunner_APINamesComboBox.Text+": Increment ["+(i+1)+"]:");
						APIRunner_ResultsTreeView.SelectedNode=APIRunner_ResultsTreeView.Nodes[APIRunner_ResultsTreeView.Nodes.Count-1];
						APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Input:\n"+APIRunner_APIXMLTextBox.Text);
						APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Template:\n"+APIRunner_APITemplateTextBox.Text);
						APIRunner_ResultsTreeView.SelectedNode.Nodes.Add("Output:\n"+XMLFormatter.IndentXML(WebRequestHelper.GetURLResultPOST(urlstring,postParamList)));
						
						APIRunner_ProgressBar.Increment(1);
						this.Refresh();
					}
					
					changedxml=APIRunner_APIXMLTextBox.Text;
					templatexml=APIRunner_APITemplateTextBox.Text;
					changedcriteria=APIRunner_IncrementCriteriaTextBox.Text;
					changedcriteria2=changedcriteria;
					IncrementCounters(ref changedxml,ref changedcriteria);
					IncrementCounters(ref templatexml,ref changedcriteria2);
					APIRunner_APIXMLTextBox.Text=changedxml;
					APIRunner_APITemplateTextBox.Text=templatexml;
					APIRunner_IncrementCriteriaTextBox.Text=changedcriteria;
					APIRunner_ProgressBar.Value=0;
				}
			}
			catch(Exception exception)
			{
				MessageBox.Show("There was a connection exception: "+exception, "Error");
			}			
		}
		
		/*
		void ComparisionBrowsePath1ButtonClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			
			ComparisionPath1TextBox.Text=folderBrowserDialog1.SelectedPath;								
		}
		
		void ComparisionBrowsePath2ButtonClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			
			ComparisionPath2TextBox.Text=folderBrowserDialog1.SelectedPath;		
		}
		
		void CompareFileButtonClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(ComparisionPath1TextBox.Text)||string.IsNullOrEmpty(ComparisionPath2TextBox.Text))
			{
				return;
			}
			
			if((!Directory.Exists(ComparisionPath1TextBox.Text))||(!Directory.Exists(ComparisionPath2TextBox.Text)))
			{
				MessageBox.Show("Directory mentioned not found.","Err");
				return;
			}									
		}
		*/
		
		void APIRunner_APINamesComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			if(APIRunner_APINamesComboBox.SelectedIndex==-1)
			{
				return;
			}
			
			if(File.Exists(APIDirectory+"\\"+APIRunner_APINamesComboBox.Text+"_input.xml"))
			{
				APIRunner_APIXMLTextBox.Text=File.ReadAllText(APIDirectory+"\\"+APIRunner_APINamesComboBox.Text+"_input.xml");
			}
			
			if(File.Exists(APIDirectory+"\\"+APIRunner_APINamesComboBox.Text+"_template.xml"))
			{
				APIRunner_APITemplateTextBox.Text=File.ReadAllText(APIDirectory+"\\"+APIRunner_APINamesComboBox.Text+"_template.xml");
			}
		}
		
		void MachineCheckSTAFButtonClick(object sender, EventArgs e)
		{
			Machine m=new Machine();
				
			m.name=HostNameTextBox.Text;
			
			if(m.CheckStafConnection())
			{
				MessageBox.Show("Staf is running on "+m.name+"." , "Success");
			}
			else
			{
				MessageBox.Show("Staf error "+m.name+"." , "Fail");
			}
			
			//m.GetTrustLevel();
			
			//MessageBox.Show("Trust level "+m.GetTrustLevel(), "Trust level");
		}
		
		void APIRunner_APIXMLTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control&&(e.KeyCode== Keys.A))
			{
				//if(Clipboard.ContainsText())
				//	ClipRingTreeView.Nodes.Add(Clipboard.GetText());
				APIRunner_APIXMLTextBox.SelectAll();
			}
		}
		
		void APIRunner_ResultsTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control&&(e.KeyCode== Keys.A))
			{
				//if(Clipboard.ContainsText())
				//	ClipRingTreeView.Nodes.Add(Clipboard.GetText());
				//APIRunner_ResultsTextBox.SelectAll();				
			}
		}		
		
		void APIRunner_RepeatCountersCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if(APIRunner_RepeatCountersCheckBox.Checked)
			{
				APIRunner_IncrementCountersCheckBox.Checked=false;				
				API_RunnerThreadCountNumericUpDown.Enabled=true;
			}
			else
			{
				API_RunnerThreadCountNumericUpDown.Enabled=false;
			}
		}
		
		void APIRunner_IncrementCountersCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if(APIRunner_IncrementCountersCheckBox.Checked)
			{
				APIRunner_RepeatCountersCheckBox.Checked=false;
			}
		}
		
		void APIRunner_ResultsTreeViewKeyDown(object sender, KeyEventArgs e)
		{
			/*if(e.Control&&(e.KeyCode== Keys.V))
			{
				if(Clipboard.ContainsText())
					ClipRingTreeView.Nodes.Add(Clipboard.GetText());
			}*/
			
			if(e.Control&&(e.KeyCode== Keys.C))
			{
				if(APIRunner_ResultsTreeView.SelectedNode != null)
				{
					if(APIRunner_ResultsTreeView.SelectedNode.Text!=null)
						Clipboard.SetText(APIRunner_ResultsTreeView.SelectedNode.Text);
				}
			}
			
			if(e.Control&&(e.KeyCode== Keys.O))
			{
				if(APIRunner_ResultsTreeView.SelectedNode != null)
				{
					string[] lines= APIRunner_ResultsTreeView.SelectedNode.Text.Split('\n');
					
					foreach(string s in lines)
					{
						APIRunner_ResultsTreeView.SelectedNode.Nodes.Add(s);
					}
				}
			}
			
			if(e.Control&&(e.KeyCode== Keys.S))
			{
				if(APIRunner_ResultsTreeView.SelectedNode != null)
				{
					ae=new ASCIIEncoding();
					saveFileDialog1.InitialDirectory=LogsPathTextBox.Text;
					saveFileDialog1.DefaultExt="xml";
					saveFileDialog1.ShowDialog();
					string fname=saveFileDialog1.FileName;
					FileStream fs=new FileStream(fname,FileMode.Create);
					fs.Write(ae.GetBytes(APIRunner_ResultsTreeView.SelectedNode.Text),0,ae.GetByteCount(APIRunner_ResultsTreeView.SelectedNode.Text));
					fs.Close();
				}
			}
			
			if(e.KeyCode==Keys.Delete)
			{
				if(APIRunner_ResultsTreeView.SelectedNode != null)
				{
					APIRunner_ResultsTreeView.Nodes.Remove(APIRunner_ResultsTreeView.SelectedNode);
				}
			}
		}
		
		void APIRunner_SaveAPIButtonClick(object sender, EventArgs e)
		{
			if(Directory.Exists(APIDirectory))
			{
				if(!string.IsNullOrEmpty(APIRunner_APIXMLTextBox.Text))
				{
					File.WriteAllText(APIDirectory+"\\"+APIRunner_APINamesComboBox.Text+"_input.xml",APIRunner_APIXMLTextBox.Text);
				}
				if(!string.IsNullOrEmpty(APIRunner_APITemplateTextBox.Text))
				{
					File.WriteAllText(APIDirectory+"\\"+APIRunner_APINamesComboBox.Text+"_template.xml",APIRunner_APITemplateTextBox.Text);
				}
			}
		}
		
		void APIRunner_APIResetButtonClick(object sender, EventArgs e)
		{
			APIRunner_APIXMLTextBox.Text=ud_APIXML;
			APIRunner_APITemplateTextBox.Text=ud_APITemplate;
			APIRunner_IncrementCriteriaTextBox.Text=ud_CriteriaParams;					
			APIRunner_APIResetButton.Enabled=false;
		}
		
		void APIRunner_APITemplateTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control&&(e.KeyCode== Keys.A))
			{
				//if(Clipboard.ContainsText())
				//	ClipRingTreeView.Nodes.Add(Clipboard.GetText());
				APIRunner_APITemplateTextBox.SelectAll();
			}
		}
		
		void APIRunner_ClearResultsButtonClick(object sender, EventArgs e)
		{
			APIRunner_ResultsTreeView.Nodes.Clear();
		}
		
		void ExtractArchiveDeleteRemoveTermButtonClick(object sender, EventArgs e)
		{
			if(ExtractArchiveRemoveTermsComboBox.SelectedIndex!=-1)
			{
				ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(ExtractArchiveRemoveTermsComboBox.SelectedIndex);
			}
			else if(ExtractArchiveRemoveTermsComboBox.Items.Count>0)
			{
				ExtractArchiveRemoveTermsComboBox.Items.RemoveAt(0);
			}
			//else do nothing
		}
		
		void ExtractArchiveAddExcludedFileButtonClick(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(ExtractArchiveAddExcludedFileTextBox.Text)&& !ExtractArchiveExcludedFilesComboBox.Items.Contains(ExtractArchiveAddExcludedFileTextBox.Text))
			{
				ExtractArchiveExcludedFilesComboBox.Items.Add(ExtractArchiveAddExcludedFileTextBox.Text);
			}
		}
		
		void ExtractArchiveDeleteExcludedFileButtonClick(object sender, EventArgs e)
		{
			if(ExtractArchiveExcludedFilesComboBox.SelectedIndex!=-1)
			{
				ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(ExtractArchiveExcludedFilesComboBox.SelectedIndex);
			}
			else if(ExtractArchiveExcludedFilesComboBox.Items.Count>0)
			{
				ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(0);
			}
			//else do nothing
		}
		
		void ExtractArchiveExcludedFilesComboBoxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Delete)
			{
				if(ExtractArchiveExcludedFilesComboBox.SelectedIndex!=-1)
				{
					ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(ExtractArchiveExcludedFilesComboBox.SelectedIndex);
				}
				else if(ExtractArchiveExcludedFilesComboBox.Items.Count>0)
				{
					ExtractArchiveExcludedFilesComboBox.Items.RemoveAt(0);
				}
				//else do nothing
			}
		}
		
		void ExtractArchiveResetButtonClick(object sender, EventArgs e)
		{
			RecursivelyExtractArchiveCheckBox.Checked=false;
			ExtractArchiveMaxNestingTextBox.Clear();
			
			ExtractArchiveAddRemoveTermTextBox.Clear();
			ExtractArchiveRemoveTermsComboBox.Items.Clear();			
			
			ExtractArchiveAddExcludedFileTextBox.Clear();
			ExtractArchiveExcludedFilesComboBox.Items.Clear();						
		}
		
		void EditScreenShotButtonClick(object sender, EventArgs e)
		{
			Process a=new Process();
			a.StartInfo.FileName="mspaint";
			a.StartInfo.Arguments=previousScreenshotText;
			a.Start();
		}
	}
}
