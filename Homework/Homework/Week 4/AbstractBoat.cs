using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public abstract class AbstractBoat : IBoat
    {
        private HullColor _color;

        public HullColor ColorType
        {
            get { return _color; }
        }

        public void AttachMotor(string motor)
        {
            throw new NotImplementedException();
        }

        public void AttachRudder(string rudder)
        {
            throw new NotImplementedException();
        }

        public void BuildBoatHull(string hull)
        {
            throw new NotImplementedException();
        }

        public abstract decimal Price { get; }
    }
}
