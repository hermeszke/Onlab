using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public int Votes { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }

    }
}
