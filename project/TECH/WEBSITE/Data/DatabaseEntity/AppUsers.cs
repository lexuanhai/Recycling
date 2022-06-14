using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WEBSITE.SharedKernel;
using static WEBSITE.General.General;

namespace WEBSITE.Data.DatabaseEntity
{
    //[Table("Staff")]
   public class AppUsers: DomainEntity<int>
    {
        //[Key]
        //public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName ="varchar(12)")]        
        public string Phone { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Address { get; set; }
        public string City { get; set; }  
        public int? TotalPoint { get; set; }
        public string Avartar { get; set; }
        public StaffStatus Status { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string PassWord { get; set; }
        public bool? IsDeleted { get; set; }
   }
}
