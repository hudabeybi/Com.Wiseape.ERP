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
    /// Repository for GlobalApplicationSetting data.
    /// </summary>
    public class DeleteGlobalApplicationSettingRepository : BaseRepository<GlobalApplicationSetting>, IDeleteGlobalApplicationSettingRepository
    {
        class Keywords
        {
            public static string DeleteGlobalApplicationSetting = "Delete.ERP.ApplicationManager.GlobalApplicationSetting";
        }

        /// <summary>
        /// Constructor for DeleteGlobalApplicationSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteGlobalApplicationSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteGlobalApplicationSettingRepository()
        {
            this.DataContextKey = Keywords.DeleteGlobalApplicationSetting;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
        public void DeleteBySettingName(string settingName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
							o.SettingName.Contains(settingName) 						
						select o;
			dataContext.GlobalApplicationSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
        public void DeleteBySettingValue(string settingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
							o.SettingValue.Contains(settingValue) 						
						select o;
			dataContext.GlobalApplicationSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>List of  Global Application Setting</returns>
        public void DeleteByUserID(string userID)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
							o.UserID.Contains(userID) 						
						select o;
			dataContext.GlobalApplicationSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
