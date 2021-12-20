using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductModel> GetAll()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().Get()); 
            return data;
        }
        public static List<string> GetNames()
        {
            var data = (from e in DataAccessFactory.ProductDataAccess().Get()
                        select e.Name).ToList();
            //data = ProductRepo.GetAll().Select(e => e.Name).ToList();
            return data;
        }
        public static void GetProductWithOrder()
        {

        }
    }
}
