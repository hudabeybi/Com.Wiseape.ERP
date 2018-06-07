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
    /// Interface for ApplicationSetting Service
    /// </summary>
    [ServiceContract]
    public interface IApplicationSettingService
    {
    
        /// <summary>
        /// Service to add ApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ApplicationSettingForm">ApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddApplicationSetting(ApplicationSetting applicationSettingForm);

        /// <summary>
        /// Service to update ApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="applicationSettingForm">ApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateApplicationSetting(ApplicationSetting applicationSettingForm);

        /// <summary>
        /// Service to delete ApplicationSetting data from data store. 
        /// The data deleted is defined by idApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteApplicationSetting(string idApplicationSetting);

        /// <summary>
        /// Service to get a ApplicationSetting data from data store. 
        /// The data retrieved is defined by idApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetApplicationSetting(string idApplicationSetting);

        /// <summary>
        /// Service to get all the ApplicationSetting data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindApplicationSetting(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream FindBySettingKey(string settingKey);

        /// <summary>
        /// Updates  Application Setting's setting Key which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream UpdateSettingKey(string idApplicationSetting,string settingKey);

        /// <summary>
        /// Delete all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream DeleteBySettingKey(string settingKey);

        /// <summary>
        /// Finds all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream FindBySettingValue(string settingValue);

        /// <summary>
        /// Updates  Application Setting's setting Value which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream UpdateSettingValue(string idApplicationSetting,string settingValue);

        /// <summary>
        /// Delete all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream DeleteBySettingValue(string settingValue);

        /// <summary>
        /// Finds all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream FindByAppName(string appName);

        /// <summary>
        /// Updates  Application Setting's app Name which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="appName">app Name</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream UpdateAppName(string idApplicationSetting,string appName);

        /// <summary>
        /// Delete all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
		[OperationContract]
		Stream DeleteByAppName(string appName);
    
    }
}