using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IDeleteApplicationGroupBusinessService
    {

        /// <summary>
        /// Delete all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
		OperationResult DeleteByApplicationGroupName(string applicationGroupName);

        /// <summary>
        /// Delete all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		OperationResult DeleteByApplicationGroupDesc(string applicationGroupDesc);

        /// <summary>
        /// Delete all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		OperationResult DeleteByApplicationGroupIcon(string applicationGroupIcon);

	}
}