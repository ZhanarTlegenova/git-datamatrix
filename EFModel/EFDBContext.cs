using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModel
{
    class EFDBContext:DbContext
    {
        public EFDBContext(DbContextOptions<EFDBContext> options): base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }

    }
}
