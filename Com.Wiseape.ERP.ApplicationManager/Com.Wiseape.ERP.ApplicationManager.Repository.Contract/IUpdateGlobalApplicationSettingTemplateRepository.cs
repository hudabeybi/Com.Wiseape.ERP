using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IUpdateGlobalApplicationSettingTemplateRepository
    {

	    /// <summary>
	    /// Updates  Global Application Setting Template's id Global Application Setting Template, application Setting Name by idGlobalApplicationSettingTemplate
	    /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingName">application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
		void UpdateApplicationSettingName(Int16 idGlobalApplicationSettingTemplate, string applicationSettingName);
	
	    /// <summary>
	    /// Updates  Global Application Setting Template's id Global Application Setting Template, application Setting Value by idGlobalApplicationSettingTemplate
	    /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingValue">application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
		void UpdateApplicationSettingValue(Int16 idGlobalApplicationSettingTemplate, string applicationSettingValue);
	
	    /// <summary>
	    /// Updates  Global Application Setting Template's id Global Application Setting Template, is Active by idGlobalApplicationSettingTemplate
	    /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
		void UpdateIsActive(Int16 idGlobalApplicationSettingTemplate, Int16 isActive);
	
    }
}

