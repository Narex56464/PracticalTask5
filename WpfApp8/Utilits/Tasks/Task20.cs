using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task20
    {
        private double _x;
        private double _y;

        public Task20(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public bool ExpA()
        {
            return _y == 1 - Math.Cos(3 * _x);
        }

        public bool ExpB()
        {
            return _y == _x / (Math.Pow(_x - 3, 2));
        }
    }
}
