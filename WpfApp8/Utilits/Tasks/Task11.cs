﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Utilits.Tasks
{
    public class Task11
    {
        private int _x;
        private int _y;

        public Task11(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public bool ExpA()
        {
            return (!(_x * _y < 1)) & (_y > _x);
        }

        public bool ExpB()
        {
            return (_x * _y != 0) || (_y < _x);
        }
    }
}
