/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 26-03-2012
 * Time: 04:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
//using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Text;
using System.Web;
//using System.Net.Security;
//using System.Web.Security;
//using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace TesterBuddy
{
	/// <summary>
	/// Description of DBInvoker.
	/// </summary>
	public class DBInvoker
	{
		private string url;
		private  WebRequest request;
		ASCIIEncoding ae=new ASCIIEncoding();

		public DBInvoker(string hostname)
		{
			url="http://"+hostname+"/webapp/wcs/stores/servlet/dbxml.jsp";
		}
		
		 /*// callback used to validate the certificate in an SSL conversation
		private static bool ValidateRemoteCertificate(
		object sender,
			X509Certificate certificate,
			X509Chain chain,
			SslPolicyErrors policyErrors
		)
		{
				return true;
		}
		 */
		
		private string MakeDBRequest(string sql)
		{	
			string postData=HttpUtility.UrlEncode(sql);
            
	        request = WebRequest.Create (url+"?sqlstring="+postData);
            
            request.Method = "GET";                           
            //request.ContentLength = 0;
            WebResponse response = request.GetResponse ();
            
            Stream dataStream = response.GetResponseStream ();
            StreamReader reader = new StreamReader (dataStream);
            //string responseFromServer = reader.ReadToEnd ();
            //responseFromServer=responseFromServer.Replace("\r\n", "");
            
            return reader.ReadToEnd();
		}
		
		/*
		public void getDBValuesFromXML(Stream XMLStream)
		{
			XmlTextReader xr=new XmlTextReader(XMLStream);
			string elementName, attrName, attrVal;
			
			while(xr.Read())
			{
				switch (xr.NodeType) 
       			{
					case XmlNodeType.Element:
					elementName=xr.Name;

					if(elementName.Equals("Settings"))
					{	
						break;
					}
					else if(elementName.Equals("Setting"))
					{
						attrName=xr.GetAttribute("name");
						attrVal=xr.GetAttribute("value");
						//settingList.AddLast(new KeyValuePair<string, string>(attrName,attrVal));
					}
					break;
					
					default:
						break;
				}
			}
		}
		 
		public List<string> GetCatalogs()
		{
			
			List<string> catalogs=new List<string>();

			string responseFromServer=MakeDBRequest("select * from catalog").Replace("\r\n","");
			
			byte [] responsebytes=ae.GetBytes(responseFromServer.ToCharArray());
			responseFromServer="";
			
			MemoryStream inputStream=new MemoryStream(responsebytes);
			
			getDBValuesFromXML(inputStream);
			//StreamReader sr=new StreamReader(
            return catalogs;

		}*/
	}
}
