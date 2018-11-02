using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class BoatFactory
    {
        private void BoatBuilderPattern()
        {
            BoatBuilder builder = new MotorBoatBuilder();
            BoatDirector director = new MotorBoatDirector();
            IBoat boat = director.Build(builder);
            Console.WriteLine(boat);
        }
    }
}
