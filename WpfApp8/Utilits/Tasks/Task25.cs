using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task25
    {
        private int _a;
        private int _b;
        private int _c;
        private int _d;

        public Task25(int a, int b, int c, int d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public bool Exp()
        {
            return ((_a / _b) > (_c / _d));
        }

        public string print()
        {
            if (Exp() == true)
                return "A/B больше C/D";
            else
                return "C/D больше A/B";
        }
    }
}
