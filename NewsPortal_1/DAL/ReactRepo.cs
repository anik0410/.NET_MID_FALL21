using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReactRepo : IRepository<React, int>
    {
        NewsPortalEntities db;
        public ReactRepo(NewsPortalEntities db)
        {
            this.db = db;
        }

        public bool Add(React e)
        {
            db.Reacts.Add(e);
            return (db.SaveChanges() > 0);
        }

        public bool Delete(int id)
        {
            var react = db.Reacts.FirstOrDefault(r => r.ReactId == id);
            db.Reacts.Remove(react);
            return (db.SaveChanges() > 0);
        }

        public bool Edit(React e)
        {
            var react = db.Reacts.FirstOrDefault(r => r.ReactId == e.ReactId);
            db.Entry(react).CurrentValues.SetValues(e);
            return (db.SaveChanges() > 0);
        }

        public List<React> Get()
        {
            return db.Reacts.ToList();
        }

        public React Get(int id)
        {
            return db.Reacts.FirstOrDefault(r => r.ReactId == id); ;
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
