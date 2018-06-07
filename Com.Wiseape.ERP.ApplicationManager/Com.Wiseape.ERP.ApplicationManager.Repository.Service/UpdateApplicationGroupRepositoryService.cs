using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.Data.Context;
using Com.Wiseape.ERP.ApplicationManager.Repository.Contract;

namespace Com.Wiseape.ERP.ApplicationManager.Repository.Service
{
    /// <summary>
    /// Repository for UpdateApplicationGroup data.
    /// </summary>
    public class UpdateApplicationGroupRepository : BaseRepository<ApplicationGroup>, IUpdateApplicationGroupRepository
    {
        class Keywords
        {
            public static string UpdateApplicationGroup = "Update.ERP.ApplicationManager.ApplicationGroup";
        }

        /// <summary>
        /// Constructor for ApplicationGroupRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateApplicationGroupRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateApplicationGroupRepository()
        {
            this.DataContextKey = Keywords.UpdateApplicationGroup;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Application Group's id Application Group, application Group Name by idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupName">application Group Name</param>
		/// <returns>List of  Application Group</returns>
        public void UpdateApplicationGroupName(Int16 idApplicationGroup, string applicationGroupName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
                       		o.IdApplicationGroup == idApplicationGroup
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationGroupName = applicationGroupName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Group's id Application Group, application Group Desc by idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupDesc">application Group Desc</param>
		/// <returns>List of  Application Group</returns>
        public void UpdateApplicationGroupDesc(Int16 idApplicationGroup, string applicationGroupDesc)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
                       		o.IdApplicationGroup == idApplicationGroup
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationGroupDesc = applicationGroupDesc;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Group's id Application Group, application Group Icon by idApplicationGroup
        /// </summary>
		/// <param name="idApplicationGroup">id Application Group</param>
		/// <param name="applicationGroupIcon">application Group Icon</param>
		/// <returns>List of  Application Group</returns>
        public void UpdateApplicationGroupIcon(Int16 idApplicationGroup, string applicationGroupIcon)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
                       		o.IdApplicationGroup == idApplicationGroup
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationGroupIcon = applicationGroupIcon;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
