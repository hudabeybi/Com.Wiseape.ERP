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
    public class FindApplicationSettingRepository : BaseRepository<ApplicationSetting>, IFindApplicationSettingRepository
    {
        class Keywords
        {
            public static string FindApplicationSetting = "Find.ERP.ApplicationManager.ApplicationSetting";
        }

        /// <summary>
        /// Constructor for ApplicationSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindApplicationSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindApplicationSettingRepository()
        {
            this.DataContextKey = Keywords.FindApplicationSetting;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>List of  Application Setting</returns>
        public List<ApplicationSetting> FindBySettingKey(string settingKey)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
							o.SettingKey.Contains(settingKey) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Application Setting</returns>
        public List<ApplicationSetting> FindBySettingValue(string settingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
							o.SettingValue.Contains(settingValue) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>List of  Application Setting</returns>
        public List<ApplicationSetting> FindByAppName(string appName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationSettings
                       where
							o.AppName.Contains(appName) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
