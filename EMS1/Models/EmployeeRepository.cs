using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EMS1.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext dbcontext;
        public EmployeeRepository(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public List<Employee> AddEmployee(Employee Employees)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllUsers()
        {
            return await dbcontext.Employees.ToListAsync();
        }

        public Employee GetEmployee(int v)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

     /*   public async Task<Employee> GetUser(int id)
        {
            return await dbcontext.Employees.Where(i => i.ID == id).FirstOrDefaultAsync();
        } */
    }
}

