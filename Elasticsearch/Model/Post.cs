using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elasticsearch.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Index { get; set; }
        public string Type { get; set; }
    }
}
