using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IUpdateApplicationGroupBusinessService
    {

        /// <summary>
        /// Updates  Application Group's application Group Name which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupName">application Group Name</param>
		/// <returns>List of  Application Group</returns>
		OperationResult UpdateApplicationGroupName(Int16 idApplicationGroup, string applicationGroupName);

        /// <summary>
        /// Updates  Application Group's application Group Desc which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupDesc">application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		OperationResult UpdateApplicationGroupDesc(Int16 idApplicationGroup, string applicationGroupDesc);

        /// <summary>
        /// Updates  Application Group's application Group Icon which has specified idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupIcon">application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		OperationResult UpdateApplicationGroupIcon(Int16 idApplicationGroup, string applicationGroupIcon);

	}
}