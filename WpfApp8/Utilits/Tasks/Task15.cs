using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task15
    {
        private int _a;

        public Task15(int a)
        {
            _a = a;
        }

        public bool Exp()
        {
            return (_a <= -51 && _a >= -137) || (_a >= 55 && _a <= 123);
        }
    }
}
