using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverDesignPattern
{
    public class Subject
    {
        List<Observer> observers = new List<Observer>();

        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers(object arg)
        {
            observers.ForEach(observer => observer.Notify(arg));
        }
    }
}
