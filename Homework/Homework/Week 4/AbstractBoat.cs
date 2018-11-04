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
        private Helm _helmtype;
        private Hull _hulltype;

        public abstract void motorBoatInProgress();

        public abstract void sailBoatInProgress();

        public abstract decimal Price { get; }

        public HullColor ColorType
        {
            get { return _color; }
        }

        public Helm HelmType
        {
            get { return _helmtype; }
        }

        public Hull HullType
        {
            get { return _hulltype; }
        }
        public override string ToString()
        {
            return this.GetType().Name +
                "Boat has a" + _hulltype + " and the color is " + _color + " and it costs $" + Price;
        }

        public void BuildMotor(string motor)
        {

        }

        public void BuildRudder(string rudder)
        {

        }

        public void BuildBoatHull(string hull)
        {

        }

        public void BuildSail(string sail)
        {

        }


    }
}
