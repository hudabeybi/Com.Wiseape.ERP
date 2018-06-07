using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IUpdateGlobalApplicationSettingBusinessService
    {

        /// <summary>
        /// Updates  Global Application Setting's setting Name which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingName">setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
		OperationResult UpdateSettingName(Int16 idGlobalApplicationSetting, string settingName);

        /// <summary>
        /// Updates  Global Application Setting's setting Value which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
		OperationResult UpdateSettingValue(Int16 idGlobalApplicationSetting, string settingValue);

        /// <summary>
        /// Updates  Global Application Setting's user I D which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="userID">user I D</param>
		/// <returns>List of  Global Application Setting</returns>
		OperationResult UpdateUserID(Int16 idGlobalApplicationSetting, string userID);

	}
}