using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher:Human
	{
		static readonly int SPECIALITY_WIDTH = 16;
		static readonly int EXPERIENCE_WIDTH = 5;
		public string Speciality {  get; set; }
		public int Experience { get; set; }
		public Teacher(
			string lastName, string firstName, int age,
			string speciality, int experience):base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TConstructor: {GetHashCode()}");
		}
		~Teacher()
		{
			Console.WriteLine($"TDestructor:{GetHashCode()}");
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality} {Experience}");
		}
		public override string ToString()
		{
			return base.ToString()+$" {Speciality.PadRight(SPECIALITY_WIDTH)} {Experience.ToString().PadRight(EXPERIENCE_WIDTH)}";
		}
		public override string ToFileString()
		{
			return base.ToFileString() + $",{Speciality},{Experience}";
		}
		public override Human Init(string[] values)
		{
			base.Init(values);
			Speciality = values[4];
			Experience = Convert.ToInt32(values[5]);
			return this;
		}
	}
}
