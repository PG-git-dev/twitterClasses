using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClasses
{
    public class TweetComment
    {
        private DateTime tweetCommentDate;

        public TweetComment(string txt, Person author, Tweet tweet)
        {
            Text = txt;
            Author = author;
            Tweet = tweet;
            this.tweetCommentDate = DateTime.Now;
            Tweet.CommentsCount++;
            Author.CommentsCount++;
        }

        public string Text { get; }
        public Person Author { get; }
        public Tweet Tweet { get; }

    }
}
