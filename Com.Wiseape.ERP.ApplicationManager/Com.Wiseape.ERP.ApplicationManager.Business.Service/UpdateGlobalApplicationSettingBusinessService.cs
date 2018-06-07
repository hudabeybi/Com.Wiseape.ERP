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
    /// Business Service for GlobalApplicationSetting module.
    /// </summary>
    public class UpdateGlobalApplicationSettingBusinessService : BaseBusinessService<GlobalApplicationSetting>, IUpdateGlobalApplicationSettingBusinessService
    {
        class Keywords
        {
            public static string UpdateGlobalApplicationSetting = "Update.ERP.ApplicationManager.GlobalApplicationSetting";
        }
        
        public UpdateGlobalApplicationSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateGlobalApplicationSettingBusinessService()
        {
            this.RepoKey = Keywords.UpdateGlobalApplicationSetting;
        }


        /// <summary>
        /// Update  Global Application Setting data with id Global Application Setting, setting Name
        /// </summary>
		/// <param name="idGlobalApplicationSetting"> Id Global Application Setting</param>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSettingName(Int16 idGlobalApplicationSetting, string settingName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingName
			ValidationResult validationResult = this.ValidateSettingName( idGlobalApplicationSetting, settingName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSettingName(idGlobalApplicationSetting, settingName);
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
		
		//Validate SettingName
		protected virtual ValidationResult ValidateSettingName(Int16 idGlobalApplicationSetting, string settingName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingValidator validator = (IGlobalApplicationSettingValidator)ValidatorFactory.Create(Keywords.UpdateGlobalApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingName(idGlobalApplicationSetting, settingName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SettingName
		protected virtual OperationResult _UpdateSettingName(Int16 idGlobalApplicationSetting, string settingName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGlobalApplicationSettingRepository repository = (IUpdateGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.UpdateGlobalApplicationSetting);
            try
            {
            	//Execute UpdateSettingName
                repository.UpdateSettingName(idGlobalApplicationSetting, settingName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Global Application Setting data with id Global Application Setting, setting Value
        /// </summary>
		/// <param name="idGlobalApplicationSetting"> Id Global Application Setting</param>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateSettingValue(Int16 idGlobalApplicationSetting, string settingValue)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingValue
			ValidationResult validationResult = this.ValidateSettingValue( idGlobalApplicationSetting, settingValue );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateSettingValue(idGlobalApplicationSetting, settingValue);
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
		protected virtual ValidationResult ValidateSettingValue(Int16 idGlobalApplicationSetting, string settingValue)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingValidator validator = (IGlobalApplicationSettingValidator)ValidatorFactory.Create(Keywords.UpdateGlobalApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingValue(idGlobalApplicationSetting, settingValue);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update SettingValue
		protected virtual OperationResult _UpdateSettingValue(Int16 idGlobalApplicationSetting, string settingValue)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGlobalApplicationSettingRepository repository = (IUpdateGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.UpdateGlobalApplicationSetting);
            try
            {
            	//Execute UpdateSettingValue
                repository.UpdateSettingValue(idGlobalApplicationSetting, settingValue);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Global Application Setting data with id Global Application Setting, user I D
        /// </summary>
		/// <param name="idGlobalApplicationSetting"> Id Global Application Setting</param>
		/// <param name="userID"> User I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateUserID(Int16 idGlobalApplicationSetting, string userID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate UserID
			ValidationResult validationResult = this.ValidateUserID( idGlobalApplicationSetting, userID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateUserID(idGlobalApplicationSetting, userID);
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
		
		//Validate UserID
		protected virtual ValidationResult ValidateUserID(Int16 idGlobalApplicationSetting, string userID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingValidator validator = (IGlobalApplicationSettingValidator)ValidatorFactory.Create(Keywords.UpdateGlobalApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateUserID(idGlobalApplicationSetting, userID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update UserID
		protected virtual OperationResult _UpdateUserID(Int16 idGlobalApplicationSetting, string userID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGlobalApplicationSettingRepository repository = (IUpdateGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.UpdateGlobalApplicationSetting);
            try
            {
            	//Execute UpdateUserID
                repository.UpdateUserID(idGlobalApplicationSetting, userID);
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