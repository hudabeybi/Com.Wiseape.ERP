using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IFindApplicationItemRepository
    {

        /// <summary>
        /// Finds all  Application Item data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationName(string applicationName);

        /// <summary>
        /// Finds all  Application Item data with application Title containing specified keyword
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationTitle(string applicationTitle);

        /// <summary>
        /// Finds all  Application Item data with application Icon containing specified keyword
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationIcon(string applicationIcon);

        /// <summary>
        /// Finds all  Application Item data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Finds all  Application Item data with application Path containing specified keyword
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationPath(string applicationPath);

        /// <summary>
        /// Finds all  Application Item data with application File containing specified keyword
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationFile(string applicationFile);

        /// <summary>
        /// Finds all  Application Item data with application Class containing specified keyword
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationClass(string applicationClass);

        /// <summary>
        /// Finds all  Application Item data with application Start Function containing specified keyword
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationStartFunction(string applicationStartFunction);

        /// <summary>
        /// Finds all  Application Item data with application Group Id containing specified keyword
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationGroupId(Int16 applicationGroupId);

        /// <summary>
        /// Finds all  Application Item data with application Group Id, is Displayed containing specified keyword
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByApplicationGroupIdAndIsDisplayed(Int16 applicationGroupId, Int16 isDisplayed);

        /// <summary>
        /// Finds all  Application Item data with is Displayed containing specified keyword
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
		List<ApplicationItem> FindByIsDisplayed(Int16 isDisplayed);

    }
}

