using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task7
    {
        private double _x;
        private double _y;

        public Task7(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public bool ExpA()
        {
            return _y == 2 * Math.Tan(_x);
        }

        public bool ExpB()
        {
            return _y == 3 / (_x - 1);
        }
    }
}
