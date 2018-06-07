using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;

namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IDeleteGlobalApplicationSettingTemplateRepository
    {

	   	/// <summary>
	   	/// Delete all  Global Application Setting Template data with application Setting Name containing specified keyword
	    /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
		void DeleteByApplicationSettingName(string applicationSettingName);
	
	   	/// <summary>
	   	/// Delete all  Global Application Setting Template data with application Setting Value containing specified keyword
	    /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
		void DeleteByApplicationSettingValue(string applicationSettingValue);
	
	   	/// <summary>
	    /// Delete all  Global Application Setting Template data with specified is Active 
	    /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
		void DeleteByIsActive(Int16 isActive);
	
    }
}

