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

namespace Com.Wiseape.ERP.ApplicationManager.Business.Service
{
    /// <summary>
    /// Business Service for GlobalApplicationSettingTemplate module.
    /// </summary>
    public class FindGlobalApplicationSettingTemplateBusinessService : BaseBusinessService<GlobalApplicationSettingTemplate>, IFindGlobalApplicationSettingTemplateBusinessService
    {
        class Keywords
        {
            public static string FindGlobalApplicationSettingTemplate = "Find.ERP.ApplicationManager.GlobalApplicationSettingTemplate";
        }
        
        public FindGlobalApplicationSettingTemplateBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindGlobalApplicationSettingTemplateBusinessService()
        {
            this.RepoKey = Keywords.FindGlobalApplicationSettingTemplate;
        }


        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Name containing specified keyword
        /// </summary>
		/// <param name="applicationSettingName"> Application Setting Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationSettingName(string applicationSettingName)
		{
            IFindGlobalApplicationSettingTemplateRepository repository = (IFindGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);
            try
            {
                List<GlobalApplicationSettingTemplate> res = repository.FindByApplicationSettingName(applicationSettingName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Global Application Setting Template data with application Setting Value containing specified keyword
        /// </summary>
		/// <param name="applicationSettingValue"> Application Setting Value</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationSettingValue(string applicationSettingValue)
		{
            IFindGlobalApplicationSettingTemplateRepository repository = (IFindGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);
            try
            {
                List<GlobalApplicationSettingTemplate> res = repository.FindByApplicationSettingValue(applicationSettingValue);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Global Application Setting Template data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByIsActive(Int16 isActive)
		{
            IFindGlobalApplicationSettingTemplateRepository repository = (IFindGlobalApplicationSettingTemplateRepository)RepositoryFactory.Create(Keywords.FindGlobalApplicationSettingTemplate);
            try
            {
                List<GlobalApplicationSettingTemplate> res = repository.FindByIsActive(isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }