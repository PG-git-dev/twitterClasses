using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClasses
{
    public class Subscribe
    {
        //Person subscriber;
        //Person subscibesOn;

        public Subscribe(Person s1, Person s2)
        {
            if (s1.Equals(s2))
            {
                Console.WriteLine("Объект не создан, нельзя подписаться на себя!");
                Console.ReadKey();
            }
            else
            {
                Subscriber = s1;
                SubscribesOn = s2;
                Subscriber.SubscribesCount++;
                SubscribesOn.SubscribersCount++;
            }
        }

        public Person Subscriber { get; }
        public Person SubscribesOn { get; }

    }
}
