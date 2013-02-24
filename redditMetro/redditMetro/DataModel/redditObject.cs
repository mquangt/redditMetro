using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace redditMetro.DataModel
{
    
    [DataContract]
    public class redditObject
    {
        [DataMember]
        public string kind { get; set; }
        [DataMember]
        public redditData data { get; set; }
    }
    
}
