using e_commerce.Models.EF;
using e_commerce.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce.Repo
{
    public class ProductRepository
    {
        static ECMEntities db;
        static ProductRepository()
        {
            db = new ECMEntities();

        }
        public static ProductModel Get(int id)
        {
            //The below code is working for fetching data's from database
            var p = (from pr in db.Products
                    where pr.Id.Equals(id)
                    select pr).FirstOrDefault();

            //This code below is working for the application
            ProductModel pm = new ProductModel()
            {
                Id = p.Id,
                Category = p.Category,
                Name = p.Name,
                Price = p.Price
                
            };
            return pm;
        }
        public static List<ProductModel> GetAll()
        {
            var products = new List<ProductModel>();
            foreach(var p in db.Products)
            {
                ProductModel pm = new ProductModel()
                {
                    Id = p.Id,
                    Category = p.Category,
                    Name = p.Name,
                    Price = p.Price
                };
                products.Add(pm);
            }
            return products;

        }
    }
}