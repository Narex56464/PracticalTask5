using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task22
    {
        private double _x;
        private double _y;
        private double _b;

        public Task22(double x, double y, double b)
        {
            _x = x;
            _y = y;
            _b = b;
        }

        public bool ExpA()
        {
            return !(_x <= 5) && _x > 5;
        }

        public bool ExpB()
        {
            return (-3.5 < _y && _y <= 8.1) && _b != 0;
        }
    }
}
