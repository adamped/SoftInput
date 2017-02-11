using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SoftInput
{
    public class Tweet
    {
    }

    public class NormalTweet : Tweet
    {
    }

    public class PromotedTweet : Tweet
    {
    }

    public class Retweet : Tweet
    {

    }

    public class TweetTemplateSelector : DataTemplateSelector
    {
        public DataTemplate NormalTweetTemplate { get; set; }

        public DataTemplate PromotedTweetTemplate { get; set; }

        public DataTemplate RetweetTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is NormalTweet)
            {
                return NormalTweetTemplate;
            }

            if (item is PromotedTweet)
            {
                return PromotedTweetTemplate;
            }

            if (item is Retweet)
            {
                return RetweetTemplate;
            }

            return null;
        }
    }

}