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
    /// Business Service for ApplicationGroup module.
    /// </summary>
    public class DeleteApplicationGroupBusinessService : BaseBusinessService<ApplicationGroup>, IDeleteApplicationGroupBusinessService
    {
        class Keywords
        {
            public static string DeleteApplicationGroup = "Delete.ERP.ApplicationManager.ApplicationGroup";
        }
        
        public DeleteApplicationGroupBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteApplicationGroupBusinessService()
        {
            this.RepoKey = Keywords.DeleteApplicationGroup;
        }

        /// <summary>
        /// Delete  Application Group data by application Group Name
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationGroupName(string applicationGroupName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationGroupName
			ValidationResult validationResult = this.ValidateApplicationGroupName( applicationGroupName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationGroupName(applicationGroupName);
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
		
		//Validate ApplicationGroupName
		protected virtual ValidationResult ValidateApplicationGroupName(string applicationGroupName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationGroup'. 
				//The validator factory will create the validator object based on its key.
				IApplicationGroupValidator validator = (IApplicationGroupValidator)ValidatorFactory.Create(Keywords.DeleteApplicationGroup);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupName(applicationGroupName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationGroupName
		protected virtual OperationResult _DeleteByApplicationGroupName(string applicationGroupName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationGroup'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationGroupRepository repository = (IDeleteApplicationGroupRepository)RepositoryFactory.Create(Keywords.DeleteApplicationGroup);
            try
            {
            	//Execute DeleteByApplicationGroupName
                repository.DeleteByApplicationGroupName(applicationGroupName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Group data by application Group Desc
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationGroupDesc(string applicationGroupDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationGroupDesc
			ValidationResult validationResult = this.ValidateApplicationGroupDesc( applicationGroupDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationGroupDesc(applicationGroupDesc);
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
		
		//Validate ApplicationGroupDesc
		protected virtual ValidationResult ValidateApplicationGroupDesc(string applicationGroupDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationGroup'. 
				//The validator factory will create the validator object based on its key.
				IApplicationGroupValidator validator = (IApplicationGroupValidator)ValidatorFactory.Create(Keywords.DeleteApplicationGroup);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupDesc(applicationGroupDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationGroupDesc
		protected virtual OperationResult _DeleteByApplicationGroupDesc(string applicationGroupDesc)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationGroup'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationGroupRepository repository = (IDeleteApplicationGroupRepository)RepositoryFactory.Create(Keywords.DeleteApplicationGroup);
            try
            {
            	//Execute DeleteByApplicationGroupDesc
                repository.DeleteByApplicationGroupDesc(applicationGroupDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Application Group data by application Group Icon
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationGroupIcon(string applicationGroupIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationGroupIcon
			ValidationResult validationResult = this.ValidateApplicationGroupIcon( applicationGroupIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationGroupIcon(applicationGroupIcon);
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
		
		//Validate ApplicationGroupIcon
		protected virtual ValidationResult ValidateApplicationGroupIcon(string applicationGroupIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationGroup'. 
				//The validator factory will create the validator object based on its key.
				IApplicationGroupValidator validator = (IApplicationGroupValidator)ValidatorFactory.Create(Keywords.DeleteApplicationGroup);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupIcon(applicationGroupIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationGroupIcon
		protected virtual OperationResult _DeleteByApplicationGroupIcon(string applicationGroupIcon)
		{
			//Create repository based on its Key name : 'Keywords.DeleteApplicationGroup'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteApplicationGroupRepository repository = (IDeleteApplicationGroupRepository)RepositoryFactory.Create(Keywords.DeleteApplicationGroup);
            try
            {
            	//Execute DeleteByApplicationGroupIcon
                repository.DeleteByApplicationGroupIcon(applicationGroupIcon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }