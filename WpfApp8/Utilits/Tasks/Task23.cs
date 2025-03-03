using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task23
    {
        private int _a;

        public Task23(int a)
        {
            _a = a;
        }

        public bool Exp()
        {
            return (_a <= -1 && _a >= -10) || (_a >= 2 && _a <= 15);
        }
    }
}
