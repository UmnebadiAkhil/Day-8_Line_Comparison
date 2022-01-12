using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class UC1
    {
        public void LengthOfLine(int X1, int X2, int Y1, int Y2 )
        {
            var distance = Math.Sqrt((Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)));
            Console.WriteLine("Length of a line is " + distance);
        }
    }
}
