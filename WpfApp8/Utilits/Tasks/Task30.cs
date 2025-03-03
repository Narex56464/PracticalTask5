using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task30
    {
        private double _x;
        private double _y;

        public Task30(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public bool Exp()
        {
            return _y == (1) / Math.Pow(_x, 2);
        }
    }
}
