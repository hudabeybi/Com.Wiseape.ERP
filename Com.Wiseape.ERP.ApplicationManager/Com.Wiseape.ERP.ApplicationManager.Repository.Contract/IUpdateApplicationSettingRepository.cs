using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IUpdateApplicationSettingRepository
    {

	    /// <summary>
	    /// Updates  Application Setting's id Application Setting, setting Key by idApplicationSetting
	    /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  Application Setting</returns>
		void UpdateSettingKey(Int16 idApplicationSetting, string settingKey);
	
	    /// <summary>
	    /// Updates  Application Setting's id Application Setting, setting Value by idApplicationSetting
	    /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Application Setting</returns>
		void UpdateSettingValue(Int16 idApplicationSetting, string settingValue);
	
	    /// <summary>
	    /// Updates  Application Setting's id Application Setting, app Name by idApplicationSetting
	    /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="appName">app Name</param>
		/// <returns>List of  Application Setting</returns>
		void UpdateAppName(Int16 idApplicationSetting, string appName);
	
    }
}

