using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public class EFDBContext: DbContext
    {
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
