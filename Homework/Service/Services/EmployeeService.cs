using System;
using System.Collections.Generic;
using Domain.Models;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class EmployeeService : IEmployee
    {
        public List<Person> FilterBySalary(Predicate<Person> func, List<Person> people)
        {
            List<Person> newList = new List<Person>();

            foreach (var item in people)
            {
                if (func(item))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}