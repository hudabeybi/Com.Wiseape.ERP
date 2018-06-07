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
    public class ApplicationItemService : IApplicationItemService
    {

        class Keywords
        {
            public static string ApplicationItem = "ERP.ApplicationManager.ApplicationItem";
            public static string FindApplicationItem = "Find.ERP.ApplicationManager.ApplicationItem";
            public static string AddApplicationItem = "Add.ERP.ApplicationManager.ApplicationItem";
            public static string UpdateApplicationItem = "Update.ERP.ApplicationManager.ApplicationItem";
            public static string DeleteApplicationItem = "Delete.ERP.ApplicationManager.ApplicationItem";
        }

        /// <summary>
        /// Service to add ApplicationItem data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ApplicationItemForm">ApplicationItem data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/add")]
        public Stream AddApplicationItem(ApplicationItem applicationItemForm)
        {
            BaseBusinessService<ApplicationItem> businessService = (BaseBusinessService<ApplicationItem>)BusinessFactory.Create(Keywords.AddApplicationItem);
            OperationResult result = businessService.Add(applicationItemForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update ApplicationItem data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="applicationItemForm">ApplicationItem data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update")]
        public Stream UpdateApplicationItem(ApplicationItem applicationItemForm)
        {
            BaseBusinessService<ApplicationItem> businessService = (BaseBusinessService<ApplicationItem>)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.Update(applicationItemForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete ApplicationItem data from data store. 
        /// The data deleted is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete/{idApplication}")]
        public Stream DeleteApplicationItem(string idApplication)
        {
            BaseBusinessService<ApplicationItem> businessService = (BaseBusinessService<ApplicationItem>)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.Delete(idApplication);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a ApplicationItem data from data store. 
        /// The data retrieved is defined by idApplication.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplication">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/get/{idApplication}")]
        public Stream GetApplicationItem(string idApplication)
        {
            BaseBusinessService<ApplicationItem> businessService = (BaseBusinessService<ApplicationItem>)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.Get(idApplication);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the ApplicationItem data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find/{keyword}/{page}/{max}")]
        public Stream FindApplicationItem(string keyword, string page, string max)
        {
            BaseBusinessService<ApplicationItem> businessService = (BaseBusinessService<ApplicationItem>)BusinessFactory.Create(Keywords.FindApplicationItem);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Application Item data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-name/{applicationName}")]
        public Stream FindByApplicationName(string applicationName)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationName(Convert.ToString(applicationName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application Name which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-name/{idApplication}/{applicationName}")]
        public Stream UpdateApplicationName(string idApplication,string applicationName)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationName(Convert.ToInt16(idApplication),Convert.ToString(applicationName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-name/{applicationName}")]
        public Stream DeleteByApplicationName(string applicationName)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationName(Convert.ToString(applicationName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with application Title containing specified keyword
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-title/{applicationTitle}")]
        public Stream FindByApplicationTitle(string applicationTitle)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationTitle(Convert.ToString(applicationTitle));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application Title which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationTitle">application Title</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-title/{idApplication}/{applicationTitle}")]
        public Stream UpdateApplicationTitle(string idApplication,string applicationTitle)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationTitle(Convert.ToInt16(idApplication),Convert.ToString(applicationTitle) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application Title containing specified keyword
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-title/{applicationTitle}")]
        public Stream DeleteByApplicationTitle(string applicationTitle)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationTitle(Convert.ToString(applicationTitle) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with application Icon containing specified keyword
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-icon/{applicationIcon}")]
        public Stream FindByApplicationIcon(string applicationIcon)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationIcon(Convert.ToString(applicationIcon));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application Icon which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationIcon">application Icon</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-icon/{idApplication}/{applicationIcon}")]
        public Stream UpdateApplicationIcon(string idApplication,string applicationIcon)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationIcon(Convert.ToInt16(idApplication),Convert.ToString(applicationIcon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application Icon containing specified keyword
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-icon/{applicationIcon}")]
        public Stream DeleteByApplicationIcon(string applicationIcon)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationIcon(Convert.ToString(applicationIcon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-desc/{applicationDesc}")]
        public Stream FindByApplicationDesc(string applicationDesc)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationDesc(Convert.ToString(applicationDesc));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application Desc which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-desc/{idApplication}/{applicationDesc}")]
        public Stream UpdateApplicationDesc(string idApplication,string applicationDesc)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationDesc(Convert.ToInt16(idApplication),Convert.ToString(applicationDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-desc/{applicationDesc}")]
        public Stream DeleteByApplicationDesc(string applicationDesc)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationDesc(Convert.ToString(applicationDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with application Path containing specified keyword
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-path/{applicationPath}")]
        public Stream FindByApplicationPath(string applicationPath)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationPath(Convert.ToString(applicationPath));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application Path which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationPath">application Path</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-path/{idApplication}/{applicationPath}")]
        public Stream UpdateApplicationPath(string idApplication,string applicationPath)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationPath(Convert.ToInt16(idApplication),Convert.ToString(applicationPath) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application Path containing specified keyword
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-path/{applicationPath}")]
        public Stream DeleteByApplicationPath(string applicationPath)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationPath(Convert.ToString(applicationPath) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with application File containing specified keyword
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-file/{applicationFile}")]
        public Stream FindByApplicationFile(string applicationFile)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationFile(Convert.ToString(applicationFile));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application File which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationFile">application File</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-file/{idApplication}/{applicationFile}")]
        public Stream UpdateApplicationFile(string idApplication,string applicationFile)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationFile(Convert.ToInt16(idApplication),Convert.ToString(applicationFile) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application File containing specified keyword
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-file/{applicationFile}")]
        public Stream DeleteByApplicationFile(string applicationFile)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationFile(Convert.ToString(applicationFile) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with application Class containing specified keyword
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-class/{applicationClass}")]
        public Stream FindByApplicationClass(string applicationClass)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationClass(Convert.ToString(applicationClass));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application Class which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationClass">application Class</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-class/{idApplication}/{applicationClass}")]
        public Stream UpdateApplicationClass(string idApplication,string applicationClass)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationClass(Convert.ToInt16(idApplication),Convert.ToString(applicationClass) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application Class containing specified keyword
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-class/{applicationClass}")]
        public Stream DeleteByApplicationClass(string applicationClass)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationClass(Convert.ToString(applicationClass) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with application Start Function containing specified keyword
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-start-function/{applicationStartFunction}")]
        public Stream FindByApplicationStartFunction(string applicationStartFunction)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationStartFunction(Convert.ToString(applicationStartFunction));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Item's application Start Function which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationStartFunction">application Start Function</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-start-function/{idApplication}/{applicationStartFunction}")]
        public Stream UpdateApplicationStartFunction(string idApplication,string applicationStartFunction)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationStartFunction(Convert.ToInt16(idApplication),Convert.ToString(applicationStartFunction) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with application Start Function containing specified keyword
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-start-function/{applicationStartFunction}")]
        public Stream DeleteByApplicationStartFunction(string applicationStartFunction)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationStartFunction(Convert.ToString(applicationStartFunction) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with specified application Group Id 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-group-id/{applicationGroupId}")]
        public Stream FindByApplicationGroupId(string applicationGroupId)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationGroupId(Convert.ToInt16(applicationGroupId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Application Item's application Group Id which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-group-id/{idApplication}/{applicationGroupId}")]
        public Stream UpdateApplicationGroupId(string idApplication,string applicationGroupId)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationGroupId(Convert.ToInt16(idApplication),Convert.ToInt16(applicationGroupId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with specified application Group Id 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-group-id/{applicationGroupId}")]
        public Stream DeleteByApplicationGroupId(string applicationGroupId)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationGroupId(Convert.ToInt16(applicationGroupId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with specified application Group Id, is Displayed 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-application-group-id-and-is-displayed/{applicationGroupId}/{isDisplayed}")]
        public Stream FindByApplicationGroupIdAndIsDisplayed(string applicationGroupId,string isDisplayed)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByApplicationGroupIdAndIsDisplayed(Convert.ToInt16(applicationGroupId),Convert.ToInt16(isDisplayed) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Application Item's application Group Id, is Displayed which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-application-group-id-and-is-displayed/{idApplication}/{applicationGroupId}/{isDisplayed}")]
        public Stream UpdateApplicationGroupIdAndIsDisplayed(string idApplication,string applicationGroupId,string isDisplayed)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateApplicationGroupIdAndIsDisplayed(Convert.ToInt16(idApplication),Convert.ToInt16(applicationGroupId),Convert.ToInt16(isDisplayed) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with specified application Group Id, is Displayed 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-application-group-id-and-is-displayed/{applicationGroupId}/{isDisplayed}")]
        public Stream DeleteByApplicationGroupIdAndIsDisplayed(string applicationGroupId,string isDisplayed)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByApplicationGroupIdAndIsDisplayed(Convert.ToInt16(applicationGroupId),Convert.ToInt16(isDisplayed) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Item data with specified is Displayed 
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/find-by-is-displayed/{isDisplayed}")]
        public Stream FindByIsDisplayed(string isDisplayed)
        {
            IFindApplicationItemBusinessService businessService = (IFindApplicationItemBusinessService)BusinessFactory.Create(Keywords.FindApplicationItem);
            OperationResult result = businessService.FindByIsDisplayed(Convert.ToInt16(isDisplayed) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Application Item's is Displayed which has specified idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/update-is-displayed/{idApplication}/{isDisplayed}")]
        public Stream UpdateIsDisplayed(string idApplication,string isDisplayed)
        {
            IUpdateApplicationItemBusinessService businessService = (IUpdateApplicationItemBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationItem);
            OperationResult result = businessService.UpdateIsDisplayed(Convert.ToInt16(idApplication),Convert.ToInt16(isDisplayed) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Item data with specified is Displayed 
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationitem/delete-by-is-displayed/{isDisplayed}")]
        public Stream DeleteByIsDisplayed(string isDisplayed)
        {
            IDeleteApplicationItemBusinessService businessService = (IDeleteApplicationItemBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationItem);
            OperationResult result = businessService.DeleteByIsDisplayed(Convert.ToInt16(isDisplayed) );
            return result.ToJsonStream();
        }	
		
 
	}
}