﻿
using System.Linq;


namespace EntityFramework.Demo
{
	internal class EmployeeProvider : IEmployeeProvider
	{
		private EmployeeContext employeeContext;

		public EmployeeProvider(EmployeeContext employeeContext)
		{
			this.employeeContext = employeeContext;
		}
		public Employee Get(int id)
		{
			return employeeContext.Employees.Where(e => e.Id == id).FirstOrDefault();
		}
	}
}
