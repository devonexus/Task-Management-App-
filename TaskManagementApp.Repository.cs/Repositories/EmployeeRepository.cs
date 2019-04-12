using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using System.Linq;
using TaskManagementApp.Models;
using TrackableEntities.Common;
using Repository.Pattern.UnitOfWork;
using System.Data.Entity;

namespace TaskManagementApp.Repository.cs.Repositories
{
    public interface IEmployeeRepository : IRepositoryAsync<employee> {
        IQueryable<employee> GetEmployees();
    }


    public class EmployeeRepository : Repository<employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context, IUnitOfWorkAsync unitOfWork) : base(context, unitOfWork)
        {
        }

        public IQueryable<employee> GetEmployees()
        {
            return Queryable()
                .AsNoTracking()
                .OrderBy(m => m.first_name);
        }
    }
}
