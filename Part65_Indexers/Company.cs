﻿using System.Collections.Generic;
using System.Linq;

namespace Part65_Indexers
{
    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            listEmployees.Add(new Employee
            { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(e => e.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(e => e.EmployeeId == employeeId).Name = value;
            }
        }
    }
}
