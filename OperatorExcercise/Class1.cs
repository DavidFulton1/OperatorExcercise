using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExcercise
{
    public class Operator_Class
    {
        public static double AreaOfCircle()
        {
            Console.WriteLine("please enter the radius");
            var r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(($"The area of a circle with this radius is {area}")); 
            return area;
        }
    }
}

