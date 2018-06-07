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
    /// Interface for ApplicationGroup Service
    /// </summary>
    [ServiceContract]
    public interface IApplicationGroupService
    {
    
        /// <summary>
        /// Service to add ApplicationGroup data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ApplicationGroupForm">ApplicationGroup data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddApplicationGroup(ApplicationGroup applicationGroupForm);

        /// <summary>
        /// Service to update ApplicationGroup data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="applicationGroupForm">ApplicationGroup data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateApplicationGroup(ApplicationGroup applicationGroupForm);

        /// <summary>
        /// Service to delete ApplicationGroup data from data store. 
        /// The data deleted is defined by idApplicationGroup.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationGroup">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteApplicationGroup(string idApplicationGroup);

        /// <summary>
        /// Service to get a ApplicationGroup data from data store. 
        /// The data retrieved is defined by idApplicationGroup.
        /// This is a GET request.
        /// </summary>
        /// <param name="idApplicationGroup">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetApplicationGroup(string idApplicationGroup);

        /// <summary>
        /// Service to get all the ApplicationGroup data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindApplicationGroup(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream FindByApplicationGroupName(string applicationGroupName);

        /// <summary>
        /// Updates  Application Group's application Group Name which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupName">application Group Name</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream UpdateApplicationGroupName(string idApplicationGroup,string applicationGroupName);

        /// <summary>
        /// Delete all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream DeleteByApplicationGroupName(string applicationGroupName);

        /// <summary>
        /// Finds all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream FindByApplicationGroupDesc(string applicationGroupDesc);

        /// <summary>
        /// Updates  Application Group's application Group Desc which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupDesc">application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream UpdateApplicationGroupDesc(string idApplicationGroup,string applicationGroupDesc);

        /// <summary>
        /// Delete all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream DeleteByApplicationGroupDesc(string applicationGroupDesc);

        /// <summary>
        /// Finds all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream FindByApplicationGroupIcon(string applicationGroupIcon);

        /// <summary>
        /// Updates  Application Group's application Group Icon which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupIcon">application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream UpdateApplicationGroupIcon(string idApplicationGroup,string applicationGroupIcon);

        /// <summary>
        /// Delete all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		[OperationContract]
		Stream DeleteByApplicationGroupIcon(string applicationGroupIcon);
    
    }
}