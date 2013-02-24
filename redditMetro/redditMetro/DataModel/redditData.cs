using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace redditMetro.DataModel
{
    [DataContract]
   public class redditData : Object
    {
        [DataMember]
        public string modhash { get; set; }
        [DataMember]
        public redditObject[] children { get; set; }
        [DataMember]
        public string kind { get; set; }
        [DataMember]
        public string domain { get; set; }
        [DataMember]
        public object media_embed { get; set; }
        [DataMember]
        public string levenshtein { get; set; }
        [DataMember]
        public string subreddit { get; set; }
        [DataMember]
        public string selftext_html { get; set; }
        [DataMember]
        public string selftext { get; set; }
        [DataMember]
        public string likes { get; set; }
        [DataMember]
        public string saved { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string clicked { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public object media { get; set; }
        [DataMember]
        public string score { get; set; }
        [DataMember]
        public string over_18 { get; set; }
        [DataMember]
        public string hidden { get; set; }
        [DataMember]
        public string thumbnail { get; set; }
        [DataMember]
        public string subreddit_id { get; set; }
        [DataMember]
        public string author_flair_css_class { get; set; }
        [DataMember]
        public string downs { get; set; }
        [DataMember]
        public string is_self { get; set; }
        [DataMember]
        public string permalink { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string created { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string author_flair_text { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public string created_utc { get; set; }
        [DataMember]
        public string num_comments { get; set; }
        [DataMember]
        public string ups { get; set; }
        public override string ToString()
        {
            return title;
        }
    }
}
