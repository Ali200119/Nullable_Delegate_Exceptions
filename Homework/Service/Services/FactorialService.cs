using System;
using Service.Constants;
using Service.Exceptions;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class FactorialService : IFactorial
    {
        public int Calculate(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}