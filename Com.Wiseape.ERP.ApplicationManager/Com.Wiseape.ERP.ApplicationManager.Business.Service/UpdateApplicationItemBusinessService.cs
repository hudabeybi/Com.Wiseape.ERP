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
    public class UpdateApplicationItemBusinessService : BaseBusinessService<ApplicationItem>, IUpdateApplicationItemBusinessService
    {
        class Keywords
        {
            public static string UpdateApplicationItem = "Update.ERP.ApplicationManager.ApplicationItem";
        }
        
        public UpdateApplicationItemBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateApplicationItemBusinessService()
        {
            this.RepoKey = Keywords.UpdateApplicationItem;
        }


        /// <summary>
        /// Update  Application Item data with id Application, application Name
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationName(Int16 idApplication, string applicationName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationName
			ValidationResult validationResult = this.ValidateApplicationName( idApplication, applicationName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationName(idApplication, applicationName);
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
		protected virtual ValidationResult ValidateApplicationName(Int16 idApplication, string applicationName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationName(idApplication, applicationName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationName
		protected virtual OperationResult _UpdateApplicationName(Int16 idApplication, string applicationName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationName
                repository.UpdateApplicationName(idApplication, applicationName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Title
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationTitle(Int16 idApplication, string applicationTitle)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationTitle
			ValidationResult validationResult = this.ValidateApplicationTitle( idApplication, applicationTitle );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationTitle(idApplication, applicationTitle);
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
		protected virtual ValidationResult ValidateApplicationTitle(Int16 idApplication, string applicationTitle)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationTitle(idApplication, applicationTitle);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationTitle
		protected virtual OperationResult _UpdateApplicationTitle(Int16 idApplication, string applicationTitle)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationTitle
                repository.UpdateApplicationTitle(idApplication, applicationTitle);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Icon
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationIcon(Int16 idApplication, string applicationIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationIcon
			ValidationResult validationResult = this.ValidateApplicationIcon( idApplication, applicationIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationIcon(idApplication, applicationIcon);
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
		protected virtual ValidationResult ValidateApplicationIcon(Int16 idApplication, string applicationIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationIcon(idApplication, applicationIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationIcon
		protected virtual OperationResult _UpdateApplicationIcon(Int16 idApplication, string applicationIcon)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationIcon
                repository.UpdateApplicationIcon(idApplication, applicationIcon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Desc
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationDesc(Int16 idApplication, string applicationDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationDesc
			ValidationResult validationResult = this.ValidateApplicationDesc( idApplication, applicationDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationDesc(idApplication, applicationDesc);
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
		protected virtual ValidationResult ValidateApplicationDesc(Int16 idApplication, string applicationDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationDesc(idApplication, applicationDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationDesc
		protected virtual OperationResult _UpdateApplicationDesc(Int16 idApplication, string applicationDesc)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationDesc
                repository.UpdateApplicationDesc(idApplication, applicationDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Path
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationPath(Int16 idApplication, string applicationPath)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationPath
			ValidationResult validationResult = this.ValidateApplicationPath( idApplication, applicationPath );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationPath(idApplication, applicationPath);
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
		protected virtual ValidationResult ValidateApplicationPath(Int16 idApplication, string applicationPath)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationPath(idApplication, applicationPath);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationPath
		protected virtual OperationResult _UpdateApplicationPath(Int16 idApplication, string applicationPath)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationPath
                repository.UpdateApplicationPath(idApplication, applicationPath);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application File
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationFile(Int16 idApplication, string applicationFile)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationFile
			ValidationResult validationResult = this.ValidateApplicationFile( idApplication, applicationFile );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationFile(idApplication, applicationFile);
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
		protected virtual ValidationResult ValidateApplicationFile(Int16 idApplication, string applicationFile)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationFile(idApplication, applicationFile);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationFile
		protected virtual OperationResult _UpdateApplicationFile(Int16 idApplication, string applicationFile)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationFile
                repository.UpdateApplicationFile(idApplication, applicationFile);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Class
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationClass(Int16 idApplication, string applicationClass)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationClass
			ValidationResult validationResult = this.ValidateApplicationClass( idApplication, applicationClass );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationClass(idApplication, applicationClass);
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
		protected virtual ValidationResult ValidateApplicationClass(Int16 idApplication, string applicationClass)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationClass(idApplication, applicationClass);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationClass
		protected virtual OperationResult _UpdateApplicationClass(Int16 idApplication, string applicationClass)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationClass
                repository.UpdateApplicationClass(idApplication, applicationClass);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Start Function
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationStartFunction(Int16 idApplication, string applicationStartFunction)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationStartFunction
			ValidationResult validationResult = this.ValidateApplicationStartFunction( idApplication, applicationStartFunction );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationStartFunction(idApplication, applicationStartFunction);
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
		protected virtual ValidationResult ValidateApplicationStartFunction(Int16 idApplication, string applicationStartFunction)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationStartFunction(idApplication, applicationStartFunction);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationStartFunction
		protected virtual OperationResult _UpdateApplicationStartFunction(Int16 idApplication, string applicationStartFunction)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationStartFunction
                repository.UpdateApplicationStartFunction(idApplication, applicationStartFunction);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Group Id
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationGroupId(Int16 idApplication, Int16 applicationGroupId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateApplicationGroupId( idApplication, applicationGroupId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationGroupId(idApplication, applicationGroupId);
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
		protected virtual ValidationResult ValidateApplicationGroupId(Int16 idApplication, Int16 applicationGroupId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupId(idApplication, applicationGroupId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateApplicationGroupId(Int16 idApplication, Int16 applicationGroupId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationGroupId
                repository.UpdateApplicationGroupId(idApplication, applicationGroupId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, application Group Id, is Displayed
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationGroupIdAndIsDisplayed(Int16 idApplication, Int16 applicationGroupId, Int16 isDisplayed)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateApplicationGroupIdAndIsDisplayed( idApplication, applicationGroupId, isDisplayed );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationGroupIdAndIsDisplayed(idApplication, applicationGroupId, isDisplayed);
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
		protected virtual ValidationResult ValidateApplicationGroupIdAndIsDisplayed(Int16 idApplication, Int16 applicationGroupId, Int16 isDisplayed)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupIdAndIsDisplayed(idApplication, applicationGroupId, isDisplayed);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateApplicationGroupIdAndIsDisplayed(Int16 idApplication, Int16 applicationGroupId, Int16 isDisplayed)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateApplicationGroupIdAndIsDisplayed
                repository.UpdateApplicationGroupIdAndIsDisplayed(idApplication, applicationGroupId, isDisplayed);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Item data with id Application, is Displayed
        /// </summary>
		/// <param name="idApplication"> Id Application</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateIsDisplayed(Int16 idApplication, Int16 isDisplayed)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsDisplayed( idApplication, isDisplayed );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateIsDisplayed(idApplication, isDisplayed);
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
		protected virtual ValidationResult ValidateIsDisplayed(Int16 idApplication, Int16 isDisplayed)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationItem'. 
				//The validator factory will create the validator object based on its key.
				IApplicationItemValidator validator = (IApplicationItemValidator)ValidatorFactory.Create(Keywords.UpdateApplicationItem);
				
				//Execute validation process
				validationResult = validator.ValidateIsDisplayed(idApplication, isDisplayed);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateIsDisplayed(Int16 idApplication, Int16 isDisplayed)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationItem'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationItemRepository repository = (IUpdateApplicationItemRepository)RepositoryFactory.Create(Keywords.UpdateApplicationItem);
            try
            {
            	//Execute UpdateIsDisplayed
                repository.UpdateIsDisplayed(idApplication, isDisplayed);
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