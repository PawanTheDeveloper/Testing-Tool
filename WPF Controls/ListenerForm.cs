/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 03/03/2010
 * Time: 4:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;

namespace TesterBuddy
{
	/// <summary>
	/// Description of ListenerForm.
	/// </summary>
	public partial class ListenerForm : Form
	{
		TcpListener rconListner=new TcpListener(IPAddress.Any,17000);
		
		public ListenerForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ListenerFormLoad(object sender, EventArgs e)
		{
			rconListner.Start();
			timer1.Start();
		}
		
		void ListnerEventsTextBoxTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			ASCIIEncoding ae=new ASCIIEncoding();
			TcpListener tl=rconListner;
			TcpClient tc;
			
			int CmdID,LengthCmd,LengthArg;
			byte[] body;
			string scmd,sarg="";
			NetworkStream ns;
			string FName;
			int ReturnCode;
			FileStream fs;
			int FNameLen;
			string line;
			byte[] magicno={0x09,0xab,0xcd,0xef};
			
			StringBuilder sb=new StringBuilder();
			
			if(tl.Pending())
			{
				tc=tl.AcceptTcpClient();	
				ns=tc.GetStream();
				
				body=new byte[4];
				ns.Read(body,0,4);
				
				//Check Magic number
				
				body=new byte[1];
				ns.Read(body,0,1);
				CmdID=body[0];
				
				ListnerEventsTextBox.AppendText("New Command Requested.\r");
				ListnerEventsTextBox.AppendText("CmdID="+CmdID.ToString()+"\r");
				
				if(CmdID==0)
				{
					ns.Write(body,0,1);
					ns.Close();
					tc.Close();
					return;
				}
				else if(CmdID==1)
				{
					body=new byte[2];
					ns.Read(body,0,2);
					//Read length as the next two bytes from the stream
					//in 256'th number system.
					LengthCmd=body[0]*256+body[1];
					
					if(LengthCmd<=0)
					{
						ns.Write(body,0,1);
						ns.Close();
						tc.Close();
						return;
					}	
					
					body=new byte[LengthCmd];
					ns.Read(body,0,LengthCmd);
					scmd=ae.GetString(body);
					Process cmd=new Process();
					cmd.StartInfo.FileName=scmd;
					
					ns.Read(body,0,2);
					LengthArg=body[0]*256+body[1];
					
					if(LengthArg>0)
					{
						body=new byte[LengthArg];
						ns.Read(body,0,LengthArg);
						sarg=ae.GetString(body);
						cmd.StartInfo.Arguments=sarg;
					}
					Program a=new Program();
					Console.WriteLine("Requested Command: {0} {1}",scmd,sarg);
					cmd.StartInfo.RedirectStandardOutput=true;
					cmd.StartInfo.RedirectStandardError=true;
					cmd.StartInfo.UseShellExecute=false;
					
					cmd.Start();
					ns.Write(ae.GetBytes("Started Execution of the program.\n\n"),0,ae.GetByteCount("Started Execution of the program.\n\n"));
					StreamReader sr=cmd.StandardOutput,se=cmd.StandardError;
					Console.WriteLine("The Exection of the process has been started.\n");
					
					while(!sr.EndOfStream)
					{
						if((line=sr.ReadLine())!="")
						{
							ns.Write(ae.GetBytes("Output:"+line+"\n"),0,ae.GetByteCount("Output:"+line+"\n"));
						}
						
						if((se.EndOfStream)&&(line=se.ReadLine())!="")
						{
							ns.Write(ae.GetBytes("Error:"+line+"\n"),0,ae.GetByteCount("Error:"+line+"\n"));
						}
					}
							
					ReturnCode=cmd.ExitCode;
					ns.Write(ae.GetBytes("\n Return Code: "+ReturnCode.ToString()+"\n"),0,ae.GetByteCount("\n Return Code: "+ReturnCode.ToString()+"\n"));
					Console.WriteLine("Process execution complete.\n");
					
					ns.Close();
					tc.Close();
				}
				else if(CmdID==2)
				{
					body=new byte[2];
					ns.Read(body,0,2);
					FNameLen=body[0]*256+body[1];
					
					if(FNameLen<=0)
					{
						ns.Write(body,0,1);
						ns.Close();
						tc.Close();
						return;
					}	
					
					body=new byte[FNameLen];
					ns.Read(body,0,FNameLen);
					FName=ae.GetString(body);
					fs=new FileStream(FName,FileMode.Open);
					
					if(fs==null)
					{
						ns.Write(body,0,1);
						ns.Close();
						tc.Close();
						return;
					}	
					
					body=new byte[65536];
					
					while(true)
					{
						if(fs.Read(body,0,65536)<0)
							break;
						sb.Append(ae.GetString(body));
					}
					
				}
				else if(CmdID==3)
				{
					
					//Protocol for screenshot
					//Receive: [1 byte type=3 for screenshot][4 byte x][4 byte y][4 byte l][4 byte w]
					//Send: [4 byte length][4 byte width] [3*length*width bytes of rgb data]
				
					int x,y,l,w;
					//byte[] buff = new byte[256];
					//w=Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle).Size.Height;
					//l=Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle).Size.Width;
					//x=Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle).Location.X;
					//y=Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle).Location.Y;
					//this.WindowState=FormWindowState.Minimized;						
					//Thread.Sleep(500);
					//pictureBox1.Image=CaptureScreen.GetDesktopImage(0,0,300,200);
					//this.WindowState=FormWindowState.Normal;
					byte[] buff=new byte[4];
					
					ns.Read(buff,0,4);
					x=BitConverter.ToInt32(buff,0);
					
					ns.Read(buff,0,4);
					y=BitConverter.ToInt32(buff,0);
					
					ns.Read(buff,0,4);
					l=BitConverter.ToInt32(buff,0);
					
					ns.Read(buff,0,4);
					w=BitConverter.ToInt32(buff,0);
					
					Bitmap bmp=CaptureScreen.GetDesktopImage(x,y,l,w);
					
					//bmp.Save("c:\\screenshot.bmp");
					
					ns.Write(BitConverter.GetBytes(bmp.Width),0,4);
					ns.Write(BitConverter.GetBytes(bmp.Height),0,4);
					
					byte[] rgbdata=new byte[bmp.Width*bmp.Height*3+1];	
					//int bytecount;
					
					Image img=bmp;
					
					//Send jpg image
					img.Save(ns,ImageFormat.Jpeg);
					
					/*
					for(i=0,bytecount=0;i<bmp.Width;i++)
					{
						for(j=0;j<bmp.Height;j++)
						{			
							BitConverter.GetBytes(bmp.GetPixel(i,j).R).CopyTo(rgbdata,bytecount);
							BitConverter.GetBytes(bmp.GetPixel(i,j).G).CopyTo(rgbdata,bytecount+1);
							BitConverter.GetBytes(bmp.GetPixel(i,j).B).CopyTo(rgbdata,bytecount+2);
							
							bytecount+=3;
							
							//Writing byte by byte will be rather slow. Let transport layer take care of it.
							//ns.Write(BitConverter.GetBytes(bmp.GetPixel(i,j).R),0,1);
							//ns.Write(BitConverter.GetBytes(bmp.GetPixel(i,j).G),0,1);
							//ns.Write(BitConverter.GetBytes(bmp.GetPixel(i,j).B),0,1);
						}
					}
					
					ns.Write(rgbdata,0,rgbdata.Length);
					*/
					
					ns.Close();
					tc.Close();
				}
					
				else if(CmdID==4)
				{
					/*FileStream fsx =new FileStream("c:\\test.txt",FileMode.Open);
					int len;
					byte[] buff=new byte[128];
					
					while((len=fsx.Read(buff,0,128))>0)
						ns.Write(buff,0,len);
						*/
						
					//use existing feature than write own code for this.
					tc.Client.SendFile("c:\\test.txt");
					tc.Close();
					//fsx.Close();
				}
				else
				{
				
				}
			}
		}
		
		void ListenerFormFormClosed(object sender, FormClosedEventArgs e)
		{
			timer1.Stop();
			rconListner.Stop();
		}
	}
}
