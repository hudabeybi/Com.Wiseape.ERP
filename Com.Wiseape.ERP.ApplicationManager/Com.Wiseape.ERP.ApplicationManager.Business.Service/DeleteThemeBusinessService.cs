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
using Com.Wiseape.ERP.ApplicationManager.View.Contract.Validator;

namespace Com.Wiseape.ERP.ApplicationManager.Business.Service
{
    /// <summary>
    /// Business Service for Theme module.
    /// </summary>
    public class DeleteThemeBusinessService : BaseBusinessService<Theme>, IDeleteThemeBusinessService
    {
        class Keywords
        {
            public static string DeleteTheme = "Delete.ERP.ApplicationManager.Theme";
        }
        
        public DeleteThemeBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteThemeBusinessService()
        {
            this.RepoKey = Keywords.DeleteTheme;
        }

        /// <summary>
        /// Delete  Theme data by theme Name
        /// </summary>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByThemeName(string themeName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ThemeName
			ValidationResult validationResult = this.ValidateThemeName( themeName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByThemeName(themeName);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate ThemeName
		protected virtual ValidationResult ValidateThemeName(string themeName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.DeleteTheme);
				
				//Execute validation process
				validationResult = validator.ValidateThemeName(themeName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ThemeName
		protected virtual OperationResult _DeleteByThemeName(string themeName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteTheme'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteThemeRepository repository = (IDeleteThemeRepository)RepositoryFactory.Create(Keywords.DeleteTheme);
            try
            {
            	//Execute DeleteByThemeName
                repository.DeleteByThemeName(themeName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Theme data by theme Info
        /// </summary>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByThemeInfo(string themeInfo)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ThemeInfo
			ValidationResult validationResult = this.ValidateThemeInfo( themeInfo );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByThemeInfo(themeInfo);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate ThemeInfo
		protected virtual ValidationResult ValidateThemeInfo(string themeInfo)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.DeleteTheme);
				
				//Execute validation process
				validationResult = validator.ValidateThemeInfo(themeInfo);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ThemeInfo
		protected virtual OperationResult _DeleteByThemeInfo(string themeInfo)
		{
			//Create repository based on its Key name : 'Keywords.DeleteTheme'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteThemeRepository repository = (IDeleteThemeRepository)RepositoryFactory.Create(Keywords.DeleteTheme);
            try
            {
            	//Execute DeleteByThemeInfo
                repository.DeleteByThemeInfo(themeInfo);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Theme data by loading Animation
        /// </summary>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByLoadingAnimation(string loadingAnimation)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LoadingAnimation
			ValidationResult validationResult = this.ValidateLoadingAnimation( loadingAnimation );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByLoadingAnimation(loadingAnimation);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate LoadingAnimation
		protected virtual ValidationResult ValidateLoadingAnimation(string loadingAnimation)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.DeleteTheme);
				
				//Execute validation process
				validationResult = validator.ValidateLoadingAnimation(loadingAnimation);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete LoadingAnimation
		protected virtual OperationResult _DeleteByLoadingAnimation(string loadingAnimation)
		{
			//Create repository based on its Key name : 'Keywords.DeleteTheme'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteThemeRepository repository = (IDeleteThemeRepository)RepositoryFactory.Create(Keywords.DeleteTheme);
            try
            {
            	//Execute DeleteByLoadingAnimation
                repository.DeleteByLoadingAnimation(loadingAnimation);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Theme data by loading Animation Audio
        /// </summary>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByLoadingAnimationAudio(string loadingAnimationAudio)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LoadingAnimationAudio
			ValidationResult validationResult = this.ValidateLoadingAnimationAudio( loadingAnimationAudio );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByLoadingAnimationAudio(loadingAnimationAudio);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate LoadingAnimationAudio
		protected virtual ValidationResult ValidateLoadingAnimationAudio(string loadingAnimationAudio)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.DeleteTheme);
				
				//Execute validation process
				validationResult = validator.ValidateLoadingAnimationAudio(loadingAnimationAudio);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete LoadingAnimationAudio
		protected virtual OperationResult _DeleteByLoadingAnimationAudio(string loadingAnimationAudio)
		{
			//Create repository based on its Key name : 'Keywords.DeleteTheme'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteThemeRepository repository = (IDeleteThemeRepository)RepositoryFactory.Create(Keywords.DeleteTheme);
            try
            {
            	//Execute DeleteByLoadingAnimationAudio
                repository.DeleteByLoadingAnimationAudio(loadingAnimationAudio);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Theme data by default Wallpaper
        /// </summary>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByDefaultWallpaper(string defaultWallpaper)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate DefaultWallpaper
			ValidationResult validationResult = this.ValidateDefaultWallpaper( defaultWallpaper );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByDefaultWallpaper(defaultWallpaper);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate DefaultWallpaper
		protected virtual ValidationResult ValidateDefaultWallpaper(string defaultWallpaper)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.DeleteTheme);
				
				//Execute validation process
				validationResult = validator.ValidateDefaultWallpaper(defaultWallpaper);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete DefaultWallpaper
		protected virtual OperationResult _DeleteByDefaultWallpaper(string defaultWallpaper)
		{
			//Create repository based on its Key name : 'Keywords.DeleteTheme'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteThemeRepository repository = (IDeleteThemeRepository)RepositoryFactory.Create(Keywords.DeleteTheme);
            try
            {
            	//Execute DeleteByDefaultWallpaper
                repository.DeleteByDefaultWallpaper(defaultWallpaper);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Theme data by taskbar Color
        /// </summary>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByTaskbarColor(string taskbarColor)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate TaskbarColor
			ValidationResult validationResult = this.ValidateTaskbarColor( taskbarColor );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByTaskbarColor(taskbarColor);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate TaskbarColor
		protected virtual ValidationResult ValidateTaskbarColor(string taskbarColor)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.DeleteTheme);
				
				//Execute validation process
				validationResult = validator.ValidateTaskbarColor(taskbarColor);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete TaskbarColor
		protected virtual OperationResult _DeleteByTaskbarColor(string taskbarColor)
		{
			//Create repository based on its Key name : 'Keywords.DeleteTheme'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteThemeRepository repository = (IDeleteThemeRepository)RepositoryFactory.Create(Keywords.DeleteTheme);
            try
            {
            	//Execute DeleteByTaskbarColor
                repository.DeleteByTaskbarColor(taskbarColor);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Theme data by taskbar Menu Color
        /// </summary>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByTaskbarMenuColor(string taskbarMenuColor)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate TaskbarMenuColor
			ValidationResult validationResult = this.ValidateTaskbarMenuColor( taskbarMenuColor );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByTaskbarMenuColor(taskbarMenuColor);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate TaskbarMenuColor
		protected virtual ValidationResult ValidateTaskbarMenuColor(string taskbarMenuColor)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.DeleteTheme);
				
				//Execute validation process
				validationResult = validator.ValidateTaskbarMenuColor(taskbarMenuColor);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete TaskbarMenuColor
		protected virtual OperationResult _DeleteByTaskbarMenuColor(string taskbarMenuColor)
		{
			//Create repository based on its Key name : 'Keywords.DeleteTheme'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteThemeRepository repository = (IDeleteThemeRepository)RepositoryFactory.Create(Keywords.DeleteTheme);
            try
            {
            	//Execute DeleteByTaskbarMenuColor
                repository.DeleteByTaskbarMenuColor(taskbarMenuColor);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }