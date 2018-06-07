using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.ApplicationManager.Repository.Contract;
using Com.Wiseape.ERP.ApplicationManager.Business.Contract;

namespace Com.Wiseape.ERP.ApplicationManager.Business.Service
{
    /// <summary>
    /// Business Service for Theme module.
    /// </summary>
    public class FindThemeBusinessService : BaseBusinessService<Theme>, IFindThemeBusinessService
    {
        class Keywords
        {
            public static string FindTheme = "Find.ERP.ApplicationManager.Theme";
        }
        
        public FindThemeBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindThemeBusinessService()
        {
            this.RepoKey = Keywords.FindTheme;
        }


        /// <summary>
        /// Finds all  Theme data with theme Name containing specified keyword
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByThemeName(string themeName)
		{
            IFindThemeRepository repository = (IFindThemeRepository)RepositoryFactory.Create(Keywords.FindTheme);
            try
            {
                List<Theme> res = repository.FindByThemeName(themeName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Theme data with theme Info containing specified keyword
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByThemeInfo(string themeInfo)
		{
            IFindThemeRepository repository = (IFindThemeRepository)RepositoryFactory.Create(Keywords.FindTheme);
            try
            {
                List<Theme> res = repository.FindByThemeInfo(themeInfo);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Theme data with loading Animation containing specified keyword
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLoadingAnimation(string loadingAnimation)
		{
            IFindThemeRepository repository = (IFindThemeRepository)RepositoryFactory.Create(Keywords.FindTheme);
            try
            {
                List<Theme> res = repository.FindByLoadingAnimation(loadingAnimation);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Theme data with loading Animation Audio containing specified keyword
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLoadingAnimationAudio(string loadingAnimationAudio)
		{
            IFindThemeRepository repository = (IFindThemeRepository)RepositoryFactory.Create(Keywords.FindTheme);
            try
            {
                List<Theme> res = repository.FindByLoadingAnimationAudio(loadingAnimationAudio);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Theme data with default Wallpaper containing specified keyword
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByDefaultWallpaper(string defaultWallpaper)
		{
            IFindThemeRepository repository = (IFindThemeRepository)RepositoryFactory.Create(Keywords.FindTheme);
            try
            {
                List<Theme> res = repository.FindByDefaultWallpaper(defaultWallpaper);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Theme data with taskbar Color containing specified keyword
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByTaskbarColor(string taskbarColor)
		{
            IFindThemeRepository repository = (IFindThemeRepository)RepositoryFactory.Create(Keywords.FindTheme);
            try
            {
                List<Theme> res = repository.FindByTaskbarColor(taskbarColor);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Theme data with taskbar Menu Color containing specified keyword
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByTaskbarMenuColor(string taskbarMenuColor)
		{
            IFindThemeRepository repository = (IFindThemeRepository)RepositoryFactory.Create(Keywords.FindTheme);
            try
            {
                List<Theme> res = repository.FindByTaskbarMenuColor(taskbarMenuColor);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }