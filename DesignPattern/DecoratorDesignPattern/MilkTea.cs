﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorDesignPattern
{
    public class MilkTea : IMilkTea
    {
        public double Cost()
        {
            return 5;
        }
    }
}
