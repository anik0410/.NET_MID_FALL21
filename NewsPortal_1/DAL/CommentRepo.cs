using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommentRepo : IRepository<Comment, int>
    {
        NewsPortalEntities db;
        public CommentRepo(NewsPortalEntities db)
        {
            this.db = db;
        }
        public bool Add(Comment e)
        {
            db.Comments.Add(e);
            return (db.SaveChanges() > 0);
        }

        public bool Delete(int id)
        {
            var comment = db.Comments.FirstOrDefault(c => c.CommentId == id);
            db.Comments.Remove(comment);
            return (db.SaveChanges() > 0);
        }

        public bool Edit(Comment e)
        {
            var comment = db.Comments.FirstOrDefault(c => c.CommentId == e.CommentId);
            db.Entry(comment).CurrentValues.SetValues(e);
            return (db.SaveChanges() > 0);
        }

        public List<Comment> Get()
        {
            return db.Comments.ToList();
        }

        public Comment Get(int id)
        {
            return db.Comments.FirstOrDefault(c => c.CommentId == id);
        }

        public List<News> GetByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public List<News> GetByDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public List<News> GetByDateCategory(DateTime dateTime, string category)
        {
            throw new NotImplementedException();
        }
    }
}
