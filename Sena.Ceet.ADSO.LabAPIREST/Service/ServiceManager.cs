using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class ServiceManager : IServiceManager
    {
        public readonly Lazy<ICompanyService> _companyService;
        public readonly Lazy<IEmployeeService> _employeeService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger)
        {
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repository, logger));
            _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repository, logger));
        }

        public ICompanyService CompanyService => throw new NotImplementedException();

        public IEmployeeService EmployeeService => throw new NotImplementedException();
    }
}
