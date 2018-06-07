using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IUpdateGlobalApplicationSettingTemplateBusinessService
    {

        /// <summary>
        /// Updates  Global Application Setting Template's application Setting Name which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingName">application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
		OperationResult UpdateApplicationSettingName(Int16 idGlobalApplicationSettingTemplate, string applicationSettingName);

        /// <summary>
        /// Updates  Global Application Setting Template's application Setting Value which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingValue">application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
		OperationResult UpdateApplicationSettingValue(Int16 idGlobalApplicationSettingTemplate, string applicationSettingValue);

        /// <summary>
        /// Updates  Global Application Setting Template's is Active which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
		OperationResult UpdateIsActive(Int16 idGlobalApplicationSettingTemplate, Int16 isActive);

	}
}