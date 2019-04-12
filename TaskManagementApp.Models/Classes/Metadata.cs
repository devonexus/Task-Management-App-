using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementApp.Models
{
    public class employee_metadata
    {
       
        public int employee_id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is required.")]
        public string first_name { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Middle Name")]
        [Required(ErrorMessage = "{0} is required.")]
        public string middle_name { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} is required.")]
        public string last_name { get; set; }

        [Display(Name = "Age")]    
        [Required(ErrorMessage = "{0} is required.")]
        public int? age { get; set; }

        [Display(Name = "Assigned Person")]
        public string fullname { get; set; }
    }

    public class task_metadata {      
        public int task_id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Task")]
        public string task_name { get; set; }

        [Display(Name = "Assigned Person")]
        public int? task_assignee { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? start_date { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString= "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "{0} is required.")]
        public DateTime? due_date { get; set; }
        public virtual employee employee { get; set; }
    }
}