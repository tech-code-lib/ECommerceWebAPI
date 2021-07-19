using ECommerce.DAL.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Contexts
{
    public class ECommDBContext: DbContext
    {
        public ECommDBContext()
        {

        }

        public ECommDBContext(DbContextOptions<ECommDBContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.LogTo(sql => Debug.Write(sql));

        public virtual DbSet<Product> Products { get; set; }

        
    }
}
