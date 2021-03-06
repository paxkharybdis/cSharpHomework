﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class MotorBoatDirector : BoatDirector
    {
        public override IBoat Build(BoatBuilder builder)
        {
            builder.BuildBoatHull();
            builder.BuildMotor();
            builder.BuildRudder();
            builder.BuildHelm();
            builder.ToString();
            return builder.Boat;
        }



    }
}
