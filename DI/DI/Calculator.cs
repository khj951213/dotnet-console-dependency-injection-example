﻿namespace DI
{
    internal class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
        public int Divide(int a, int b) => a / b;
        public int Modulo(int a, int b) => a % b;
        public int Multiply(int a, int b) => a * b;
        public int Subtract(int a, int b) => a - b;
    }
}
