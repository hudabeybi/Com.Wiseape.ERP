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
    /// Repository for UpdateTheme data.
    /// </summary>
    public class UpdateThemeRepository : BaseRepository<Theme>, IUpdateThemeRepository
    {
        class Keywords
        {
            public static string UpdateTheme = "Update.ERP.ApplicationManager.Theme";
        }

        /// <summary>
        /// Constructor for ThemeRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateThemeRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateThemeRepository()
        {
            this.DataContextKey = Keywords.UpdateTheme;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Theme's id Theme, theme Name by idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeName">theme Name</param>
		/// <returns>List of  Theme</returns>
        public void UpdateThemeName(Int16 idTheme, string themeName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
                       		o.IdTheme == idTheme
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ThemeName = themeName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Theme's id Theme, theme Info by idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeInfo">theme Info</param>
		/// <returns>List of  Theme</returns>
        public void UpdateThemeInfo(Int16 idTheme, string themeInfo)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
                       		o.IdTheme == idTheme
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ThemeInfo = themeInfo;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Theme's id Theme, loading Animation by idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimation">loading Animation</param>
		/// <returns>List of  Theme</returns>
        public void UpdateLoadingAnimation(Int16 idTheme, string loadingAnimation)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
                       		o.IdTheme == idTheme
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LoadingAnimation = loadingAnimation;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Theme's id Theme, loading Animation Audio by idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimationAudio">loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
        public void UpdateLoadingAnimationAudio(Int16 idTheme, string loadingAnimationAudio)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
                       		o.IdTheme == idTheme
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LoadingAnimationAudio = loadingAnimationAudio;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Theme's id Theme, default Wallpaper by idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="defaultWallpaper">default Wallpaper</param>
		/// <returns>List of  Theme</returns>
        public void UpdateDefaultWallpaper(Int16 idTheme, string defaultWallpaper)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
                       		o.IdTheme == idTheme
                       	select o;
           	list.ToList().ForEach(o => {
      			o.DefaultWallpaper = defaultWallpaper;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Theme's id Theme, taskbar Color by idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarColor">taskbar Color</param>
		/// <returns>List of  Theme</returns>
        public void UpdateTaskbarColor(Int16 idTheme, string taskbarColor)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
                       		o.IdTheme == idTheme
                       	select o;
           	list.ToList().ForEach(o => {
      			o.TaskbarColor = taskbarColor;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Theme's id Theme, taskbar Menu Color by idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarMenuColor">taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
        public void UpdateTaskbarMenuColor(Int16 idTheme, string taskbarMenuColor)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.Themes
                       where
                       		o.IdTheme == idTheme
                       	select o;
           	list.ToList().ForEach(o => {
      			o.TaskbarMenuColor = taskbarMenuColor;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
