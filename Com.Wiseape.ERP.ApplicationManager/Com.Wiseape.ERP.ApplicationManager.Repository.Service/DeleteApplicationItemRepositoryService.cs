using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.ERP.Data.Model;
using Com.Wiseape.ERP.Data.Context;
using Com.Wiseape.ERP.ApplicationManager.Repository.Contract;

namespace Com.Wiseape.ERP.ApplicationManager.Repository.Service
{
    /// <summary>
    /// Repository for ApplicationItem data.
    /// </summary>
    public class DeleteApplicationItemRepository : BaseRepository<ApplicationItem>, IDeleteApplicationItemRepository
    {
        class Keywords
        {
            public static string DeleteApplicationItem = "Delete.ERP.ApplicationManager.ApplicationItem";
        }

        /// <summary>
        /// Constructor for DeleteApplicationItemRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteApplicationItemRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteApplicationItemRepository()
        {
            this.DataContextKey = Keywords.DeleteApplicationItem;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Application Item data with application Name containing specified keyword
        /// </summary>
		/// <param name="applicationName"> Application Name</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationName(string applicationName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationName.Contains(applicationName) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with application Title containing specified keyword
        /// </summary>
		/// <param name="applicationTitle"> Application Title</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationTitle(string applicationTitle)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationTitle.Contains(applicationTitle) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with application Icon containing specified keyword
        /// </summary>
		/// <param name="applicationIcon"> Application Icon</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationIcon(string applicationIcon)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationIcon.Contains(applicationIcon) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with application Desc containing specified keyword
        /// </summary>
		/// <param name="applicationDesc"> Application Desc</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationDesc(string applicationDesc)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationDesc.Contains(applicationDesc) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with application Path containing specified keyword
        /// </summary>
		/// <param name="applicationPath"> Application Path</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationPath(string applicationPath)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationPath.Contains(applicationPath) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with application File containing specified keyword
        /// </summary>
		/// <param name="applicationFile"> Application File</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationFile(string applicationFile)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationFile.Contains(applicationFile) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with application Class containing specified keyword
        /// </summary>
		/// <param name="applicationClass"> Application Class</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationClass(string applicationClass)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationClass.Contains(applicationClass) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with application Start Function containing specified keyword
        /// </summary>
		/// <param name="applicationStartFunction"> Application Start Function</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationStartFunction(string applicationStartFunction)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationStartFunction.Contains(applicationStartFunction) 						
						select o;
			dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------

        /// <summary>
        /// Delete all  Application Item data with specified application Group Id 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationGroupId(Int16 applicationGroupId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationGroupId == applicationGroupId  						
						select o;
            dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with specified application Group Id, is Displayed 
        /// </summary>
		/// <param name="applicationGroupId"> Application Group Id</param>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByApplicationGroupIdAndIsDisplayed(Int16 applicationGroupId, Int16 isDisplayed)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.ApplicationGroupId == applicationGroupId && 
							o.IsDisplayed == isDisplayed  						
						select o;
            dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Application Item data with specified is Displayed 
        /// </summary>
		/// <param name="isDisplayed"> Is Displayed</param>
		/// <returns>List of  Application Item</returns>
        public void DeleteByIsDisplayed(Int16 isDisplayed)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
							o.IsDisplayed == isDisplayed  						
						select o;
            dataContext.ApplicationItems.RemoveRange(list);
            dataContext.SaveChanges();
        }


    }
}
