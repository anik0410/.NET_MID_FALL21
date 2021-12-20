using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo : IRepository<News, int>
    {
        NewsPortalEntities db;
        public NewsRepo(NewsPortalEntities db)
        {
            this.db = db;
        }

        public bool Add(News e)
        {
            db.News.Add(e);
            return (db.SaveChanges() > 0);
        }

        public bool Delete(int id)
        {
            var news = db.News.FirstOrDefault(n => n.NewsId == id);
            db.News.Remove(news);
            return (db.SaveChanges() > 0);
        }

        public bool Edit(News e)
        {
            var news = db.News.FirstOrDefault(n => n.NewsId == e.NewsId);
            db.Entry(news).CurrentValues.SetValues(e);
            return (db.SaveChanges() > 0);
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(int id)
        {
            return db.News.FirstOrDefault(n => n.NewsId == id);
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
