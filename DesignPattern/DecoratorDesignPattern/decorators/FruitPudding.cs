using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorDesignPattern.decorators
{
    public class FruitPudding : MilkTeaDecorator
    {
        public FruitPudding(IMilkTea wrappe) : base(wrappe)
        {
        }

        public override double Cost()
        {
            return 3 + base.Cost();
        }
    }
}
