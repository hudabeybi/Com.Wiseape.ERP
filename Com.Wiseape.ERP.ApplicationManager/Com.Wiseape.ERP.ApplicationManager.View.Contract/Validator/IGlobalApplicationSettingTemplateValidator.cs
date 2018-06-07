using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.ERP.ApplicationManager.View.Contract.Validator
{
    public interface IGlobalApplicationSettingTemplateValidator
    {

		ValidationResult ValidateApplicationSettingName(Int16 idGlobalApplicationSettingTemplate, string applicationSettingName);

		ValidationResult ValidateApplicationSettingName(string applicationSettingName);

		ValidationResult ValidateApplicationSettingValue(Int16 idGlobalApplicationSettingTemplate, string applicationSettingValue);

		ValidationResult ValidateApplicationSettingValue(string applicationSettingValue);

		ValidationResult ValidateIsActive(Int16 idGlobalApplicationSettingTemplate, Int16 isActive);

		ValidationResult ValidateIsActive(Int16 isActive);

	}
}