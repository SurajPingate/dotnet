using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Create an array of Employee class objects
        Accept details for all Employees
        Display the Employee with highest Salary
        Accept EmpNo to be searched. Display all details for that employee.
 */

namespace Que1
{
    class Program
    {
        static void Main()
        {
            Employee[] e = new Employee[3];
          //  Employee e1 = new Employee();
            for(int i =0; i<3; i++)
            {
                Console.WriteLine("Enter the data for Employee ID {0}",i+1);
                e[i] = new Employee();
                e[i].SetEmpData();
            }
            
            for(int i = 0; i<3; i++)
            {
                //e[i].HighSal(e1);
                int max = e[i].salary;
                for (int j = i+1; j < 3; j++)
                {
                    if (e[j].salary > max)
                    {
                        max = e[j].salary;
                    }
                }
                for (int j = 0; j < 3; j++)
                {
                    if (e[j].salary == max)
                    {
                        Console.WriteLine("==========================================================");
                        Console.Write("Maximum Salary of Employee is : " + e[j].name);
                        Console.WriteLine(" and Salary is : " + e[j].salary);
                    }
                    break;
                }
            }

            Console.WriteLine("Search Employee by Employee Id");
            Console.WriteLine("Enter Employee Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<3; i++)
            {
                if(e[i].empId == id)
                {
                    e[i].Display();
                }
                break;
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int empId;
        public string name;
        public int salary;
        public string joiningDate;

        public Employee()
        {

        }

        public Employee(int empId,string name, int salary, string joiningDate)
        {
            this.name = name;
            this.salary = salary;
            this.joiningDate = joiningDate;
        }

        public void SetEmpData()
        {
            Console.WriteLine("Enter Id of Employee");
            empId =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of Employee");
            name = Console.ReadLine();
            Console.WriteLine("Enter the salary of Employee");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the joining Date");
            joiningDate = Console.ReadLine();

        }

        public void Display()
        {
            Console.WriteLine("Employee Id : " + empId);
            Console.WriteLine("Employee Name : "+name);
            Console.WriteLine("Salary : "+salary);
            Console.WriteLine("Date of Join : "+joiningDate);
        }
        public void HighSal(Employee e)
        {
            int max = e.salary;
            
        }

    }
}
