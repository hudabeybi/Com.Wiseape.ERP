using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.ERP.ApplicationManager.View.Contract.Validator
{
    public interface IApplicationSettingValidator
    {

		ValidationResult ValidateSettingKey(Int16 idApplicationSetting, string settingKey);

		ValidationResult ValidateSettingKey(string settingKey);

		ValidationResult ValidateSettingValue(Int16 idApplicationSetting, string settingValue);

		ValidationResult ValidateSettingValue(string settingValue);

		ValidationResult ValidateAppName(Int16 idApplicationSetting, string appName);

		ValidationResult ValidateAppName(string appName);

	}
}