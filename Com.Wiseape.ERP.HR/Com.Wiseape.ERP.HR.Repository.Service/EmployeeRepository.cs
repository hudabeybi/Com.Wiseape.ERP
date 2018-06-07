using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.Data.Context;
using Com.Wiseape.ERP.HR.Repository.Contract;



namespace Com.Wiseape.ERP.HR.Repository.Service
{
    /// <summary>
    /// Repository for Employee data.
    /// </summary>
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        class Keywords
        {
            public static string Employee = "HR.Employee";
        }

        /// <summary>
        /// Constructor for EmployeeRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public EmployeeRepository(string dataContextKey) : base(dataContextKey)
        {
        }

        /// <summary>
        /// Finds all Employee data with livingAddress containing specified keyword
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByLivingAddress(string livingAddress)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.LivingAddress.Contains(livingAddress)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's livingAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="livingAddress">living Address</param>
        /// <returns> - </returns>
        public void UpdateLivingAddress(Int16 idEmployee, string livingAddress)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.LivingAddress = livingAddress);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by livingAddress
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns> - </returns>
        public void DeleteByLivingAddress(string livingAddress)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.LivingAddress.Contains(livingAddress)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with homeAddress containing specified keyword
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByHomeAddress(string homeAddress)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.HomeAddress.Contains(homeAddress)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's homeAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homeAddress">home Address</param>
        /// <returns> - </returns>
        public void UpdateHomeAddress(Int16 idEmployee, string homeAddress)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.HomeAddress = homeAddress);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by homeAddress
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns> - </returns>
        public void DeleteByHomeAddress(string homeAddress)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.HomeAddress.Contains(homeAddress)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with homePhone containing specified keyword
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByHomePhone(string homePhone)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.HomePhone.Contains(homePhone)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's homePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homePhone">home Phone</param>
        /// <returns> - </returns>
        public void UpdateHomePhone(Int16 idEmployee, string homePhone)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.HomePhone = homePhone);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by homePhone
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns> - </returns>
        public void DeleteByHomePhone(string homePhone)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.HomePhone.Contains(homePhone)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with mobilePhone containing specified keyword
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByMobilePhone(string mobilePhone)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.MobilePhone.Contains(mobilePhone)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's mobilePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns> - </returns>
        public void UpdateMobilePhone(Int16 idEmployee, string mobilePhone)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.MobilePhone = mobilePhone);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by mobilePhone
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns> - </returns>
        public void DeleteByMobilePhone(string mobilePhone)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.MobilePhone.Contains(mobilePhone)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with email containing specified keyword
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByEmail(string email)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.Email.Contains(email)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's email which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="email">email</param>
        /// <returns> - </returns>
        public void UpdateEmail(Int16 idEmployee, string email)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.Email = email);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns> - </returns>
        public void DeleteByEmail(string email)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.Email.Contains(email)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with employeeNo containing specified keyword
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByEmployeeNo(string employeeNo)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.EmployeeNo.Contains(employeeNo)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's employeeNo which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="employeeNo">employee No</param>
        /// <returns> - </returns>
        public void UpdateEmployeeNo(Int16 idEmployee, string employeeNo)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.EmployeeNo = employeeNo);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by employeeNo
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns> - </returns>
        public void DeleteByEmployeeNo(string employeeNo)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.EmployeeNo.Contains(employeeNo)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with identityNumber containing specified keyword
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByIdentityNumber(string identityNumber)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.IdentityNumber.Contains(identityNumber)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's identityNumber which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="identityNumber">identity Number</param>
        /// <returns> - </returns>
        public void UpdateIdentityNumber(Int16 idEmployee, string identityNumber)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.IdentityNumber = identityNumber);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by identityNumber
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns> - </returns>
        public void DeleteByIdentityNumber(string identityNumber)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdentityNumber.Contains(identityNumber)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with firstName containing specified keyword
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByFirstName(string firstName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.FirstName.Contains(firstName)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's firstName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="firstName">first Name</param>
        /// <returns> - </returns>
        public void UpdateFirstName(Int16 idEmployee, string firstName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.FirstName = firstName);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by firstName
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns> - </returns>
        public void DeleteByFirstName(string firstName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.FirstName.Contains(firstName)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with middleName containing specified keyword
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByMiddleName(string middleName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.MiddleName.Contains(middleName)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's middleName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="middleName">middle Name</param>
        /// <returns> - </returns>
        public void UpdateMiddleName(Int16 idEmployee, string middleName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.MiddleName = middleName);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by middleName
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns> - </returns>
        public void DeleteByMiddleName(string middleName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.MiddleName.Contains(middleName)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with lastName containing specified keyword
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByLastName(string lastName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.LastName.Contains(lastName)
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's lastName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="lastName">last Name</param>
        /// <returns> - </returns>
        public void UpdateLastName(Int16 idEmployee, string lastName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.LastName = lastName);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by lastName
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns> - </returns>
        public void DeleteByLastName(string lastName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.LastName.Contains(lastName)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with birthDate1 containing specified keyword
        /// </summary>
        /// <param name="birthDate1">birth Date1</param>
        /// <param name="birthDate2">birth Date2</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByBirthDateBetween(DateTime birthDate1, DateTime birthDate2)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                            o.BirthDate >= birthDate1 &&
                            o.BirthDate >= birthDate2
                       select o;
            return list.ToList();
        }

        /// <summary>
        /// Update Employee's birthDate which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthDate">birth Date</param>
        /// <returns> - </returns>
        public void UpdateBirthDate(Int16 idEmployee, DateTime birthDate)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o =>
                                  o.BirthDate = birthDate);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete Employee by birthDate
        /// </summary>
        /// <param name="birthDate">birth Date</param>
        /// <returns> - </returns>
        public void DeleteByBirthDate(DateTime birthDate)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.BirthDate.Equals(birthDate)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderId(Int16 genderId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <returns> - </returns>
        public void UpdateGenderId(Int16 idEmployee, Int16 genderId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns> - </returns>
        public void DeleteByGenderId(Int16 genderId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId, organizationId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        public void UpdateGenderIdAndOrganizationId(Int16 idEmployee, Int16 genderId, Int16 organizationId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
                o.OrganizationId = organizationId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        public void DeleteByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId, organizationId, isActive which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void UpdateGenderIdAndOrganizationIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
                o.OrganizationId = organizationId;
                o.IsActive = isActive;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void DeleteByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId, organizationId, isActive, birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
                o.OrganizationId = organizationId;
                o.IsActive = isActive;
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId, organizationId, birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateGenderIdAndOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
                o.OrganizationId = organizationId;
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.OrganizationId.Equals(organizationId) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderIdAndIsActive(Int16 genderId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.IsActive.Equals(isActive)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId, isActive which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void UpdateGenderIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
                o.IsActive = isActive;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void DeleteByGenderIdAndIsActive(Int16 genderId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.IsActive.Equals(isActive)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId, isActive, birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateGenderIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
                o.IsActive = isActive;
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's genderId, birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateGenderIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.GenderId = genderId;
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.GenderId.Equals(genderId) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByOrganizationId(Int16 organizationId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's organizationId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        public void UpdateOrganizationId(Int16 idEmployee, Int16 organizationId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.OrganizationId = organizationId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        public void DeleteByOrganizationId(Int16 organizationId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's organizationId, isActive which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void UpdateOrganizationIdAndIsActive(Int16 idEmployee, Int16 organizationId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.OrganizationId = organizationId;
                o.IsActive = isActive;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void DeleteByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's organizationId, isActive, birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.OrganizationId = organizationId;
                o.IsActive = isActive;
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId) &&
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's organizationId, birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.OrganizationId = organizationId;
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.OrganizationId.Equals(organizationId) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByIsActive(Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.IsActive.Equals(isActive)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's isActive which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void UpdateIsActive(Int16 idEmployee, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.IsActive = isActive;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        public void DeleteByIsActive(Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.IsActive.Equals(isActive)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's isActive, birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.IsActive = isActive;
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.IsActive.Equals(isActive) &&
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Finds all Employee data with birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        public List<Employee> FindByBirthPlaceId(Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            return list.ToList();
        }

        //(update-int-and-int)
        /// <summary>
        /// Update Employee's birthPlaceId which has specified idEmployee. 
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void UpdateBirthPlaceId(Int16 idEmployee, Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                               o.IdEmployee.Equals(idEmployee)
                       select o;
            list.ToList().ForEach(o => {
                o.BirthPlaceId = birthPlaceId;
            });
            dataContext.SaveChanges();
        }

        //(delete-int-and-int)
        /// <summary>
        /// Delete Employee by birthPlaceId
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        public void DeleteByBirthPlaceId(Int16 birthPlaceId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Employees
                       where
                        o.BirthPlaceId.Equals(birthPlaceId)
                       select o;
            dataContext.Employees.RemoveRange(list);
            dataContext.SaveChanges();
        }

    }
}