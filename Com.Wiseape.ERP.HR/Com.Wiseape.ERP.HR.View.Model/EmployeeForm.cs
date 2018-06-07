using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.ERP.Data.Model;

namespace Com.Wiseape.ERP.HR.View.Model
{
    public class EmployeeForm : Employee
    {
        //Properties that extends the data model
        public string FormattedBirthDate
        {
            get
            {
                return this.BirthDate.Value.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }

    }
}