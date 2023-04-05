using Friable_mongo.InfoModels;
using Friable_mongo.Models;
using Microsoft.EntityFrameworkCore;

namespace Friable_mongo.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<CollectionMark> CollectionMarks { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Identification> Identifications { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Mounting> Mountings { get; set; }
        public DbSet<PrimaryPictorial> Pictorials { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<PrimarySupport> Supports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>()
                .HasOne(p => p.Identification)
                .WithOne(c => c.Registration)
                .HasForeignKey<Identification>(b => b.RegistrationID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Registration>()
                .HasOne(p => p.PrimarySupport)
                .WithOne(c => c.Registration)
                .HasForeignKey<PrimarySupport>(b => b.RegistrationID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Registration>()
              .HasOne(p => p.SecondarySupport)
              .WithOne(c => c.Registration)
              .HasForeignKey<SecondarySupport>(b => b.RegistrationID)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Registration>()
             .HasOne(p => p.Storage)
             .WithOne(c => c.Registration)
             .HasForeignKey<Storage>(b => b.RegistrationID)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Registration>()
             .HasOne(p => p.Mounting)
             .WithOne(c => c.Registration)
             .HasForeignKey<Mounting>(b => b.RegistrationID)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PrimarySupport>()
              .HasOne(p => p.Pictorial)
              .WithOne(c => c.Support)
              .HasForeignKey<PrimaryPictorial>(b => b.SupportId)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SecondarySupport>()
              .HasOne(p => p.Pictorial)
              .WithOne(c => c.Support)
              .HasForeignKey<SecondaryPictorial>(b => b.SupportId)
              .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Identification>()
                .HasOne(p => p.Date)
                .WithOne(c => c.Identification)
                .HasForeignKey<Date>(b => b.IdentificationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Identification>()
             .HasOne(p => p.Artist)
             .WithOne(c => c.Identification)
             .HasForeignKey<Artist>(b => b.IdentificationId)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Identification>()
               .HasOne(p => p.Signature)
               .WithOne(c => c.Identification)
               .HasForeignKey<Signature>(b => b.IdentificationId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Identification>()
               .HasMany(p => p.Inscriptions)
               .WithOne(c => c.Identification)
               .HasForeignKey(b => b.IdentificationId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Identification>()
             .HasMany(p => p.CollectionMarks)
             .WithOne(c => c.Identification)
             .HasForeignKey(b => b.IdentificationId)
             .OnDelete(DeleteBehavior.Cascade);

   


        }

    }
}
