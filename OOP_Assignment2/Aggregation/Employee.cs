﻿namespace OOP_Assignment2.Aggregation
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime HiringDate { get; set; }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            HiringDate = DateTime.UtcNow;
        }
    }
}
