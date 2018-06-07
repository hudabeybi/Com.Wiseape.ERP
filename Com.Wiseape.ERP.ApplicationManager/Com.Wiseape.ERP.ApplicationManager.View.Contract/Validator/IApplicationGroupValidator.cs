using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.ERP.ApplicationManager.View.Contract.Validator
{
    public interface IApplicationGroupValidator
    {

		ValidationResult ValidateApplicationGroupName(Int16 idApplicationGroup, string applicationGroupName);

		ValidationResult ValidateApplicationGroupName(string applicationGroupName);

		ValidationResult ValidateApplicationGroupDesc(Int16 idApplicationGroup, string applicationGroupDesc);

		ValidationResult ValidateApplicationGroupDesc(string applicationGroupDesc);

		ValidationResult ValidateApplicationGroupIcon(Int16 idApplicationGroup, string applicationGroupIcon);

		ValidationResult ValidateApplicationGroupIcon(string applicationGroupIcon);

	}
}