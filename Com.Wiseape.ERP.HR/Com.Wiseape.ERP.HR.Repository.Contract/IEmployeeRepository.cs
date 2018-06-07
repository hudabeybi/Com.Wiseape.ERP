using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;

namespace Com.Wiseape.ERP.HR.Repository.Contract
{
    public interface IEmployeeRepository
    {

        /// <summary>
        /// Finds all Employee data with livingAddress containing specified keyword
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByLivingAddress(string livingAddress);

        /// <summary>
        /// Update Employee's livingAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="livingAddress">living Address</param>
        /// <returns> - </returns>
        void UpdateLivingAddress(Int16 idEmployee, string livingAddress);

        /// <summary>
        /// Delete Employee by livingAddress
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns> - </returns>
        void DeleteByLivingAddress(string livingAddress);

        /// <summary>
        /// Finds all Employee data with homeAddress containing specified keyword
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByHomeAddress(string homeAddress);

        /// <summary>
        /// Update Employee's homeAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homeAddress">home Address</param>
        /// <returns> - </returns>
        void UpdateHomeAddress(Int16 idEmployee, string homeAddress);

        /// <summary>
        /// Delete Employee by homeAddress
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns> - </returns>
        void DeleteByHomeAddress(string homeAddress);

        /// <summary>
        /// Finds all Employee data with homePhone containing specified keyword
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByHomePhone(string homePhone);

        /// <summary>
        /// Update Employee's homePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homePhone">home Phone</param>
        /// <returns> - </returns>
        void UpdateHomePhone(Int16 idEmployee, string homePhone);

        /// <summary>
        /// Delete Employee by homePhone
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns> - </returns>
        void DeleteByHomePhone(string homePhone);

        /// <summary>
        /// Finds all Employee data with mobilePhone containing specified keyword
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByMobilePhone(string mobilePhone);

        /// <summary>
        /// Update Employee's mobilePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns> - </returns>
        void UpdateMobilePhone(Int16 idEmployee, string mobilePhone);

        /// <summary>
        /// Delete Employee by mobilePhone
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns> - </returns>
        void DeleteByMobilePhone(string mobilePhone);

        /// <summary>
        /// Finds all Employee data with email containing specified keyword
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByEmail(string email);

        /// <summary>
        /// Update Employee's email which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="email">email</param>
        /// <returns> - </returns>
        void UpdateEmail(Int16 idEmployee, string email);

        /// <summary>
        /// Delete Employee by email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns> - </returns>
        void DeleteByEmail(string email);

        /// <summary>
        /// Finds all Employee data with employeeNo containing specified keyword
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByEmployeeNo(string employeeNo);

        /// <summary>
        /// Update Employee's employeeNo which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="employeeNo">employee No</param>
        /// <returns> - </returns>
        void UpdateEmployeeNo(Int16 idEmployee, string employeeNo);

        /// <summary>
        /// Delete Employee by employeeNo
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns> - </returns>
        void DeleteByEmployeeNo(string employeeNo);

        /// <summary>
        /// Finds all Employee data with identityNumber containing specified keyword
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByIdentityNumber(string identityNumber);

        /// <summary>
        /// Update Employee's identityNumber which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="identityNumber">identity Number</param>
        /// <returns> - </returns>
        void UpdateIdentityNumber(Int16 idEmployee, string identityNumber);

        /// <summary>
        /// Delete Employee by identityNumber
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns> - </returns>
        void DeleteByIdentityNumber(string identityNumber);

        /// <summary>
        /// Finds all Employee data with firstName containing specified keyword
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByFirstName(string firstName);

        /// <summary>
        /// Update Employee's firstName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="firstName">first Name</param>
        /// <returns> - </returns>
        void UpdateFirstName(Int16 idEmployee, string firstName);

        /// <summary>
        /// Delete Employee by firstName
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns> - </returns>
        void DeleteByFirstName(string firstName);

        /// <summary>
        /// Finds all Employee data with middleName containing specified keyword
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByMiddleName(string middleName);

        /// <summary>
        /// Update Employee's middleName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="middleName">middle Name</param>
        /// <returns> - </returns>
        void UpdateMiddleName(Int16 idEmployee, string middleName);

        /// <summary>
        /// Delete Employee by middleName
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns> - </returns>
        void DeleteByMiddleName(string middleName);

        /// <summary>
        /// Finds all Employee data with lastName containing specified keyword
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByLastName(string lastName);

        /// <summary>
        /// Update Employee's lastName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="lastName">last Name</param>
        /// <returns> - </returns>
        void UpdateLastName(Int16 idEmployee, string lastName);

        /// <summary>
        /// Delete Employee by lastName
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns> - </returns>
        void DeleteByLastName(string lastName);

        /// <summary>
        /// Finds all Employee data with birthDate1, birthDate2 containing specified keyword
        /// </summary>
        /// <param name="birthDate1">birth Date1</param>
        /// <param name="birthDate2">birth Date2</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByBirthDateBetween(DateTime birthDate1, DateTime birthDate2);

        /// <summary>
        /// Update Employee's birthDate which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthDate">birth Date</param>
        /// <returns> - </returns>
        void UpdateBirthDate(Int16 idEmployee, DateTime birthDate);

        /// <summary>
        /// Delete Employee by birthDate
        /// </summary>
        /// <param name="birthDate">birth Date</param>
        /// <returns> - </returns>
        void DeleteByBirthDate(DateTime birthDate);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderId(Int16 genderId);

        /// <summary>
        /// Update Employee's genderId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <returns> - </returns>
        void UpdateGenderId(Int16 idEmployee, Int16 genderId);

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns> - </returns>
        void DeleteByGenderId(Int16 genderId);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Update Employee's genderId, organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        void UpdateGenderIdAndOrganizationId(Int16 idEmployee, Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Delete Employee by genderId, organizationId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        void DeleteByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, isActive containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void UpdateGenderIdAndOrganizationIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void DeleteByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateGenderIdAndOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, organizationId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId, isActive containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderIdAndIsActive(Int16 genderId, Int16 isActive);

        /// <summary>
        /// Update Employee's genderId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void UpdateGenderIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 isActive);

        /// <summary>
        /// Delete Employee by genderId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void DeleteByGenderIdAndIsActive(Int16 genderId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with genderId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateGenderIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateGenderIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByOrganizationId(Int16 organizationId);

        /// <summary>
        /// Update Employee's organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        void UpdateOrganizationId(Int16 idEmployee, Int16 organizationId);

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns> - </returns>
        void DeleteByOrganizationId(Int16 organizationId);

        /// <summary>
        /// Finds all Employee data with organizationId, isActive containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Update Employee's organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void UpdateOrganizationIdAndIsActive(Int16 idEmployee, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Delete Employee by organizationId, isActive
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void DeleteByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with organizationId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with organizationId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by organizationId, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByIsActive(Int16 isActive);

        /// <summary>
        /// Update Employee's isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void UpdateIsActive(Int16 idEmployee, Int16 isActive);

        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns> - </returns>
        void DeleteByIsActive(Int16 isActive);

        /// <summary>
        /// Finds all Employee data with isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by isActive, birthPlaceId
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>List of Employee</returns>
        List<Employee> FindByBirthPlaceId(Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void UpdateBirthPlaceId(Int16 idEmployee, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by birthPlaceId
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns> - </returns>
        void DeleteByBirthPlaceId(Int16 birthPlaceId);

    }
}