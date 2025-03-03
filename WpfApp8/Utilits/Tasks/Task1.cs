using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task1
    {
        public bool A {  get; set; }
        public bool B { get; set; }
        public bool C { get; set; }

        public Task1(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool ExpA()
        {
            return (A || !A && B) || C;
        }

        public bool ExpB()
        {
            return !A || A && (B || C);
        }

        public bool ExpC()
        {
            return (A || B && !C) && C;
        }
    }
}
