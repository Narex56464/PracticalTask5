﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task14
    {
        private int _a;

        public Task14(int a)
        {
            _a = a;
        }

        public bool Exp()
        {
            return (_a % 3 != 0) && (_a % 10 != 0);
        }
    }
}
