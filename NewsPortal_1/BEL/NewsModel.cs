﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NewsModel
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime DatePosted { get; set; }
        public string Category { get; set; }
        public int PosterId { get; set; }
        public virtual UserModel User { get; set; }
        public virtual List<CommentModel> Comments { get; set; }
        public virtual List<ReactModel> Reacts { get; set; }
    }
}
