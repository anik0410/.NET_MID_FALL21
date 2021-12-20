﻿using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class CategoryService
    {
        public static bool Add(CategoryModel categoryModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(categoryModel);

            return DataAccessFactory.CategoryDataAccess().Add(data);
        }
        public static bool Edit(CategoryModel categoryModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(categoryModel);

            return DataAccessFactory.CategoryDataAccess().Edit(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.CategoryDataAccess().Delete(id);
        }
        public static List<CategoryModel> Get()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CategoryModel>>(DataAccessFactory.CategoryDataAccess().Get());

            return data;
        }
        public static List<CategoryModel> Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CategoryModel>>(DataAccessFactory.CategoryDataAccess().Get(id));

            return data;
        }
    }
}
