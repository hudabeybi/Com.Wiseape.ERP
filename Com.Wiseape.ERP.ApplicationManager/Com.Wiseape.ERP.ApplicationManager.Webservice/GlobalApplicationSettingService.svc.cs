using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.ApplicationManager.Business.Contract;


namespace Com.Wiseape.ERP.ApplicationManager.Webservice
{
	[AspNetCompatibilityRequirements(
            RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class GlobalApplicationSettingService : IGlobalApplicationSettingService
    {

        class Keywords
        {
            public static string GlobalApplicationSetting = "ERP.ApplicationManager.GlobalApplicationSetting";
            public static string FindGlobalApplicationSetting = "Find.ERP.ApplicationManager.GlobalApplicationSetting";
            public static string AddGlobalApplicationSetting = "Add.ERP.ApplicationManager.GlobalApplicationSetting";
            public static string UpdateGlobalApplicationSetting = "Update.ERP.ApplicationManager.GlobalApplicationSetting";
            public static string DeleteGlobalApplicationSetting = "Delete.ERP.ApplicationManager.GlobalApplicationSetting";
        }

        /// <summary>
        /// Service to add GlobalApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="GlobalApplicationSettingForm">GlobalApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/add")]
        public Stream AddGlobalApplicationSetting(GlobalApplicationSetting globalApplicationSettingForm)
        {
            BaseBusinessService<GlobalApplicationSetting> businessService = (BaseBusinessService<GlobalApplicationSetting>)BusinessFactory.Create(Keywords.AddGlobalApplicationSetting);
            OperationResult result = businessService.Add(globalApplicationSettingForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update GlobalApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="globalApplicationSettingForm">GlobalApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/update")]
        public Stream UpdateGlobalApplicationSetting(GlobalApplicationSetting globalApplicationSettingForm)
        {
            BaseBusinessService<GlobalApplicationSetting> businessService = (BaseBusinessService<GlobalApplicationSetting>)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSetting);
            OperationResult result = businessService.Update(globalApplicationSettingForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete GlobalApplicationSetting data from data store. 
        /// The data deleted is defined by idGlobalApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/delete/{idGlobalApplicationSetting}")]
        public Stream DeleteGlobalApplicationSetting(string idGlobalApplicationSetting)
        {
            BaseBusinessService<GlobalApplicationSetting> businessService = (BaseBusinessService<GlobalApplicationSetting>)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSetting);
            OperationResult result = businessService.Delete(idGlobalApplicationSetting);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a GlobalApplicationSetting data from data store. 
        /// The data retrieved is defined by idGlobalApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/get/{idGlobalApplicationSetting}")]
        public Stream GetGlobalApplicationSetting(string idGlobalApplicationSetting)
        {
            BaseBusinessService<GlobalApplicationSetting> businessService = (BaseBusinessService<GlobalApplicationSetting>)BusinessFactory.Create(Keywords.FindGlobalApplicationSetting);
            OperationResult result = businessService.Get(idGlobalApplicationSetting);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the GlobalApplicationSetting data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/find/{keyword}/{page}/{max}")]
        public Stream FindGlobalApplicationSetting(string keyword, string page, string max)
        {
            BaseBusinessService<GlobalApplicationSetting> businessService = (BaseBusinessService<GlobalApplicationSetting>)BusinessFactory.Create(Keywords.FindGlobalApplicationSetting);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/find-by-setting-name/{settingName}")]
        public Stream FindBySettingName(string settingName)
        {
            IFindGlobalApplicationSettingBusinessService businessService = (IFindGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.FindGlobalApplicationSetting);
            OperationResult result = businessService.FindBySettingName(Convert.ToString(settingName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Global Application Setting's setting Name which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingName">setting Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/update-setting-name/{idGlobalApplicationSetting}/{settingName}")]
        public Stream UpdateSettingName(string idGlobalApplicationSetting,string settingName)
        {
            IUpdateGlobalApplicationSettingBusinessService businessService = (IUpdateGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSetting);
            OperationResult result = businessService.UpdateSettingName(Convert.ToInt16(idGlobalApplicationSetting),Convert.ToString(settingName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/delete-by-setting-name/{settingName}")]
        public Stream DeleteBySettingName(string settingName)
        {
            IDeleteGlobalApplicationSettingBusinessService businessService = (IDeleteGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSetting);
            OperationResult result = businessService.DeleteBySettingName(Convert.ToString(settingName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/find-by-setting-value/{settingValue}")]
        public Stream FindBySettingValue(string settingValue)
        {
            IFindGlobalApplicationSettingBusinessService businessService = (IFindGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.FindGlobalApplicationSetting);
            OperationResult result = businessService.FindBySettingValue(Convert.ToString(settingValue));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Global Application Setting's setting Value which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/update-setting-value/{idGlobalApplicationSetting}/{settingValue}")]
        public Stream UpdateSettingValue(string idGlobalApplicationSetting,string settingValue)
        {
            IUpdateGlobalApplicationSettingBusinessService businessService = (IUpdateGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSetting);
            OperationResult result = businessService.UpdateSettingValue(Convert.ToInt16(idGlobalApplicationSetting),Convert.ToString(settingValue) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/delete-by-setting-value/{settingValue}")]
        public Stream DeleteBySettingValue(string settingValue)
        {
            IDeleteGlobalApplicationSettingBusinessService businessService = (IDeleteGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSetting);
            OperationResult result = businessService.DeleteBySettingValue(Convert.ToString(settingValue) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>List of  Global Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/find-by-userid/{userID}")]
        public Stream FindByUserID(string userID)
        {
            IFindGlobalApplicationSettingBusinessService businessService = (IFindGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.FindGlobalApplicationSetting);
            OperationResult result = businessService.FindByUserID(Convert.ToString(userID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Global Application Setting's user I D which has specified idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="userID">user I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/update-user-i-d/{idGlobalApplicationSetting}/{userID}")]
        public Stream UpdateUserID(string idGlobalApplicationSetting,string userID)
        {
            IUpdateGlobalApplicationSettingBusinessService businessService = (IUpdateGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSetting);
            OperationResult result = businessService.UpdateUserID(Convert.ToInt16(idGlobalApplicationSetting),Convert.ToString(userID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>List of  Global Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsetting/delete-by-user-i-d/{userID}")]
        public Stream DeleteByUserID(string userID)
        {
            IDeleteGlobalApplicationSettingBusinessService businessService = (IDeleteGlobalApplicationSettingBusinessService)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSetting);
            OperationResult result = businessService.DeleteByUserID(Convert.ToString(userID) );
            return result.ToJsonStream();
        }	
		
 
	}
}