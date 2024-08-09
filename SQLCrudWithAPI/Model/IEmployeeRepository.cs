namespace SQLCrudWithAPI.Model
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
        Task<IEnumerable<Employee>> GetAll();

        Task Create(Employee employee);
        Task Update(Employee employee);
        Task Delete(int id);
    }
}
