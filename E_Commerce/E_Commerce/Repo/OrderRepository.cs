using e_commerce.Models.EF;
using e_commerce.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce.Repo
{
    public class OrderRepository
    {
        static ECMEntities db;
        static OrderRepository()
        {
            db = new ECMEntities();
        }
        public static void PlaceOrder(List<ProductModel> products, int cId)
        {
            Order o = new Order();
            o.CustomerId = cId;
            o.Status = "Ordered";
            db.Orders.Add(o);
            db.SaveChanges();
            foreach(var p in products)
            {
                var od = new OrderDetail
                {
                    ProductId = p.Id,
                    Quantity = 1,
                    Unitprice = p.Price,
                    OrderId = o.Id
                };
                db.OrderDetails.Add(od);
                db.SaveChanges();
            }
            
        }
        public static List<Order> MyOrders(int id)
        {
            return db.Orders.Where(e => e.Id.Equals(id)).ToList();
        }
    }
}