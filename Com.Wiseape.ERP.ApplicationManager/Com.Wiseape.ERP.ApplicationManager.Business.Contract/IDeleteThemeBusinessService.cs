using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.ERP.Data.Model;


namespace Com.Wiseape.ERP.ApplicationManager.Business.Contract
{
    public interface IDeleteThemeBusinessService
    {

        /// <summary>
        /// Delete all  Theme data with theme Name containing specified keyword
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>List of  Theme</returns>
		OperationResult DeleteByThemeName(string themeName);

        /// <summary>
        /// Delete all  Theme data with theme Info containing specified keyword
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>List of  Theme</returns>
		OperationResult DeleteByThemeInfo(string themeInfo);

        /// <summary>
        /// Delete all  Theme data with loading Animation containing specified keyword
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>List of  Theme</returns>
		OperationResult DeleteByLoadingAnimation(string loadingAnimation);

        /// <summary>
        /// Delete all  Theme data with loading Animation Audio containing specified keyword
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
		OperationResult DeleteByLoadingAnimationAudio(string loadingAnimationAudio);

        /// <summary>
        /// Delete all  Theme data with default Wallpaper containing specified keyword
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>List of  Theme</returns>
		OperationResult DeleteByDefaultWallpaper(string defaultWallpaper);

        /// <summary>
        /// Delete all  Theme data with taskbar Color containing specified keyword
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>List of  Theme</returns>
		OperationResult DeleteByTaskbarColor(string taskbarColor);

        /// <summary>
        /// Delete all  Theme data with taskbar Menu Color containing specified keyword
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
		OperationResult DeleteByTaskbarMenuColor(string taskbarMenuColor);

	}
}