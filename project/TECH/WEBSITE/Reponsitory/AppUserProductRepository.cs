using Microsoft.EntityFrameworkCore;
using System;
using WEBSITE.Data.DatabaseEntity;

namespace WEBSITE.Reponsitory
{
    public interface IAppUserProductRepository : IRepository<AppUsersProduct, int>
    {
       
    }

    public class AppUserProductRepository : EFRepository<AppUsersProduct, int>, IAppUserProductRepository
    {
        public AppUserProductRepository(DataBaseEntityContext context) : base(context)
        {
        }
    }
}
