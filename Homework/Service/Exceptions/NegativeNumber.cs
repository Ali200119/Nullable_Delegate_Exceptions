using System;
namespace Service.Exceptions
{
	public class NegativeNumber: Exception
	{
		public NegativeNumber(string message):base(message) { }
	}
}