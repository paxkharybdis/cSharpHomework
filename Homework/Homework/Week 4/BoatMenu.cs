using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class BoatMenu
    {

        public static void TheMenu()
        {


            Console.Clear();
            Console.WriteLine("############################################################");
            Console.WriteLine("I see you wish to build a motor boat.");
            Console.WriteLine("##############################");
            BoatBuilder builder = new MotorBoatBuilder(Hull.fiberglass, Helm.wheel, HullColor.White);
            BoatDirector director = new MotorBoatDirector();
            IBoat boat = director.Build(builder);
            Console.WriteLine("############################################################");
            Console.WriteLine("Your new motor boat is ready.");
            Console.WriteLine("############################################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("############################################################");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.WriteLine("############################################################");
            Console.WriteLine();
            Console.ReadLine();

        }

    }
}
