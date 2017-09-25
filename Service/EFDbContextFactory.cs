using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EFDbContextFactory
    {
        public IDbContext db { get; private set; }
        public EFDbContextFactory()
        {
            db = new PersonalBlogDbContext();
        }
    }
}
