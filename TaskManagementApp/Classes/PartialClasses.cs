using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagementApp.Models
{
    [MetadataType(typeof(employee_metadata))]
    public partial class employee {
        public string fullname
        {
            get
            {
                return string.Format("{0} {1} {2}", first_name, middle_name, last_name);
            }
        }
    }

    [MetadataType(typeof(task_metadata))]
    public partial class task {
       
    }
}