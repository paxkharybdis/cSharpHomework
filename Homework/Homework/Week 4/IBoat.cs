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
        void BuildMotor(string motor);
        void BuildRudder(string rudder);
        void BuildSail(string sail);

        HullColor ColorType { get; }
        Helm HelmType { get; }
        decimal Price { get; }

        void motorBoatInProgress();
        void sailBoatInProgress();

    }
}
