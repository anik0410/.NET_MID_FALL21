using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static BlogsDbEntities db;
        static DataAccessFactory()
        {
            db = new BlogsDbEntities();
        }
        public static IAuth AuthDataAccess()
        {
            return new AuthRepo(db);
        }
    }
}
