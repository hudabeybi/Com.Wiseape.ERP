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
    /// Repository for GlobalApplicationSettingTemplate data.
    /// </summary>
    public class FindGlobalApplicationSettingTemplateRepository : BaseRepository<GlobalApplicationSettingTemplate>, IFindGlobalApplicationSettingTemplateRepository
    {
        class Keywords
        {
            public static string FindGlobalApplicationSettingTemplate = "Find.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
        }

        /// <summary>
        /// Constructor for GlobalApplicationSettingTemplateRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindGlobalApplicationSettingTemplateRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindGlobalApplicationSettingTemplateRepository()
        {
            this.DataContextKey = Keywords.FindGlobalApplicationSettingTemplate;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public List<GlobalApplicationSettingTemplate> FindByApplicationSettingName(string applicationSettingName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
							o.ApplicationSettingName.Contains(applicationSettingName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public List<GlobalApplicationSettingTemplate> FindByApplicationSettingValue(string applicationSettingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
							o.ApplicationSettingValue.Contains(applicationSettingValue) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------

        /// <summary>
        /// Finds all  Global Application Setting Template data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public List<GlobalApplicationSettingTemplate> FindByIsActive(Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
							o.IsActive == isActive  						
						select o;
            return list.ToList();
        }




    }
}
