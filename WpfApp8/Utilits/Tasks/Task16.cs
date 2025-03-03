using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task16
    {
        private int _x;
        private int _y;
        private int _z;

        public Task16(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public bool Exp()
        {
            return (_x % 5 == 0 && _y % 5 != 0 && _z % 5 != 0) ||
                   (_x % 5 != 0 && _y % 5 == 0 && _z % 5 != 0) ||
                   (_x % 5 != 0 && _y % 5 != 0 && _z % 5 == 0);
        }
    }
}
