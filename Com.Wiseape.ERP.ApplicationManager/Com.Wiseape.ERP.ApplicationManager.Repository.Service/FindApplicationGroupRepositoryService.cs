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
    public class FindApplicationGroupRepository : BaseRepository<ApplicationGroup>, IFindApplicationGroupRepository
    {
        class Keywords
        {
            public static string FindApplicationGroup = "Find.ERP.ApplicationManager.ApplicationGroup";
        }

        /// <summary>
        /// Constructor for ApplicationGroupRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindApplicationGroupRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindApplicationGroupRepository()
        {
            this.DataContextKey = Keywords.FindApplicationGroup;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>List of  Application Group</returns>
        public List<ApplicationGroup> FindByApplicationGroupName(string applicationGroupName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
							o.ApplicationGroupName.Contains(applicationGroupName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>List of  Application Group</returns>
        public List<ApplicationGroup> FindByApplicationGroupDesc(string applicationGroupDesc)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
							o.ApplicationGroupDesc.Contains(applicationGroupDesc) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>List of  Application Group</returns>
        public List<ApplicationGroup> FindByApplicationGroupIcon(string applicationGroupIcon)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationGroups
                       where
							o.ApplicationGroupIcon.Contains(applicationGroupIcon) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
