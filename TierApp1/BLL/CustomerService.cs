using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL
{
    public class CustomerService
    {
        public static List<CustomerModel> GetAll()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CustomerModel>>(DataAccessFactory.CustomerDataAccess().Get());
            return data;
        }
        public static List<string> GetNames()
        {
            var data = (from e in DataAccessFactory.CustomerDataAccess().Get()
                        select e.Username).ToList();
            //data = ProductRepo.GetAll().Select(e => e.Name).ToList();
            return data;
        }
    }
}
