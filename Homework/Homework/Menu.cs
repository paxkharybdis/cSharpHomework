using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class MenuDisplay
    {
        public MenuDisplay()
        {
            string menuInput;
            // Present menu.

            do
            {
                Console.Clear();
                Console.WriteLine("================================================");
                Console.WriteLine("Which C# code example would you like to execute?");
                Console.WriteLine("Week 1: Basic Class Functions.  (1)");
                Console.WriteLine("Week 2: Counting To Ten.        (2)");
                Console.WriteLine("Week 2: Display Grades.         (3)");
                Console.WriteLine("Week 3: Virtual Bicycle Shop    (4)");
                Console.WriteLine("Week 5: Welcome The Delegation  (5)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("================================================");
                Console.Write("Enter choice:");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("Basic Class Functions.");
                        Bicycle bicycle = new Bicycle();
                        bicycle.ShowAll();
                        break;
                    case "2":
                        Console.WriteLine("Count To Ten");
                        CountToTen counting = new CountToTen();
                        counting.Counting();
                        break;
                    case "3":
                        Console.WriteLine("The Great Grade Displayer!!");
                        Gradeswitch gradeswitch = new Gradeswitch();
                        gradeswitch.GradeMenu();
                        break;
                    case "4":
                        Console.WriteLine("Loading Virtual Bicycle Shop");
                        bicycle2 bicycle2 = new bicycle2();
                        bicycle2.bikeMenu();
                        break;
                    case "5":

                        break;
                }
            } while (true);
        }
    }
}




















