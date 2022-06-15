using Microsoft.EntityFrameworkCore;
using System;
using WEBSITE.Data.DatabaseEntity;

namespace WEBSITE.Reponsitory
{
    public interface ITelecomRepository : IRepository<Telecom, int>
    {
       
    }

    public class TelecomRepository : EFRepository<Telecom, int>, ITelecomRepository
    {
        public TelecomRepository(DataBaseEntityContext context) : base(context)
        {
        }
    }
}
