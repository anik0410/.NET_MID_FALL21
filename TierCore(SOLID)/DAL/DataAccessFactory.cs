using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierCore.Repository;
using TierCore.Repository.Models;

namespace DAL
{
    public class DataAccessFactory
    {
        static ECMDbContext db;
        static DataAccessFactory()
        {
            db = new ECMDbContext();
        }
        public static IRepository<Product,int> ProductDataAccess()
        {
            /*ProductRepo pr = new ProductRepo(db);
            return pr;*/
            return new ProductRepo(db);
        }
        public static IRepository<Customer,int> CustomerDataAccess()
        {
            return new CustomerRepo(db);
        }
        /*public static IRepository<Order,int> OrderDataAccess()
        {

        }*/
    }
}
