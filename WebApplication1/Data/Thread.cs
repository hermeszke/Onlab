using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Thread
    {
        public Thread ()
        {
            this.Posts = new HashSet<Post>();
        }
        public int ThreadId { get; set; }
        public string ThreadName { get; set;}
        public string FirstPostHeadline { get; set; }
        public string FirstPostContent { get; set; }
        public string BannerPath { get; set; }


        public virtual ICollection<Post> Posts { get; set; }
        //public List<Post> Posts {get; set;}
    }
}
