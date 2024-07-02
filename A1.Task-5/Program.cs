using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.Task_5
{
    class GradeCalculator
    {    
        //Task 5

        public double math, physics, chemistry, computerScience; // Declaring variables and storing it in double format
        public double CalculateAverage()                         // Function to calculate average marks
        {
            return (math + physics + chemistry + computerScience) / 4;
        }

        public string CalculateGrade(double averageMarks) 
        {
            // If/else statement are executing block of code dependending on the output of Calculate average function. 

            if (averageMarks >= 80)                               // If average marks is greater than/equal to 80 then it is considered an 'A'
                return "A";

            else if (averageMarks >= 70 && averageMarks <= 80)    // If average marks is between 70 to 80 then it is considered a 'B'
                return "B";

            else if (averageMarks >= 60 && averageMarks <= 70)    // If average marks is between 60 to 70 then it is considered a 'C'
                return "C";

            else if (averageMarks >= 50 && averageMarks <= 60)    // If average marks is between 50 to 60 then it is considered a 'B'
                return "D";

            else                                                  // If none of the above than the grade is consided 'F' 
                return "F";
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                try  // This code will prevent code from crashing due to invalid user input (i.e. characters or special lettters)
                {
                    GradeCalculator calculator = new GradeCalculator();                // References the class

                    Console.WriteLine("Enter marks for Math: ");                      // Prompt users to enter marks for Math
                    double math = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter marks for Physics: ");                  // Prompt users to enter marks for Physics
                    double physics = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter marks for Chemistry");                 // Prompt users to enter marks for Chemistry
                    double chemistry = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter marks for Computer Science: ");       // Prompt users to enter marks for Computer Science
                    double computerScience = Convert.ToDouble(Console.ReadLine());
 
                    double averageMarks = calculator.CalculateAverage();            // References the public CalculateAverage function
                    string grade = calculator.CalculateGrade(averageMarks);         // References the public CalculateGrade function

                    switch (grade)
                    {
                        case "A":
                            Console.WriteLine("Excellent! Your grade is A ");  // If grade is A then print "Excellent! Your grade is A"
                            break;
                        case "B":
                            Console.WriteLine("Good! Your grade is B ");       // If grade is B then print "Good! Your grade is B "
                            break;
                        case "C":
                            Console.WriteLine("Satisfactory. Your grade is C "); // If grade is C then print "Satisfactory. Your grade is C "
                            break;
                        case "D":
                            Console.WriteLine("Pass. Your grade is D ");        // If grade is D then print "Pass. Your grade is D "
                            break;
                        case "F":
                            Console.WriteLine("Fail. Your grade is F ");        // If grade is F then print "Fail. Your grade is F "
                            break;
                    }

                }
                catch (Exception)   // If user any character/special letters then display: "Invalid input. Please enter a valid number."
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                Console.ReadLine();

            }

        }
    }
}
