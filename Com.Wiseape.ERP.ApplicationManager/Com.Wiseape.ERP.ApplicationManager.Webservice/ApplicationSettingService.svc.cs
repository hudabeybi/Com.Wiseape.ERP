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
    public class ApplicationSettingService : IApplicationSettingService
    {

        class Keywords
        {
            public static string ApplicationSetting = "ERP.ApplicationManager.ApplicationSetting";
            public static string FindApplicationSetting = "Find.ERP.ApplicationManager.ApplicationSetting";
            public static string AddApplicationSetting = "Add.ERP.ApplicationManager.ApplicationSetting";
            public static string UpdateApplicationSetting = "Update.ERP.ApplicationManager.ApplicationSetting";
            public static string DeleteApplicationSetting = "Delete.ERP.ApplicationManager.ApplicationSetting";
        }

        /// <summary>
        /// Service to add ApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ApplicationSettingForm">ApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/add")]
        public Stream AddApplicationSetting(ApplicationSetting applicationSettingForm)
        {
            BaseBusinessService<ApplicationSetting> businessService = (BaseBusinessService<ApplicationSetting>)BusinessFactory.Create(Keywords.AddApplicationSetting);
            OperationResult result = businessService.Add(applicationSettingForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update ApplicationSetting data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="applicationSettingForm">ApplicationSetting data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/update")]
        public Stream UpdateApplicationSetting(ApplicationSetting applicationSettingForm)
        {
            BaseBusinessService<ApplicationSetting> businessService = (BaseBusinessService<ApplicationSetting>)BusinessFactory.Create(Keywords.UpdateApplicationSetting);
            OperationResult result = businessService.Update(applicationSettingForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete ApplicationSetting data from data store. 
        /// The data deleted is defined by idApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/delete/{idApplicationSetting}")]
        public Stream DeleteApplicationSetting(string idApplicationSetting)
        {
            BaseBusinessService<ApplicationSetting> businessService = (BaseBusinessService<ApplicationSetting>)BusinessFactory.Create(Keywords.DeleteApplicationSetting);
            OperationResult result = businessService.Delete(idApplicationSetting);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a ApplicationSetting data from data store. 
        /// The data retrieved is defined by idApplicationSetting.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationSetting">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/get/{idApplicationSetting}")]
        public Stream GetApplicationSetting(string idApplicationSetting)
        {
            BaseBusinessService<ApplicationSetting> businessService = (BaseBusinessService<ApplicationSetting>)BusinessFactory.Create(Keywords.FindApplicationSetting);
            OperationResult result = businessService.Get(idApplicationSetting);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the ApplicationSetting data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/find/{keyword}/{page}/{max}")]
        public Stream FindApplicationSetting(string keyword, string page, string max)
        {
            BaseBusinessService<ApplicationSetting> businessService = (BaseBusinessService<ApplicationSetting>)BusinessFactory.Create(Keywords.FindApplicationSetting);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/find-by-setting-key/{settingKey}")]
        public Stream FindBySettingKey(string settingKey)
        {
            IFindApplicationSettingBusinessService businessService = (IFindApplicationSettingBusinessService)BusinessFactory.Create(Keywords.FindApplicationSetting);
            OperationResult result = businessService.FindBySettingKey(Convert.ToString(settingKey));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Setting's setting Key which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/update-setting-key/{idApplicationSetting}/{settingKey}")]
        public Stream UpdateSettingKey(string idApplicationSetting,string settingKey)
        {
            IUpdateApplicationSettingBusinessService businessService = (IUpdateApplicationSettingBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationSetting);
            OperationResult result = businessService.UpdateSettingKey(Convert.ToInt16(idApplicationSetting),Convert.ToString(settingKey) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/delete-by-setting-key/{settingKey}")]
        public Stream DeleteBySettingKey(string settingKey)
        {
            IDeleteApplicationSettingBusinessService businessService = (IDeleteApplicationSettingBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationSetting);
            OperationResult result = businessService.DeleteBySettingKey(Convert.ToString(settingKey) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/find-by-setting-value/{settingValue}")]
        public Stream FindBySettingValue(string settingValue)
        {
            IFindApplicationSettingBusinessService businessService = (IFindApplicationSettingBusinessService)BusinessFactory.Create(Keywords.FindApplicationSetting);
            OperationResult result = businessService.FindBySettingValue(Convert.ToString(settingValue));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Setting's setting Value which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/update-setting-value/{idApplicationSetting}/{settingValue}")]
        public Stream UpdateSettingValue(string idApplicationSetting,string settingValue)
        {
            IUpdateApplicationSettingBusinessService businessService = (IUpdateApplicationSettingBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationSetting);
            OperationResult result = businessService.UpdateSettingValue(Convert.ToInt16(idApplicationSetting),Convert.ToString(settingValue) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/delete-by-setting-value/{settingValue}")]
        public Stream DeleteBySettingValue(string settingValue)
        {
            IDeleteApplicationSettingBusinessService businessService = (IDeleteApplicationSettingBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationSetting);
            OperationResult result = businessService.DeleteBySettingValue(Convert.ToString(settingValue) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/find-by-app-name/{appName}")]
        public Stream FindByAppName(string appName)
        {
            IFindApplicationSettingBusinessService businessService = (IFindApplicationSettingBusinessService)BusinessFactory.Create(Keywords.FindApplicationSetting);
            OperationResult result = businessService.FindByAppName(Convert.ToString(appName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Setting's app Name which has specified idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="appName">app Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/update-app-name/{idApplicationSetting}/{appName}")]
        public Stream UpdateAppName(string idApplicationSetting,string appName)
        {
            IUpdateApplicationSettingBusinessService businessService = (IUpdateApplicationSettingBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationSetting);
            OperationResult result = businessService.UpdateAppName(Convert.ToInt16(idApplicationSetting),Convert.ToString(appName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationsetting/delete-by-app-name/{appName}")]
        public Stream DeleteByAppName(string appName)
        {
            IDeleteApplicationSettingBusinessService businessService = (IDeleteApplicationSettingBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationSetting);
            OperationResult result = businessService.DeleteByAppName(Convert.ToString(appName) );
            return result.ToJsonStream();
        }	
		
 
	}
}