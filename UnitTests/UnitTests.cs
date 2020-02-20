using System;
using NUnit.Framework;
using FluentAssertions;


namespace Pochodne
{
    [TestFixture]
    class UnitTests
    {
        // funkcja stała
        private double test_function_1(double x)
        {
            return 3;
        }
        // funkcja stała dla dwóch zmiennych
        private double test_function_1(double x, double y)
        {
            return 2;
        }
        // funkcja e^x jednej zmiennej
        private double test_function_2(double x)
        {
            return Math.Exp(x);
        }
        // funkcja stała e^x dla dwóch zmiennych
        private double test_function_2(double x, double y)
        {
            return Math.Exp(x + y);
        }
        // funkcja sinus
        private double test_function_3(double x)
        {
            return Math.Sin(x);
        }
        // funkcja kwadratowa
        private double test_function_4(double x)
        {
            return x * x;
        }

        // test wartości pochodnych dla funkcji stałych
        [TestCase(Math.PI / 4, 0)]
        [TestCase(43429, 0)]
        [TestCase(-34737, 0)]
        public void check_first_derivate_for_one_varable_constant_fucntion(double testValue,
            double expectedValue, double dx = 0.000001)
        {
            Derivates.FirstDerivativeOneVariable(test_function_1, testValue, dx)
                .Should().Be(expectedValue);
        }
        // test wartości pochodnych dla funkcji stałych dwóch zmiennych po x
        [TestCase(4, 5, 0)]
        public void check_first_derivate_for_two_varables_constant_fucntion_for_x(double x, double y,
            double expectedValue, double dx = 0.000001)
        {
            Derivates.FirstDerivativeTwoVariablesOfx(test_function_1, x, y, dx).Should().Be(expectedValue);
        }
        // test wartości pochodnych dla funkcji stałych dwóch zmiennych po y
        [TestCase(6, 8, 0)]
        public void check_first_derivate_for_two_varables_constant_fucntion_for_y(double x, double y,
            double expectedValue, double dy = 0.000001)
        {
            Derivates.FirstDerivativeTwoVariablesOfx(test_function_1, x, y, dy).Should().Be(expectedValue);
        }
        // test wartości pochodnych dla funkcji stałych dwóch zmiennych po x oraz po y
        [TestCase(11, 28, 0)]
        public void check_first_derivate_for_two_varables_constant_fucntion_for_xy(double x, double y,
            double expectedValue, double dx = 0.000001, double dy = 0.000001)
        {
            Derivates.SecondDerivativeTwoVariablesOfxy(test_function_1, x, y, dx, dy)
                .Should().Be(expectedValue);
        }
        // test wartości pochodnych dla funkcji e^x
        [TestCase(1, 2.7183)]
        [TestCase(0, 1)]
        public void check_first_derivate_for_one_varable_for_Exp(double testValue,
            double expectedValue, double dx = 0.000001)
        {
            Derivates.FirstDerivativeOneVariable(test_function_2, testValue, dx)
                .Should().Be(expectedValue);
        }

        // test wartości drugich pochodnych dla funkcji e^(x+y) po obu zmiennych
        [TestCase(0, 0, 1)]
        [TestCase(1, 0, 2.7183)]
        [TestCase(0, 1, 2.7183)]
        [TestCase(0.7, 0.3, 2.7183)]
        public void check_second_derivate_for_xy(double x, double y, double expectedValue,
            double dx = 0.000001, double dy = 0.000001)
        {
            Derivates.SecondDerivativeTwoVariablesOfxy(test_function_2, x, y, dx, dy)
                .Should().Be(expectedValue);
        }
        // test wartości pierwszej pochodnej dla funkcji sin^2(x) po x
        [TestCase(0, 0)]
        [TestCase(Math.PI, 0)]
        [TestCase(Math.PI / 2, 0)]
        [TestCase(Math.PI / 4, 1 )]
        [TestCase(- Math.PI / 4, -1)]
        public void check_compound_derivate_one_variable_of_x(double x, double expectedValue, double dx = 0.00001)
        {
            Derivates.CompoundDerivateOnevariable(test_function_4 ,test_function_3, x, dx)
                .Should().Be(expectedValue);
        }
    }
}
