using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.HR.Business.Contract;
using Com.Wiseape.ERP.HR.View.Model;

namespace Com.Wiseape.ERP.HR.Webservice
{
    public class EmployeeService : IEmployeeService
    {

        class Keywords
        {
            public static string Employee = "HR.Employee";
        }

        /// <summary>
        /// Service to add Employee data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="EmployeeForm">Employee data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "employee/add")]
        public string AddEmployee(EmployeeForm employeeForm)
        {
            BaseBusinessService<Employee> businessService = (BaseBusinessService<Employee>)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.Add(employeeForm);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Service to update Employee data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="EmployeeForm">Employee data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "employee/update")]
        public string UpdateEmployee(EmployeeForm employeeForm)
        {
            BaseBusinessService<Employee> businessService = (BaseBusinessService<Employee>)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.Update(employeeForm);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Service to delete Employee data from data store. 
        /// The data deleted is defined by idEmployee.
        /// This is a GET request.
        /// </summary>
        /// <param name="idEmployee">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "employee/delete/{idEmployee}")]
        public string DeleteEmployee(string idEmployee)
        {
            BaseBusinessService<Employee> businessService = (BaseBusinessService<Employee>)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.Delete(idEmployee);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Service to get a Employee data from data store. 
        /// The data retrieved is defined by idEmployee.
        /// This is a GET request.
        /// </summary>
        /// <param name="idEmployee">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "employee/get/{idEmployee}")]
        public string GetEmployee(string idEmployee)
        {
            BaseBusinessService<Employee> businessService = (BaseBusinessService<Employee>)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.Get(idEmployee);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Service to get all the Employee data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "employee/find/{keyword}/{page}/{max}")]
        public string FindEmployee(string keyword, int page, int max)
        {
            BaseBusinessService<Employee> businessService = (BaseBusinessService<Employee>)BusinessFactory.Create(Keywords.Employee);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, page, max);

            return Serializer.Json.Serialize(result);
        }


        /// <summary>
        /// Finds all Employee data with livingAddress containing specified keyword
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-living-address/{livingAddress}")]
        public string FindByLivingAddress(string livingAddress)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByLivingAddress(livingAddress);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's livingAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="livingAddress">living Address</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-living-address/{idEmployee}/{livingAddress}")]
        public string UpdateLivingAddress(Int16 idEmployee, string livingAddress)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateLivingAddress(idEmployee, livingAddress);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by livingAddress
        /// </summary>
        /// <param name="livingAddress">living Address</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-living-address/{livingAddress}")]
        public string DeleteByLivingAddress(string livingAddress)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByLivingAddress(livingAddress);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with homeAddress containing specified keyword
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-home-address/{homeAddress}")]
        public string FindByHomeAddress(string homeAddress)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByHomeAddress(homeAddress);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's homeAddress which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homeAddress">home Address</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-home-address/{idEmployee}/{homeAddress}")]
        public string UpdateHomeAddress(Int16 idEmployee, string homeAddress)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateHomeAddress(idEmployee, homeAddress);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by homeAddress
        /// </summary>
        /// <param name="homeAddress">home Address</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-home-address/{homeAddress}")]
        public string DeleteByHomeAddress(string homeAddress)
        { 

            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByHomeAddress(homeAddress);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with homePhone containing specified keyword
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-home-phone/{homePhone}")]
        public string FindByHomePhone(string homePhone)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByHomePhone(homePhone);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's homePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="homePhone">home Phone</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-home-phone/{idEmployee}/{homePhone}")]
        public string UpdateHomePhone(Int16 idEmployee, string homePhone)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateHomePhone(idEmployee, homePhone);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by homePhone
        /// </summary>
        /// <param name="homePhone">home Phone</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-home-phone/{homePhone}")]
        public string DeleteByHomePhone(string homePhone)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByHomePhone(homePhone);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with mobilePhone containing specified keyword
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-mobile-phone/{mobilePhone}")]
        public string FindByMobilePhone(string mobilePhone)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByMobilePhone(mobilePhone);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's mobilePhone which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-mobile-phone/{idEmployee}/{mobilePhone}")]
        public string UpdateMobilePhone(Int16 idEmployee, string mobilePhone)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateMobilePhone(idEmployee, mobilePhone);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by mobilePhone
        /// </summary>
        /// <param name="mobilePhone">mobile Phone</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-mobile-phone/{mobilePhone}")]
        public string DeleteByMobilePhone(string mobilePhone)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByMobilePhone(mobilePhone);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with email containing specified keyword
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-email/{email}")]
        public string FindByEmail(string email)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByEmail(email);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's email which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="email">email</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-email/{idEmployee}/{email}")]
        public string UpdateEmail(Int16 idEmployee, string email)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateEmail(idEmployee, email);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by email
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-email/{email}")]
        public string DeleteByEmail(string email)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByEmail(email);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with employeeNo containing specified keyword
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-employee-no/{employeeNo}")]
        public string FindByEmployeeNo(string employeeNo)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByEmployeeNo(employeeNo);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's employeeNo which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="employeeNo">employee No</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-employee-no/{idEmployee}/{employeeNo}")]
        public string UpdateEmployeeNo(Int16 idEmployee, string employeeNo)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateEmployeeNo(idEmployee, employeeNo);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by employeeNo
        /// </summary>
        /// <param name="employeeNo">employee No</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-employee-no/{employeeNo}")]
        public string DeleteByEmployeeNo(string employeeNo)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByEmployeeNo(employeeNo);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with identityNumber containing specified keyword
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-identity-number/{identityNumber}")]
        public string FindByIdentityNumber(string identityNumber)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByIdentityNumber(identityNumber);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's identityNumber which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-identity-number/{idEmployee}/{identityNumber}")]
        public string UpdateIdentityNumber(Int16 idEmployee, string identityNumber)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateIdentityNumber(idEmployee, identityNumber);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by identityNumber
        /// </summary>
        /// <param name="identityNumber">identity Number</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-identity-number/{identityNumber}")]
        public string DeleteByIdentityNumber(string identityNumber)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByIdentityNumber(identityNumber);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with firstName containing specified keyword
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-first-name/{firstName}")]
        public string FindByFirstName(string firstName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByFirstName(firstName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's firstName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="firstName">first Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-first-name/{idEmployee}/{firstName}")]
        public string UpdateFirstName(Int16 idEmployee, string firstName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateFirstName(idEmployee, firstName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by firstName
        /// </summary>
        /// <param name="firstName">first Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-first-name/{firstName}")]
        public string DeleteByFirstName(string firstName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByFirstName(firstName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with middleName containing specified keyword
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-middle-name/{middleName}")]
        public string FindByMiddleName(string middleName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByMiddleName(middleName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's middleName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="middleName">middle Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-middle-name/{idEmployee}/{middleName}")]
        public string UpdateMiddleName(Int16 idEmployee, string middleName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateMiddleName(idEmployee, middleName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by middleName
        /// </summary>
        /// <param name="middleName">middle Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-middle-name/{middleName}")]
        public string DeleteByMiddleName(string middleName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByMiddleName(middleName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with lastName containing specified keyword
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-last-name/{lastName}")]
        public string FindByLastName(string lastName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByLastName(lastName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's lastName which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="lastName">last Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-last-name/{idEmployee}/{lastName}")]
        public string UpdateLastName(Int16 idEmployee, string lastName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateLastName(idEmployee, lastName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by lastName
        /// </summary>
        /// <param name="lastName">last Name</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-last-name/{lastName}")]
        public string DeleteByLastName(string lastName)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByLastName(lastName);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with birthDate1 containing specified keyword
        /// </summary>
        /// <param name="birthDate1">birth Date1</param>
        /// <param name="birthDate2">birth Date2</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-birth-date-between/{birthDate1}/{birthDate2}")]
        public string FindByBirthDateBetween(DateTime birthDate1, DateTime birthDate2)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByBirthDateBetween(birthDate1, birthDate2);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's birthDate which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthDate">birth Date</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-birth-date/{idEmployee}/{birthDate}")]
        public string UpdateBirthDate(Int16 idEmployee, DateTime birthDate)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateBirthDate(idEmployee, birthDate);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by birthDate
        /// </summary>
        /// <param name="birthDate">birth Date</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-birth-date/{birthDate}")]
        public string DeleteByBirthDate(DateTime birthDate)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByBirthDate(birthDate);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id/{genderId}")]
        public string FindByGenderId(Int16 genderId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderId(genderId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id/{idEmployee}/{genderId}")]
        public string UpdateGenderId(Int16 idEmployee, Int16 genderId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderId(idEmployee, genderId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id/{genderId}")]
        public string DeleteByGenderId(Int16 genderId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderId(genderId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id-and-organization-id/{genderId}/{organizationId}")]
        public string FindByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderIdAndOrganizationId(genderId, organizationId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId, organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id-and-organization-id/{idEmployee}/{genderId}/{organizationId}")]
        public string UpdateGenderIdAndOrganizationId(Int16 idEmployee, Int16 genderId, Int16 organizationId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderIdAndOrganizationId(idEmployee, genderId, organizationId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id-and-organization-id/{genderId}/{organizationId}")]
        public string DeleteByGenderIdAndOrganizationId(Int16 genderId, Int16 organizationId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderIdAndOrganizationId(genderId, organizationId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id-and-organization-id-and-is-active/{genderId}/{organizationId}/{isActive}")]
        public string FindByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderIdAndOrganizationIdAndIsActive(genderId, organizationId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id-and-organization-id-and-is-active/{idEmployee}/{genderId}/{organizationId}/{isActive}")]
        public string UpdateGenderIdAndOrganizationIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderIdAndOrganizationIdAndIsActive(idEmployee, genderId, organizationId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id-and-organization-id-and-is-active/{genderId}/{organizationId}/{isActive}")]
        public string DeleteByGenderIdAndOrganizationIdAndIsActive(Int16 genderId, Int16 organizationId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderIdAndOrganizationIdAndIsActive(genderId, organizationId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id-and-organization-id-and-is-active-and-birth-place-id/{genderId}/{organizationId}/{isActive}/{birthPlaceId}")]
        public string FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(genderId, organizationId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId, organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id-and-organization-id-and-is-active-and-birth-place-id/{idEmployee}/{genderId}/{organizationId}/{isActive}/{birthPlaceId}")]
        public string UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(idEmployee, genderId, organizationId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id-and-organization-id-and-is-active-and-birth-place-id/{genderId}/{organizationId}/{isActive}/{birthPlaceId}")]
        public string DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderIdAndOrganizationIdAndIsActiveAndBirthPlaceId(genderId, organizationId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id-and-organization-id-and-birth-place-id/{genderId}/{organizationId}/{birthPlaceId}")]
        public string FindByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderIdAndOrganizationIdAndBirthPlaceId(genderId, organizationId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId, organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id-and-organization-id-and-birth-place-id/{idEmployee}/{genderId}/{organizationId}/{birthPlaceId}")]
        public string UpdateGenderIdAndOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderIdAndOrganizationIdAndBirthPlaceId(idEmployee, genderId, organizationId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id-and-organization-id-and-birth-place-id/{genderId}/{organizationId}/{birthPlaceId}")]
        public string DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(Int16 genderId, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderIdAndOrganizationIdAndBirthPlaceId(genderId, organizationId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id-and-is-active/{genderId}/{isActive}")]
        public string FindByGenderIdAndIsActive(Int16 genderId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderIdAndIsActive(genderId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id-and-is-active/{idEmployee}/{genderId}/{isActive}")]
        public string UpdateGenderIdAndIsActive(Int16 idEmployee, Int16 genderId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderIdAndIsActive(idEmployee, genderId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id-and-is-active/{genderId}/{isActive}")]
        public string DeleteByGenderIdAndIsActive(Int16 genderId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderIdAndIsActive(genderId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id-and-is-active-and-birth-place-id/{genderId}/{isActive}/{birthPlaceId}")]
        public string FindByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderIdAndIsActiveAndBirthPlaceId(genderId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id-and-is-active-and-birth-place-id/{idEmployee}/{genderId}/{isActive}/{birthPlaceId}")]
        public string UpdateGenderIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderIdAndIsActiveAndBirthPlaceId(idEmployee, genderId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id-and-is-active-and-birth-place-id/{genderId}/{isActive}/{birthPlaceId}")]
        public string DeleteByGenderIdAndIsActiveAndBirthPlaceId(Int16 genderId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderIdAndIsActiveAndBirthPlaceId(genderId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with genderId containing specified keyword
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-gender-id-and-birth-place-id/{genderId}/{birthPlaceId}")]
        public string FindByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByGenderIdAndBirthPlaceId(genderId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's genderId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-gender-id-and-birth-place-id/{idEmployee}/{genderId}/{birthPlaceId}")]
        public string UpdateGenderIdAndBirthPlaceId(Int16 idEmployee, Int16 genderId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateGenderIdAndBirthPlaceId(idEmployee, genderId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by genderId
        /// </summary>
        /// <param name="genderId">gender Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-gender-id-and-birth-place-id/{genderId}/{birthPlaceId}")]
        public string DeleteByGenderIdAndBirthPlaceId(Int16 genderId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByGenderIdAndBirthPlaceId(genderId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-organization-id/{organizationId}")]
        public string FindByOrganizationId(Int16 organizationId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByOrganizationId(organizationId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's organizationId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-organization-id/{idEmployee}/{organizationId}")]
        public string UpdateOrganizationId(Int16 idEmployee, Int16 organizationId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateOrganizationId(idEmployee, organizationId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-organization-id/{organizationId}")]
        public string DeleteByOrganizationId(Int16 organizationId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByOrganizationId(organizationId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-organization-id-and-is-active/{organizationId}/{isActive}")]
        public string FindByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByOrganizationIdAndIsActive(organizationId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's organizationId, isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-organization-id-and-is-active/{idEmployee}/{organizationId}/{isActive}")]
        public string UpdateOrganizationIdAndIsActive(Int16 idEmployee, Int16 organizationId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateOrganizationIdAndIsActive(idEmployee, organizationId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-organization-id-and-is-active/{organizationId}/{isActive}")]
        public string DeleteByOrganizationIdAndIsActive(Int16 organizationId, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByOrganizationIdAndIsActive(organizationId, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-organization-id-and-is-active-and-birth-place-id/{organizationId}/{isActive}/{birthPlaceId}")]
        public string FindByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByOrganizationIdAndIsActiveAndBirthPlaceId(organizationId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's organizationId, isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-organization-id-and-is-active-and-birth-place-id/{idEmployee}/{organizationId}/{isActive}/{birthPlaceId}")]
        public string UpdateOrganizationIdAndIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateOrganizationIdAndIsActiveAndBirthPlaceId(idEmployee, organizationId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-organization-id-and-is-active-and-birth-place-id/{organizationId}/{isActive}/{birthPlaceId}")]
        public string DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(Int16 organizationId, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByOrganizationIdAndIsActiveAndBirthPlaceId(organizationId, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with organizationId containing specified keyword
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-organization-id-and-birth-place-id/{organizationId}/{birthPlaceId}")]
        public string FindByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByOrganizationIdAndBirthPlaceId(organizationId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's organizationId, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-organization-id-and-birth-place-id/{idEmployee}/{organizationId}/{birthPlaceId}")]
        public string UpdateOrganizationIdAndBirthPlaceId(Int16 idEmployee, Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateOrganizationIdAndBirthPlaceId(idEmployee, organizationId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by organizationId
        /// </summary>
        /// <param name="organizationId">organization Id</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-organization-id-and-birth-place-id/{organizationId}/{birthPlaceId}")]
        public string DeleteByOrganizationIdAndBirthPlaceId(Int16 organizationId, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByOrganizationIdAndBirthPlaceId(organizationId, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-is-active/{isActive}")]
        public string FindByIsActive(Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByIsActive(isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's isActive which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-is-active/{idEmployee}/{isActive}")]
        public string UpdateIsActive(Int16 idEmployee, Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateIsActive(idEmployee, isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-is-active/{isActive}")]
        public string DeleteByIsActive(Int16 isActive)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByIsActive(isActive);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with isActive containing specified keyword
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-is-active-and-birth-place-id/{isActive}/{birthPlaceId}")]
        public string FindByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByIsActiveAndBirthPlaceId(isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's isActive, birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-is-active-and-birth-place-id/{idEmployee}/{isActive}/{birthPlaceId}")]
        public string UpdateIsActiveAndBirthPlaceId(Int16 idEmployee, Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateIsActiveAndBirthPlaceId(idEmployee, isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by isActive
        /// </summary>
        /// <param name="isActive">is Active</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-is-active-and-birth-place-id/{isActive}/{birthPlaceId}")]
        public string DeleteByIsActiveAndBirthPlaceId(Int16 isActive, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByIsActiveAndBirthPlaceId(isActive, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Finds all Employee data with birthPlaceId containing specified keyword
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/find-by-birth-place-id/{birthPlaceId}")]
        public string FindByBirthPlaceId(Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.FindByBirthPlaceId(birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Update Employee's birthPlaceId which has specified idEmployee
        /// </summary>
        /// <param name="idEmployee">id Employee</param>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/update-birth-place-id/{idEmployee}/{birthPlaceId}")]
        public string UpdateBirthPlaceId(Int16 idEmployee, Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.UpdateBirthPlaceId(idEmployee, birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

        /// <summary>
        /// Delete Employee by birthPlaceId
        /// </summary>
        /// <param name="birthPlaceId">birth Place Id</param>
        /// <returns>JSON string representation of operation result</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "Employee/delete-by-birth-place-id/{birthPlaceId}")]
        public string DeleteByBirthPlaceId(Int16 birthPlaceId)
        {
            IEmployeeBusinessService businessService = (IEmployeeBusinessService)BusinessFactory.Create(Keywords.Employee);
            OperationResult result = businessService.DeleteByBirthPlaceId(birthPlaceId);
            return Serializer.Json.Serialize(result);
        }

    }
}