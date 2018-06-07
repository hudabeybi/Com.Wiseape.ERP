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
    public class UpdateGlobalApplicationSettingTemplateBusinessService : BaseBusinessService<GlobalApplicationSettingTemplate>, IUpdateGlobalApplicationSettingTemplateBusinessService
    {
        class Keywords
        {
            public static string UpdateGlobalApplicationSettingTemplate = "Update.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
        }
        
        public UpdateGlobalApplicationSettingTemplateBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateGlobalApplicationSettingTemplateBusinessService()
        {
            this.RepoKey = Keywords.UpdateGlobalApplicationSettingTemplate;
        }


        /// <summary>
        /// Update  Global Application Setting Template data with id Global Application Setting Template, application Setting Name
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate"> Id Global Application Setting Template</param>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationSettingName(Int16 idGlobalApplicationSettingTemplate, string applicationSettingName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationSettingName
			ValidationResult validationResult = this.ValidateApplicationSettingName( idGlobalApplicationSettingTemplate, applicationSettingName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationSettingName(idGlobalApplicationSettingTemplate, applicationSettingName);
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
		protected virtual ValidationResult ValidateApplicationSettingName(Int16 idGlobalApplicationSettingTemplate, string applicationSettingName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingTemplateValidator validator = (IGlobalApplicationSettingTemplateValidator)ValidatorFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationSettingName(idGlobalApplicationSettingTemplate, applicationSettingName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationSettingName
		protected virtual OperationResult _UpdateApplicationSettingName(Int16 idGlobalApplicationSettingTemplate, string applicationSettingName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGlobalApplicationSettingTemplateRepository repository = (IUpdateGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
            try
            {
            	//Execute UpdateApplicationSettingName
                repository.UpdateApplicationSettingName(idGlobalApplicationSettingTemplate, applicationSettingName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Global Application Setting Template data with id Global Application Setting Template, application Setting Value
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate"> Id Global Application Setting Template</param>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationSettingValue(Int16 idGlobalApplicationSettingTemplate, string applicationSettingValue)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationSettingValue
			ValidationResult validationResult = this.ValidateApplicationSettingValue( idGlobalApplicationSettingTemplate, applicationSettingValue );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationSettingValue(idGlobalApplicationSettingTemplate, applicationSettingValue);
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
		protected virtual ValidationResult ValidateApplicationSettingValue(Int16 idGlobalApplicationSettingTemplate, string applicationSettingValue)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingTemplateValidator validator = (IGlobalApplicationSettingTemplateValidator)ValidatorFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationSettingValue(idGlobalApplicationSettingTemplate, applicationSettingValue);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationSettingValue
		protected virtual OperationResult _UpdateApplicationSettingValue(Int16 idGlobalApplicationSettingTemplate, string applicationSettingValue)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGlobalApplicationSettingTemplateRepository repository = (IUpdateGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
            try
            {
            	//Execute UpdateApplicationSettingValue
                repository.UpdateApplicationSettingValue(idGlobalApplicationSettingTemplate, applicationSettingValue);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Global Application Setting Template data with id Global Application Setting Template, is Active
        /// </summary>
		/// <param name="idGlobalApplicationSettingTemplate"> Id Global Application Setting Template</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateIsActive(Int16 idGlobalApplicationSettingTemplate, Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsActive( idGlobalApplicationSettingTemplate, isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateIsActive(idGlobalApplicationSettingTemplate, isActive);
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
		protected virtual ValidationResult ValidateIsActive(Int16 idGlobalApplicationSettingTemplate, Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
				//The validator factory will create the validator object based on its key.
				IGlobalApplicationSettingTemplateValidator validator = (IGlobalApplicationSettingTemplateValidator)ValidatorFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
				
				//Execute validation process
				validationResult = validator.ValidateIsActive(idGlobalApplicationSettingTemplate, isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateIsActive(Int16 idGlobalApplicationSettingTemplate, Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGlobalApplicationSettingTemplate'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGlobalApplicationSettingTemplateRepository repository = (IUpdateGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.UpdateGlobalApplicationSettingTemplate);
            try
            {
            	//Execute UpdateIsActive
                repository.UpdateIsActive(idGlobalApplicationSettingTemplate, isActive);
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