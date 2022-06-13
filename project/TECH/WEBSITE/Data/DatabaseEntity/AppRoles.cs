using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.SharedKernel;

namespace WEBSITE.Data.DatabaseEntity
{
    public class AppRoles: DomainEntity<int>
    {
        public string RoleName { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }
    }
}
