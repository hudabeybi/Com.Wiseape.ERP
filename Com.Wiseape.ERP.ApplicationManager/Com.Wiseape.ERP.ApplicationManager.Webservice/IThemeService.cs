using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.ApplicationManager.Business.Contract;

using System.ServiceModel;

namespace Com.Wiseape.ERP.ApplicationManager.Webservice
{
    /// <summary>
    /// Interface for Theme Service
    /// </summary>
    [ServiceContract]
    public interface IThemeService
    {
    
        /// <summary>
        /// Service to add Theme data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ThemeForm">Theme data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddTheme(Theme themeForm);

        /// <summary>
        /// Service to update Theme data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="themeForm">Theme data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateTheme(Theme themeForm);

        /// <summary>
        /// Service to delete Theme data from data store. 
        /// The data deleted is defined by idTheme.
        /// This is a GET request.
        /// </summary>
        /// <param name="idTheme">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteTheme(string idTheme);

        /// <summary>
        /// Service to get a Theme data from data store. 
        /// The data retrieved is defined by idTheme.
        /// This is a GET request.
        /// </summary>
        /// <param name="idTheme">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetTheme(string idTheme);

        /// <summary>
        /// Service to get all the Theme data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindTheme(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Theme data with theme Name containing specified keyword
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream FindByThemeName(string themeName);

        /// <summary>
        /// Updates  Theme's theme Name which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeName">theme Name</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream UpdateThemeName(string idTheme,string themeName);

        /// <summary>
        /// Delete all  Theme data with theme Name containing specified keyword
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream DeleteByThemeName(string themeName);

        /// <summary>
        /// Finds all  Theme data with theme Info containing specified keyword
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream FindByThemeInfo(string themeInfo);

        /// <summary>
        /// Updates  Theme's theme Info which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeInfo">theme Info</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream UpdateThemeInfo(string idTheme,string themeInfo);

        /// <summary>
        /// Delete all  Theme data with theme Info containing specified keyword
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream DeleteByThemeInfo(string themeInfo);

        /// <summary>
        /// Finds all  Theme data with loading Animation containing specified keyword
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream FindByLoadingAnimation(string loadingAnimation);

        /// <summary>
        /// Updates  Theme's loading Animation which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimation">loading Animation</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream UpdateLoadingAnimation(string idTheme,string loadingAnimation);

        /// <summary>
        /// Delete all  Theme data with loading Animation containing specified keyword
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream DeleteByLoadingAnimation(string loadingAnimation);

        /// <summary>
        /// Finds all  Theme data with loading Animation Audio containing specified keyword
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream FindByLoadingAnimationAudio(string loadingAnimationAudio);

        /// <summary>
        /// Updates  Theme's loading Animation Audio which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimationAudio">loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream UpdateLoadingAnimationAudio(string idTheme,string loadingAnimationAudio);

        /// <summary>
        /// Delete all  Theme data with loading Animation Audio containing specified keyword
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream DeleteByLoadingAnimationAudio(string loadingAnimationAudio);

        /// <summary>
        /// Finds all  Theme data with default Wallpaper containing specified keyword
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream FindByDefaultWallpaper(string defaultWallpaper);

        /// <summary>
        /// Updates  Theme's default Wallpaper which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="defaultWallpaper">default Wallpaper</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream UpdateDefaultWallpaper(string idTheme,string defaultWallpaper);

        /// <summary>
        /// Delete all  Theme data with default Wallpaper containing specified keyword
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream DeleteByDefaultWallpaper(string defaultWallpaper);

        /// <summary>
        /// Finds all  Theme data with taskbar Color containing specified keyword
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream FindByTaskbarColor(string taskbarColor);

        /// <summary>
        /// Updates  Theme's taskbar Color which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarColor">taskbar Color</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream UpdateTaskbarColor(string idTheme,string taskbarColor);

        /// <summary>
        /// Delete all  Theme data with taskbar Color containing specified keyword
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream DeleteByTaskbarColor(string taskbarColor);

        /// <summary>
        /// Finds all  Theme data with taskbar Menu Color containing specified keyword
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream FindByTaskbarMenuColor(string taskbarMenuColor);

        /// <summary>
        /// Updates  Theme's taskbar Menu Color which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarMenuColor">taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream UpdateTaskbarMenuColor(string idTheme,string taskbarMenuColor);

        /// <summary>
        /// Delete all  Theme data with taskbar Menu Color containing specified keyword
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
		[OperationContract]
		Stream DeleteByTaskbarMenuColor(string taskbarMenuColor);
    
    }
}