using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task12
    {
        private int _a;

        public Task12(int a)
        {
            _a = a;
        }

        public bool Exp()
        {
            return (_a >= 100 && _a <= 999) || (_a <= -100 && _a >= -999);
        }
    }
}
