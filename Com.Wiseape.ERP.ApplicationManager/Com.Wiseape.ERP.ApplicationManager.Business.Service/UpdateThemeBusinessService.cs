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
    public class UpdateThemeBusinessService : BaseBusinessService<Theme>, IUpdateThemeBusinessService
    {
        class Keywords
        {
            public static string UpdateTheme = "Update.ERP.ApplicationManager.Theme";
        }
        
        public UpdateThemeBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateThemeBusinessService()
        {
            this.RepoKey = Keywords.UpdateTheme;
        }


        /// <summary>
        /// Update  Theme data with id Theme, theme Name
        /// </summary>
		/// <param name="idTheme"> Id Theme</param>
		/// <param name="themeName"> Theme Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateThemeName(Int16 idTheme, string themeName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ThemeName
			ValidationResult validationResult = this.ValidateThemeName( idTheme, themeName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateThemeName(idTheme, themeName);
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
		protected virtual ValidationResult ValidateThemeName(Int16 idTheme, string themeName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.UpdateTheme);
				
				//Execute validation process
				validationResult = validator.ValidateThemeName(idTheme, themeName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ThemeName
		protected virtual OperationResult _UpdateThemeName(Int16 idTheme, string themeName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateTheme'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateThemeRepository repository = (IUpdateThemeRepository)RepositoryFactory.Create(Keywords.UpdateTheme);
            try
            {
            	//Execute UpdateThemeName
                repository.UpdateThemeName(idTheme, themeName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Theme data with id Theme, theme Info
        /// </summary>
		/// <param name="idTheme"> Id Theme</param>
		/// <param name="themeInfo"> Theme Info</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateThemeInfo(Int16 idTheme, string themeInfo)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ThemeInfo
			ValidationResult validationResult = this.ValidateThemeInfo( idTheme, themeInfo );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateThemeInfo(idTheme, themeInfo);
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
		protected virtual ValidationResult ValidateThemeInfo(Int16 idTheme, string themeInfo)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.UpdateTheme);
				
				//Execute validation process
				validationResult = validator.ValidateThemeInfo(idTheme, themeInfo);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ThemeInfo
		protected virtual OperationResult _UpdateThemeInfo(Int16 idTheme, string themeInfo)
		{
			//Create repository based on its Key name : 'Keywords.UpdateTheme'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateThemeRepository repository = (IUpdateThemeRepository)RepositoryFactory.Create(Keywords.UpdateTheme);
            try
            {
            	//Execute UpdateThemeInfo
                repository.UpdateThemeInfo(idTheme, themeInfo);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Theme data with id Theme, loading Animation
        /// </summary>
		/// <param name="idTheme"> Id Theme</param>
		/// <param name="loadingAnimation"> Loading Animation</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLoadingAnimation(Int16 idTheme, string loadingAnimation)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LoadingAnimation
			ValidationResult validationResult = this.ValidateLoadingAnimation( idTheme, loadingAnimation );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLoadingAnimation(idTheme, loadingAnimation);
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
		protected virtual ValidationResult ValidateLoadingAnimation(Int16 idTheme, string loadingAnimation)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.UpdateTheme);
				
				//Execute validation process
				validationResult = validator.ValidateLoadingAnimation(idTheme, loadingAnimation);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LoadingAnimation
		protected virtual OperationResult _UpdateLoadingAnimation(Int16 idTheme, string loadingAnimation)
		{
			//Create repository based on its Key name : 'Keywords.UpdateTheme'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateThemeRepository repository = (IUpdateThemeRepository)RepositoryFactory.Create(Keywords.UpdateTheme);
            try
            {
            	//Execute UpdateLoadingAnimation
                repository.UpdateLoadingAnimation(idTheme, loadingAnimation);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Theme data with id Theme, loading Animation Audio
        /// </summary>
		/// <param name="idTheme"> Id Theme</param>
		/// <param name="loadingAnimationAudio"> Loading Animation Audio</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLoadingAnimationAudio(Int16 idTheme, string loadingAnimationAudio)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LoadingAnimationAudio
			ValidationResult validationResult = this.ValidateLoadingAnimationAudio( idTheme, loadingAnimationAudio );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLoadingAnimationAudio(idTheme, loadingAnimationAudio);
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
		protected virtual ValidationResult ValidateLoadingAnimationAudio(Int16 idTheme, string loadingAnimationAudio)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.UpdateTheme);
				
				//Execute validation process
				validationResult = validator.ValidateLoadingAnimationAudio(idTheme, loadingAnimationAudio);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LoadingAnimationAudio
		protected virtual OperationResult _UpdateLoadingAnimationAudio(Int16 idTheme, string loadingAnimationAudio)
		{
			//Create repository based on its Key name : 'Keywords.UpdateTheme'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateThemeRepository repository = (IUpdateThemeRepository)RepositoryFactory.Create(Keywords.UpdateTheme);
            try
            {
            	//Execute UpdateLoadingAnimationAudio
                repository.UpdateLoadingAnimationAudio(idTheme, loadingAnimationAudio);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Theme data with id Theme, default Wallpaper
        /// </summary>
		/// <param name="idTheme"> Id Theme</param>
		/// <param name="defaultWallpaper"> Default Wallpaper</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateDefaultWallpaper(Int16 idTheme, string defaultWallpaper)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate DefaultWallpaper
			ValidationResult validationResult = this.ValidateDefaultWallpaper( idTheme, defaultWallpaper );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateDefaultWallpaper(idTheme, defaultWallpaper);
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
		protected virtual ValidationResult ValidateDefaultWallpaper(Int16 idTheme, string defaultWallpaper)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.UpdateTheme);
				
				//Execute validation process
				validationResult = validator.ValidateDefaultWallpaper(idTheme, defaultWallpaper);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update DefaultWallpaper
		protected virtual OperationResult _UpdateDefaultWallpaper(Int16 idTheme, string defaultWallpaper)
		{
			//Create repository based on its Key name : 'Keywords.UpdateTheme'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateThemeRepository repository = (IUpdateThemeRepository)RepositoryFactory.Create(Keywords.UpdateTheme);
            try
            {
            	//Execute UpdateDefaultWallpaper
                repository.UpdateDefaultWallpaper(idTheme, defaultWallpaper);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Theme data with id Theme, taskbar Color
        /// </summary>
		/// <param name="idTheme"> Id Theme</param>
		/// <param name="taskbarColor"> Taskbar Color</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateTaskbarColor(Int16 idTheme, string taskbarColor)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate TaskbarColor
			ValidationResult validationResult = this.ValidateTaskbarColor( idTheme, taskbarColor );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateTaskbarColor(idTheme, taskbarColor);
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
		protected virtual ValidationResult ValidateTaskbarColor(Int16 idTheme, string taskbarColor)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.UpdateTheme);
				
				//Execute validation process
				validationResult = validator.ValidateTaskbarColor(idTheme, taskbarColor);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update TaskbarColor
		protected virtual OperationResult _UpdateTaskbarColor(Int16 idTheme, string taskbarColor)
		{
			//Create repository based on its Key name : 'Keywords.UpdateTheme'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateThemeRepository repository = (IUpdateThemeRepository)RepositoryFactory.Create(Keywords.UpdateTheme);
            try
            {
            	//Execute UpdateTaskbarColor
                repository.UpdateTaskbarColor(idTheme, taskbarColor);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Theme data with id Theme, taskbar Menu Color
        /// </summary>
		/// <param name="idTheme"> Id Theme</param>
		/// <param name="taskbarMenuColor"> Taskbar Menu Color</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateTaskbarMenuColor(Int16 idTheme, string taskbarMenuColor)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate TaskbarMenuColor
			ValidationResult validationResult = this.ValidateTaskbarMenuColor( idTheme, taskbarMenuColor );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateTaskbarMenuColor(idTheme, taskbarMenuColor);
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
		protected virtual ValidationResult ValidateTaskbarMenuColor(Int16 idTheme, string taskbarMenuColor)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateTheme'. 
				//The validator factory will create the validator object based on its key.
				IThemeValidator validator = (IThemeValidator)ValidatorFactory.Create(Keywords.UpdateTheme);
				
				//Execute validation process
				validationResult = validator.ValidateTaskbarMenuColor(idTheme, taskbarMenuColor);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update TaskbarMenuColor
		protected virtual OperationResult _UpdateTaskbarMenuColor(Int16 idTheme, string taskbarMenuColor)
		{
			//Create repository based on its Key name : 'Keywords.UpdateTheme'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateThemeRepository repository = (IUpdateThemeRepository)RepositoryFactory.Create(Keywords.UpdateTheme);
            try
            {
            	//Execute UpdateTaskbarMenuColor
                repository.UpdateTaskbarMenuColor(idTheme, taskbarMenuColor);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}


    }
 }