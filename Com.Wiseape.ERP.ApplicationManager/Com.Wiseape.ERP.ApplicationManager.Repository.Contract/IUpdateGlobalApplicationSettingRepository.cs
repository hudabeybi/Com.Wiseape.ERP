using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IUpdateGlobalApplicationSettingRepository
    {

	    /// <summary>
	    /// Updates  Global Application Setting's id Global Application Setting, setting Name by idGlobalApplicationSetting
	    /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingName">setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
		void UpdateSettingName(Int16 idGlobalApplicationSetting, string settingName);
	
	    /// <summary>
	    /// Updates  Global Application Setting's id Global Application Setting, setting Value by idGlobalApplicationSetting
	    /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
		void UpdateSettingValue(Int16 idGlobalApplicationSetting, string settingValue);
	
	    /// <summary>
	    /// Updates  Global Application Setting's id Global Application Setting, user I D by idGlobalApplicationSetting
	    /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="userID">user I D</param>
		/// <returns>List of  Global Application Setting</returns>
		void UpdateUserID(Int16 idGlobalApplicationSetting, string userID);
	
    }
}

