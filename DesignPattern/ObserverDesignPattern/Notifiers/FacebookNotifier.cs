using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.ObserverDesignPattern;

namespace DesignPattern.ObserverDesignPattern.Notifiers
{
    public class FacebookNotifier : Observer
    {
        public FacebookNotifier(Subject subject)
        {
            Subject = subject;
            Subject.addObserver(this);
        }
        public override void Notify(object arg)
        {
            if (Subject is VideoData videoData)
            {
                Console.WriteLine(
                    "\n\t FACEBOOK NOTIFICATION" +
                    "\n\t Name: {0}" +
                    "\n\t Description: {1}" +
                    "\n\t FileName: {2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName());
            }
        }
    }
}
