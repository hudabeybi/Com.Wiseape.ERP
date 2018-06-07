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
    public class UpdateApplicationGroupBusinessService : BaseBusinessService<ApplicationGroup>, IUpdateApplicationGroupBusinessService
    {
        class Keywords
        {
            public static string UpdateApplicationGroup = "Update.ERP.ApplicationManager.ApplicationGroup";
        }
        
        public UpdateApplicationGroupBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateApplicationGroupBusinessService()
        {
            this.RepoKey = Keywords.UpdateApplicationGroup;
        }


        /// <summary>
        /// Update  Application Group data with id Application Group, application Group Name
        /// </summary>
		/// <param name="idApplicationGroup"> Id Application Group</param>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationGroupName(Int16 idApplicationGroup, string applicationGroupName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationGroupName
			ValidationResult validationResult = this.ValidateApplicationGroupName( idApplicationGroup, applicationGroupName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationGroupName(idApplicationGroup, applicationGroupName);
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
		protected virtual ValidationResult ValidateApplicationGroupName(Int16 idApplicationGroup, string applicationGroupName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationGroup'. 
				//The validator factory will create the validator object based on its key.
				IApplicationGroupValidator validator = (IApplicationGroupValidator)ValidatorFactory.Create(Keywords.UpdateApplicationGroup);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupName(idApplicationGroup, applicationGroupName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationGroupName
		protected virtual OperationResult _UpdateApplicationGroupName(Int16 idApplicationGroup, string applicationGroupName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationGroup'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationGroupRepository repository = (IUpdateApplicationGroupRepository)RepositoryFactory.Create(Keywords.UpdateApplicationGroup);
            try
            {
            	//Execute UpdateApplicationGroupName
                repository.UpdateApplicationGroupName(idApplicationGroup, applicationGroupName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Group data with id Application Group, application Group Desc
        /// </summary>
		/// <param name="idApplicationGroup"> Id Application Group</param>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationGroupDesc(Int16 idApplicationGroup, string applicationGroupDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationGroupDesc
			ValidationResult validationResult = this.ValidateApplicationGroupDesc( idApplicationGroup, applicationGroupDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationGroupDesc(idApplicationGroup, applicationGroupDesc);
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
		protected virtual ValidationResult ValidateApplicationGroupDesc(Int16 idApplicationGroup, string applicationGroupDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationGroup'. 
				//The validator factory will create the validator object based on its key.
				IApplicationGroupValidator validator = (IApplicationGroupValidator)ValidatorFactory.Create(Keywords.UpdateApplicationGroup);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupDesc(idApplicationGroup, applicationGroupDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationGroupDesc
		protected virtual OperationResult _UpdateApplicationGroupDesc(Int16 idApplicationGroup, string applicationGroupDesc)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationGroup'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationGroupRepository repository = (IUpdateApplicationGroupRepository)RepositoryFactory.Create(Keywords.UpdateApplicationGroup);
            try
            {
            	//Execute UpdateApplicationGroupDesc
                repository.UpdateApplicationGroupDesc(idApplicationGroup, applicationGroupDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Application Group data with id Application Group, application Group Icon
        /// </summary>
		/// <param name="idApplicationGroup"> Id Application Group</param>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationGroupIcon(Int16 idApplicationGroup, string applicationGroupIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationGroupIcon
			ValidationResult validationResult = this.ValidateApplicationGroupIcon( idApplicationGroup, applicationGroupIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationGroupIcon(idApplicationGroup, applicationGroupIcon);
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
		protected virtual ValidationResult ValidateApplicationGroupIcon(Int16 idApplicationGroup, string applicationGroupIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateApplicationGroup'. 
				//The validator factory will create the validator object based on its key.
				IApplicationGroupValidator validator = (IApplicationGroupValidator)ValidatorFactory.Create(Keywords.UpdateApplicationGroup);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationGroupIcon(idApplicationGroup, applicationGroupIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationGroupIcon
		protected virtual OperationResult _UpdateApplicationGroupIcon(Int16 idApplicationGroup, string applicationGroupIcon)
		{
			//Create repository based on its Key name : 'Keywords.UpdateApplicationGroup'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateApplicationGroupRepository repository = (IUpdateApplicationGroupRepository)RepositoryFactory.Create(Keywords.UpdateApplicationGroup);
            try
            {
            	//Execute UpdateApplicationGroupIcon
                repository.UpdateApplicationGroupIcon(idApplicationGroup, applicationGroupIcon);
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