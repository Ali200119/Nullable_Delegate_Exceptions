using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IEmployee
	{
		List<Person> FilterBySalary(List<Person> people, Predicate<> func);
	}
}