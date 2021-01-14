﻿using System;

namespace EntityFramework.Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var context = new EmployeeContext("");
			var provider = new EmployeeProvider(context);
			var employee = provider.Get(1);
			Console.WriteLine($"Welcome {employee.FirstName} {employee.LastName}");

			var repo = new EmployeeRepo(context);
			repo.Create("First", "Last", "Address", "1234", "67890");
		}
	}
}
