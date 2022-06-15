using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WEBSITE.SharedKernel;

namespace WEBSITE.Data.DatabaseEntity
{
    [Table("Telecom")]
    public class Telecom : DomainEntity<int>
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
        public string Exchange { get; set; }
        public int? Point { get; set; }

    }
}
