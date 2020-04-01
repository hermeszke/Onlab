using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public string PostHeadline { get; set; }
        public string PostContent { get; set; }
        public int Votes { get; set; }
        public bool IsPinned { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }

        public int ThreadId { get; set; }
        public virtual Thread Thread { get; set; }
    }
}
