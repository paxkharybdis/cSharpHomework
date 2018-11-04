using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class AbstractSailBoat : AbstractBoat
    {
        private IBoat hull;
        private HullColor red;
        private Helm outboard;

        public AbstractSailBoat(IBoat hull, HullColor red, Helm outboard)
        {
            this.hull = hull;
            this.red = red;
            this.outboard = outboard;
        }

        public override decimal Price
        {
            get { return 1738.00m; }
        }

        public override void motorBoatInProgress()
        {

        }

        public override void sailBoatInProgress()
        {
            Console.WriteLine("Sailboat in progress.");
        }
    }
}
