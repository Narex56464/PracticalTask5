using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task8
    {
        private int _x;
        private int _y;

        public Task8(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public bool ExpA()
        {
            return (_x >= 0) && (Math.Pow(_y, 2) != 4);
        }

        public bool ExpB()
        {
            return (_x * _y != 0) || (_y > _x);
        }
    }
}
