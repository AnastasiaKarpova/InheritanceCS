//#define INHERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_CHECK
			Human human = new Human("Montana", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Print();
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Print();
			Console.WriteLine(teacher); 
#endif
			Human[] group = new Human[]
			{
				new Student("Pimkman", "Jessie", 20, "Chenistry", "WW_220", 95, 90),
				new Teacher("White", "Walter", 50, "chemistry", 25),
				new Graduate("Schrader", "Hank", 40, "Chiminalistic", "OBN", 50, 70, "How to catch Heisenberg"),
				new Student("Vercetti", "Tommy", 30, "Theft", "Vice", 95, 98),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
			};
			//for (int i = 0; i < group.Length; i++)
			//{
			//	Console.WriteLine(group[i] + ";");
			//}
			//Console.WriteLine();

			string filename = "group.txt";
			//save(group, filename);
			Load(filename);
		}
		static void save(Human[] group, string filename)
		{
			StreamWriter sw = new StreamWriter("group.txt");
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine(group[i].ToString());
			}
			sw.Close();
			Process.Start("notepad", "group.txt");
			Console.WriteLine();
		}
		static Human[] Load (string filename)
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
