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
    /// Repository for UpdateApplicationSetting data.
    /// </summary>
    public class UpdateApplicationSettingRepository : BaseRepository<ApplicationSetting>, IUpdateApplicationSettingRepository
    {
        class Keywords
        {
            public static string UpdateApplicationSetting = "Update.ERP.ApplicationManager.ApplicationSetting";
        }

        /// <summary>
        /// Constructor for ApplicationSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateApplicationSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateApplicationSettingRepository()
        {
            this.DataContextKey = Keywords.UpdateApplicationSetting;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Application Setting's id Application Setting, setting Key by idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingKey">setting Key</param>
		/// <returns>List of  Application Setting</returns>
        public void UpdateSettingKey(Int16 idApplicationSetting, string settingKey)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
                       		o.IdApplicationSetting == idApplicationSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SettingKey = settingKey;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Setting's id Application Setting, setting Value by idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Application Setting</returns>
        public void UpdateSettingValue(Int16 idApplicationSetting, string settingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
                       		o.IdApplicationSetting == idApplicationSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SettingValue = settingValue;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Setting's id Application Setting, app Name by idApplicationSetting
        /// </summary>
		/// <param name="idApplicationSetting">id Application Setting</param>
		/// <param name="appName">app Name</param>
		/// <returns>List of  Application Setting</returns>
        public void UpdateAppName(Int16 idApplicationSetting, string appName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
                       		o.IdApplicationSetting == idApplicationSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.AppName = appName;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
