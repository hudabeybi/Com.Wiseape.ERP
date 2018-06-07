using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IUpdateApplicationGroupRepository
    {

	    /// <summary>
	    /// Updates  Application Group's id Application Group, application Group Name by idApplicationGroup
	    /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupName">application Group Name</param>
		/// <returns>List of  Application Group</returns>
		void UpdateApplicationGroupName(Int16 idApplicationGroup, string applicationGroupName);
	
	    /// <summary>
	    /// Updates  Application Group's id Application Group, application Group Desc by idApplicationGroup
	    /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupDesc">application Group Desc</param>
		/// <returns>List of  Application Group</returns>
		void UpdateApplicationGroupDesc(Int16 idApplicationGroup, string applicationGroupDesc);
	
	    /// <summary>
	    /// Updates  Application Group's id Application Group, application Group Icon by idApplicationGroup
	    /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupIcon">application Group Icon</param>
		/// <returns>List of  Application Group</returns>
		void UpdateApplicationGroupIcon(Int16 idApplicationGroup, string applicationGroupIcon);
	
    }
}

