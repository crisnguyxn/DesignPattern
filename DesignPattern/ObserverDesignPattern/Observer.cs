﻿namespace DesignPattern.ObserverDesignPattern
{
    public abstract class Observer
    {
        protected Subject Subject;
        public abstract void Notify(object arg);
    }
}