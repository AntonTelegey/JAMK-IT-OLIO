using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
	class Employee
	{
		public string Name { get; set; }
		public string Profession { get; set; }
		public int Salary { get; set; }

		public void Print()
		{
			Console.Write(this.GetType().Name + ":");
			Console.WriteLine("");
			Console.Write("- Name:" + Name + " Profession:" + Profession + " Salary:" + Salary);
		}
	}
}