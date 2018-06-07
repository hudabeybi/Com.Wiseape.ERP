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
    /// Interface for GlobalApplicationSettingTemplate Service
    /// </summary>
    [ServiceContract]
    public interface IGlobalApplicationSettingTemplateService
    {
    
        /// <summary>
        /// Service to add GlobalApplicationSettingTemplate data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="GlobalApplicationSettingTemplateForm">GlobalApplicationSettingTemplate data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddGlobalApplicationSettingTemplate(GlobalApplicationSettingTemplate globalApplicationSettingTemplateForm);

        /// <summary>
        /// Service to update GlobalApplicationSettingTemplate data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="globalApplicationSettingTemplateForm">GlobalApplicationSettingTemplate data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateGlobalApplicationSettingTemplate(GlobalApplicationSettingTemplate globalApplicationSettingTemplateForm);

        /// <summary>
        /// Service to delete GlobalApplicationSettingTemplate data from data store. 
        /// The data deleted is defined by idGlobalApplicationSettingTemplate.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSettingTemplate">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteGlobalApplicationSettingTemplate(string idGlobalApplicationSettingTemplate);

        /// <summary>
        /// Service to get a GlobalApplicationSettingTemplate data from data store. 
        /// The data retrieved is defined by idGlobalApplicationSettingTemplate.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSettingTemplate">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetGlobalApplicationSettingTemplate(string idGlobalApplicationSettingTemplate);

        /// <summary>
        /// Service to get all the GlobalApplicationSettingTemplate data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindGlobalApplicationSettingTemplate(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream FindByApplicationSettingName(string applicationSettingName);

        /// <summary>
        /// Updates  Global Application Setting Template's application Setting Name which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingName">application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream UpdateApplicationSettingName(string idGlobalApplicationSettingTemplate,string applicationSettingName);

        /// <summary>
        /// Delete all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream DeleteByApplicationSettingName(string applicationSettingName);

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream FindByApplicationSettingValue(string applicationSettingValue);

        /// <summary>
        /// Updates  Global Application Setting Template's application Setting Value which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingValue">application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream UpdateApplicationSettingValue(string idGlobalApplicationSettingTemplate,string applicationSettingValue);

        /// <summary>
        /// Delete all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream DeleteByApplicationSettingValue(string applicationSettingValue);

        /// <summary>
        /// Finds all  Global Application Setting Template data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream FindByIsActive(string isActive);

        /// <summary>
        /// Updates  Global Application Setting Template's is Active which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream UpdateIsActive(string idGlobalApplicationSettingTemplate,string isActive);

        /// <summary>
        /// Delete all  Global Application Setting Template data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
		[OperationContract]
		Stream DeleteByIsActive(string isActive);
    
    }
}