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
    /// Business Service for ApplicationItem module.
    /// </summary>
    public class FindApplicationItemBusinessService : BaseBusinessService<ApplicationItem>, IFindApplicationItemBusinessService
    {
        class Keywords
        {
            public static string FindApplicationItem = "Find.ERP.ApplicationManager.ApplicationItem";
        }
        
        public FindApplicationItemBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindApplicationItemBusinessService()
        {
            this.RepoKey = Keywords.FindApplicationItem;
        }


        /// <summary>
        /// Finds all  Application Item data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationName(string applicationName)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationName(applicationName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Title containing specified keyword
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationTitle(string applicationTitle)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationTitle(applicationTitle);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Icon containing specified keyword
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationIcon(string applicationIcon)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationIcon(applicationIcon);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationDesc(string applicationDesc)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationDesc(applicationDesc);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Path containing specified keyword
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationPath(string applicationPath)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationPath(applicationPath);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application File containing specified keyword
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationFile(string applicationFile)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationFile(applicationFile);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Class containing specified keyword
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationClass(string applicationClass)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationClass(applicationClass);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Start Function containing specified keyword
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationStartFunction(string applicationStartFunction)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationStartFunction(applicationStartFunction);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Group Id containing specified keyword
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationGroupId(Int16 applicationGroupId)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationGroupId(applicationGroupId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with application Group Id, is Displayed containing specified keyword
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationGroupIdAndIsDisplayed(Int16 applicationGroupId, Int16 isDisplayed)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByApplicationGroupIdAndIsDisplayed(applicationGroupId, isDisplayed);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Application Item data with is Displayed containing specified keyword
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByIsDisplayed(Int16 isDisplayed)
		{
            IFindApplicationItemRepository repository = (IFindApplicationItemRepository)RepositoryFactory.Create(Keywords.FindApplicationItem);
            try
            {
                List<ApplicationItem> res = repository.FindByIsDisplayed(isDisplayed);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }