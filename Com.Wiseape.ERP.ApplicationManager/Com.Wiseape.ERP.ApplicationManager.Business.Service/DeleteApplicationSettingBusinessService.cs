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
    /// Business Service for ApplicationSetting module.
    /// </summary>
    public class DeleteApplicationSettingBusinessService : BaseBusinessService<ApplicationSetting>, IDeleteApplicationSettingBusinessService
    {
        class Keywords
        {
            public static string DeleteApplicationSetting = "Delete.ERP.ApplicationManager.ApplicationSetting";
        }
        
        public DeleteApplicationSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteApplicationSettingBusinessService()
        {
            this.RepoKey = Keywords.DeleteApplicationSetting;
        }

        /// <summary>
        /// Delete  Application Setting data by setting Key
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteBySettingKey(string settingKey)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingKey
			ValidationResult validationResult = this.ValidateSettingKey( settingKey );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteBySettingKey(settingKey);
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
		
		//Validate SettingKey
		protected virtual ValidationResult ValidateSettingKey(string settingKey)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IApplicationSettingValidator validator = (IApplicationSettingValidator)ValidatorFactory.Create(Keywords.DeleteApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingKey(settingKey);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete SettingKey
		protected virtual OperationResult _DeleteBySettingKey(string settingKey)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationSettingRepository repository = (IDeleteApplicationSettingRepository)RepositoryFactory.Create(Keywords.DeleteApplicationSetting);
            try
            {
            	//Execute DeleteBySettingKey
                repository.DeleteBySettingKey(settingKey);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Setting data by setting Value
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteBySettingValue(string settingValue)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingValue
			ValidationResult validationResult = this.ValidateSettingValue( settingValue );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteBySettingValue(settingValue);
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
		
		//Validate SettingValue
		protected virtual ValidationResult ValidateSettingValue(string settingValue)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IApplicationSettingValidator validator = (IApplicationSettingValidator)ValidatorFactory.Create(Keywords.DeleteApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingValue(settingValue);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete SettingValue
		protected virtual OperationResult _DeleteBySettingValue(string settingValue)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationSettingRepository repository = (IDeleteApplicationSettingRepository)RepositoryFactory.Create(Keywords.DeleteApplicationSetting);
            try
            {
            	//Execute DeleteBySettingValue
                repository.DeleteBySettingValue(settingValue);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Setting data by app Name
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAppName(string appName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AppName
			ValidationResult validationResult = this.ValidateAppName( appName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAppName(appName);
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
		
		//Validate AppName
		protected virtual ValidationResult ValidateAppName(string appName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IApplicationSettingValidator validator = (IApplicationSettingValidator)ValidatorFactory.Create(Keywords.DeleteApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateAppName(appName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete AppName
		protected virtual OperationResult _DeleteByAppName(string appName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationSettingRepository repository = (IDeleteApplicationSettingRepository)RepositoryFactory.Create(Keywords.DeleteApplicationSetting);
            try
            {
            	//Execute DeleteByAppName
                repository.DeleteByAppName(appName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }