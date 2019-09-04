using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person h1 = new Person();
            Person h2 = new Person("Ivan", "Ivanov", "Vanja", new DateTime(1990,05,15));
            h1.ToSubscribe(h2);
            //h1.ToSubscribe(h1);
            h1.Print();
            h2.Print();
            Tweet tw1 = new Tweet(h1, "Опggпозиционный политик и главный оппонент действующего главы государства Сооронбая Жээнбекова на последних президентских выборах Омурбек Бабанов вернулся в Киргизию");
            Tweet tw2 = h2.ToTweet("В связи с нестабильностью национальной валюты Украины просим провести денежную реформу, заменив национальную валюту Украины гривну на более стабильную — доллар США с пересчетом цен, тарифов, окладов заработной платы, стипендий, пенсий, средств на счетах предприятий, учреждений и организаций, а также вкладов граждан");
            Tweet tw3 = h2.ToTweet("fffffffff");
            Console.WriteLine("строка:\n{0}\nдлина строки - {1} ", tw1.Text, tw1.Text.Length);
            h2.ToComment("comment1", tw1);
            h2.ToSubscribe(h1);
            h1.Print();
            h2.Print();
            Console.WriteLine(tw3.ToString());

            Console.ReadKey();
        }
    }
}
