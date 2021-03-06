﻿using System;
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
        private Helm wheel;

        public AbstractMotorBoat(IBoat hull, HullColor white, Helm wheel)
        {
            this.hull = hull;
            this.white = white;
            this.wheel = wheel;
        }

        public override decimal Price
        {
            get { return 1000.00m; }
        }

        public override void motorBoatInProgress()
        {
            Console.WriteLine("Motor boat in progress.");
        }

        public override void sailBoatInProgress()
        {

        }
    }
}
