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
    /// Repository for UpdateGlobalApplicationSettingTemplate data.
    /// </summary>
    public class UpdateGlobalApplicationSettingTemplateRepository : BaseRepository<GlobalApplicationSettingTemplate>, IUpdateGlobalApplicationSettingTemplateRepository
    {
        class Keywords
        {
            public static string UpdateGlobalApplicationSettingTemplate = "Update.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
        }

        /// <summary>
        /// Constructor for GlobalApplicationSettingTemplateRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateGlobalApplicationSettingTemplateRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateGlobalApplicationSettingTemplateRepository()
        {
            this.DataContextKey = Keywords.UpdateGlobalApplicationSettingTemplate;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Global Application Setting Template's id Global Application Setting Template, application Setting Name by idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingName">application Setting Name</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public void UpdateApplicationSettingName(Int16 idGlobalApplicationSettingTemplate, string applicationSettingName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
                       		o.IdGlobalApplicationSettingTemplate == idGlobalApplicationSettingTemplate
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationSettingName = applicationSettingName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Global Application Setting Template's id Global Application Setting Template, application Setting Value by idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="applicationSettingValue">application Setting Value</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public void UpdateApplicationSettingValue(Int16 idGlobalApplicationSettingTemplate, string applicationSettingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
                       		o.IdGlobalApplicationSettingTemplate == idGlobalApplicationSettingTemplate
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationSettingValue = applicationSettingValue;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------

        /// <summary>
        /// Updates  Global Application Setting Template's id Global Application Setting Template, is Active by idGlobalApplicationSettingTemplate
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate">id Global Application Setting Template</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Global Application Setting Template</returns>
        public void UpdateIsActive(Int16 idGlobalApplicationSettingTemplate, Int16 isActive)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettingTemplates
                       where
                       		o.IdGlobalApplicationSettingTemplate == idGlobalApplicationSettingTemplate
                       	select o;
           	list.ToList().ForEach(o => {
      			o.IsActive = isActive;
	
            });
            dataContext.SaveChanges();
        }


    }
}
