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
    public class DeleteGlobalApplicationSettingTemplateRepository : BaseRepository<GlobalApplicationSettingTemplate>, IDeleteGlobalApplicationSettingTemplateRepository
    {
        class Keywords
        {
            public static string DeleteGlobalApplicationSettingTemplate = "Delete.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
        }

        /// <summary>
        /// Constructor for DeleteGlobalApplicationSettingTemplateRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteGlobalApplicationSettingTemplateRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteGlobalApplicationSettingTemplateRepository()
        {
            this.DataContextKey = Keywords.DeleteGlobalApplicationSettingTemplate;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public void DeleteByApplicationSettingName(string applicationSettingName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
							o.ApplicationSettingName.Contains(applicationSettingName) 						
						select o;
			dataContext.GlobalApplicationSettingTemplates.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public void DeleteByApplicationSettingValue(string applicationSettingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
							o.ApplicationSettingValue.Contains(applicationSettingValue) 						
						select o;
			dataContext.GlobalApplicationSettingTemplates.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------

        /// <summary>
        /// Delete all  Global Application Setting Template data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public void DeleteByIsActive(Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
							o.IsActive == isActive  						
						select o;
            dataContext.GlobalApplicationSettingTemplates.RemoveRange(list);
            dataContext.SaveChanges();
        }


    }
}
