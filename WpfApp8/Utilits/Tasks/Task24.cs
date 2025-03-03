using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task24
    {
        private int _a;

        public Task24(int a)
        {
            _a = a;
        }

        public bool Exp()
        {
            return (_a >= 1000 && _a <= 9999) && _a != 4999;
        }
    }
}
