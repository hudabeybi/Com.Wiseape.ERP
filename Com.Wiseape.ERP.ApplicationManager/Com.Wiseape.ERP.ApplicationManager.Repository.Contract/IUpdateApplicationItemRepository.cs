using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IUpdateApplicationItemRepository
    {

	    /// <summary>
	    /// Updates  Application Item's id Application, application Name by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationName(Int16 idApplication, string applicationName);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Title by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationTitle">application Title</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationTitle(Int16 idApplication, string applicationTitle);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Icon by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationIcon">application Icon</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationIcon(Int16 idApplication, string applicationIcon);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Desc by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationDesc(Int16 idApplication, string applicationDesc);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Path by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationPath">application Path</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationPath(Int16 idApplication, string applicationPath);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application File by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationFile">application File</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationFile(Int16 idApplication, string applicationFile);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Class by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationClass">application Class</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationClass(Int16 idApplication, string applicationClass);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Start Function by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationStartFunction">application Start Function</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationStartFunction(Int16 idApplication, string applicationStartFunction);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Group Id by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationGroupId(Int16 idApplication, Int16 applicationGroupId);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, application Group Id, is Displayed by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
		void UpdateApplicationGroupIdAndIsDisplayed(Int16 idApplication, Int16 applicationGroupId, Int16 isDisplayed);
	
	    /// <summary>
	    /// Updates  Application Item's id Application, is Displayed by idApplication
	    /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
		void UpdateIsDisplayed(Int16 idApplication, Int16 isDisplayed);
	
    }
}

