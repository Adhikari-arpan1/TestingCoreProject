using AutoMapper;
using EBantan.DAL.Entities;
using EBantan.Models;

namespace EBantan.Helpers
{
    public class MapperClass : Profile
    {
        public MapperClass()
        {
            CreateMap<TestModel, Test>();
            CreateMap<Test, TestModel>();
        }
    }
}
