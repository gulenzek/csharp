using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestOdev
{
    public class Car
    {
        private double _currentSpeed;
        private double _minSpeed = 0;
        private double _maxSpeed;
        private Way _way;
        private int _penaltyPoint;

        public int PenaltyPoint
        {
            get
            {
                return _penaltyPoint;
            }
        }

        public Car(double maxSpeed)
        {
            _maxSpeed = maxSpeed;
        }

        public Car(double maxSpeed, Way way)
        {
            _maxSpeed = maxSpeed;
            _way = way;
        }

        public void IncreaseSpeed(double speed)
        {
            if (speed <= 0)
                throw new ArgumentException("Speed value must be positive");

            CurrentSpeed += speed;
            if(_way.SpeedLimit < CurrentSpeed)
            {
                int speedDifference = (int)(CurrentSpeed - _way.SpeedLimit);

                _penaltyPoint = speedDifference * 5;
            }

        }

        public void ReduceSpeed(double speed)
        {
            if (speed <= 0)
                throw new ArgumentException("Speed value must be positive");
            CurrentSpeed -= speed;
        }

        private double CurrentSpeed {
            get {
                return _currentSpeed;
            }

            set
            {
                

                if(value >= _minSpeed && value <= _maxSpeed) {
                    _currentSpeed = value;
                }
                else 
                    throw new ArgumentException($"Speed must be between {_minSpeed} and {_maxSpeed}");
            }
        }

    }
}
