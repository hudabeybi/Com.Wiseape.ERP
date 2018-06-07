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
    /// Repository for UpdateApplicationItem data.
    /// </summary>
    public class UpdateApplicationItemRepository : BaseRepository<ApplicationItem>, IUpdateApplicationItemRepository
    {
        class Keywords
        {
            public static string UpdateApplicationItem = "Update.ERP.ApplicationManager.ApplicationItem";
        }

        /// <summary>
        /// Constructor for ApplicationItemRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateApplicationItemRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateApplicationItemRepository()
        {
            this.DataContextKey = Keywords.UpdateApplicationItem;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Application Item's id Application, application Name by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationName">application Name</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationName(Int16 idApplication, string applicationName)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationName = applicationName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application Title by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationTitle">application Title</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationTitle(Int16 idApplication, string applicationTitle)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationTitle = applicationTitle;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application Icon by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationIcon">application Icon</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationIcon(Int16 idApplication, string applicationIcon)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationIcon = applicationIcon;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application Desc by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationDesc">application Desc</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationDesc(Int16 idApplication, string applicationDesc)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationDesc = applicationDesc;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application Path by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationPath">application Path</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationPath(Int16 idApplication, string applicationPath)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationPath = applicationPath;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application File by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationFile">application File</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationFile(Int16 idApplication, string applicationFile)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationFile = applicationFile;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application Class by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationClass">application Class</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationClass(Int16 idApplication, string applicationClass)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationClass = applicationClass;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application Start Function by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationStartFunction">application Start Function</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationStartFunction(Int16 idApplication, string applicationStartFunction)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationStartFunction = applicationStartFunction;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------

        /// <summary>
        /// Updates  Application Item's id Application, application Group Id by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationGroupId(Int16 idApplication, Int16 applicationGroupId)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationGroupId = applicationGroupId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, application Group Id, is Displayed by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="applicationGroupId">application Group Id</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateApplicationGroupIdAndIsDisplayed(Int16 idApplication, Int16 applicationGroupId, Int16 isDisplayed)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationGroupId = applicationGroupId;
     			o.IsDisplayed = isDisplayed;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Application Item's id Application, is Displayed by idApplication
        /// </summary>
		/// <param name="idApplication">id Application</param>
		/// <param name="isDisplayed">is Displayed</param>
		/// <returns>List of  Application Item</returns>
        public void UpdateIsDisplayed(Int16 idApplication, Int16 isDisplayed)
        {
            ERPDataContext dataContext = (ERPDataContext)this.DataContext;
            var list = from o in dataContext.ApplicationItems
                       where
                       		o.IdApplication == idApplication
                       	select o;
           	list.ToList().ForEach(o => {
      			o.IsDisplayed = isDisplayed;
	
            });
            dataContext.SaveChanges();
        }


    }
}
