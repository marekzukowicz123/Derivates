using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pochodne
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dx = 0.00001; // różniczka, h --> 0
            const double dy = 0.00001; // różniczka, k --> 0

            Console.WriteLine("Pierwsza Pochodna funkcji Sin(x) w punkcie 0 to: "
                + Derivates.FirstDerivativeOneVariable(Functions.Sinx, 0, dx) + ".");

            Console.WriteLine("Druga Pochodna funkcji Sin(x) w punkcie 0 to: "
                 + Derivates.SecondDerivativeOneVariable(Functions.Sinx, 0, dx) + ".");

            Console.WriteLine("Pierwsza pochodna funkcji x^2*y zmiennej po x w punkcie (1,1) to: "
                + Derivates.FirstDerivativeTwoVariablesOfx(Functions.FunctiononOfx2y, 1, 1, dx) + ".");

            Console.WriteLine("Pierwsza pochodna funkcji x^2*y  po zmiennej y w punkcie (1,1) to: "
                + Derivates.FirstDerivativeTwoVariablesOfy(Functions.FunctiononOfx2y, 1, 1, dy) + ".");

            Console.WriteLine("Druga pochodna funkcji x^2*y po x zmiennej w punkcie (1,1) to: "
                + Derivates.SecondDerivativeTwoVariablesOfx(Functions.FunctiononOfx2y, 1, 1, dx) + ".");

            Console.WriteLine("Druga pochodna funkcji x^2*y po zmiennej y w punkcie (1,1) to: "
                + Derivates.SecondDerivativeTwoVariablesOfy(Functions.FunctiononOfx2y, 1, 1, dy) + ".");

            Console.WriteLine("Druga pochodna po zmiennej x i po zmiennej y funkcji x^2*y po y w punkcie (1,1) to: "
                + Derivates.SecondDerivativeTwoVariablesOfxy(Functions.FunctiononOfx2y, 1, 1, dx, dy) + ".");

            Console.WriteLine("Pochodna funcji sin^2(x)) w punkcie PI/2 to: "
                 + Derivates.CompoundDerivateOnevariable(Functions.Square, Functions.Sinx, (Math.PI) / 2.0, dx) + ".");

            Console.ReadKey();

        }
    }
}
