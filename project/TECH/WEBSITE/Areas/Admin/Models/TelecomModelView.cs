using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITE.Areas.Admin.Models
{
    public class TelecomModelView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
        public string Exchange { get; set; }
        public int? Point { get; set; }
    }
}
