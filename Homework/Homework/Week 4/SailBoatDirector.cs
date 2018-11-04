using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class SailBoatDirector : BoatDirector
    {
        public override IBoat Build(BoatBuilder builder)
        {
            builder.BuildBoatHull();
            builder.BuildRudder();
            builder.BuildSail();
            builder.BuildHelm();
            return builder.Boat;
        }
    }
}
