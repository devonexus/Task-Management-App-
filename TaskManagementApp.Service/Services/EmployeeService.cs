using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Models;
using Repository.Pattern.Repositories;
using TaskManagementApp.Repository.cs.Repositories;
using System.Data.Entity;

namespace TaskManagementApp.Service.Services
{
    public interface IEmployeeService : IService<employee> {
        List<employee> GetEmployee();
    }

    public class EmployeeService : Service<employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public List<employee> GetEmployee()
        {
            return _repository.GetEmployees().ToList();
        }

        public override void Delete(object id)
        {
            var source = _repository.Queryable()
                .AsNoTracking()
                .Where(m => m.employee_id == (int)id).SingleOrDefault();
            if (source != null) {
                base.Delete(source);
            }       
        }
    }
}
