using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class SailBoatBuilder : BoatBuilder
    {
        private AbstractSailBoat sailBoatInProgress;

        public override IBoat Boat
        {
            get { return sailBoatInProgress; }
        }

        public override void BuildBoatHull()
        {
            Console.WriteLine("Building sail boat hull.");
        }

        public override void BuildSail()
        {
            Console.WriteLine("Building sail boat sail.");
        }

        public override void BuildRudder()
        {
            Console.WriteLine("Building sail boat rudder.");
        }

        public override void BuildHelm()
        {
            Console.WriteLine("Building sail boat helm.");
        }

        /*public SailBoatBuilder(AbstractSailBoat sailBoat)
        {
            this.sailBoatInProgress = sailBoat;
        }*/
    }

}
