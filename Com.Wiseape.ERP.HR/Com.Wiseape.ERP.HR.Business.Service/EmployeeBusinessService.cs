using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.HR.Repository.Contract;
using Com.Wiseape.ERP.HR.Business.Contract;



namespace Com.Wiseape.ERP.HR.Business.Service
{
    /// <summary>
    /// Business Service for Employee module.
    /// </summary>
    public class EmployeeBusinessService : BaseBusinessService<Employee>, IEmployeeBusinessService
    {
        class Keywords
        {
            public static string Employee = "HR.Employee";
        }

        /// <summary>
        /// Constructor for EmployeeBusinessService
        /// </summary>
        /// <param name="repoKey">Key for Repository to use by this Business Service</param>
        public EmployeeBusinessService(string repoKey) : base(repoKey)
        {
        }

        /// <summary>
        /// Finds all Employee data with livingAddress containing specified keyword
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByLivingAddress(string livingAddress)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByLivingAddress(livingAddress);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's livingAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="livingAddress">living Address</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateLivingAddress(Int16 idEmployee, string livingAddress)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateLivingAddress(idEmployee, livingAddress);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by livingAddress
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByLivingAddress(string livingAddress)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByLivingAddress(livingAddress);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with homeAddress containing specified keyword
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByHomeAddress(string homeAddress)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByHomeAddress(homeAddress);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's homeAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homeAddress">home Address</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateHomeAddress(Int16 idEmployee, string homeAddress)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateHomeAddress(idEmployee, homeAddress);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by homeAddress
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByHomeAddress(string homeAddress)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByHomeAddress(homeAddress);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with homePhone containing specified keyword
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByHomePhone(string homePhone)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByHomePhone(homePhone);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's homePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homePhone">home Phone</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateHomePhone(Int16 idEmployee, string homePhone)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateHomePhone(idEmployee, homePhone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by homePhone
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByHomePhone(string homePhone)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByHomePhone(homePhone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with mobilePhone containing specified keyword
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByMobilePhone(string mobilePhone)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByMobilePhone(mobilePhone);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's mobilePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateMobilePhone(Int16 idEmployee, string mobilePhone)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateMobilePhone(idEmployee, mobilePhone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by mobilePhone
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByMobilePhone(string mobilePhone)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByMobilePhone(mobilePhone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with email containing specified keyword
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByEmail(string email)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByEmail(email);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's email which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="email">email</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateEmail(Int16 idEmployee, string email)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateEmail(idEmployee, email);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByEmail(string email)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByEmail(email);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with employeeNo containing specified keyword
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByEmployeeNo(string employeeNo)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByEmployeeNo(employeeNo);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's employeeNo which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="employeeNo">employee No</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateEmployeeNo(Int16 idEmployee, string employeeNo)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateEmployeeNo(idEmployee, employeeNo);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by employeeNo
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByEmployeeNo(string employeeNo)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByEmployeeNo(employeeNo);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with identityNumber containing specified keyword
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByIdentityNumber(string identityNumber)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByIdentityNumber(identityNumber);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's identityNumber which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateIdentityNumber(Int16 idEmployee, string identityNumber)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateIdentityNumber(idEmployee, identityNumber);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by identityNumber
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByIdentityNumber(string identityNumber)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByIdentityNumber(identityNumber);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with firstName containing specified keyword
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByFirstName(string firstName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByFirstName(firstName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's firstName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="firstName">first Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateFirstName(Int16 idEmployee, string firstName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateFirstName(idEmployee, firstName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by firstName
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByFirstName(string firstName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByFirstName(firstName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with middleName containing specified keyword
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByMiddleName(string middleName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByMiddleName(middleName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's middleName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="middleName">middle Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateMiddleName(Int16 idEmployee, string middleName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateMiddleName(idEmployee, middleName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by middleName
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByMiddleName(string middleName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByMiddleName(middleName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with lastName containing specified keyword
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByLastName(string lastName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByLastName(lastName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's lastName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="lastName">last Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateLastName(Int16 idEmployee, string lastName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateLastName(idEmployee, lastName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by lastName
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByLastName(string lastName)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByLastName(lastName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with birthDate1, birthDate2 containing specified keyword
        /// </summary>
        /// <param name="birthDate1">birth Date1</param>
        /// <param name="birthDate2">birth Date2</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByBirthDateBetween(DateTime birthDate1, DateTime birthDate2)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByBirthDateBetween(birthDate1, birthDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's birthDate which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthDate">birth Date</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateBirthDate(Int16 idEmployee, DateTime birthDate)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateBirthDate(idEmployee, birthDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by birthDate
        /// </summary>
        /// <param name="birthDate">birth Date</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByBirthDate(DateTime birthDate)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByBirthDate(birthDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderId(Int16 genderId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderId(genderId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderId(Int16 idEmployee, Int16 genderId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderId(idEmployee, genderId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderId(Int16 genderId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderId(genderId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId, organizationId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderIdAndOrganizationId(genderId, organizationId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId, organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderIdAndOrganizationId(Int16 idEmployee, Int16 genderId, Int16 organizationId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderIdAndOrganizationId(idEmployee, genderId, organizationId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId, organizationId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderIdAndOrganizationId(genderId, organizationId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, isActive containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderIdAndOrganizationIdAndIsActive(genderId, organizationId, isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderIdAndOrganizationIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderIdAndOrganizationIdAndIsActive(idEmployee, genderId, organizationId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderIdAndOrganizationIdAndIsActive(genderId, organizationId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(genderId, organizationId, isActive, birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(idEmployee, genderId, organizationId, isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(genderId, organizationId, isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderIdAndOrganizationIdAndBirthPlaceId(genderId, organizationId, birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId, organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderIdAndOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderIdAndOrganizationIdAndBirthPlaceId(idEmployee, genderId, organizationId, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId, organizationId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(genderId, organizationId, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId, isActive containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderIdAndIsActive(Int16 genderId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderIdAndIsActive(genderId, isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderIdAndIsActive(idEmployee, genderId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderIdAndIsActive(Int16 genderId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderIdAndIsActive(genderId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderIdAndIsActiveAndBirthPlaceId(genderId, isActive, birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderIdAndIsActiveAndBirthPlaceId(idEmployee, genderId, isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderIdAndIsActiveAndBirthPlaceId(genderId, isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with genderId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByGenderIdAndBirthPlaceId(genderId, birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's genderId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateGenderIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateGenderIdAndBirthPlaceId(idEmployee, genderId, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by genderId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByGenderIdAndBirthPlaceId(genderId, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByOrganizationId(Int16 organizationId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByOrganizationId(organizationId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateOrganizationId(Int16 idEmployee, Int16 organizationId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateOrganizationId(idEmployee, organizationId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByOrganizationId(Int16 organizationId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByOrganizationId(organizationId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with organizationId, isActive containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByOrganizationIdAndIsActive(organizationId, isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateOrganizationIdAndIsActive(Int16 idEmployee, Int16 organizationId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateOrganizationIdAndIsActive(idEmployee, organizationId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by organizationId, isActive
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByOrganizationIdAndIsActive(organizationId, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with organizationId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByOrganizationIdAndIsActiveAndBirthPlaceId(organizationId, isActive, birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateOrganizationIdAndIsActiveAndBirthPlaceId(idEmployee, organizationId, isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(organizationId, isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with organizationId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByOrganizationIdAndBirthPlaceId(organizationId, birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateOrganizationIdAndBirthPlaceId(idEmployee, organizationId, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by organizationId, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByOrganizationIdAndBirthPlaceId(organizationId, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByIsActive(Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByIsActive(isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateIsActive(Int16 idEmployee, Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateIsActive(idEmployee, isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByIsActive(Int16 isActive)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByIsActive(isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByIsActiveAndBirthPlaceId(isActive, birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateIsActiveAndBirthPlaceId(idEmployee, isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by isActive, birthPlaceId
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByIsActiveAndBirthPlaceId(isActive, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Finds all Employee data with birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult FindByBirthPlaceId(Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                List<Employee> res = repository.FindByBirthPlaceId(birthPlaceId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Update Employee's birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult UpdateBirthPlaceId(Int16 idEmployee, Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.UpdateBirthPlaceId(idEmployee, birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

        /// <summary>
        /// Delete Employee by birthPlaceId
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>The result of the operation</returns>
        public OperationResult DeleteByBirthPlaceId(Int16 birthPlaceId)
        {
            IEmployeeRepository repository = (IEmployeeRepository)RepositoryFactory.Create(Keywords.Employee);
            try
            {
                repository.DeleteByBirthPlaceId(birthPlaceId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
        }

    }
}