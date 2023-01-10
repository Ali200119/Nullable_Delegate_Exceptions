using System;
namespace Domain.Commons
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }

		public BaseEntity(int id)
		{
			Id = id;
		}
	}
}