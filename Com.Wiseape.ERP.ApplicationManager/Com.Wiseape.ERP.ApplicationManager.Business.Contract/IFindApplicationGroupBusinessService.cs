using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IFindApplicationGroupBusinessService
    {

        /// <summary>
        /// Finds all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
		OperationResult FindByApplicationGroupName(string applicationGroupName);

        /// <summary>
        /// Finds all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		OperationResult FindByApplicationGroupDesc(string applicationGroupDesc);

        /// <summary>
        /// Finds all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		OperationResult FindByApplicationGroupIcon(string applicationGroupIcon);

	}
}