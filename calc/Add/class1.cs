using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Add
{
    public class class1
    {
        public double add(double x, double y)
        {
            return x + y;
        }
        public double add(double a, double b, double c)
        {
            return a + b + c;

        }
        public int add(int num1, int num2 ,int num3)
        {

            return (num1+ num2 + num3);

        }

        public string salary(double salary, int work_hour)
        {
            return $"total salary { salary + (work_hour * 10)}";


        }


    }


}