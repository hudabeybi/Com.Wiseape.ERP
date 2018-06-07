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
    /// Repository for ApplicationSetting data.
    /// </summary>
    public class DeleteApplicationSettingRepository : BaseRepository<ApplicationSetting>, IDeleteApplicationSettingRepository
    {
        class Keywords
        {
            public static string DeleteApplicationSetting = "Delete.ERP.ApplicationManager.ApplicationSetting";
        }

        /// <summary>
        /// Constructor for DeleteApplicationSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteApplicationSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteApplicationSettingRepository()
        {
            this.DataContextKey = Keywords.DeleteApplicationSetting;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
        public void DeleteBySettingKey(string settingKey)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
							o.SettingKey.Contains(settingKey) 						
						select o;
			dataContext.ApplicationSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
        public void DeleteBySettingValue(string settingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
							o.SettingValue.Contains(settingValue) 						
						select o;
			dataContext.ApplicationSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
        public void DeleteByAppName(string appName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
							o.AppName.Contains(appName) 						
						select o;
			dataContext.ApplicationSettings.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
