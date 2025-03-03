using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task5
    {
        private int _a;
        private int _b;

        public Task5(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public bool Exp()
        {
            return (_a % 2 != 0) && (_b % 2 != 0);
        }
    }
}
