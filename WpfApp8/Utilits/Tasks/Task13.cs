using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task13
    {
        private int _a;
        private int _b;
        private int _c;

        public Task13(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public bool Exp()
        {
            return (_a > 45 && _b > 45 && _c < 45) ||
                   (_a > 45 && _b < 45 && _c > 45) ||
                   (_a < 45 && _b > 45 && _c > 45);
        }
    }
}
