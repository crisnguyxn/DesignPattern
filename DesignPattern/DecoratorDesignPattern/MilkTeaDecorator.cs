using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorDesignPattern
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;

        protected MilkTeaDecorator(IMilkTea wrappe)
        {
            _milkTea = wrappe;
        }

        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
