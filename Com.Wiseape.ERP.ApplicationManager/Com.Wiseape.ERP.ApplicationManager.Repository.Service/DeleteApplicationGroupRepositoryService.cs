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
    /// Repository for ApplicationGroup data.
    /// </summary>
    public class DeleteApplicationGroupRepository : BaseRepository<ApplicationGroup>, IDeleteApplicationGroupRepository
    {
        class Keywords
        {
            public static string DeleteApplicationGroup = "Delete.ERP.ApplicationManager.ApplicationGroup";
        }

        /// <summary>
        /// Constructor for DeleteApplicationGroupRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteApplicationGroupRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteApplicationGroupRepository()
        {
            this.DataContextKey = Keywords.DeleteApplicationGroup;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
        public void DeleteByApplicationGroupName(string applicationGroupName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
							o.ApplicationGroupName.Contains(applicationGroupName) 						
						select o;
			dataContext.ApplicationGroups.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
        public void DeleteByApplicationGroupDesc(string applicationGroupDesc)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
							o.ApplicationGroupDesc.Contains(applicationGroupDesc) 						
						select o;
			dataContext.ApplicationGroups.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
        public void DeleteByApplicationGroupIcon(string applicationGroupIcon)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
							o.ApplicationGroupIcon.Contains(applicationGroupIcon) 						
						select o;
			dataContext.ApplicationGroups.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
