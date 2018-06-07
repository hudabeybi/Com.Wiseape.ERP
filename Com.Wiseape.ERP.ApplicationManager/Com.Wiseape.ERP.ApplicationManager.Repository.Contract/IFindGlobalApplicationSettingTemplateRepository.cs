using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IFindGlobalApplicationSettingTemplateRepository
    {

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
		List<GlobalApplicationSettingTemplate> FindByApplicationSettingName(string applicationSettingName);

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
		List<GlobalApplicationSettingTemplate> FindByApplicationSettingValue(string applicationSettingValue);

        /// <summary>
        /// Finds all  Global Application Setting Template data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
		List<GlobalApplicationSettingTemplate> FindByIsActive(Int16 isActive);

    }
}

