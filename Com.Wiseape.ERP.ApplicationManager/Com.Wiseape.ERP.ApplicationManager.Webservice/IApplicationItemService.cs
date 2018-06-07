using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.ApplicationManager.Business.Contract;

using System.ServiceModel;

namespace Com.Wiseape.ERP.ApplicationManager.Webservice
{
    /// <summary>
    /// Interface for ApplicationItem Service
    /// </summary>
    [ServiceContract]
    public interface IApplicationItemService
    {
    
        /// <summary>
        /// Service to add ApplicationItem data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ApplicationItemForm">ApplicationItem data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddApplicationItem(ApplicationItem applicationItemForm);

        /// <summary>
        /// Service to update ApplicationItem data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="applicationItemForm">ApplicationItem data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateApplicationItem(ApplicationItem applicationItemForm);

        /// <summary>
        /// Service to delete ApplicationItem data from data store. 
        /// The data deleted is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteApplicationItem(string idApplication);

        /// <summary>
        /// Service to get a ApplicationItem data from data store. 
        /// The data retrieved is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetApplicationItem(string idApplication);

        /// <summary>
        /// Service to get all the ApplicationItem data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindApplicationItem(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Application Item data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationName(string applicationName);

        /// <summary>
        /// Updates  Application Item's application Name which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationName(string idApplication,string applicationName);

        /// <summary>
        /// Delete all  Application Item data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationName(string applicationName);

        /// <summary>
        /// Finds all  Application Item data with application Title containing specified keyword
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationTitle(string applicationTitle);

        /// <summary>
        /// Updates  Application Item's application Title which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationTitle">application Title</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationTitle(string idApplication,string applicationTitle);

        /// <summary>
        /// Delete all  Application Item data with application Title containing specified keyword
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationTitle(string applicationTitle);

        /// <summary>
        /// Finds all  Application Item data with application Icon containing specified keyword
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationIcon(string applicationIcon);

        /// <summary>
        /// Updates  Application Item's application Icon which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationIcon">application Icon</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationIcon(string idApplication,string applicationIcon);

        /// <summary>
        /// Delete all  Application Item data with application Icon containing specified keyword
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationIcon(string applicationIcon);

        /// <summary>
        /// Finds all  Application Item data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Updates  Application Item's application Desc which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationDesc(string idApplication,string applicationDesc);

        /// <summary>
        /// Delete all  Application Item data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationDesc(string applicationDesc);

        /// <summary>
        /// Finds all  Application Item data with application Path containing specified keyword
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationPath(string applicationPath);

        /// <summary>
        /// Updates  Application Item's application Path which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationPath">application Path</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationPath(string idApplication,string applicationPath);

        /// <summary>
        /// Delete all  Application Item data with application Path containing specified keyword
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationPath(string applicationPath);

        /// <summary>
        /// Finds all  Application Item data with application File containing specified keyword
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationFile(string applicationFile);

        /// <summary>
        /// Updates  Application Item's application File which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationFile">application File</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationFile(string idApplication,string applicationFile);

        /// <summary>
        /// Delete all  Application Item data with application File containing specified keyword
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationFile(string applicationFile);

        /// <summary>
        /// Finds all  Application Item data with application Class containing specified keyword
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationClass(string applicationClass);

        /// <summary>
        /// Updates  Application Item's application Class which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationClass">application Class</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationClass(string idApplication,string applicationClass);

        /// <summary>
        /// Delete all  Application Item data with application Class containing specified keyword
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationClass(string applicationClass);

        /// <summary>
        /// Finds all  Application Item data with application Start Function containing specified keyword
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationStartFunction(string applicationStartFunction);

        /// <summary>
        /// Updates  Application Item's application Start Function which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationStartFunction">application Start Function</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationStartFunction(string idApplication,string applicationStartFunction);

        /// <summary>
        /// Delete all  Application Item data with application Start Function containing specified keyword
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationStartFunction(string applicationStartFunction);

        /// <summary>
        /// Finds all  Application Item data with specified application Group Id 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationGroupId(string applicationGroupId);

        /// <summary>
        /// Updates  Application Item's application Group Id which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationGroupId(string idApplication,string applicationGroupId);

        /// <summary>
        /// Delete all  Application Item data with specified application Group Id 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationGroupId(string applicationGroupId);

        /// <summary>
        /// Finds all  Application Item data with specified application Group Id, is Displayed 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByApplicationGroupIdAndIsDisplayed(string applicationGroupId,string isDisplayed);

        /// <summary>
        /// Updates  Application Item's application Group Id, is Displayed which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateApplicationGroupIdAndIsDisplayed(string idApplication,string applicationGroupId,string isDisplayed);

        /// <summary>
        /// Delete all  Application Item data with specified application Group Id, is Displayed 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByApplicationGroupIdAndIsDisplayed(string applicationGroupId,string isDisplayed);

        /// <summary>
        /// Finds all  Application Item data with specified is Displayed 
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream FindByIsDisplayed(string isDisplayed);

        /// <summary>
        /// Updates  Application Item's is Displayed which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream UpdateIsDisplayed(string idApplication,string isDisplayed);

        /// <summary>
        /// Delete all  Application Item data with specified is Displayed 
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
		[OperationContract]
		Stream DeleteByIsDisplayed(string isDisplayed);
    
    }
}