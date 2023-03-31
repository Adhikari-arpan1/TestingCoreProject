using EBantan.DAL.Entities;
using EBantan.DAL.Interfaces;

namespace EBantan.DAL
{
    public class TestRepo : Repository<Test, EBantanDBContext>, ITestRepo
    {
        public TestRepo(EBantanDBContext context) : base(context)
        {
        }
    }
}
