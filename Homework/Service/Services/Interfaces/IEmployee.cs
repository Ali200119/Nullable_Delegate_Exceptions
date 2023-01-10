using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IEmployee
	{
		List<Person> FilterBySalary(Predicate<Person> func, List<Person> people);
	}
}