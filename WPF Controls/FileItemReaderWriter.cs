/*
 * Created by SharpDevelop.
 * User: Manian
 * Date: 27-04-2012
 * Time: 04:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace TesterBuddy
{
	/// <summary>
	/// Description of FileItemReader.
	/// </summary>
	public class FileItemReaderWriter
	{
		public FileItemReaderWriter()
		{
		}
		
		public static string[] ReadItems(string file)
		{
			if(!File.Exists(file))
			{
				throw new IOException("File named :"+file+" could not be accessed.\n");
			}
			string[] lines=File.ReadAllLines(file);
			
			return lines;
		}
		
		public static void WriteItems(string file, string[]  items, bool append)
		{
			if(!File.Exists(file))
			{
				throw new IOException("File named :"+file+" could not be accessed.\n");
			}
			
			//string contents="";
			
			//foreach(string item in items)
			//{
			//	contents=item+"\r\n";
			//}
			
			//File.AppendAllText(file,contents);
			
			File.WriteAllLines(file,items);
			
		}
	}
}
