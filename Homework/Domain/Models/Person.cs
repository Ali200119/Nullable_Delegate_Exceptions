using System;
using Domain.Commons;

namespace Domain.Models
{
	public class Person: BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public int Salary  { get; set; }

		public Person(int id, string name, string surname, string address, int salary):base(id)
		{
			Name = name;
			Surname = surname;
			Address = address;
			Salary = salary;
		}

        public override string ToString()
        {
			return $"{Name} {Surname} {Address}";
        }
    }
}