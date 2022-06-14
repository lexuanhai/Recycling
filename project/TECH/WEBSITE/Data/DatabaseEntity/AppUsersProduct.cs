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
    [Table("AppUsersProduct")]
    public class AppUsersProduct : DomainEntity<int>
   {
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int? AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public AppUsers AppUsers { get; set; }

    }
}
