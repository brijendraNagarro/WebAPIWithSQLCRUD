using Microsoft.AspNetCore.Mvc;
using SQLCrudWithAPI.Model;

namespace SQLCrudWithAPI.Services
{
    public class EmplyeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmplyeeService(IEmployeeRepository repository) { 
            _employeeRepository = repository;
        }
        public async Task CreateEntityAsync(Employee employee)
        {

            await _employeeRepository.Create(employee);
        }

        public async Task DeleteEntityAsync(int id)
        {
            await _employeeRepository.Delete(id);   
        }

        public async Task<IEnumerable<Employee>> GetAllEntitiesAsync()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task<Employee> GetEntityByIdAsync(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task UpdateEntityAsync(Employee employee)
        {
            await _employeeRepository.Update(employee);
        }
    }
}
