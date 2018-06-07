using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;

namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IDeleteApplicationGroupRepository
    {

	   	/// <summary>
	   	/// Delete all  Application Group data with application Group Name containing specified keyword
	    /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
		void DeleteByApplicationGroupName(string applicationGroupName);
	
	   	/// <summary>
	   	/// Delete all  Application Group data with application Group Desc containing specified keyword
	    /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		void DeleteByApplicationGroupDesc(string applicationGroupDesc);
	
	   	/// <summary>
	   	/// Delete all  Application Group data with application Group Icon containing specified keyword
	    /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		void DeleteByApplicationGroupIcon(string applicationGroupIcon);
	
    }
}

