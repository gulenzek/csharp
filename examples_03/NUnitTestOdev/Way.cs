using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestOdev
{
    public class Way
    {
        private double _speedLimit;

        public double SpeedLimit
        {
            get
            {
                return _speedLimit;
            }
        }
        

        public Way(double speedLimit)
        {
            if (speedLimit < 0)
                throw new ArgumentException();
            _speedLimit = speedLimit;
        }
    }
}
