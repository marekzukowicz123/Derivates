using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochodne
{
    public static class Derivates
    {
        // zmienne pomocnicze
        public delegate double Function(double x);
        public delegate double TwoArgumentsFunction(double x, double y);
        public delegate double CompoundFunction(Function OutsideFunction, Function Insidefunction);

        // pierwsza pochodna funkcji jednej zmiennej
        public static double FirstDerivativeOneVariable(Function Function, double x, double dx)
        {
            // dx --> h zgodnie z wzorem (1)
            //funkcja Math.Round zaokrągla wynik, w tym przypadku do 4 miejsc po przecinku
            // wyrażenie Function(x + dx) - Function(x)) / dx to iloraz różnicowy
            double y = Math.Round((Function(x + dx) - Function(x)) / dx, 4);
            return y;
        }
        // druga pochodna funkcji jednej zmiennej
        public static double SecondDerivativeOneVariable(Function Function, double x, double dx)
        {
            double y = Math.Round((Function(x + 2 * dx) - 2 * Function(x + dx) + Function(x)) / (dx * dx), 4);
            return y;
        }
        //trzecia pochodna funkcji jednej zmiennej
        public static double ThridDerivativeOneVariable(Function Function, double x, double dx)
        {
            double y = Math.Round((Function(x + 3 * dx) - 2 * Function(x + 2 * dx) + Function(x + dx) -
                Function(x + 2 * dx) + 2 * Function(x + dx) - Function(x)) / (dx * dx * dx), 4);
            return y;
        }
        //pierwsza pochodna funkcji dwóch zmiennych po x
        public static double FirstDerivativeTwoVariablesOfx(TwoArgumentsFunction TwoArgumentsFunction, double x, double y, double dx)
        {
            double z = Math.Round((TwoArgumentsFunction(x + dx, y) - TwoArgumentsFunction(x, y)) / dx, 4);
            return z;
        }
        //pierwsza pochodna funkcji dwóch zmiennych po y
        public static double FirstDerivativeTwoVariablesOfy(TwoArgumentsFunction TwoArgumentsFunction, double x, double y, double dy)
        {
            double z = Math.Round((TwoArgumentsFunction(x, y + dy) - TwoArgumentsFunction(x, y)) / dy, 4);
            return z;
        }
        //druga  pochodna funkcji dwóch zmiennych po x oraz y
        public static double SecondDerivativeTwoVariablesOfxy(TwoArgumentsFunction TwoArgumentsFunction, double x, double y, double dx, double dy)
        {
            double z = Math.Round((TwoArgumentsFunction(x + dx, y + dy) - TwoArgumentsFunction(x + dx, y)
                - TwoArgumentsFunction(x, y + dy) + TwoArgumentsFunction(x, y)) / (dx * dy), 4);
            return z;
        }
        //druga  pochodna funkcji dwóch zmiennych po x 
        public static double SecondDerivativeTwoVariablesOfx(TwoArgumentsFunction TwoArgumentsFunction, double x, double y, double dx)
        {
            double z = Math.Round((TwoArgumentsFunction(x + 2*dx, y) - 2 * TwoArgumentsFunction(x + dx, y) + TwoArgumentsFunction(x, y))/ (dx * dx), 4);
            return z;
        }
        //druga  pochodna funkcji dwóch zmiennych po y 
        public static double SecondDerivativeTwoVariablesOfy(TwoArgumentsFunction TwoArgumentsFunction, double x, double y, double dy)
        {
            double z = Math.Round((TwoArgumentsFunction(x , y + 2*dy) - 2 * TwoArgumentsFunction(x, y + dy) + TwoArgumentsFunction(x, y)) / (dy * dy), 4);
            return z;
        }
        // pochodna funkcji złożonej jednej zmiennej f(g(x))' = f'(g(x))*f'(x), gotowy wzór z analizy matematycznej
        public static double CompoundDerivateOnevariable(Function OutsideFunction, Function InsideFunction, double x, double dx)
        {
            return Math.Round(FirstDerivativeOneVariable(OutsideFunction, InsideFunction(x), dx) * FirstDerivativeOneVariable(InsideFunction, x, dx), 4);
        }
        // pierwsza pochodna funkcji zlożonej po x, wewnętrzna ma dwie zmienne, zewnętrzna jest elementarna
        public static double CompoundDerivateTwovariablesOfx(Function OutsideFunction, TwoArgumentsFunction InsideFunction, 
            double x, double y, double dx, double dy)
        {
            return Math.Round(FirstDerivativeOneVariable(OutsideFunction, InsideFunction(x, y), dx) * FirstDerivativeTwoVariablesOfx(InsideFunction, x,y, dx), 4);
        }
        // pierwsza pochodna funkcji zlożonej po y, wewnętrzna ma dwie zmienne, zewnętrzna jest elementarna
        public static double CompoundDerivateTwovariablesOfy(Function OutsideFunction, TwoArgumentsFunction InsideFunction, 
            double x, double y, double dx, double dy)
        {
            return Math.Round(FirstDerivativeOneVariable(OutsideFunction, InsideFunction(x, y), dy) * FirstDerivativeTwoVariablesOfx(InsideFunction, x, y, dy), 4);
        }


    }
}
