using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    3. Create a struct Student with the following properties. Put in appropriate validations.
    string Name 
    int RollNo
    decimal Marks

    Create a parameterized constructor.

    Create an array to accept details for 5 students
 */

namespace Que3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[5];

            Console.WriteLine("Enter the details of Student ");
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Enter the RollNo of Student : ");
                s[i].RollNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Name of Student : ");
                s[i].Name = Console.ReadLine();

                Console.WriteLine("Enter the Marks of Student : ");
                s[i].Marks = Convert.ToDecimal(Console.ReadLine());
            }


            //foreach(Student i in s)
            //{
            //    Console.WriteLine("Roll Number : "+s[i].RollNo);
            //}
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("RollNo : "+s[i].RollNo);
                Console.WriteLine("Name Of Student : "+s[i].Name);
                Console.WriteLine("Marks : "+s[i].Marks);
             
            }

            Console.ReadLine();
        }


        struct Student
        {
            private int rollNo;
            private string name;
            private decimal marks;

            public int RollNo
            {
                set
                {
                    if (value != 0)
                    {
                        rollNo = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid.....!");
                    }
                }

                get { return rollNo; }
            }

            public string Name
            {
                set
                {
                    if(value != "")
                    {
                        name = value;
                    }
                    else
                    {
                        Console.WriteLine("Can't be blank");
                    }
                }
                get{ return name; }
            }

            public decimal Marks
            {
                set
                {
                    if(value < 100)
                    {
                        marks = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid.......!");
                    }
                }

                get { return marks; }
            }

            Student(int rollNo, string name, decimal marks)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.marks = marks;
            }
        }
    }
}
