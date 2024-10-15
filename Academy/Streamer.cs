using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Streamer
	{
		internal static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			Console.WriteLine();
		}
		internal static void save(Human[] group, string filename)
		{
			StreamWriter sw = new StreamWriter(filename);
			sw.WriteLine("Sep=,");
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine(group[i].ToFileString()/*.ToString()*/);
			}
			sw.Close();
			//Process.Start("notepad", filename);
			Process.Start("excel", filename);
			Console.WriteLine();
		}
		//CSV - Comma Separated Valyes (Значения, разделенные запятой).
		internal static Human[] Load(string filename)
		{
			List<Human> group = new List<Human>();
			try
			{
				StreamReader sr = new StreamReader("group.txt");
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					Console.WriteLine(buffer);
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return group.ToArray();
		}
	}
}
