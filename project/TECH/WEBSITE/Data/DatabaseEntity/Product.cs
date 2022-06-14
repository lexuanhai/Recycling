using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WEBSITE.SharedKernel;

namespace WEBSITE.Data.DatabaseEntity
{
    [Table("Product")]
    public class Product : DomainEntity<int>
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string UrlImage { get; set; }
        public string SubDecription { get; set; }
        [Column(TypeName = "decimal")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal")]
        public decimal? ReducedPrice { get; set; }
        public int? Total { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Point { get; set; }
        public string DateExpired { get; set; }
        public int? PricePercent { get; set; }

    }
}
