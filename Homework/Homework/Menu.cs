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
                Console.WriteLine("Week 1: Basic Class Functions.  (A)");
                Console.WriteLine("Week 2: Counting To Ten.        (B)");
                Console.WriteLine("Week 2: Display Grades.         (C)");
                Console.WriteLine("Week 3: Virtual Bicycle Shop.   (D)");
                Console.WriteLine("Week 4: Boat Builder.           (E)");
                Console.WriteLine("Week 5: Find Your Lucky Number. (F)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("================================================");
                Console.Write("Enter choice:");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("Basic Class Functions.");
                        Bicycle bicycle = new Bicycle();
                        bicycle.ShowAll();
                        break;
                    case "B":
                    case "b":
                        Console.WriteLine("Count To Ten");
                        CountToTen counting = new CountToTen();
                        counting.Counting();
                        break;
                    case "C":
                    case "c":
                        Console.WriteLine("The Great Grade Displayer!!");
                        Gradeswitch gradeswitch = new Gradeswitch();
                        gradeswitch.GradeMenu();
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Loading Virtual Bicycle Shop");
                        bicycle2 bicycle2 = new bicycle2();
                        bicycle2.bikeMenu();
                        break;
                    case "E":
                    case "e":
                        Console.WriteLine("Boaty McBoatface Factory");
                        BoatBuilder builder = new SailBoatBuilder();
                        BoatBuilder motorbuild = new MotorBoatBuilder();
                        break;
                    case "F":
                    case "f":
                        Console.WriteLine("Finding Your Lucky Number!");

                        break;
                }
            } while (true);
        }
    }
}




















