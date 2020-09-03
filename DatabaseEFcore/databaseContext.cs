using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseEFcore
{
    public partial class databaseContext : DbContext
    {
        public databaseContext()
        {
        }

        public databaseContext(DbContextOptions<databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<KnexMigrations> KnexMigrations { get; set; }
        public virtual DbSet<KnexMigrationsLock> KnexMigrationsLock { get; set; }
        public virtual DbSet<Points> Points { get; set; }
        public virtual DbSet<PointsItems> PointsItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("data source=databaseClass/database.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>(entity =>
            {
                entity.ToTable("items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<KnexMigrations>(entity =>
            {
                entity.ToTable("knex_migrations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.MigrationTime)
                    .HasColumnName("migration_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<KnexMigrationsLock>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("knex_migrations_lock");

                entity.Property(e => e.Index)
                    .HasColumnName("index")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsLocked).HasColumnName("is_locked");
            });

            modelBuilder.Entity<Points>(entity =>
            {
                entity.ToTable("points");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("float");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("float");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("uf")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Whatsapp)
                    .IsRequired()
                    .HasColumnName("whatsapp")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<PointsItems>(entity =>
            {
                entity.ToTable("points_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PointsItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.PointsItems)
                    .HasForeignKey(d => d.PointId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
