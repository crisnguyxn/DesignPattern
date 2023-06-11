using DesignPattern.DecoratorDesignPattern;
using DesignPattern.DecoratorDesignPattern.decorators;
using DesignPattern.ObserverDesignPattern;
using DesignPattern.ObserverDesignPattern.Notifiers;
using DesignPattern.StrateryDesignPattern;
using DesignPattern.StrateryDesignPattern.strategy;
using System.Net.WebSockets;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRATEGY DESIGN PATTERN
            
            Random random = new Random();
            Console.WriteLine("---------Promote Strategy----------");
            for (int i = 1;i < 4; i++)
            {
                Ticket ticket = new Ticket();
                ticket.SetId(i);
                ticket.SetName("ticket " + i);
                ticket.SetPrice(50.00 * i);
                int randomIdx = random.Next(0, 3);
                switch(randomIdx)
                {
                    case 0:
                        ticket.SetPromoteStrategy(new NoDiscountStrategy());
                        break;
                    case 1:
                        ticket.SetPromoteStrategy(new HaftDiscountStrategy());
                        break;
                    default:
                        ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
                        break;
                }
                Console.WriteLine(ticket.GetName());
                Console.WriteLine(ticket.GetPrice());
                Console.WriteLine(ticket.GetPromoteStrategy().GetType().Name);
            }


            // OBSERVER DESIGN PATTERN

            VideoData videoData = new VideoData();
            _ = new YoutubeNotifier(videoData);
            var facebookNotifier = new FacebookNotifier(videoData);
            _ = new PhoneNotifier(videoData);

            Console.WriteLine("-----------------------");
            videoData.SetDescription("check descriptions");

            Console.WriteLine("-----------------------");
            videoData.removeObserver(facebookNotifier);
            videoData.SetDescription("check descriptions");


            //DECORATOR DESIGN PATTERN

            var milkTea1 = new EggPudding(new FruitPudding(new BlackSugar(new Bubble(new MilkTea()))));
            Console.WriteLine("milkTea1 " +milkTea1.Cost());
            var milkTea2 = new EggPudding(new BlackSugar(new WhiteBubble(new MilkTea())));
            Console.WriteLine("milkTea2 " + milkTea2.Cost());
        }
    }
}