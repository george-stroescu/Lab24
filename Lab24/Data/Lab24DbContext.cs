using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab24.Models;

namespace Lab24.Data
{
    public class Lab24DbContext : DbContext
    {
        public Lab24DbContext (DbContextOptions<Lab24DbContext> options)
            : base(options)
        {
        }

        public DbSet<Lab24.Models.ContactListEntry> ContactListEntry { get; set; }
    }
}
