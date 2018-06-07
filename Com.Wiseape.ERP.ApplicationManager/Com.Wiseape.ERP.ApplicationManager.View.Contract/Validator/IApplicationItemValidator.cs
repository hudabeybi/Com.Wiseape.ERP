using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.ERP.ApplicationManager.View.Contract.Validator
{
    public interface IApplicationItemValidator
    {

		ValidationResult ValidateApplicationName(Int16 idApplication, string applicationName);

		ValidationResult ValidateApplicationName(string applicationName);

		ValidationResult ValidateApplicationTitle(Int16 idApplication, string applicationTitle);

		ValidationResult ValidateApplicationTitle(string applicationTitle);

		ValidationResult ValidateApplicationIcon(Int16 idApplication, string applicationIcon);

		ValidationResult ValidateApplicationIcon(string applicationIcon);

		ValidationResult ValidateApplicationDesc(Int16 idApplication, string applicationDesc);

		ValidationResult ValidateApplicationDesc(string applicationDesc);

		ValidationResult ValidateApplicationPath(Int16 idApplication, string applicationPath);

		ValidationResult ValidateApplicationPath(string applicationPath);

		ValidationResult ValidateApplicationFile(Int16 idApplication, string applicationFile);

		ValidationResult ValidateApplicationFile(string applicationFile);

		ValidationResult ValidateApplicationClass(Int16 idApplication, string applicationClass);

		ValidationResult ValidateApplicationClass(string applicationClass);

		ValidationResult ValidateApplicationStartFunction(Int16 idApplication, string applicationStartFunction);

		ValidationResult ValidateApplicationStartFunction(string applicationStartFunction);

		ValidationResult ValidateApplicationGroupId(Int16 idApplication, Int16 applicationGroupId);

		ValidationResult ValidateApplicationGroupId(Int16 applicationGroupId);

		ValidationResult ValidateApplicationGroupIdAndIsDisplayed(Int16 idApplication, Int16 applicationGroupId, Int16 isDisplayed);

		ValidationResult ValidateApplicationGroupIdAndIsDisplayed(Int16 applicationGroupId, Int16 isDisplayed);

		ValidationResult ValidateIsDisplayed(Int16 idApplication, Int16 isDisplayed);

		ValidationResult ValidateIsDisplayed(Int16 isDisplayed);

	}
}