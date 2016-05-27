using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    public class Calculation
    {
        public double GetCurrentSpeed(string distance, string time)
        {
            double Distance = double.Parse(distance);
            double Time = double.Parse(time);
            return Distance/Time;
        }
    }
}
