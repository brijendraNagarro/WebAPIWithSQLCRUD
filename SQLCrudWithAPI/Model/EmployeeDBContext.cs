using Microsoft.EntityFrameworkCore;

namespace SQLCrudWithAPI.Model
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> opt):base(opt)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
