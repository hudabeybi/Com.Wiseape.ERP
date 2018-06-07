using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IDeleteApplicationSettingBusinessService
    {

        /// <summary>
        /// Delete all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
		OperationResult DeleteBySettingKey(string settingKey);

        /// <summary>
        /// Delete all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
		OperationResult DeleteBySettingValue(string settingValue);

        /// <summary>
        /// Delete all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
		OperationResult DeleteByAppName(string appName);

	}
}