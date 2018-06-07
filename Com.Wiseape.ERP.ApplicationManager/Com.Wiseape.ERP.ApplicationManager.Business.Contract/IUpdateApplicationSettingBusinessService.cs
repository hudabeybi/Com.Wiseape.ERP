using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IUpdateApplicationSettingBusinessService
    {

        /// <summary>
        /// Updates  Application Setting's setting Key which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  Application Setting</returns>
		OperationResult UpdateSettingKey(Int16 idApplicationSetting, string settingKey);

        /// <summary>
        /// Updates  Application Setting's setting Value which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Application Setting</returns>
		OperationResult UpdateSettingValue(Int16 idApplicationSetting, string settingValue);

        /// <summary>
        /// Updates  Application Setting's app Name which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="appName">app Name</param>
		/// <returns>List of  Application Setting</returns>
		OperationResult UpdateAppName(Int16 idApplicationSetting, string appName);

	}
}