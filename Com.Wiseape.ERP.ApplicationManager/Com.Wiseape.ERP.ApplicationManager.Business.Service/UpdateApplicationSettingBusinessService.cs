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
    public class UpdateApplicationSettingBusinessService : BaseBusinessService<ApplicationSetting>, IUpdateApplicationSettingBusinessService
    {
        class Keywords
        {
            public static string UpdateApplicationSetting = "Update.ERP.ApplicationManager.ApplicationSetting";
        }
        
        public UpdateApplicationSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateApplicationSettingBusinessService()
        {
            this.RepoKey = Keywords.UpdateApplicationSetting;
        }


        /// <summary>
        /// Update  Application Setting data with id Application Setting, setting Key
        /// </summary>
		/// <param name="idApplicationSetting"> Id Application Setting</param>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSettingKey(Int16 idApplicationSetting, string settingKey)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingKey
			ValidationResult validationResult = this.ValidateSettingKey( idApplicationSetting, settingKey );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSettingKey(idApplicationSetting, settingKey);
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
		protected virtual ValidationResult ValidateSettingKey(Int16 idApplicationSetting, string settingKey)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IApplicationSettingValidator validator = (IApplicationSettingValidator)ValidatorFactory.Create(Keywords.UpdateApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingKey(idApplicationSetting, settingKey);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SettingKey
		protected virtual OperationResult _UpdateSettingKey(Int16 idApplicationSetting, string settingKey)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationSettingRepository repository = (IUpdateApplicationSettingRepository)RepositoryFactory.Create(Keywords.UpdateApplicationSetting);
            try
            {
            	//Execute UpdateSettingKey
                repository.UpdateSettingKey(idApplicationSetting, settingKey);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Setting data with id Application Setting, setting Value
        /// </summary>
		/// <param name="idApplicationSetting"> Id Application Setting</param>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSettingValue(Int16 idApplicationSetting, string settingValue)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingValue
			ValidationResult validationResult = this.ValidateSettingValue( idApplicationSetting, settingValue );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSettingValue(idApplicationSetting, settingValue);
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
		protected virtual ValidationResult ValidateSettingValue(Int16 idApplicationSetting, string settingValue)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IApplicationSettingValidator validator = (IApplicationSettingValidator)ValidatorFactory.Create(Keywords.UpdateApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingValue(idApplicationSetting, settingValue);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SettingValue
		protected virtual OperationResult _UpdateSettingValue(Int16 idApplicationSetting, string settingValue)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationSettingRepository repository = (IUpdateApplicationSettingRepository)RepositoryFactory.Create(Keywords.UpdateApplicationSetting);
            try
            {
            	//Execute UpdateSettingValue
                repository.UpdateSettingValue(idApplicationSetting, settingValue);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Setting data with id Application Setting, app Name
        /// </summary>
		/// <param name="idApplicationSetting"> Id Application Setting</param>
		/// <param name="appName"> App Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAppName(Int16 idApplicationSetting, string appName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate AppName
			ValidationResult validationResult = this.ValidateAppName( idApplicationSetting, appName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAppName(idApplicationSetting, appName);
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
		protected virtual ValidationResult ValidateAppName(Int16 idApplicationSetting, string appName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IApplicationSettingValidator validator = (IApplicationSettingValidator)ValidatorFactory.Create(Keywords.UpdateApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateAppName(idApplicationSetting, appName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update AppName
		protected virtual OperationResult _UpdateAppName(Int16 idApplicationSetting, string appName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationSettingRepository repository = (IUpdateApplicationSettingRepository)RepositoryFactory.Create(Keywords.UpdateApplicationSetting);
            try
            {
            	//Execute UpdateAppName
                repository.UpdateAppName(idApplicationSetting, appName);
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