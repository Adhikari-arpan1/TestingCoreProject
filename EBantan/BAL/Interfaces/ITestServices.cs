
using EBantan.Models;

namespace EBantan.BAL.Interface
{
    public interface ITestServices
    {
        public IEnumerable<TestModel> getTestData();
    }
}
