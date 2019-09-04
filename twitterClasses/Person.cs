using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClasses
{
    public class Person
    {
        #region Поля класса старые
        //==========================================
        //данные поля можно не вводить, т.к. они реализованы соответствующими автосвойствами
        //string name;
        //string surname;
        //string nickName;
        //DateTime birthDay;
        //int twitsCount;
        //int subscribesCount;
        //int subscribersCount;
        //int commentsCount;
        //==========================================
        #endregion

        #region Конструктор по умолчанию старый
        //public Person_old()
        //{
        //    this.name = "NoName";
        //    this.surname = "NoName";
        //    this.nickName = "Unknown";
        //    this.birthDay = new DateTime(1900,01,01);
        //    this.twitsCount = 0;
        //    this.subscribesCount = 0;
        //    this.subscribersCount = 0;
        //}
        #endregion


        public Person()
        {
            Name = "NoName";
            Surname = "NoSurname";
            NickName = "unknown";
            BirthDay = new DateTime(1900, 01, 01);
            TweetsCount = 0;
            SubscribesCount = 0;
            SubscribersCount = 0;
            CommentsCount = 0;
        }

        #region Конструктор с 1 параметром подробно (старый)
        //public Person_old(string name)
        //{
        //    this.name = name;
        //    this.surname = "NoName";
        //    this.nickName = "Unknown";
        //    this.birthDay = new DateTime(1900, 01, 01);
        //    this.twitsCount = 0;
        //    this.subscribesCount = 0;
        //    this.subscribersCount = 0;
        //}
        #endregion

        public Person(string name)
            : this() => Name = name;

        #region Конструктор с 2 параметрами подробно (старый)
        //public Person_old(string name, string surname)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.nickName = "Unknown";
        //    this.birthDay = new DateTime(1900, 01, 01);
        //    this.twitsCount = 0;
        //    this.subscribesCount = 0;
        //    this.subscribersCount = 0;
        //}
        #endregion

        public Person(string name, string surname)
            : this(name) => Surname = surname;

        #region Конструктор с 3 параметрами подробно (старый)
        //public Person_old(string name, string surname, string nick)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.nickName = nick;
        //    this.birthDay = new DateTime(1900, 01, 01);
        //    this.twitsCount = 0;
        //    this.subscribesCount = 0;
        //    this.subscribersCount = 0;
        //}
        #endregion

        public Person(string name, string surname, string nick)
            : this(name, surname) => NickName = nick;

        #region Конструктор с 4 параметрами подробно (старый)
        //public Person_old(string name, string surname, string nick, DateTime birthDay)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.nickName = nick;
        //    this.birthDay = birthDay;
        //    this.twitsCount = 0;
        //    this.subscribesCount = 0;
        //    this.subscribersCount = 0;
        //}
        #endregion

        public Person(string name, string surname, string nick, DateTime birthday)
            : this(name, surname, nick) => BirthDay = birthday;

        #region ToTweet старый
        //public Tweet ToTweet(string txt)
        //{
        //    return new Tweet(this, txt);
        //}
        #endregion

        public Tweet ToTweet(string txt) => new Tweet(this, txt);

        #region ToSubscribe старый
        //public Subscribe ToSubscribe(Person author)
        //{
        //    //subscribesCount++;
        //    return new Subscribe(this, author);
        //}
        #endregion

        public Subscribe ToSubscribe(Person author) => new Subscribe(this, author);

        #region Свойства полей старые
        //=================================================================
        //не нужны, т.к. определены автосвойства
        //public int SubscribesCount
        //{
        //    get
        //    {
        //        return this.subscribesCount;
        //    }
        //    set
        //    {
        //        this.subscribesCount = value;
        //    }
        //}

        //public int TwitsCount
        //{
        //    get
        //    {
        //        return this.twitsCount;
        //    }

        //    set
        //    {
        //        this.twitsCount = value;
        //    }
        //}
        //public int SubscribersCount
        //{
        //    get
        //    {
        //        return this.subscribersCount;
        //    }
        //    set
        //    {
        //        this.subscribersCount = value;

        //    }
        //}

        //public string NickName
        //{
        //    get
        //    {
        //        return this.nickName;
        //    }
        //}
        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //}
        //public string Surname
        //{
        //    get
        //    {
        //        return this.surname;
        //    }
        //}
        //public DateTime Birthday
        //{
        //    get
        //    {
        //        return this.birthDay;
        //    }
        //}
        //public int CommentsCount
        //{
        //    get
        //    {
        //        return this.CommentsCount;
        //    }
        //    set
        //    {
        //        this.CommentsCount = value;
        //    }
        //}
        //=================================================================
        #endregion

        #region Автосвойства
        public string Name { get; }
        public string Surname { get; }
        public string NickName { get; }
        public DateTime BirthDay { get; }
        public int SubscribesCount { get; set; }
        public int SubscribersCount { get; set; }
        public int TweetsCount { get; set; }
        public int CommentsCount { get; set; }
        #endregion


        public void Print()
        {
            #region старый формат вывода
            //Console.WriteLine("Имя: {0}\n" +
            //                    "Фамилия: {1}\n" +
            //                    "Ник: {2}\n" +
            //                    "Дата рождения: {3}\n" +
            //                    "Количество твитов: {4}\n" +
            //                    "Количество подписок: {5}\n" +
            //                    "Количество подписчиков {6}\n", name, surname, nickName, 
            //                    birthDay, twitsCount, subscribesCount, subscribersCount);
            #endregion

            Console.WriteLine($@"Имя: {Name}
Фамилия__: {Surname}
Ник: {NickName}
Дата рождения: {BirthDay}
Количество твитов: {TweetsCount}
Количество подписок: {SubscribesCount}
Количество подписчиков {SubscribersCount}
Количество комментариев {CommentsCount}");

            Console.ReadKey();
        }
        #region ToLike старый
        //public void ToLike(Tweet tweet)
        //{
        //    tweet.LikesCount++;
        //}
        #endregion

        public void ToLike(Tweet tweet) => tweet.LikesCount++;

        #region ToComment старый
        //public TweetComment ToComment(string txt, Tweet tweet)
        //{
        //    return new TweetComment_old(txt, this, tweet);
        //}
        #endregion

        public TweetComment ToComment(string txt, Tweet tweet) => new TweetComment(txt, this, tweet);

        #region Equals старый
        //public override bool Equals(object obj)
        //{
        //    return this.nickName == ((Person)obj).NickName;
        //}
        #endregion

        public override bool Equals(object obj) => this.NickName == ((Person)obj).NickName;
    }
}
