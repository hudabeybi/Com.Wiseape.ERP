using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.ERP.HR.View.Model;


namespace Com.Wiseape.ERP.HR.View.Contract.Validator
{
    public interface IEmployeeValidator
    {
        ValidationResult Validate(EmployeeForm employeeForm);
    }
}