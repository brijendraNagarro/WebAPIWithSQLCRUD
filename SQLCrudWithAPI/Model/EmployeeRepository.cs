
using Microsoft.EntityFrameworkCore;

namespace SQLCrudWithAPI.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _context;
        public EmployeeRepository(EmployeeDBContext dbContext) { 
            
            _context = dbContext;
        }
        public async Task Create(Employee employee)
        {
            employee.EmployeeID = 0;
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            if(entity != null)
            {
                _context.Employees.Remove(entity);
                await _context.SaveChangesAsync();  
            }
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task Update(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
