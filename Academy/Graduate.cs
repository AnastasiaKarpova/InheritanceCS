using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	
	internal class Graduate:Student
	{
		static readonly int SUBJECT_WIDTH = 20;
		public string Subject {  get; set; }

		public Graduate (string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance, 
			string subject) :base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor:{GetHashCode()}");
		}
		~Graduate()
		{
			Console.WriteLine($"GDestructor:{GetHashCode()}");
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Subject}");
		}
		public override string ToString()
		{
			return base.ToString() + $" {Subject.PadRight(SUBJECT_WIDTH)}";
		}
		public override string ToFileString()
		{
			return base.ToFileString()+$",{Subject}";
		}
	}
}
