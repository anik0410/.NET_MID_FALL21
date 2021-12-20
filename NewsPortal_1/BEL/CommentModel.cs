using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CommentModel
    {
        public int CommentId { get; set; }
        public string Comment1 { get; set; }
        public string CommenterName { get; set; }
        public int NewsId { get; set; }

        public virtual NewsModel News { get; set; }
    }
}
