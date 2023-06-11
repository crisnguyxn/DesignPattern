using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorDesignPattern.decorators
{
    public class EggPudding : MilkTeaDecorator
    {
        public EggPudding(IMilkTea wrappe) : base(wrappe)
        {
        }

        public override double Cost()
        {
            return 3 + base.Cost();
        }
    }
}
