using BusinessEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CategoryService
    {
        public static bool Add(CategoryModel categoryModel)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(categoryModel);
        }
    }
}
