using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task27
    {
        private double _x;
        private double _y;
        private double _b;

        public Task27(double x, double y, double b)
        {
            _x = x;
            _y = y;
            _b = b;
        }

        public bool ExpA()
        {
            return _x > 3 || _x < -1;
        }

        public bool ExpB()
        {
            return (-4 < _y && _y <= 2) && _b > 0;
        }
    }
}
