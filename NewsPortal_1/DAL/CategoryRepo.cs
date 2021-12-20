using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo : IRepository<Category, int>
    {
        NewsPortalEntities db;
        public CategoryRepo(NewsPortalEntities db)
        {
            this.db = db;
        }
        public bool Add(Category e)
        {
            db.Categories.Add(e);
            return (db.SaveChanges() > 0);
        }

        public bool Delete(int id)
        {
            var category = db.Categories.FirstOrDefault(c =>c.CategoryId == id);
            db.Categories.Remove(category);
            return (db.SaveChanges() > 0);
        }

        public bool Edit(Category e)
        {
            var category = db.Categories.FirstOrDefault(c => c.CategoryId == e.CategoryId);
            db.Entry(category).CurrentValues.SetValues(e);
            return (db.SaveChanges() > 0);
        }

        public Category Get(int id)
        {
            return db.Categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
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
