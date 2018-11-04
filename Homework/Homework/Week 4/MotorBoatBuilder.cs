using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class MotorBoatBuilder : BoatBuilder
    {
        private AbstractMotorBoat motorBoatInProgress;
        private Hull fiberglass;
        private Helm wheel;
        private HullColor white;

        public MotorBoatBuilder(Hull fiberglass, Helm wheel, HullColor white)
        {
            this.fiberglass = fiberglass;
            this.wheel = wheel;
            this.white = white;
        }

        public override IBoat Boat
        {
            get { return motorBoatInProgress; }
        }

        public override void BuildBoatHull()
        {
            Console.WriteLine("Building " + Hull.fiberglass + " motor boat hull.");
        }

        public override void BuildMotor()
        {
            Console.WriteLine("Building motor boat motor.");
        }

        public override void BuildRudder()
        {
            Console.WriteLine("Building motor boat rudder.");
        }

        public override void BuildHelm()
        {
            Console.WriteLine("Building " + Helm.wheel + " style motor boat helm.");
        }

        /* public MotorBoatBuilder(AbstractMotorBoat motorBoat)
         {
             this.motorBoatInProgress = motorBoat;
         }*/
    }
}
