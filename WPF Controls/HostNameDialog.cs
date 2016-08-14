/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 11/08/2009
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesterBuddy
{
	/// <summary>
	/// Description of HostNameDialog.
	/// </summary>
	public partial class HostNameDialog : Form
	{
		public Boolean signal=false;
		public HostInfo hi=new HostInfo();
		
		public HostNameDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			hi.HostName=textBox1.Text;
			hi.Alias=textBox6.Text;
			hi.IP=textBox2.Text+"."+textBox3.Text+"."+textBox4.Text+"."+textBox5.Text;
			if((String.Compare(hi.HostName,"")!=0)&&
			   (String.Compare(hi.IP,"")!=0))
				signal=true;
		}
	}
}
