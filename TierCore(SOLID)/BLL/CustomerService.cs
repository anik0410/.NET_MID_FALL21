using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TierCore.Repository.Models;

namespace BLL
{
    public class CustomerService
    {
        public static List<CustomerModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerModel>().ReverseMap());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CustomerModel>>(DataAccessFactory.CustomerDataAccess().Get());

            return data;

        }
    }
}
