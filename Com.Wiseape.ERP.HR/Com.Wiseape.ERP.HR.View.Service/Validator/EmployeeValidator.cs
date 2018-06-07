using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.ERP.HR.View.Model;
using Com.Wiseape.ERP.HR.View.Contract.Validator;

namespace Com.Wiseape.ERP.HR.View.Service.Validator
{
    public class EmployeeValidator : IEmployeeValidator
    {
        public ValidationResult Validate(EmployeeForm employeeForm)
        {
            ValidationResult validationResult = new ValidationResult(true);
            if (validationResult.Result)
                validationResult = this.ValidateEmail(employeeForm.Email);
            if (validationResult.Result)
                validationResult = this.ValidateEmployeeNo(employeeForm.EmployeeNo);
            if (validationResult.Result)
                validationResult = this.ValidateIdentityNumber(employeeForm.IdentityNumber);
            if (validationResult.Result)
                validationResult = this.ValidateFirstName(employeeForm.FirstName);

            return validationResult;
        }


        /// <summary>
        /// Validate Email
        /// </summary>
        /// <param name="Email"> Email</param>
        /// <returns>Validation Result</returns>
        protected virtual ValidationResult ValidateEmail(string email)
        {
            ValidationResult result = new ValidationResult(true);

            if (email == null || (email != null && email.Length == 0))
            {
                result.Result = false;
                result.ErrorMessage = "Please fill Email";
            }

            return result;
        }

        /// <summary>
        /// Validate EmployeeNo
        /// </summary>
        /// <param name="EmployeeNo"> Employee No</param>
        /// <returns>Validation Result</returns>
        protected virtual ValidationResult ValidateEmployeeNo(string employeeNo)
        {
            ValidationResult result = new ValidationResult(true);

            if (employeeNo == null || (employeeNo != null && employeeNo.Length == 0))
            {
                result.Result = false;
                result.ErrorMessage = "Please fill Employee No";
            }

            return result;
        }

        /// <summary>
        /// Validate IdentityNumber
        /// </summary>
        /// <param name="IdentityNumber"> Identity Number</param>
        /// <returns>Validation Result</returns>
        protected virtual ValidationResult ValidateIdentityNumber(string identityNumber)
        {
            ValidationResult result = new ValidationResult(true);

            if (identityNumber == null || (identityNumber != null && identityNumber.Length == 0))
            {
                result.Result = false;
                result.ErrorMessage = "Please fill Identity Number";
            }

            return result;
        }

        /// <summary>
        /// Validate FirstName
        /// </summary>
        /// <param name="FirstName"> First Name</param>
        /// <returns>Validation Result</returns>
        protected virtual ValidationResult ValidateFirstName(string firstName)
        {
            ValidationResult result = new ValidationResult(true);

            if (firstName == null || (firstName != null && firstName.Length == 0))
            {
                result.Result = false;
                result.ErrorMessage = "Please fill First Name";
            }

            return result;
        }

    }
}