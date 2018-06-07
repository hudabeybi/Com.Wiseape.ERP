using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;

namespace Com.Wiseape.ERP.HR.Business.Contract
{
    public interface IEmployeeBusinessService
    {

        /// <summary>
        /// Finds all Employee data with livingAddress containing specified keyword
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByLivingAddress(string livingAddress);

        /// <summary>
        /// Update Employee's livingAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="livingAddress">living Address</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateLivingAddress(Int16 idEmployee, string livingAddress);

        /// <summary>
        /// Delete Employee by livingAddress
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByLivingAddress(string livingAddress);

        /// <summary>
        /// Finds all Employee data with homeAddress containing specified keyword
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByHomeAddress(string homeAddress);

        /// <summary>
        /// Update Employee's homeAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homeAddress">home Address</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateHomeAddress(Int16 idEmployee, string homeAddress);

        /// <summary>
        /// Delete Employee by homeAddress
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByHomeAddress(string homeAddress);

        /// <summary>
        /// Finds all Employee data with homePhone containing specified keyword
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByHomePhone(string homePhone);

        /// <summary>
        /// Update Employee's homePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homePhone">home Phone</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateHomePhone(Int16 idEmployee, string homePhone);

        /// <summary>
        /// Delete Employee by homePhone
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByHomePhone(string homePhone);

        /// <summary>
        /// Finds all Employee data with mobilePhone containing specified keyword
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByMobilePhone(string mobilePhone);

        /// <summary>
        /// Update Employee's mobilePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateMobilePhone(Int16 idEmployee, string mobilePhone);

        /// <summary>
        /// Delete Employee by mobilePhone
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByMobilePhone(string mobilePhone);

        /// <summary>
        /// Finds all Employee data with email containing specified keyword
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByEmail(string email);

        /// <summary>
        /// Update Employee's email which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="email">email</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateEmail(Int16 idEmployee, string email);

        /// <summary>
        /// Delete Employee by email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByEmail(string email);

        /// <summary>
        /// Finds all Employee data with employeeNo containing specified keyword
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByEmployeeNo(string employeeNo);

        /// <summary>
        /// Update Employee's employeeNo which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="employeeNo">employee No</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateEmployeeNo(Int16 idEmployee, string employeeNo);

        /// <summary>
        /// Delete Employee by employeeNo
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByEmployeeNo(string employeeNo);

        /// <summary>
        /// Finds all Employee data with identityNumber containing specified keyword
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByIdentityNumber(string identityNumber);

        /// <summary>
        /// Update Employee's identityNumber which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateIdentityNumber(Int16 idEmployee, string identityNumber);

        /// <summary>
        /// Delete Employee by identityNumber
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByIdentityNumber(string identityNumber);

        /// <summary>
        /// Finds all Employee data with firstName containing specified keyword
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByFirstName(string firstName);

        /// <summary>
        /// Update Employee's firstName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="firstName">first Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateFirstName(Int16 idEmployee, string firstName);

        /// <summary>
        /// Delete Employee by firstName
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByFirstName(string firstName);

        /// <summary>
        /// Finds all Employee data with middleName containing specified keyword
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByMiddleName(string middleName);

        /// <summary>
        /// Update Employee's middleName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="middleName">middle Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateMiddleName(Int16 idEmployee, string middleName);

        /// <summary>
        /// Delete Employee by middleName
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByMiddleName(string middleName);

        /// <summary>
        /// Finds all Employee data with lastName containing specified keyword
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByLastName(string lastName);

        /// <summary>
        /// Update Employee's lastName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="lastName">last Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateLastName(Int16 idEmployee, string lastName);

        /// <summary>
        /// Delete Employee by lastName
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByLastName(string lastName);

        /// <summary>
        /// Finds all Employee data with birthDate1 containing specified keyword
        /// </summary>
        /// <param name="birthDate1">birth Date1</param>
        /// <param name="birthDate2">birth Date2</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByBirthDateBetween(DateTime birthDate1, DateTime birthDate2);

        /// <summary>
        /// Update Employee's birthDate which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthDate">birth Date</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateBirthDate(Int16 idEmployee, DateTime birthDate);

        /// <summary>
        /// Delete Employee by birthDate
        /// </summary>
        /// <param name="birthDate">birth Date</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByBirthDate(DateTime birthDate);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderId(Int16 genderId);

        /// <summary>
        /// Update Employee's genderId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderId(Int16 idEmployee, Int16 genderId);

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderId(Int16 genderId);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Update Employee's genderId, organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderIdAndOrganizationId(Int16 idEmployee, Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Delete Employee by genderId, organizationId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderIdAndOrganizationIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderIdAndOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, organizationId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderIdAndIsActive(Int16 genderId, Int16 isActive);

        /// <summary>
        /// Update Employee's genderId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 isActive);

        /// <summary>
        /// Delete Employee by genderId, isActive
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderIdAndIsActive(Int16 genderId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, isActive, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's genderId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateGenderIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by genderId, birthPlaceId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByOrganizationId(Int16 organizationId);

        /// <summary>
        /// Update Employee's organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateOrganizationId(Int16 idEmployee, Int16 organizationId);

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByOrganizationId(Int16 organizationId);

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Update Employee's organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateOrganizationIdAndIsActive(Int16 idEmployee, Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Delete Employee by organizationId, isActive
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive);

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by organizationId, isActive, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by organizationId, birthPlaceId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByIsActive(Int16 isActive);

        /// <summary>
        /// Update Employee's isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateIsActive(Int16 idEmployee, Int16 isActive);

        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByIsActive(Int16 isActive);

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by isActive, birthPlaceId
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId);

        /// <summary>
        /// Finds all Employee data with birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult FindByBirthPlaceId(Int16 birthPlaceId);

        /// <summary>
        /// Update Employee's birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult UpdateBirthPlaceId(Int16 idEmployee, Int16 birthPlaceId);

        /// <summary>
        /// Delete Employee by birthPlaceId
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>Result of the operation</returns>
        OperationResult DeleteByBirthPlaceId(Int16 birthPlaceId);

    }
}