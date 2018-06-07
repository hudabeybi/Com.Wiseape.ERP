using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IUpdateApplicationItemBusinessService
    {

        /// <summary>
        /// Updates  Application Item's application Name which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationName(Int16 idApplication, string applicationName);

        /// <summary>
        /// Updates  Application Item's application Title which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationTitle">application Title</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationTitle(Int16 idApplication, string applicationTitle);

        /// <summary>
        /// Updates  Application Item's application Icon which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationIcon">application Icon</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationIcon(Int16 idApplication, string applicationIcon);

        /// <summary>
        /// Updates  Application Item's application Desc which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationDesc(Int16 idApplication, string applicationDesc);

        /// <summary>
        /// Updates  Application Item's application Path which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationPath">application Path</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationPath(Int16 idApplication, string applicationPath);

        /// <summary>
        /// Updates  Application Item's application File which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationFile">application File</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationFile(Int16 idApplication, string applicationFile);

        /// <summary>
        /// Updates  Application Item's application Class which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationClass">application Class</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationClass(Int16 idApplication, string applicationClass);

        /// <summary>
        /// Updates  Application Item's application Start Function which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationStartFunction">application Start Function</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationStartFunction(Int16 idApplication, string applicationStartFunction);

        /// <summary>
        /// Updates  Application Item's application Group Id which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationGroupId(Int16 idApplication, Int16 applicationGroupId);

        /// <summary>
        /// Updates  Application Item's application Group Id, is Displayed which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateApplicationGroupIdAndIsDisplayed(Int16 idApplication, Int16 applicationGroupId, Int16 isDisplayed);

        /// <summary>
        /// Updates  Application Item's is Displayed which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
		OperationResult UpdateIsDisplayed(Int16 idApplication, Int16 isDisplayed);

	}
}