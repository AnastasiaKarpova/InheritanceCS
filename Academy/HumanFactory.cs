using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class HumanFactory
	{
		internal static Human Create(string type)
		{
			Human human = null;
			switch (type)
			{
				case "Human": human = new Human("", "", 0); break;
				case "Teacher": human = new Teacher("", "", 0, "", 0); break;
				case "Student": human = new Student("", "", 0, "", "", 0, 0); break;
				case "Graduate": human = new Graduate("", "", 0, "", "", 0, 0, ""); break;
			}
			return human;
		}
	}
}
