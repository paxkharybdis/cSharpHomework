using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public interface IBoat
    {
        void BuildBoatHull(string hull);
        void AttachMotor(string motor);
        void AttachRudder(string rudder);

        HullColor ColorType { get; }
        decimal Price { get; }

    }
}
