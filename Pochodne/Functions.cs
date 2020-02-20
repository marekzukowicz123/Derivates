using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochodne
{
    public class Functions
    {
         // pierwisatek
        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        // x kwadrat
        public static double Square(double x)
        {
            return x * x;
        }
        //Sinus X
        public static double Sinx(double x)
        {
            return Math.Sin(x);
        }
        public static double Sinx(double x, double y)
        {
            return Math.Sin(x+y);
        }
        //funkcja liniowa dwóch ziennych
        public static double LineFunctionOfxy(double x, double y)
        {
            return x * y;
        }
        // dowolna funkcja dwóch zmiennych
        public static double FunctiononOfx2y(double x, double y)
        {
            return x*x * y;
        }
    }
}
