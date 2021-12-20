using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using AutoMapper;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductModel> GetAll()
        {
            var config = new MapperConfiguration(c => c.CreateMap < Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(ProductRepo.GetAll());
            return data;
        }
        public static List<string> GetNames()
        {
            /*var data = (from e in ProductRepo.GetAll()
                       select e.Name).ToList();*/
            var data = ProductRepo.GetAll().Select(e => e.Name).ToList();
            return data;
        }
        public static void GetProductWithOrder()
        {

        }
    }
}
