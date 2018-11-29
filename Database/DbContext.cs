using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Database
{
    public class AbcContext:IdentityDbContext
    {
        public AbcContext():base ("ABCcnn")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<TbCategories> TbCat { get; set; }
        public DbSet<TbNews> TbNews { get; set; }
    }
}
