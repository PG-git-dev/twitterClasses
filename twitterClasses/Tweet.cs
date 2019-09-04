using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClasses
{
    public class Tweet
    {
        const int textLim = 140;
        #region Старое
        //string text;
        //public string authorNickName;
        //Person tweetAuthor;
        //private DateTime creationDate;
        //int viewsCount;
        //int likesCount;
        //int commentsCount;

        //public Tweet(string txt)
        //{
        //    this.text = StringHelper.Cut(txt, textLim);
        //    creationDate = DateTime.Now;
        //    tweetAuthor = new Person();
        //    tweetAuthor.TwitsCount++;
        //}
        #endregion
        public Tweet(Person author, string txt)
        {
            Text = StringHelper.Cut(txt, textLim);
            TweetAuthor = author;
            CreationDate = DateTime.Now;
            TweetAuthor.TweetsCount++;
        }

        public string Text { get; }
        public DateTime CreationDate { get; }
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public int ViewsCount { get; set; }
        public Person TweetAuthor { get; set; }

        public override string ToString() => Text;
    }
}
