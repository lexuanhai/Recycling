using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Data.DatabaseEntity;

namespace WEBSITE.Areas.Admin.Models
{
    public class UserModelView
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public bool RememberMe { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public int? TotalPoint { get; set; }

        public List<ProductModelView> Products { get; set; }
    }
}
