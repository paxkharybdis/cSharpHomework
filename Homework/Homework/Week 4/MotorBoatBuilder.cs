using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class MotorBoatBuilder : BoatBuilder
    {
        private readonly IBoat build;


        public override IBoat Boat
        {
            get { return motorBoatInProgress; }
        }

        public override void BuildBoatHull()
        {
            Console.WriteLine("Building Motorboat Hull");
        }

        public string MotorBoat
        {
            get { return "Motor boat hull finished."; }
        }

        public MotorBoatBuilder(BoatBuilder boat)
        {
            this.motorBoatInProgress = boat;
        }
    }
}
