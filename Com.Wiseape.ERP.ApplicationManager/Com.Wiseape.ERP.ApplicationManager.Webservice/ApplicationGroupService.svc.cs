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
    public class ApplicationGroupService : IApplicationGroupService
    {

        class Keywords
        {
            public static string ApplicationGroup = "ERP.ApplicationManager.ApplicationGroup";
            public static string FindApplicationGroup = "Find.ERP.ApplicationManager.ApplicationGroup";
            public static string AddApplicationGroup = "Add.ERP.ApplicationManager.ApplicationGroup";
            public static string UpdateApplicationGroup = "Update.ERP.ApplicationManager.ApplicationGroup";
            public static string DeleteApplicationGroup = "Delete.ERP.ApplicationManager.ApplicationGroup";
        }

        /// <summary>
        /// Service to add ApplicationGroup data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ApplicationGroupForm">ApplicationGroup data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/add")]
        public Stream AddApplicationGroup(ApplicationGroup applicationGroupForm)
        {
            BaseBusinessService<ApplicationGroup> businessService = (BaseBusinessService<ApplicationGroup>)BusinessFactory.Create(Keywords.AddApplicationGroup);
            OperationResult result = businessService.Add(applicationGroupForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update ApplicationGroup data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="applicationGroupForm">ApplicationGroup data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/update")]
        public Stream UpdateApplicationGroup(ApplicationGroup applicationGroupForm)
        {
            BaseBusinessService<ApplicationGroup> businessService = (BaseBusinessService<ApplicationGroup>)BusinessFactory.Create(Keywords.UpdateApplicationGroup);
            OperationResult result = businessService.Update(applicationGroupForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete ApplicationGroup data from data store. 
        /// The data deleted is defined by idApplicationGroup.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationGroup">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/delete/{idApplicationGroup}")]
        public Stream DeleteApplicationGroup(string idApplicationGroup)
        {
            BaseBusinessService<ApplicationGroup> businessService = (BaseBusinessService<ApplicationGroup>)BusinessFactory.Create(Keywords.DeleteApplicationGroup);
            OperationResult result = businessService.Delete(idApplicationGroup);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a ApplicationGroup data from data store. 
        /// The data retrieved is defined by idApplicationGroup.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationGroup">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/get/{idApplicationGroup}")]
        public Stream GetApplicationGroup(string idApplicationGroup)
        {
            BaseBusinessService<ApplicationGroup> businessService = (BaseBusinessService<ApplicationGroup>)BusinessFactory.Create(Keywords.FindApplicationGroup);
            OperationResult result = businessService.Get(idApplicationGroup);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the ApplicationGroup data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/find/{keyword}/{page}/{max}")]
        public Stream FindApplicationGroup(string keyword, string page, string max)
        {
            BaseBusinessService<ApplicationGroup> businessService = (BaseBusinessService<ApplicationGroup>)BusinessFactory.Create(Keywords.FindApplicationGroup);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/find-by-application-group-name/{applicationGroupName}")]
        public Stream FindByApplicationGroupName(string applicationGroupName)
        {
            IFindApplicationGroupBusinessService businessService = (IFindApplicationGroupBusinessService)BusinessFactory.Create(Keywords.FindApplicationGroup);
            OperationResult result = businessService.FindByApplicationGroupName(Convert.ToString(applicationGroupName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Group's application Group Name which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupName">application Group Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/update-application-group-name/{idApplicationGroup}/{applicationGroupName}")]
        public Stream UpdateApplicationGroupName(string idApplicationGroup,string applicationGroupName)
        {
            IUpdateApplicationGroupBusinessService businessService = (IUpdateApplicationGroupBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationGroup);
            OperationResult result = businessService.UpdateApplicationGroupName(Convert.ToInt16(idApplicationGroup),Convert.ToString(applicationGroupName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/delete-by-application-group-name/{applicationGroupName}")]
        public Stream DeleteByApplicationGroupName(string applicationGroupName)
        {
            IDeleteApplicationGroupBusinessService businessService = (IDeleteApplicationGroupBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationGroup);
            OperationResult result = businessService.DeleteByApplicationGroupName(Convert.ToString(applicationGroupName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/find-by-application-group-desc/{applicationGroupDesc}")]
        public Stream FindByApplicationGroupDesc(string applicationGroupDesc)
        {
            IFindApplicationGroupBusinessService businessService = (IFindApplicationGroupBusinessService)BusinessFactory.Create(Keywords.FindApplicationGroup);
            OperationResult result = businessService.FindByApplicationGroupDesc(Convert.ToString(applicationGroupDesc));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Group's application Group Desc which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupDesc">application Group Desc</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/update-application-group-desc/{idApplicationGroup}/{applicationGroupDesc}")]
        public Stream UpdateApplicationGroupDesc(string idApplicationGroup,string applicationGroupDesc)
        {
            IUpdateApplicationGroupBusinessService businessService = (IUpdateApplicationGroupBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationGroup);
            OperationResult result = businessService.UpdateApplicationGroupDesc(Convert.ToInt16(idApplicationGroup),Convert.ToString(applicationGroupDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/delete-by-application-group-desc/{applicationGroupDesc}")]
        public Stream DeleteByApplicationGroupDesc(string applicationGroupDesc)
        {
            IDeleteApplicationGroupBusinessService businessService = (IDeleteApplicationGroupBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationGroup);
            OperationResult result = businessService.DeleteByApplicationGroupDesc(Convert.ToString(applicationGroupDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/find-by-application-group-icon/{applicationGroupIcon}")]
        public Stream FindByApplicationGroupIcon(string applicationGroupIcon)
        {
            IFindApplicationGroupBusinessService businessService = (IFindApplicationGroupBusinessService)BusinessFactory.Create(Keywords.FindApplicationGroup);
            OperationResult result = businessService.FindByApplicationGroupIcon(Convert.ToString(applicationGroupIcon));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Application Group's application Group Icon which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupIcon">application Group Icon</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/update-application-group-icon/{idApplicationGroup}/{applicationGroupIcon}")]
        public Stream UpdateApplicationGroupIcon(string idApplicationGroup,string applicationGroupIcon)
        {
            IUpdateApplicationGroupBusinessService businessService = (IUpdateApplicationGroupBusinessService)BusinessFactory.Create(Keywords.UpdateApplicationGroup);
            OperationResult result = businessService.UpdateApplicationGroupIcon(Convert.ToInt16(idApplicationGroup),Convert.ToString(applicationGroupIcon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "applicationgroup/delete-by-application-group-icon/{applicationGroupIcon}")]
        public Stream DeleteByApplicationGroupIcon(string applicationGroupIcon)
        {
            IDeleteApplicationGroupBusinessService businessService = (IDeleteApplicationGroupBusinessService)BusinessFactory.Create(Keywords.DeleteApplicationGroup);
            OperationResult result = businessService.DeleteByApplicationGroupIcon(Convert.ToString(applicationGroupIcon) );
            return result.ToJsonStream();
        }	
		
 
	}
}