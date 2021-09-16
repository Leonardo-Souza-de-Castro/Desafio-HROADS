using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai_hroads_webApi.Domains;

#nullable disable

namespace senai_hroads_webApi.Contexts
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
        public virtual DbSet<StatusPersonagem> StatusPersonagems { get; set; }
        public virtual DbSet<TipoHabilidade> TipoHabilidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-R3SNJAL\\SQLEXPRESS; initial catalog=SENAI_HROADS_MANHA; user Id=sa; pwd=senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classe__2D2D6FFA849B06AD");

                entity.ToTable("Classe");

                entity.HasIndex(e => e.NomeClasse, "UQ__Classe__69858DF311323473")
                    .IsUnique();

                entity.HasIndex(e => e.DescricaoClasse, "UQ__Classe__A9EBFFD6B00C2596")
                    .IsUnique();

                entity.Property(e => e.IdClasse).HasColumnName("Id_Classe");

                entity.Property(e => e.DescricaoClasse)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Classe");

                entity.Property(e => e.NomeClasse)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Classe");
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__Habilida__DFE6A4CCC40262CE");

                entity.ToTable("Habilidade");

                entity.HasIndex(e => e.DescricaoHabilidade, "UQ__Habilida__1800DF93DD5998ED")
                    .IsUnique();

                entity.HasIndex(e => e.NomeHabilidade, "UQ__Habilida__762CF16574842EF5")
                    .IsUnique();

                entity.Property(e => e.IdHabilidade).HasColumnName("Id_Habilidade");

                entity.Property(e => e.DescricaoHabilidade)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Habilidade");

                entity.Property(e => e.NomeHabilidade)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Habilidade");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK__Habilidad__IdTip__286302EC");
            });

            modelBuilder.Entity<Personagen>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__Personag__4C5EDFB32912EC47");

                entity.HasIndex(e => e.NomePersonagem, "UQ__Personag__CCBF90F4D0887484")
                    .IsUnique();

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("date")
                    .HasColumnName("Data_Atualizacao");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("date")
                    .HasColumnName("Data_Criacao");

                entity.Property(e => e.IdClasse).HasColumnName("Id_Classe");

                entity.Property(e => e.NomePersonagem)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Personagem");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Personagens)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Personage__Id_Cl__33D4B598");
            });

            modelBuilder.Entity<StatusPersonagem>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__Status_P__E39037C68C662D80");

                entity.ToTable("Status_Personagem");

                entity.Property(e => e.IdStatus).HasColumnName("Id_Status");

                entity.Property(e => e.IdHabilidade).HasColumnName("Id_Habilidade");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.StatusPersonagems)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Status_Pe__IdCla__300424B4");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany(p => p.StatusPersonagems)
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__Status_Pe__Id_Ha__2F10007B");
            });

            modelBuilder.Entity<TipoHabilidade>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__Tipo_Hab__9E3A29A5DEB63246");

                entity.ToTable("Tipo_Habilidade");

                entity.Property(e => e.TipoHabilidade1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Habilidade");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
