using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.hroads.webApi.Domains;

#nullable disable

namespace senai.hroads.webApi.Contexts
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Personagen> Personagens { get; set; }
        public virtual DbSet<StatusPersonagen> StatusPersonagens { get; set; }
        public virtual DbSet<TiposHabilidade> TiposHabilidades { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-R3SNJAL\\SQLEXPRESS; initial catalog=SENAI_HROADS_MANHA; user Id=sa; pwd=senai@132;");
                //Pc da Livia: optionsBuilder.UseSqlServer("Data Source=DESKTOP-9F56DG6\SQLEXPRESS; initial catalog=SENAI_HROADS_MANHA;  integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classes__0652AF798A42EB4C");

                entity.HasIndex(e => e.NomeClasse, "UQ__Classes__36F040DB5FB23F54")
                    .IsUnique();

                entity.HasIndex(e => e.DescricaoClasse, "UQ__Classes__7C62A17384AAFF07")
                    .IsUnique();

                entity.Property(e => e.DescricaoClasse)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeClasse)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__Habilida__0DD4B30D865BEF24");

                entity.HasIndex(e => e.NomeHabilidade, "UQ__Habilida__206452FF95A0185D")
                    .IsUnique();

                entity.HasIndex(e => e.DescricaoHabilidade, "UQ__Habilida__223AC33AAD952E6C")
                    .IsUnique();

                entity.Property(e => e.DescricaoHabilidade)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NomeHabilidade)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK__Habilidad__IdTip__286302EC");
            });

            modelBuilder.Entity<Personagen>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__Personag__4C5EDFB3C1F9646F");

                entity.HasIndex(e => e.NomePersonagem, "UQ__Personag__84C7E40C96C169FB")
                    .IsUnique();

                entity.Property(e => e.DataAtualizacao).HasColumnType("date");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.NomePersonagem)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Personagens)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Personage__IdCla__33D4B598");
            });

            modelBuilder.Entity<StatusPersonagen>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__StatusPe__B450643AA68BCBEB");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.StatusPersonagens)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__StatusPer__IdCla__300424B4");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany(p => p.StatusPersonagens)
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__StatusPer__IdHab__2F10007B");
            });

            modelBuilder.Entity<TiposHabilidade>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__TiposHab__9E3A29A5FE3D4817");

                entity.Property(e => e.TipoHabilidade)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TiposUsu__CA04062BDFB1FA20");

                entity.HasIndex(e => e.Titulo, "UQ__TiposUsu__7B406B56BF9A8A9F")
                    .IsUnique();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF97CE9F687F");

                entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D1053464193347")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuarios__IdTipo__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
