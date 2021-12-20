using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TierCore.Repository.Models;
using DAL;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>().ReverseMap());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().Get());

            return data;
        }
        public static List<string> GetNames()
        {
            var data = DataAccessFactory.ProductDataAccess().Get().Select(e => e.Name).ToList();
            
            return data;
        }
        public static void GetProductWithOrder()
        {

        }
    }
}
