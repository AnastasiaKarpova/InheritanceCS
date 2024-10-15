using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Student:Human
	{
		static readonly int SPECIALITY_WIDTH = 16;
		static readonly int GROUP_WIDTH = 8;
		static readonly int RATING_WIDTH = 8;
		static readonly int ATTENDANCE_WIDTH = 8;
		public string Speciality { get; set; }
		public string Group {  get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }

		public Student(string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance):base(lastName, firstName, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"SConstructor:{GetHashCode()}");
		}
		~Student()
		{
			Console.WriteLine($"SDestructor:{GetHashCode()}");
		}

		public override void Print()
		{ 
			base.Print(); 
			Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
		}
		public override string ToString()
		{
			return base.ToString()+$" {Speciality.PadRight(SPECIALITY_WIDTH)} {Group.PadRight(GROUP_WIDTH)} {Rating.ToString().PadRight(RATING_WIDTH)} {Attendance.ToString().PadRight(ATTENDANCE_WIDTH)}";
		}
		public override string ToFileString()
		{
			return base.ToFileString()+$",{Speciality},{Group},{Rating},{Attendance}";
		}
		public override Human Init(string[] values)
		{
			base.Init(values);
			Speciality = values[4];
			Group = values[5];
			Rating = Convert.ToInt32(values[6]);
			Attendance = Convert.ToInt32(values[7]);
			return this;
		}
	}
}
