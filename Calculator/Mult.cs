﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Mult : ITwoArgumetsCalculate
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}

