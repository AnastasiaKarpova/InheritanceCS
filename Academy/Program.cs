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

			Streamer.Print(group);
			//string filename = "group.txt";
			//Streamer.save(group, "group.txt");
			Streamer.save(group, "group.csv");
			//Load(filename);
		}
		
	}
}
