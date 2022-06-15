using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITE.Areas.Admin.Models
{
    public class CartModelView
    {
       public List<ProductModelView> Products { get; set; }
        public List<TelecomModelView> Telecoms { get; set; }
    }
}
