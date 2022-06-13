using Microsoft.EntityFrameworkCore;
using System;
using WEBSITE.Data.DatabaseEntity;

namespace WEBSITE.Reponsitory
{
    public interface IAppUserRepository : IRepository<AppUsers, int>
    {
       
    }

    public class AppUserRepository : EFRepository<AppUsers, int>, IAppUserRepository
    {
        public AppUserRepository(DataBaseEntityContext context) : base(context)
        {
        }
    }
}
