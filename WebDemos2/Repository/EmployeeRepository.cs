using WebDemos2.Contracts;
using WebDemos2.Infrastructure;

namespace WebDemos2.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected readonly FakeDBContext _dbContext = new FakeDBContext();
        protected readonly List<Employee> _table;

        public EmployeeRepository()
        {
            _table = _dbContext.GetTable();
        }
        public void Add(Employee employee)
        {
            _table.Add(employee);
        }
    }
}
