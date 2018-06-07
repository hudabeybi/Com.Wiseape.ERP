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
    /// Repository for Theme data.
    /// </summary>
    public class FindThemeRepository : BaseRepository<Theme>, IFindThemeRepository
    {
        class Keywords
        {
            public static string FindTheme = "Find.ERP.ApplicationManager.Theme";
        }

        /// <summary>
        /// Constructor for ThemeRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindThemeRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindThemeRepository()
        {
            this.DataContextKey = Keywords.FindTheme;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Theme data with theme Name containing specified keyword
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>List of  Theme</returns>
        public List<Theme> FindByThemeName(string themeName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
							o.ThemeName.Contains(themeName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Theme data with theme Info containing specified keyword
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>List of  Theme</returns>
        public List<Theme> FindByThemeInfo(string themeInfo)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
							o.ThemeInfo.Contains(themeInfo) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Theme data with loading Animation containing specified keyword
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>List of  Theme</returns>
        public List<Theme> FindByLoadingAnimation(string loadingAnimation)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
							o.LoadingAnimation.Contains(loadingAnimation) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Theme data with loading Animation Audio containing specified keyword
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
        public List<Theme> FindByLoadingAnimationAudio(string loadingAnimationAudio)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
							o.LoadingAnimationAudio.Contains(loadingAnimationAudio) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Theme data with default Wallpaper containing specified keyword
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>List of  Theme</returns>
        public List<Theme> FindByDefaultWallpaper(string defaultWallpaper)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
							o.DefaultWallpaper.Contains(defaultWallpaper) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Theme data with taskbar Color containing specified keyword
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>List of  Theme</returns>
        public List<Theme> FindByTaskbarColor(string taskbarColor)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
							o.TaskbarColor.Contains(taskbarColor) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Theme data with taskbar Menu Color containing specified keyword
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
        public List<Theme> FindByTaskbarMenuColor(string taskbarMenuColor)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
							o.TaskbarMenuColor.Contains(taskbarMenuColor) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
