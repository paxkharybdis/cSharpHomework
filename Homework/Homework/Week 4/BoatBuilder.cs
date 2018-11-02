using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public abstract class BoatBuilder
    {
        public abstract IBoat Boat { get; }

        public virtual void BuildBoatHull()
        {
            Console.WriteLine("Building Boat Hull.");
        }


    }
}
