using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task6
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }

        public Task6(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public bool ExpA()
        {
            return X || Y && !Z;
        }

        public bool ExpB()
        {
            return !X && !Y;
        }

        public bool ExpC()
        {
            return !(X && Z) || Y;
        }
    }
}
