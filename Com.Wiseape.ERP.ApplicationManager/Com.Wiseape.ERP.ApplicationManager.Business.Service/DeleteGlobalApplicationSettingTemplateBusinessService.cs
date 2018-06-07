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
    /// Business Service for GlobalApplicationSettingTemplate module.
    /// </summary>
    public class DeleteGlobalApplicationSettingTemplateBusinessService : BaseBusinessService<GlobalApplicationSettingTemplate>, IDeleteGlobalApplicationSettingTemplateBusinessService
    {
        class Keywords
        {
            public static string DeleteGlobalApplicationSettingTemplate = "Delete.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
        }
        
        public DeleteGlobalApplicationSettingTemplateBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteGlobalApplicationSettingTemplateBusinessService()
        {
            this.RepoKey = Keywords.DeleteGlobalApplicationSettingTemplate;
        }

        /// <summary>
        /// Delete  Global Application Setting Template data by application Setting Name
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationSettingName(string applicationSettingName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationSettingName
			ValidationResult validationResult = this.ValidateApplicationSettingName( applicationSettingName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationSettingName(applicationSettingName);
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
		
		//Validate ApplicationSettingName
		protected virtual ValidationResult ValidateApplicationSettingName(string applicationSettingName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingTemplateValidator validator = (IGlobalApplicationSettingTemplateValidator)ValidatorFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationSettingName(applicationSettingName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationSettingName
		protected virtual OperationResult _DeleteByApplicationSettingName(string applicationSettingName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGlobalApplicationSettingTemplate'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGlobalApplicationSettingTemplateRepository repository = (IDeleteGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
            try
            {
            	//Execute DeleteByApplicationSettingName
                repository.DeleteByApplicationSettingName(applicationSettingName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Global Application Setting Template data by application Setting Value
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationSettingValue(string applicationSettingValue)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationSettingValue
			ValidationResult validationResult = this.ValidateApplicationSettingValue( applicationSettingValue );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationSettingValue(applicationSettingValue);
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
		
		//Validate ApplicationSettingValue
		protected virtual ValidationResult ValidateApplicationSettingValue(string applicationSettingValue)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingTemplateValidator validator = (IGlobalApplicationSettingTemplateValidator)ValidatorFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationSettingValue(applicationSettingValue);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationSettingValue
		protected virtual OperationResult _DeleteByApplicationSettingValue(string applicationSettingValue)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGlobalApplicationSettingTemplate'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGlobalApplicationSettingTemplateRepository repository = (IDeleteGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
            try
            {
            	//Execute DeleteByApplicationSettingValue
                repository.DeleteByApplicationSettingValue(applicationSettingValue);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Global Application Setting Template data by is Active
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByIsActive(Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsActive( isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByIsActive(isActive);
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
		protected virtual ValidationResult ValidateIsActive(Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingTemplateValidator validator = (IGlobalApplicationSettingTemplateValidator)ValidatorFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
				
				//Execute validation process
				validationResult = validator.ValidateIsActive(isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByIsActive(Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGlobalApplicationSettingTemplate'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGlobalApplicationSettingTemplateRepository repository = (IDeleteGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.DeleteGlobalApplicationSettingTemplate);
            try
            {
            	//Execute DeleteByIsActive
                repository.DeleteByIsActive(isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }