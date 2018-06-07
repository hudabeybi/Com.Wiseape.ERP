using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;



namespace Com.Wiseape.ERP.ApplicationManager.Repository.Contract
{
    public interface IUpdateThemeRepository
    {

	    /// <summary>
	    /// Updates  Theme's id Theme, theme Name by idTheme
	    /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeName">theme Name</param>
		/// <returns>List of  Theme</returns>
		void UpdateThemeName(Int16 idTheme, string themeName);
	
	    /// <summary>
	    /// Updates  Theme's id Theme, theme Info by idTheme
	    /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeInfo">theme Info</param>
		/// <returns>List of  Theme</returns>
		void UpdateThemeInfo(Int16 idTheme, string themeInfo);
	
	    /// <summary>
	    /// Updates  Theme's id Theme, loading Animation by idTheme
	    /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimation">loading Animation</param>
		/// <returns>List of  Theme</returns>
		void UpdateLoadingAnimation(Int16 idTheme, string loadingAnimation);
	
	    /// <summary>
	    /// Updates  Theme's id Theme, loading Animation Audio by idTheme
	    /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimationAudio">loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
		void UpdateLoadingAnimationAudio(Int16 idTheme, string loadingAnimationAudio);
	
	    /// <summary>
	    /// Updates  Theme's id Theme, default Wallpaper by idTheme
	    /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="defaultWallpaper">default Wallpaper</param>
		/// <returns>List of  Theme</returns>
		void UpdateDefaultWallpaper(Int16 idTheme, string defaultWallpaper);
	
	    /// <summary>
	    /// Updates  Theme's id Theme, taskbar Color by idTheme
	    /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarColor">taskbar Color</param>
		/// <returns>List of  Theme</returns>
		void UpdateTaskbarColor(Int16 idTheme, string taskbarColor);
	
	    /// <summary>
	    /// Updates  Theme's id Theme, taskbar Menu Color by idTheme
	    /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarMenuColor">taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
		void UpdateTaskbarMenuColor(Int16 idTheme, string taskbarMenuColor);
	
    }
}

