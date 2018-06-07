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
    /// Business Service for ApplicationItem module.
    /// </summary>
    public class DeleteApplicationItemBusinessService : BaseBusinessService<ApplicationItem>, IDeleteApplicationItemBusinessService
    {
        class Keywords
        {
            public static string DeleteApplicationItem = "Delete.ERP.ApplicationManager.ApplicationItem";
        }
        
        public DeleteApplicationItemBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteApplicationItemBusinessService()
        {
            this.RepoKey = Keywords.DeleteApplicationItem;
        }

        /// <summary>
        /// Delete  Application Item data by application Name
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationName(string applicationName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationName
			ValidationResult validationResult = this.ValidateApplicationName( applicationName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationName(applicationName);
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
		
		//Validate ApplicationName
		protected virtual ValidationResult ValidateApplicationName(string applicationName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationName(applicationName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationName
		protected virtual OperationResult _DeleteByApplicationName(string applicationName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationName
                repository.DeleteByApplicationName(applicationName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Title
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationTitle(string applicationTitle)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationTitle
			ValidationResult validationResult = this.ValidateApplicationTitle( applicationTitle );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationTitle(applicationTitle);
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
		
		//Validate ApplicationTitle
		protected virtual ValidationResult ValidateApplicationTitle(string applicationTitle)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationTitle(applicationTitle);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationTitle
		protected virtual OperationResult _DeleteByApplicationTitle(string applicationTitle)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationTitle
                repository.DeleteByApplicationTitle(applicationTitle);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Icon
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationIcon(string applicationIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationIcon
			ValidationResult validationResult = this.ValidateApplicationIcon( applicationIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationIcon(applicationIcon);
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
		
		//Validate ApplicationIcon
		protected virtual ValidationResult ValidateApplicationIcon(string applicationIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationIcon(applicationIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationIcon
		protected virtual OperationResult _DeleteByApplicationIcon(string applicationIcon)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationIcon
                repository.DeleteByApplicationIcon(applicationIcon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Desc
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationDesc(string applicationDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationDesc
			ValidationResult validationResult = this.ValidateApplicationDesc( applicationDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationDesc(applicationDesc);
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
		
		//Validate ApplicationDesc
		protected virtual ValidationResult ValidateApplicationDesc(string applicationDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationDesc(applicationDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationDesc
		protected virtual OperationResult _DeleteByApplicationDesc(string applicationDesc)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationDesc
                repository.DeleteByApplicationDesc(applicationDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Path
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationPath(string applicationPath)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationPath
			ValidationResult validationResult = this.ValidateApplicationPath( applicationPath );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationPath(applicationPath);
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
		
		//Validate ApplicationPath
		protected virtual ValidationResult ValidateApplicationPath(string applicationPath)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationPath(applicationPath);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationPath
		protected virtual OperationResult _DeleteByApplicationPath(string applicationPath)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationPath
                repository.DeleteByApplicationPath(applicationPath);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application File
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationFile(string applicationFile)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationFile
			ValidationResult validationResult = this.ValidateApplicationFile( applicationFile );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationFile(applicationFile);
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
		
		//Validate ApplicationFile
		protected virtual ValidationResult ValidateApplicationFile(string applicationFile)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationFile(applicationFile);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationFile
		protected virtual OperationResult _DeleteByApplicationFile(string applicationFile)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationFile
                repository.DeleteByApplicationFile(applicationFile);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Class
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationClass(string applicationClass)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationClass
			ValidationResult validationResult = this.ValidateApplicationClass( applicationClass );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationClass(applicationClass);
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
		
		//Validate ApplicationClass
		protected virtual ValidationResult ValidateApplicationClass(string applicationClass)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationClass(applicationClass);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationClass
		protected virtual OperationResult _DeleteByApplicationClass(string applicationClass)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationClass
                repository.DeleteByApplicationClass(applicationClass);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Start Function
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationStartFunction(string applicationStartFunction)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationStartFunction
			ValidationResult validationResult = this.ValidateApplicationStartFunction( applicationStartFunction );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationStartFunction(applicationStartFunction);
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
		
		//Validate ApplicationStartFunction
		protected virtual ValidationResult ValidateApplicationStartFunction(string applicationStartFunction)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationStartFunction(applicationStartFunction);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationStartFunction
		protected virtual OperationResult _DeleteByApplicationStartFunction(string applicationStartFunction)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationStartFunction
                repository.DeleteByApplicationStartFunction(applicationStartFunction);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Group Id
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationGroupId(Int16 applicationGroupId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateApplicationGroupId( applicationGroupId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationGroupId(applicationGroupId);
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
		
		//Validate 
		protected virtual ValidationResult ValidateApplicationGroupId(Int16 applicationGroupId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupId(applicationGroupId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByApplicationGroupId(Int16 applicationGroupId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationGroupId
                repository.DeleteByApplicationGroupId(applicationGroupId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by application Group Id, is Displayed
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationGroupIdAndIsDisplayed(Int16 applicationGroupId, Int16 isDisplayed)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateApplicationGroupIdAndIsDisplayed( applicationGroupId, isDisplayed );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationGroupIdAndIsDisplayed(applicationGroupId, isDisplayed);
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
		
		//Validate 
		protected virtual ValidationResult ValidateApplicationGroupIdAndIsDisplayed(Int16 applicationGroupId, Int16 isDisplayed)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupIdAndIsDisplayed(applicationGroupId, isDisplayed);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByApplicationGroupIdAndIsDisplayed(Int16 applicationGroupId, Int16 isDisplayed)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByApplicationGroupIdAndIsDisplayed
                repository.DeleteByApplicationGroupIdAndIsDisplayed(applicationGroupId, isDisplayed);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Item data by is Displayed
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByIsDisplayed(Int16 isDisplayed)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsDisplayed( isDisplayed );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByIsDisplayed(isDisplayed);
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
		
		//Validate 
		protected virtual ValidationResult ValidateIsDisplayed(Int16 isDisplayed)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.DeleteApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateIsDisplayed(isDisplayed);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByIsDisplayed(Int16 isDisplayed)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationItem'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationItemRepository repository = (IDeleteApplicationItemRepository)RepositoryFactory.Create(Keywords.DeleteApplicationItem);
            try
            {
            	//Execute DeleteByIsDisplayed
                repository.DeleteByIsDisplayed(isDisplayed);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }