using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrateryDesignPattern.strategy
{
    public class NoDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double value)
        {
            return value;
        }
    }
}
