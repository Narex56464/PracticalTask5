using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task17
    {
        private int _x;
        private int _y;
        private int _z;

        public Task17(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public bool Exp()
        {
            int count = 0;

            if (_x > 80)
                ++count;
            if(_y > 80)
                ++count;
            if(_z > 80)
                ++count;

            return count > 0;
        }
    }
}
