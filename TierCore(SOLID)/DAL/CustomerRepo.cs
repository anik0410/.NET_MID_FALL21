using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierCore.Repository;
using TierCore.Repository.Models;

namespace DAL
{
    public class CustomerRepo : IRepository<Customer, int>
    {
        ECMDbContext db;
        public CustomerRepo(ECMDbContext db)
        {
            this.db = db;
        }
        public void Add(Customer e)
        {
            db.Customers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = db.Customers.FirstOrDefault(e => e.Id == id);
            db.Customers.Remove(c);
            db.SaveChanges();
        }

        public void Edit(Customer customer)
        {
            var c = db.Customers.FirstOrDefault(en => en.Id == customer.Id);
            db.Entry(c).CurrentValues.SetValues(customer);
            db.SaveChanges();
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.FirstOrDefault(en => en.Id == id);
        }
    }
}
