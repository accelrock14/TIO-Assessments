using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Assessment07_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    class Employee : Person
    {
        public int EmpId { get; set; }
        public double Basic { get; set; }
        public double Experience { get; set; }

        public double GetSalary()
        {
            return Basic + SalaryCalculator.CalculateSalary(Experience, Basic);
        }
    }

    class Customer : Person
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
    }

    class Company
    {
        public List<Branch> Branches { get; set; } = new List<Branch>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public string Name { get; set; }

    }
    public class Branch
    {

    }
    class Corp : Branch
    {

    }
    class Reg : Branch
    {

    }
    public class SalaryCalculator
    {
        public static double CalculateSalary(double Experience, double Basic)
        {
            int allowance;

            if (Experience <= 2)
                allowance = 30;
            else if (Experience <= 4)
                allowance = 40;
            else if (Experience <= 6)
                allowance = 50;
            else
                allowance = 60;

            return allowance * Basic / 100;
        }
    }
}
