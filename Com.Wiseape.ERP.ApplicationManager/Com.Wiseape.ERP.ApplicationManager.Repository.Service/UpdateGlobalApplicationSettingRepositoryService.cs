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
    /// Repository for UpdateGlobalApplicationSetting data.
    /// </summary>
    public class UpdateGlobalApplicationSettingRepository : BaseRepository<GlobalApplicationSetting>, IUpdateGlobalApplicationSettingRepository
    {
        class Keywords
        {
            public static string UpdateGlobalApplicationSetting = "Update.ERP.ApplicationManager.GlobalApplicationSetting";
        }

        /// <summary>
        /// Constructor for GlobalApplicationSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateGlobalApplicationSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateGlobalApplicationSettingRepository()
        {
            this.DataContextKey = Keywords.UpdateGlobalApplicationSetting;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Global Application Setting's id Global Application Setting, setting Name by idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingName">setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
        public void UpdateSettingName(Int16 idGlobalApplicationSetting, string settingName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
                       		o.IdGlobalApplicationSetting == idGlobalApplicationSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SettingName = settingName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Global Application Setting's id Global Application Setting, setting Value by idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="settingValue">setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
        public void UpdateSettingValue(Int16 idGlobalApplicationSetting, string settingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
                       		o.IdGlobalApplicationSetting == idGlobalApplicationSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.SettingValue = settingValue;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Global Application Setting's id Global Application Setting, user I D by idGlobalApplicationSetting
        /// </summary>
		/// <param name="idGlobalApplicationSetting">id Global Application Setting</param>
		/// <param name="userID">user I D</param>
		/// <returns>List of  Global Application Setting</returns>
        public void UpdateUserID(Int16 idGlobalApplicationSetting, string userID)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
                       		o.IdGlobalApplicationSetting == idGlobalApplicationSetting
                       	select o;
           	list.ToList().ForEach(o => {
      			o.UserID = userID;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
