using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IUpdateThemeBusinessService
    {

        /// <summary>
        /// Updates  Theme's theme Name which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeName">theme Name</param>
		/// <returns>List of  Theme</returns>
		OperationResult UpdateThemeName(Int16 idTheme, string themeName);

        /// <summary>
        /// Updates  Theme's theme Info which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeInfo">theme Info</param>
		/// <returns>List of  Theme</returns>
		OperationResult UpdateThemeInfo(Int16 idTheme, string themeInfo);

        /// <summary>
        /// Updates  Theme's loading Animation which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimation">loading Animation</param>
		/// <returns>List of  Theme</returns>
		OperationResult UpdateLoadingAnimation(Int16 idTheme, string loadingAnimation);

        /// <summary>
        /// Updates  Theme's loading Animation Audio which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimationAudio">loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
		OperationResult UpdateLoadingAnimationAudio(Int16 idTheme, string loadingAnimationAudio);

        /// <summary>
        /// Updates  Theme's default Wallpaper which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="defaultWallpaper">default Wallpaper</param>
		/// <returns>List of  Theme</returns>
		OperationResult UpdateDefaultWallpaper(Int16 idTheme, string defaultWallpaper);

        /// <summary>
        /// Updates  Theme's taskbar Color which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarColor">taskbar Color</param>
		/// <returns>List of  Theme</returns>
		OperationResult UpdateTaskbarColor(Int16 idTheme, string taskbarColor);

        /// <summary>
        /// Updates  Theme's taskbar Menu Color which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarMenuColor">taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
		OperationResult UpdateTaskbarMenuColor(Int16 idTheme, string taskbarMenuColor);

	}
}