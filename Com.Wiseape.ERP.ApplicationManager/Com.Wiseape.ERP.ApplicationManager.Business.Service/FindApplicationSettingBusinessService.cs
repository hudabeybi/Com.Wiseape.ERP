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
    /// Business Service for ApplicationSetting module.
    /// </summary>
    public class FindApplicationSettingBusinessService : BaseBusinessService<ApplicationSetting>, IFindApplicationSettingBusinessService
    {
        class Keywords
        {
            public static string FindApplicationSetting = "Find.ERP.ApplicationManager.ApplicationSetting";
        }
        
        public FindApplicationSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindApplicationSettingBusinessService()
        {
            this.RepoKey = Keywords.FindApplicationSetting;
        }


        /// <summary>
        /// Finds all  Application Setting data with setting Key containing specified keyword
        /// </summary>
		/// <param name="settingKey"> Setting Key</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySettingKey(string settingKey)
		{
            IFindApplicationSettingRepository repository = (IFindApplicationSettingRepository)RepositoryFactory.Create(Keywords.FindApplicationSetting);
            try
            {
                List<ApplicationSetting> res = repository.FindBySettingKey(settingKey);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySettingValue(string settingValue)
		{
            IFindApplicationSettingRepository repository = (IFindApplicationSettingRepository)RepositoryFactory.Create(Keywords.FindApplicationSetting);
            try
            {
                List<ApplicationSetting> res = repository.FindBySettingValue(settingValue);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Setting data with app Name containing specified keyword
        /// </summary>
		/// <param name="appName"> App Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAppName(string appName)
		{
            IFindApplicationSettingRepository repository = (IFindApplicationSettingRepository)RepositoryFactory.Create(Keywords.FindApplicationSetting);
            try
            {
                List<ApplicationSetting> res = repository.FindByAppName(appName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }