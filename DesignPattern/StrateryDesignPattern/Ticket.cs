using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DesignPattern.StrateryDesignPattern
{
    internal class Ticket
    {
        private int _id;
        private string _name;
        private IPromoteStrategy _promoteStrategy;
        private double _price;
        public Ticket(int id, string name, IPromoteStrategy promoteStrategy,double price)
        {
            this._id = id;
            this._name = name;
            this._promoteStrategy = promoteStrategy;
            this._price = price;
        }
        public Ticket()
        {

        }
        public void SetId(int id)
        {
            this._id = id;
        }
        public int getId()
        {
            return _id;
        }
        public void SetName(string name)
        {
            this._name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetPromoteStrategy(IPromoteStrategy promoteStrategy)
        {
            this._promoteStrategy = promoteStrategy;
        }
        public IPromoteStrategy GetPromoteStrategy()
        {
            return _promoteStrategy;
        }

        public void SetPrice(double price)
        {
            this._price = price;
        }
        public double GetPrice()
        {
            return _promoteStrategy.DoDiscount(_price);
        }

        internal void SetPromoteStrategy()
        {
            throw new NotImplementedException();
        }
    }
}
