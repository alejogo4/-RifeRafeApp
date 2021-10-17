using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rife_rafe_backend.Models;

namespace rife_rafe_backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Product> Products { set; get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
