using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    2. CDAC has certain number of batches. each batch has certain number of students
         accept number of batches from the user. for each batch accept number of students.
         create an array to store mark for each student. 
         accept the marks.
         display the marks.
 */
namespace Que2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of batches");
            int Batch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number of students");
            int Student = Convert.ToInt32(Console.ReadLine());

            int[,] CDAC = new int[Batch,Student];

            for(int i = 0; i<Batch; i++)
            {
                for(int j=0; j < Student; j++)
                {
                    Console.WriteLine("Enter the marks for batch number {0} of Student {1} : ",i+1,j+1);
                    CDAC[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            foreach(int x in CDAC)
            {
                Console.WriteLine("Marks of Students : {0} ", x);
            }

            Console.ReadLine();
        }
    }
}
