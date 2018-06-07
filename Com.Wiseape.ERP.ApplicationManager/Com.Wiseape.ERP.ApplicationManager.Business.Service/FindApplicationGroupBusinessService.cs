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
    /// Business Service for ApplicationGroup module.
    /// </summary>
    public class FindApplicationGroupBusinessService : BaseBusinessService<ApplicationGroup>, IFindApplicationGroupBusinessService
    {
        class Keywords
        {
            public static string FindApplicationGroup = "Find.ERP.ApplicationManager.ApplicationGroup";
        }
        
        public FindApplicationGroupBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindApplicationGroupBusinessService()
        {
            this.RepoKey = Keywords.FindApplicationGroup;
        }


        /// <summary>
        /// Finds all  Application Group data with application Group Name containing specified keyword
        /// </summary>
		/// <param name="applicationGroupName"> Application Group Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationGroupName(string applicationGroupName)
		{
            IFindApplicationGroupRepository repository = (IFindApplicationGroupRepository)RepositoryFactory.Create(Keywords.FindApplicationGroup);
            try
            {
                List<ApplicationGroup> res = repository.FindByApplicationGroupName(applicationGroupName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Group data with application Group Desc containing specified keyword
        /// </summary>
		/// <param name="applicationGroupDesc"> Application Group Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationGroupDesc(string applicationGroupDesc)
		{
            IFindApplicationGroupRepository repository = (IFindApplicationGroupRepository)RepositoryFactory.Create(Keywords.FindApplicationGroup);
            try
            {
                List<ApplicationGroup> res = repository.FindByApplicationGroupDesc(applicationGroupDesc);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Group data with application Group Icon containing specified keyword
        /// </summary>
		/// <param name="applicationGroupIcon"> Application Group Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationGroupIcon(string applicationGroupIcon)
		{
            IFindApplicationGroupRepository repository = (IFindApplicationGroupRepository)RepositoryFactory.Create(Keywords.FindApplicationGroup);
            try
            {
                List<ApplicationGroup> res = repository.FindByApplicationGroupIcon(applicationGroupIcon);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }