using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IFindGlobalApplicationSettingBusinessService
    {

        /// <summary>
        /// Finds all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
		OperationResult FindBySettingName(string settingName);

        /// <summary>
        /// Finds all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
		OperationResult FindBySettingValue(string settingValue);

        /// <summary>
        /// Finds all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>List of  Global Application Setting</returns>
		OperationResult FindByUserID(string userID);

	}
}