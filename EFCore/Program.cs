﻿using System;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var employee = new Employee
            {
                Name = "Employee 1" 
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}
