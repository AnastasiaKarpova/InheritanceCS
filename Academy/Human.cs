using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Human
	{
		static readonly int TYPE_WIDTH = 10;
		static readonly int LAST_NAME_WIDTH = 12;
		static readonly int FIRST_NAME_WIDTH = 12;
		static readonly int AGE_WIDTH = 5;
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }

		//Constructor

		public Human(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstructor:{GetHashCode()}");
		}
		~Human()
		{
			Console.WriteLine($"HDestructor:{GetHashCode()}");
		}

		public virtual void Print()
		{
			Console.WriteLine($"{LastName} {FirstName} {Age}");
		}
		public override string ToString()
		{
			return (base.ToString().Split('.').Last() + ":").PadRight(TYPE_WIDTH) + $"{LastName.PadRight(LAST_NAME_WIDTH)} {FirstName.PadRight(FIRST_NAME_WIDTH)} {Age.ToString().PadRight(AGE_WIDTH)}";
		}
		public virtual string ToFileString()
		{
			return GetType().ToString().Split('.').Last() + $",{LastName},{FirstName},{Age}";
		}
		public virtual Human Init(string[] values)
		{
			LastName = values[1];
			FirstName = values[2];
			Age = Convert.ToInt32(values[3]);
			return this;
		}
	}
}
