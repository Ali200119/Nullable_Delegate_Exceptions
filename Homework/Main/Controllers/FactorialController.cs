using System;
using Service.Constants;
using Service.Exceptions;
using Service.Services;
using Service.Services.Interfaces;

namespace Main.Controllers
{
	public class FactorialController
	{
		private readonly IFactorial _factorial;

		public FactorialController()
		{
			_factorial = new FactorialService();
		}

		public void Show()
		{
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number < 0)
                {
                    throw new NegativeNumber(ExceptionMessages.NegativeNumber);
                }

                Console.WriteLine(_factorial.Calculate(number));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
		}
	}
}