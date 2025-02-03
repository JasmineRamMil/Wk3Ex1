using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user to enter the numeric grade
            Console.Write("What is the Numeric score(0-100) ?");

            //Convert input to double 
            double grade = Convert.ToDouble(Console.ReadLine());

            //Getting the letterGrade
            string letterGrade;
            if (grade >= 89.5)
                letterGrade = "A";
            else if (grade >= 79.5)
                letterGrade = "B";
            else if (grade >= 69.5)
                letterGrade = "C";
            else if (grade >= 59.5)
                letterGrade = "D";
            else
                letterGrade = "F";
            //Display the lettergrade
            Console.WriteLine("Your letter grade is:" + letterGrade);

        }
    }
}
