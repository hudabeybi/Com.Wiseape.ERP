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
    /// Business Service for GlobalApplicationSetting module.
    /// </summary>
    public class FindGlobalApplicationSettingBusinessService : BaseBusinessService<GlobalApplicationSetting>, IFindGlobalApplicationSettingBusinessService
    {
        class Keywords
        {
            public static string FindGlobalApplicationSetting = "Find.ERP.ApplicationManager.GlobalApplicationSetting";
        }
        
        public FindGlobalApplicationSettingBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindGlobalApplicationSettingBusinessService()
        {
            this.RepoKey = Keywords.FindGlobalApplicationSetting;
        }


        /// <summary>
        /// Finds all  Global Application Setting data with setting Name containing specified keyword
        /// </summary>
		/// <param name="settingName"> Setting Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySettingName(string settingName)
		{
            IFindGlobalApplicationSettingRepository repository = (IFindGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.FindGlobalApplicationSetting);
            try
            {
                List<GlobalApplicationSetting> res = repository.FindBySettingName(settingName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Global Application Setting data with setting Value containing specified keyword
        /// </summary>
		/// <param name="settingValue"> Setting Value</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindBySettingValue(string settingValue)
		{
            IFindGlobalApplicationSettingRepository repository = (IFindGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.FindGlobalApplicationSetting);
            try
            {
                List<GlobalApplicationSetting> res = repository.FindBySettingValue(settingValue);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Global Application Setting data with user I D containing specified keyword
        /// </summary>
		/// <param name="userID"> User I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByUserID(string userID)
		{
            IFindGlobalApplicationSettingRepository repository = (IFindGlobalApplicationSettingRepository)RepositoryFactory.Create(Keywords.FindGlobalApplicationSetting);
            try
            {
                List<GlobalApplicationSetting> res = repository.FindByUserID(userID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }