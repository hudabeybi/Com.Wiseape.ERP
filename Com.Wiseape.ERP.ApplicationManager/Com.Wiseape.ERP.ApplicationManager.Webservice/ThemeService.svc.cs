using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.ApplicationManager.Business.Contract;


namespace Com.Wiseape.ERP.ApplicationManager.Webservice
{
	[AspNetCompatibilityRequirements(
            RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ThemeService : IThemeService
    {

        class Keywords
        {
            public static string Theme = "ERP.ApplicationManager.Theme";
            public static string FindTheme = "Find.ERP.ApplicationManager.Theme";
            public static string AddTheme = "Add.ERP.ApplicationManager.Theme";
            public static string UpdateTheme = "Update.ERP.ApplicationManager.Theme";
            public static string DeleteTheme = "Delete.ERP.ApplicationManager.Theme";
        }

        /// <summary>
        /// Service to add Theme data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="ThemeForm">Theme data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/add")]
        public Stream AddTheme(Theme themeForm)
        {
            BaseBusinessService<Theme> businessService = (BaseBusinessService<Theme>)BusinessFactory.Create(Keywords.AddTheme);
            OperationResult result = businessService.Add(themeForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update Theme data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="themeForm">Theme data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update")]
        public Stream UpdateTheme(Theme themeForm)
        {
            BaseBusinessService<Theme> businessService = (BaseBusinessService<Theme>)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.Update(themeForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete Theme data from data store. 
        /// The data deleted is defined by idTheme.
        /// This is a GET request.
        /// </summary>
        /// <param name="idTheme">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete/{idTheme}")]
        public Stream DeleteTheme(string idTheme)
        {
            BaseBusinessService<Theme> businessService = (BaseBusinessService<Theme>)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.Delete(idTheme);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a Theme data from data store. 
        /// The data retrieved is defined by idTheme.
        /// This is a GET request.
        /// </summary>
        /// <param name="idTheme">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/get/{idTheme}")]
        public Stream GetTheme(string idTheme)
        {
            BaseBusinessService<Theme> businessService = (BaseBusinessService<Theme>)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.Get(idTheme);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the Theme data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find/{keyword}/{page}/{max}")]
        public Stream FindTheme(string keyword, string page, string max)
        {
            BaseBusinessService<Theme> businessService = (BaseBusinessService<Theme>)BusinessFactory.Create(Keywords.FindTheme);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Theme data with theme Name containing specified keyword
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find-by-theme-name/{themeName}")]
        public Stream FindByThemeName(string themeName)
        {
            IFindThemeBusinessService businessService = (IFindThemeBusinessService)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.FindByThemeName(Convert.ToString(themeName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Theme's theme Name which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeName">theme Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update-theme-name/{idTheme}/{themeName}")]
        public Stream UpdateThemeName(string idTheme,string themeName)
        {
            IUpdateThemeBusinessService businessService = (IUpdateThemeBusinessService)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.UpdateThemeName(Convert.ToInt16(idTheme),Convert.ToString(themeName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Theme data with theme Name containing specified keyword
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete-by-theme-name/{themeName}")]
        public Stream DeleteByThemeName(string themeName)
        {
            IDeleteThemeBusinessService businessService = (IDeleteThemeBusinessService)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.DeleteByThemeName(Convert.ToString(themeName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Theme data with theme Info containing specified keyword
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find-by-theme-info/{themeInfo}")]
        public Stream FindByThemeInfo(string themeInfo)
        {
            IFindThemeBusinessService businessService = (IFindThemeBusinessService)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.FindByThemeInfo(Convert.ToString(themeInfo));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Theme's theme Info which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="themeInfo">theme Info</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update-theme-info/{idTheme}/{themeInfo}")]
        public Stream UpdateThemeInfo(string idTheme,string themeInfo)
        {
            IUpdateThemeBusinessService businessService = (IUpdateThemeBusinessService)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.UpdateThemeInfo(Convert.ToInt16(idTheme),Convert.ToString(themeInfo) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Theme data with theme Info containing specified keyword
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete-by-theme-info/{themeInfo}")]
        public Stream DeleteByThemeInfo(string themeInfo)
        {
            IDeleteThemeBusinessService businessService = (IDeleteThemeBusinessService)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.DeleteByThemeInfo(Convert.ToString(themeInfo) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Theme data with loading Animation containing specified keyword
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find-by-loading-animation/{loadingAnimation}")]
        public Stream FindByLoadingAnimation(string loadingAnimation)
        {
            IFindThemeBusinessService businessService = (IFindThemeBusinessService)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.FindByLoadingAnimation(Convert.ToString(loadingAnimation));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Theme's loading Animation which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimation">loading Animation</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update-loading-animation/{idTheme}/{loadingAnimation}")]
        public Stream UpdateLoadingAnimation(string idTheme,string loadingAnimation)
        {
            IUpdateThemeBusinessService businessService = (IUpdateThemeBusinessService)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.UpdateLoadingAnimation(Convert.ToInt16(idTheme),Convert.ToString(loadingAnimation) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Theme data with loading Animation containing specified keyword
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete-by-loading-animation/{loadingAnimation}")]
        public Stream DeleteByLoadingAnimation(string loadingAnimation)
        {
            IDeleteThemeBusinessService businessService = (IDeleteThemeBusinessService)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.DeleteByLoadingAnimation(Convert.ToString(loadingAnimation) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Theme data with loading Animation Audio containing specified keyword
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find-by-loading-animation-audio/{loadingAnimationAudio}")]
        public Stream FindByLoadingAnimationAudio(string loadingAnimationAudio)
        {
            IFindThemeBusinessService businessService = (IFindThemeBusinessService)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.FindByLoadingAnimationAudio(Convert.ToString(loadingAnimationAudio));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Theme's loading Animation Audio which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="loadingAnimationAudio">loading Animation Audio</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update-loading-animation-audio/{idTheme}/{loadingAnimationAudio}")]
        public Stream UpdateLoadingAnimationAudio(string idTheme,string loadingAnimationAudio)
        {
            IUpdateThemeBusinessService businessService = (IUpdateThemeBusinessService)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.UpdateLoadingAnimationAudio(Convert.ToInt16(idTheme),Convert.ToString(loadingAnimationAudio) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Theme data with loading Animation Audio containing specified keyword
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete-by-loading-animation-audio/{loadingAnimationAudio}")]
        public Stream DeleteByLoadingAnimationAudio(string loadingAnimationAudio)
        {
            IDeleteThemeBusinessService businessService = (IDeleteThemeBusinessService)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.DeleteByLoadingAnimationAudio(Convert.ToString(loadingAnimationAudio) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Theme data with default Wallpaper containing specified keyword
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find-by-default-wallpaper/{defaultWallpaper}")]
        public Stream FindByDefaultWallpaper(string defaultWallpaper)
        {
            IFindThemeBusinessService businessService = (IFindThemeBusinessService)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.FindByDefaultWallpaper(Convert.ToString(defaultWallpaper));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Theme's default Wallpaper which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="defaultWallpaper">default Wallpaper</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update-default-wallpaper/{idTheme}/{defaultWallpaper}")]
        public Stream UpdateDefaultWallpaper(string idTheme,string defaultWallpaper)
        {
            IUpdateThemeBusinessService businessService = (IUpdateThemeBusinessService)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.UpdateDefaultWallpaper(Convert.ToInt16(idTheme),Convert.ToString(defaultWallpaper) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Theme data with default Wallpaper containing specified keyword
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete-by-default-wallpaper/{defaultWallpaper}")]
        public Stream DeleteByDefaultWallpaper(string defaultWallpaper)
        {
            IDeleteThemeBusinessService businessService = (IDeleteThemeBusinessService)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.DeleteByDefaultWallpaper(Convert.ToString(defaultWallpaper) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Theme data with taskbar Color containing specified keyword
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find-by-taskbar-color/{taskbarColor}")]
        public Stream FindByTaskbarColor(string taskbarColor)
        {
            IFindThemeBusinessService businessService = (IFindThemeBusinessService)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.FindByTaskbarColor(Convert.ToString(taskbarColor));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Theme's taskbar Color which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarColor">taskbar Color</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update-taskbar-color/{idTheme}/{taskbarColor}")]
        public Stream UpdateTaskbarColor(string idTheme,string taskbarColor)
        {
            IUpdateThemeBusinessService businessService = (IUpdateThemeBusinessService)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.UpdateTaskbarColor(Convert.ToInt16(idTheme),Convert.ToString(taskbarColor) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Theme data with taskbar Color containing specified keyword
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete-by-taskbar-color/{taskbarColor}")]
        public Stream DeleteByTaskbarColor(string taskbarColor)
        {
            IDeleteThemeBusinessService businessService = (IDeleteThemeBusinessService)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.DeleteByTaskbarColor(Convert.ToString(taskbarColor) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Theme data with taskbar Menu Color containing specified keyword
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/find-by-taskbar-menu-color/{taskbarMenuColor}")]
        public Stream FindByTaskbarMenuColor(string taskbarMenuColor)
        {
            IFindThemeBusinessService businessService = (IFindThemeBusinessService)BusinessFactory.Create(Keywords.FindTheme);
            OperationResult result = businessService.FindByTaskbarMenuColor(Convert.ToString(taskbarMenuColor));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Theme's taskbar Menu Color which has specified idTheme
        /// </summary>
		/// <param name="idTheme">id Theme</param>
		/// <param name="taskbarMenuColor">taskbar Menu Color</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/update-taskbar-menu-color/{idTheme}/{taskbarMenuColor}")]
        public Stream UpdateTaskbarMenuColor(string idTheme,string taskbarMenuColor)
        {
            IUpdateThemeBusinessService businessService = (IUpdateThemeBusinessService)BusinessFactory.Create(Keywords.UpdateTheme);
            OperationResult result = businessService.UpdateTaskbarMenuColor(Convert.ToInt16(idTheme),Convert.ToString(taskbarMenuColor) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Theme data with taskbar Menu Color containing specified keyword
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>List of  Theme</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "theme/delete-by-taskbar-menu-color/{taskbarMenuColor}")]
        public Stream DeleteByTaskbarMenuColor(string taskbarMenuColor)
        {
            IDeleteThemeBusinessService businessService = (IDeleteThemeBusinessService)BusinessFactory.Create(Keywords.DeleteTheme);
            OperationResult result = businessService.DeleteByTaskbarMenuColor(Convert.ToString(taskbarMenuColor) );
            return result.ToJsonStream();
        }	
		
 
	}
}