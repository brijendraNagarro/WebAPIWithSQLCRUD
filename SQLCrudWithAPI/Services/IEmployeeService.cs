using SQLCrudWithAPI.Model;

namespace SQLCrudWithAPI.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEntitiesAsync();
        Task<Employee> GetEntityByIdAsync(int id);

        Task CreateEntityAsync(Employee employee);

        Task UpdateEntityAsync(Employee employee);
        Task DeleteEntityAsync(int id);
    }
}
