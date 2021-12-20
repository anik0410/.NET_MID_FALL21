using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static ECMEntities db;
        static ProductRepo()
        {
            db = new ECMEntities();
        }
        public static List<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public static Product Get(int id)
        {
            return db.Products.FirstOrDefault(e => e.Id == id);
        }
        public static void Edit(Product p)
        {
            var pr = db.Products.FirstOrDefault(e => e.Id == p.Id);
            db.Entry(pr).CurrentValues.SetValues(p);
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var pr = db.Products.FirstOrDefault(e => e.Id == id);
            db.Products.Remove(pr);
            db.SaveChanges();
        }
    }
}
