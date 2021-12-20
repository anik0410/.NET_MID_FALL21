using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL
{
    public class NewsService
    {
        public static bool Add(NewsModel newsModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NewsModel, News>());
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(newsModel);

            return DataAccessFactory.NewsDataAccess().Add(data);
        }
        public static bool Edit(NewsModel newsModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NewsModel, News>());
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(newsModel);

            return DataAccessFactory.NewsDataAccess().Edit(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.NewsDataAccess().Delete(id);
        }
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NewsModel, News>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(DataAccessFactory.NewsDataAccess().Get());

            return data;
        }
        public static List<NewsModel> Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NewsModel, News>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(DataAccessFactory.NewsDataAccess().Get(id));

            return data;
        }
    }
}
