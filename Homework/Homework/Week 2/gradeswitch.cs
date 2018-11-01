using System;

namespace Homework
{
    public class Gradeswitch
    {
        public void GradeMenu()
        {
            string grade = "k";

            do
            {
                // Display input request

                Console.WriteLine("Please enter a grade.");
                Console.Write("Choose from: E, V, G, A, F, or Q to quit:");

                // Input grade and assign to variable.
                grade = Console.ReadLine();
                Console.Clear();
                // Compare input to available choices and return appropriate response.
                switch (grade)
                {
                    case "E":
                    case "e":
                        Console.WriteLine("##########");
                        Console.WriteLine("Excellent");
                        Console.WriteLine("##########");
                        break;
                    case "V":
                    case "v":
                        Console.WriteLine("##########");
                        Console.WriteLine("Very Good");
                        Console.WriteLine("##########");
                        break;
                    case "G":
                    case "g":
                        Console.WriteLine("##########");
                        Console.WriteLine("Good");
                        Console.WriteLine("##########");
                        break;
                    case "A":
                    case "a":
                        Console.WriteLine("##########");
                        Console.WriteLine("Average");
                        Console.WriteLine("##########");
                        break;
                    case "F":
                    case "f":
                        Console.WriteLine("##########");
                        Console.WriteLine("Fail");
                        Console.WriteLine("##########");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("##########");
                        Console.WriteLine("Goodbye.");
                        Console.WriteLine("##########");
                        break;
                    default:
                        Console.WriteLine("##########");
                        Console.WriteLine("Please enter valid grade, or 'Q' to quit.");
                        Console.WriteLine("##########");
                        break;
                }

            } while (grade != "Q" && grade != "q");
        }
    }
}