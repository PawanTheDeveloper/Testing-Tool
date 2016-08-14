/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 22/06/2010
 * Time: 4:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TesterBuddy
{
	/// <summary>
	/// Description of CommandBuilder.
	/// </summary>
	public class CommandBuilder
	{
		public CommandBuilder()
		{
			//
		}
		
		public static List<string> Load(string filename)
		{
			List<string> cmds=new List<string>();
			string[] lines=File.ReadAllLines(filename);
			
			foreach(string s in lines)
				cmds.Add(s);
			return cmds;
		}
		
		public static void SaveFile(string filename,List<string> cmds)
		{
				File.WriteAllLines(filename,cmds.ToArray());
		}
	}
}
