using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static ECMEntities db;
        public DataAccessFactory(ECMEntities db)
        {
            db = new ECMEntities();
        }
        public static IRepository<Product,int> ProductDataAccess()
        {
            return new ProductRepo(db);
        }
        public static IRepository<Customer,int> CustomerDataAccess()
        {
            return new CustomerRepo(db);
        }
    }
}
