using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssetMgmt.Models
{
    public class AssetEmployeeMap
    {
        [Key] [Column(Order = 0)]
        [Display(Name = "Asset No")]
        [ForeignKey ("Asset")]
        public string AssetNo { get; set; }
        public Asset Asset { get; set; }

        [Key] [Column(Order = 1)]
        [Display(Name = "Employee Id")]
        public string EmployeeId { get; set; }
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Display(Name = "Manager Id")]
        public string ManagerId { get; set; }

        [Display(Name = "Employee Email")]
        public string EmployeeMail { get; set; }
        [Display(Name = "Manager Email")]
        public string ManagerMail { get; set; }

        [Display(Name = "Use Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Usage End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }
    }
}