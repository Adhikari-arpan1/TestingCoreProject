using AutoMapper;
using EBantan.BAL.Interface;
using EBantan.DAL.Entities;
using EBantan.DAL.Interfaces;
using EBantan.Models;

namespace EBantan.BAL
{
    public class TestService : ITestServices
    {
        private readonly ITestRepo _testRepo;
        private readonly IMapper _mapper;
        public TestService(ITestRepo testRepo, IMapper mapper) { 
            _testRepo = testRepo;
            _mapper = mapper;
        }   
        public IEnumerable<TestModel> getTestData()
        {
            //Map TestModel to Test
            List<Test> resultSet = _testRepo.GetAll().ToList<Test>();
            return _mapper.Map<List<TestModel>>(resultSet);
        }
    }
}
