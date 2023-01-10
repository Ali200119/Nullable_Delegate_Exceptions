using System;
using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;

namespace Main.Controllers
{
	public class EmployeeController
	{
		private readonly IEmployee _employee;

		public EmployeeController()
		{
			_employee = new EmployeeService();
		}

		public void Show()
		{
			var result = _employee.FilterBySalary(SalaryMoreThan1000, GetPeople());

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}

		private bool SalaryMoreThan1000(Person person) => person.Salary > 1000;

		private List<Person> GetPeople() => new List<Person> { new Person(1, "Ali", "Talibov", "Xetai", 2000), new Person(2, "Jonathan", "Jackson", "New York", 1000), new Person(3, "Cavid", "Bashirov", "Baki", 3000) };
	}
}