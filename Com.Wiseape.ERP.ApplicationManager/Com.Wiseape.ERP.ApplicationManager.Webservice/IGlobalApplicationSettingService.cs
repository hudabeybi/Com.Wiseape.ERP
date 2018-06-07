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
    /// Interface for GlobalApplicationSetting Service
    /// </summary>
    [ServiceContract]
    public interface IGlobalApplicationSettingService
    {
    
        /// <summary>
        /// Service to add GlobalApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="GlobalApplicationSettingForm">GlobalApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddGlobalApplicationSetting(GlobalApplicationSetting globalApplicationSettingForm);

        /// <summary>
        /// Service to update GlobalApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="globalApplicationSettingForm">GlobalApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateGlobalApplicationSetting(GlobalApplicationSetting globalApplicationSettingForm);

        /// <summary>
        /// Service to delete GlobalApplicationSetting data from data store. 
        /// The data deleted is defined by idGlobalApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteGlobalApplicationSetting(string idGlobalApplicationSetting);

        /// <summary>
        /// Service to get a GlobalApplicationSetting data from data store. 
        /// The data retrieved is defined by idGlobalApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetGlobalApplicationSetting(string idGlobalApplicationSetting);

        /// <summary>
        /// Service to get all the GlobalApplicationSetting data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindGlobalApplicationSetting(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream FindBySettingName(string settingName);

        /// <summary>
        /// Updates  Global Application Setting's setting Name which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingName">setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream UpdateSettingName(string idGlobalApplicationSetting,string settingName);

        /// <summary>
        /// Delete all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream DeleteBySettingName(string settingName);

        /// <summary>
        /// Finds all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream FindBySettingValue(string settingValue);

        /// <summary>
        /// Updates  Global Application Setting's setting Value which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream UpdateSettingValue(string idGlobalApplicationSetting,string settingValue);

        /// <summary>
        /// Delete all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream DeleteBySettingValue(string settingValue);

        /// <summary>
        /// Finds all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream FindByUserID(string userID);

        /// <summary>
        /// Updates  Global Application Setting's user I D which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="userID">user I D</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream UpdateUserID(string idGlobalApplicationSetting,string userID);

        /// <summary>
        /// Delete all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>List of  Global Application Setting</returns>
		[OperationContract]
		Stream DeleteByUserID(string userID);
    
    }
}