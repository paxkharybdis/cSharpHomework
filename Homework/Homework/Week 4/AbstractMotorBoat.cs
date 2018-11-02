using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class AbstractMotorBoat : AbstractBoat
    {
        private IBoat hull;
        private HullColor white;

        public AbstractMotorBoat(IBoat hull)
            : this(hull, HullColor.White)
        { }

        public AbstractMotorBoat(IBoat hull, HullColor white)
        {
            this.hull = hull;
            this.white = white;
        }

        public override decimal Price
        {
            get { return 1000.00m; }
        }
    }
}
