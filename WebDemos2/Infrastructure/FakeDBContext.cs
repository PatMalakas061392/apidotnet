namespace WebDemos2.Infrastructure
{
    public class FakeDBContext
    {

        public FakeDBContext() { 
        employees = new List<Employee>();
        }
        public List<Employee> employees {  get; set; }

        public List<Employee> GetTable()
        {
            return employees;
        }
    }
}
