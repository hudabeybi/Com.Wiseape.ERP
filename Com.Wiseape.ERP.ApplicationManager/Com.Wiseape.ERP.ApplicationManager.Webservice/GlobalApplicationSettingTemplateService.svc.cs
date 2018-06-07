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
    public class GlobalApplicationSettingTemplateService : IGlobalApplicationSettingTemplateService
    {

        class Keywords
        {
            public static string GlobalApplicationSettingTemplate = "ERP.ApplicationManager.GlobalApplicationSettingTemplate";
            public static string FindGlobalApplicationSettingTemplate = "Find.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
            public static string AddGlobalApplicationSettingTemplate = "Add.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
            public static string UpdateGlobalApplicationSettingTemplate = "Update.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
            public static string DeleteGlobalApplicationSettingTemplate = "Delete.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
        }

        /// <summary>
        /// Service to add GlobalApplicationSettingTemplate data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="GlobalApplicationSettingTemplateForm">GlobalApplicationSettingTemplate data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/add")]
        public Stream AddGlobalApplicationSettingTemplate(GlobalApplicationSettingTemplate globalApplicationSettingTemplateForm)
        {
            BaseBusinessService<GlobalApplicationSettingTemplate> businessService = (BaseBusinessService<GlobalApplicationSettingTemplate>)BusinessFactory.Create(Keywords.AddGlobalApplicationSettingTemplate);
            OperationResult result = businessService.Add(globalApplicationSettingTemplateForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update GlobalApplicationSettingTemplate data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="globalApplicationSettingTemplateForm">GlobalApplicationSettingTemplate data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/update")]
        public Stream UpdateGlobalApplicationSettingTemplate(GlobalApplicationSettingTemplate globalApplicationSettingTemplateForm)
        {
            BaseBusinessService<GlobalApplicationSettingTemplate> businessService = (BaseBusinessService<GlobalApplicationSettingTemplate>)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
            OperationResult result = businessService.Update(globalApplicationSettingTemplateForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete GlobalApplicationSettingTemplate data from data store. 
        /// The data deleted is defined by idGlobalApplicationSettingTemplate.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSettingTemplate">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/delete/{idGlobalApplicationSettingTemplate}")]
        public Stream DeleteGlobalApplicationSettingTemplate(string idGlobalApplicationSettingTemplate)
        {
            BaseBusinessService<GlobalApplicationSettingTemplate> businessService = (BaseBusinessService<GlobalApplicationSettingTemplate>)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
            OperationResult result = businessService.Delete(idGlobalApplicationSettingTemplate);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a GlobalApplicationSettingTemplate data from data store. 
        /// The data retrieved is defined by idGlobalApplicationSettingTemplate.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGlobalApplicationSettingTemplate">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/get/{idGlobalApplicationSettingTemplate}")]
        public Stream GetGlobalApplicationSettingTemplate(string idGlobalApplicationSettingTemplate)
        {
            BaseBusinessService<GlobalApplicationSettingTemplate> businessService = (BaseBusinessService<GlobalApplicationSettingTemplate>)BusinessFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);
            OperationResult result = businessService.Get(idGlobalApplicationSettingTemplate);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the GlobalApplicationSettingTemplate data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/find/{keyword}/{page}/{max}")]
        public Stream FindGlobalApplicationSettingTemplate(string keyword, string page, string max)
        {
            BaseBusinessService<GlobalApplicationSettingTemplate> businessService = (BaseBusinessService<GlobalApplicationSettingTemplate>)BusinessFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/find-by-application-setting-name/{applicationSettingName}")]
        public Stream FindByApplicationSettingName(string applicationSettingName)
        {
            IFindGlobalApplicationSettingTemplateBusinessService businessService = (IFindGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);
            OperationResult result = businessService.FindByApplicationSettingName(Convert.ToString(applicationSettingName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Global Application Setting Template's application Setting Name which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingName">application Setting Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/update-application-setting-name/{idGlobalApplicationSettingTemplate}/{applicationSettingName}")]
        public Stream UpdateApplicationSettingName(string idGlobalApplicationSettingTemplate,string applicationSettingName)
        {
            IUpdateGlobalApplicationSettingTemplateBusinessService businessService = (IUpdateGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
            OperationResult result = businessService.UpdateApplicationSettingName(Convert.ToInt16(idGlobalApplicationSettingTemplate),Convert.ToString(applicationSettingName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/delete-by-application-setting-name/{applicationSettingName}")]
        public Stream DeleteByApplicationSettingName(string applicationSettingName)
        {
            IDeleteGlobalApplicationSettingTemplateBusinessService businessService = (IDeleteGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
            OperationResult result = businessService.DeleteByApplicationSettingName(Convert.ToString(applicationSettingName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/find-by-application-setting-value/{applicationSettingValue}")]
        public Stream FindByApplicationSettingValue(string applicationSettingValue)
        {
            IFindGlobalApplicationSettingTemplateBusinessService businessService = (IFindGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);
            OperationResult result = businessService.FindByApplicationSettingValue(Convert.ToString(applicationSettingValue));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Global Application Setting Template's application Setting Value which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingValue">application Setting Value</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/update-application-setting-value/{idGlobalApplicationSettingTemplate}/{applicationSettingValue}")]
        public Stream UpdateApplicationSettingValue(string idGlobalApplicationSettingTemplate,string applicationSettingValue)
        {
            IUpdateGlobalApplicationSettingTemplateBusinessService businessService = (IUpdateGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
            OperationResult result = businessService.UpdateApplicationSettingValue(Convert.ToInt16(idGlobalApplicationSettingTemplate),Convert.ToString(applicationSettingValue) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/delete-by-application-setting-value/{applicationSettingValue}")]
        public Stream DeleteByApplicationSettingValue(string applicationSettingValue)
        {
            IDeleteGlobalApplicationSettingTemplateBusinessService businessService = (IDeleteGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
            OperationResult result = businessService.DeleteByApplicationSettingValue(Convert.ToString(applicationSettingValue) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Global Application Setting Template data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/find-by-is-active/{isActive}")]
        public Stream FindByIsActive(string isActive)
        {
            IFindGlobalApplicationSettingTemplateBusinessService businessService = (IFindGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);
            OperationResult result = businessService.FindByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Global Application Setting Template's is Active which has specified idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/update-is-active/{idGlobalApplicationSettingTemplate}/{isActive}")]
        public Stream UpdateIsActive(string idGlobalApplicationSettingTemplate,string isActive)
        {
            IUpdateGlobalApplicationSettingTemplateBusinessService businessService = (IUpdateGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
            OperationResult result = businessService.UpdateIsActive(Convert.ToInt16(idGlobalApplicationSettingTemplate),Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Global Application Setting Template data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "globalapplicationsettingtemplate/delete-by-is-active/{isActive}")]
        public Stream DeleteByIsActive(string isActive)
        {
            IDeleteGlobalApplicationSettingTemplateBusinessService businessService = (IDeleteGlobalApplicationSettingTemplateBusinessService)BusinessFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
            OperationResult result = businessService.DeleteByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		
 
	}
}