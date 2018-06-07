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
    public class FindGlobalApplicationSettingRepository : BaseRepository<GlobalApplicationSetting>, IFindGlobalApplicationSettingRepository
    {
        class Keywords
        {
            public static string FindGlobalApplicationSetting = "Find.ERP.ApplicationManager.GlobalApplicationSetting";
        }

        /// <summary>
        /// Constructor for GlobalApplicationSettingRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindGlobalApplicationSettingRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindGlobalApplicationSettingRepository()
        {
            this.DataContextKey = Keywords.FindGlobalApplicationSetting;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>List of  Global Application Setting</returns>
        public List<GlobalApplicationSetting> FindBySettingName(string settingName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
							o.SettingName.Contains(settingName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>List of  Global Application Setting</returns>
        public List<GlobalApplicationSetting> FindBySettingValue(string settingValue)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
							o.SettingValue.Contains(settingValue) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>List of  Global Application Setting</returns>
        public List<GlobalApplicationSetting> FindByUserID(string userID)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.GlobalApplicationSettings
                       where
							o.UserID.Contains(userID) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
