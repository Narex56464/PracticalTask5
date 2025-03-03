using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task3
    {
        public bool ExpA(int x, int y)
        {
            return (!(x + y < 0)) && (y > x);
        }

        public bool ExpB(int x, int y)
        {
            return (x >= 2) || (Math.Pow(y, 2) != 5);
        }
    }
}
