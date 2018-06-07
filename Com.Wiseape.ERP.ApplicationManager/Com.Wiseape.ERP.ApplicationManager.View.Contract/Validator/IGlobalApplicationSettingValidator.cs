using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.ERP.ApplicationManager.View.Contract.Validator
{
    public interface IGlobalApplicationSettingValidator
    {

		ValidationResult ValidateSettingName(Int16 idGlobalApplicationSetting, string settingName);

		ValidationResult ValidateSettingName(string settingName);

		ValidationResult ValidateSettingValue(Int16 idGlobalApplicationSetting, string settingValue);

		ValidationResult ValidateSettingValue(string settingValue);

		ValidationResult ValidateUserID(Int16 idGlobalApplicationSetting, string userID);

		ValidationResult ValidateUserID(string userID);

	}
}