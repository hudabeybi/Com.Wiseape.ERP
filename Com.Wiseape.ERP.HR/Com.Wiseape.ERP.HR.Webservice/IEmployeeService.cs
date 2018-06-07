using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.HR.Business.Contract;
using Com.Wiseape.ERP.HR.View.Model;

namespace Com.Wiseape.ERP.HR.Webservice
{
    /// <summary>
    /// Interface for Employee Service
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Service to add Employee data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="EmployeeForm">Employee data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        string AddEmployee(EmployeeForm employeeForm);

        /// <summary>
        /// Service to update Employee data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="EmployeeForm">Employee data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        string UpdateEmployee(EmployeeForm employeeForm);

        /// <summary>
        /// Service to delete Employee data from data store. 
        /// The data deleted is defined by idEmployee.
        /// This is a GET request.
        /// </summary>
        /// <param name="idEmployee">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>        
        string DeleteEmployee(string idEmployee);

        /// <summary>
        /// Service to get a Employee data from data store. 
        /// The data retrieved is defined by idEmployee.
        /// This is a GET request.
        /// </summary>
        /// <param name="idEmployee">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>        
        string GetEmployee(string idEmployee);

        /// <summary>
        /// Service to get all the Employee data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>     
        string FindEmployee(string keyword, int page, int max);


        /// <summary>
        /// Finds all Employee data with livingAddress containing specified keyword
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByLivingAddress(string livingAddress);

        /// <summary>
        /// Update Employee's livingAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="livingAddress">living Address</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateLivingAddress(Int16 idEmployee, string livingAddress);

        /// <summary>
        /// Delete Employee by livingAddress
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByLivingAddress(string livingAddress);

        /// <summary>
        /// Finds all Employee data with homeAddress containing specified keyword
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByHomeAddress(string homeAddress);

        /// <summary>
        /// Update Employee's homeAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homeAddress">home Address</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateHomeAddress(Int16 idEmployee, string homeAddress);

        /// <summary>
        /// Delete Employee by homeAddress
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByHomeAddress(string homeAddress);

        /// <summary>
        /// Finds all Employee data with homePhone containing specified keyword
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByHomePhone(string homePhone);

        /// <summary>
        /// Update Employee's homePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homePhone">home Phone</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateHomePhone(Int16 idEmployee, string homePhone);

        /// <summary>
        /// Delete Employee by homePhone
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByHomePhone(string homePhone);

        /// <summary>
        /// Finds all Employee data with mobilePhone containing specified keyword
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByMobilePhone(string mobilePhone);

        /// <summary>
        /// Update Employee's mobilePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateMobilePhone(Int16 idEmployee, string mobilePhone);

        /// <summary>
        /// Delete Employee by mobilePhone
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByMobilePhone(string mobilePhone);

        /// <summary>
        /// Finds all Employee data with email containing specified keyword
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByEmail(string email);

        /// <summary>
        /// Update Employee's email which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="email">email</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateEmail(Int16 idEmployee, string email);

        /// <summary>
        /// Delete Employee by email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByEmail(string email);

        /// <summary>
        /// Finds all Employee data with employeeNo containing specified keyword
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByEmployeeNo(string employeeNo);

        /// <summary>
        /// Update Employee's employeeNo which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="employeeNo">employee No</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateEmployeeNo(Int16 idEmployee, string employeeNo);

        /// <summary>
        /// Delete Employee by employeeNo
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByEmployeeNo(string employeeNo);

        /// <summary>
        /// Finds all Employee data with identityNumber containing specified keyword
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByIdentityNumber(string identityNumber);

        /// <summary>
        /// Update Employee's identityNumber which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateIdentityNumber(Int16 idEmployee, string identityNumber);

        /// <summary>
        /// Delete Employee by identityNumber
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByIdentityNumber(string identityNumber);

        /// <summary>
        /// Finds all Employee data with firstName containing specified keyword
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByFirstName(string firstName);

        /// <summary>
        /// Update Employee's firstName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="firstName">first Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateFirstName(Int16 idEmployee, string firstName);

        /// <summary>
        /// Delete Employee by firstName
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByFirstName(string firstName);

        /// <summary>
        /// Finds all Employee data with middleName containing specified keyword
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByMiddleName(string middleName);

        /// <summary>
        /// Update Employee's middleName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="middleName">middle Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateMiddleName(Int16 idEmployee, string middleName);

        /// <summary>
        /// Delete Employee by middleName
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByMiddleName(string middleName);

        /// <summary>
        /// Finds all Employee data with lastName containing specified keyword
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByLastName(string lastName);

        /// <summary>
        /// Update Employee's lastName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="lastName">last Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateLastName(Int16 idEmployee, string lastName);

        /// <summary>
        /// Delete Employee by lastName
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByLastName(string lastName);

        /// <summary>
        /// Finds all Employee data with birthDate1, birthDate2 containing specified keyword
        /// </summary>
        /// <param name="birthDate1">birth Date1</param>
        /// <param name="birthDate2">birth Date2</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByBirthDateBetween(DateTime birthDate1, DateTime birthDate2);

        /// <summary>
        /// Update Employee's birthDate which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthDate">birth Date</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateBirthDate(Int16 idEmployee, DateTime birthDate);

        /// <summary>
        /// Delete Employee by birthDate
        /// </summary>
        /// <param name="birthDate">birth Date</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByBirthDate(DateTime birthDate);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderId(Int16 genderId);

        /// <summary>
        /// Update Employee's genderId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderId(Int16 idEmployee, Int16 genderId);

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderId(Int16 genderId);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Update Employee's genderId, organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderIdAndOrganizationId(Int16 idEmployee, Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Delete Employee by genderId, organizationId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, isActive containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderIdAndOrganizationIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId, organizationId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderIdAndOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, organizationId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId, isActive containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderIdAndIsActive(Int16 genderId, Int16 isActive);

        /// <summary>
        /// Update Employee's genderId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 isActive);

        /// <summary>
        /// Delete Employee by genderId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderIdAndIsActive(Int16 genderId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with genderId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateGenderIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByOrganizationId(Int16 organizationId);

        /// <summary>
        /// Update Employee's organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateOrganizationId(Int16 idEmployee, Int16 organizationId);

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByOrganizationId(Int16 organizationId);

        /// <summary>
        /// Finds all Employee data with organizationId, isActive containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Update Employee's organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateOrganizationIdAndIsActive(Int16 idEmployee, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Delete Employee by organizationId, isActive
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with organizationId, isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with organizationId, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by organizationId, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByIsActive(Int16 isActive);

        /// <summary>
        /// Update Employee's isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateIsActive(Int16 idEmployee, Int16 isActive);

        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByIsActive(Int16 isActive);

        /// <summary>
        /// Finds all Employee data with isActive, birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by isActive, birthPlaceId
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string FindByBirthPlaceId(Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string UpdateBirthPlaceId(Int16 idEmployee, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by birthPlaceId
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of OperationResult object</returns>
        string DeleteByBirthPlaceId(Int16 birthPlaceId);

    }
}