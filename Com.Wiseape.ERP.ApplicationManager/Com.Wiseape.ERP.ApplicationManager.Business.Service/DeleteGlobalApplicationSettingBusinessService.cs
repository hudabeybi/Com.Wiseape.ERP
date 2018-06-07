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
    public class DeleteGlobalApplicationSettingBusinessService : BaseBusinessService<GlobalApplicationSetting>, IDeleteGlobalApplicationSettingBusinessService
    {
        class Keywords
        {
            public static string DeleteGlobalApplicationSetting = "Delete.ERP.ApplicationManager.GlobalApplicationSetting";
        }
        
        public DeleteGlobalApplicationSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteGlobalApplicationSettingBusinessService()
        {
            this.RepoKey = Keywords.DeleteGlobalApplicationSetting;
        }

        /// <summary>
        /// Delete  Global Application Setting data by setting Name
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteBySettingName(string settingName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate SettingName
			ValidationResult validationResult = this.ValidateSettingName( settingName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteBySettingName(settingName);
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
		protected virtual ValidationResult ValidateSettingName(string settingName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingValidator validator = (IGlobalApplicationSettingValidator)ValidatorFactory.Create(Keywords.DeleteGlobalApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateSettingName(settingName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete SettingName
		protected virtual OperationResult _DeleteBySettingName(string settingName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGlobalApplicationSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGlobalApplicationSettingRepository repository = (IDeleteGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.DeleteGlobalApplicationSetting);
            try
            {
            	//Execute DeleteBySettingName
                repository.DeleteBySettingName(settingName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Global Application Setting data by setting Value
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
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingValidator validator = (IGlobalApplicationSettingValidator)ValidatorFactory.Create(Keywords.DeleteGlobalApplicationSetting);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteGlobalApplicationSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGlobalApplicationSettingRepository repository = (IDeleteGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.DeleteGlobalApplicationSetting);
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
        /// Delete  Global Application Setting data by user I D
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByUserID(string userID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate UserID
			ValidationResult validationResult = this.ValidateUserID( userID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByUserID(userID);
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
		protected virtual ValidationResult ValidateUserID(string userID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSetting'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingValidator validator = (IGlobalApplicationSettingValidator)ValidatorFactory.Create(Keywords.DeleteGlobalApplicationSetting);
				
				//Execute validation process
				validationResult = validator.ValidateUserID(userID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete UserID
		protected virtual OperationResult _DeleteByUserID(string userID)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGlobalApplicationSetting'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGlobalApplicationSettingRepository repository = (IDeleteGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.DeleteGlobalApplicationSetting);
            try
            {
            	//Execute DeleteByUserID
                repository.DeleteByUserID(userID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }