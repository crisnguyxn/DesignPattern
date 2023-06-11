using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorDesignPattern.decorators
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea wrappe) : base(wrappe)
        {
        }

        public override double Cost()
        {
            return 1.5 + base.Cost();
        }
    }
}
