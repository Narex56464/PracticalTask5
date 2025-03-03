using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task29
    {
        private double _x;
        private double _y;
        private double _c;

        public Task29(double x, double y, double c)
        {
            _x = x;
            _y = y;
            _c = c;
        }

        public bool Exp()
        {
            return _y == _c * Math.Tan(2 * _x);
        }
    }
}
