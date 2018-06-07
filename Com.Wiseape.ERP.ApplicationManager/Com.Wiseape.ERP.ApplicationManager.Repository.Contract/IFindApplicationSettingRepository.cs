using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IFindApplicationSettingRepository
    {

        /// <summary>
        /// Finds all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
		List<ApplicationSetting> FindBySettingKey(string settingKey);

        /// <summary>
        /// Finds all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
		List<ApplicationSetting> FindBySettingValue(string settingValue);

        /// <summary>
        /// Finds all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
		List<ApplicationSetting> FindByAppName(string appName);

    }
}

