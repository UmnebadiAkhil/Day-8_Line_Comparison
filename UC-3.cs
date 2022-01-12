using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class UC_3
    {
		public void Comparision(int X1, int X2, int Y1, int Y2)
		{

			int xLength = (X1 - X2) * (Y1 - Y2);
			int yLength = (Y1 - Y2) * (Y1 - Y2);
			int Length = xLength + yLength;
			Console.WriteLine("X and Y lie length is :- " + Length);


			Console.WriteLine("X line length is " + xLength);
			Console.WriteLine("Y line length is " + yLength);

			if (xLength == yLength)
				Console.WriteLine("Two lines are equal");
			else if (xLength < yLength)
				Console.WriteLine("Y line is greater than X line");
			else if (yLength < xLength)
				Console.WriteLine("X line is greater than y line");
		}
	}
}
