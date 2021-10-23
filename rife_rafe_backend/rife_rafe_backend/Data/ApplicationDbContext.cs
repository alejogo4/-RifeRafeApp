using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rife_rafe_backend.Data.Entities;


namespace rife_rafe_backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<OfferAuction> OfferAuction { get; set; }
        public DbSet<OfferRaffle> OfferRaffle { get; set; }
        public DbSet<Applicants> Applicants { get; set; }
        public DbSet<ApplicantAuction> ApplicantAuction { get; set; }
        public DbSet<ApplicantRiffle> ApplicantRiffle { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<ProductPhoto> ProductPhoto { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }
    }
}
