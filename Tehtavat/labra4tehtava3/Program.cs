using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();
			employee.Name = "Kirsi Kernel";
			employee.Profession = "Teacher";
			employee.Salary = 1200;
			employee.Print();
			Console.WriteLine("");

			Boss boss = new Boss();
			boss.Name = "Jussi Jurkka";
			boss.Profession = "Head of Institute";
			boss.Salary = 9000;
			boss.Car = "Audi";
			boss.Bonus = 5000;
			boss.Print();
			Console.WriteLine("");

			employee = new Employee();
			employee.Name = "Kirsi Kernel";
			employee.Profession = "Principal Teacher";
			employee.Salary = 2200;
			employee.Print();
			Console.WriteLine("");

		}
	}
}