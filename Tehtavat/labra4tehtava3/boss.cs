using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
	class Boss : Employee
	{
		public int Bonus { get; set; }
		public string Car { get; set; }

		public new void Print()
		{
			base.Print();
			Console.Write(" Car:" + Car + " Bonus:" + Bonus);
		}
	}
}