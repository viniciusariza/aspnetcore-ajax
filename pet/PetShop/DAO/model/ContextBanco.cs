using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class ContextBanco : DbContext
    {
        public ContextBanco()
        {
        }

        public ContextBanco(DbContextOptions<ContextBanco> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAnimal> TbAnimal { get; set; }
        public virtual DbSet<TbAtendimento> TbAtendimento { get; set; }
        public virtual DbSet<TbCidade> TbCidade { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbEndereco> TbEndereco { get; set; }
        public virtual DbSet<TbEstado> TbEstado { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionario { get; set; }
        public virtual DbSet<TbPetshop> TbPetshop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=bd_petshop;uid=root", x => x.ServerVersion("10.1.37-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAnimal>(entity =>
            {
                entity.ToTable("tb_animal");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("fk_tb_animal_tb_cliente1_idx");

                entity.HasIndex(e => e.IdPetshop)
                    .HasName("fk_tb_animal_tb_petshop1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPetshop)
                    .HasColumnName("id_petshop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("smallint(1)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAnimal)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_animal_tb_cliente1");

                entity.HasOne(d => d.IdPetshopNavigation)
                    .WithMany(p => p.TbAnimal)
                    .HasForeignKey(d => d.IdPetshop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_animal_tb_petshop1");
            });

            modelBuilder.Entity<TbAtendimento>(entity =>
            {
                entity.HasKey(e => e.IdAtendimento)
                    .HasName("PRIMARY");

                entity.ToTable("tb_atendimento");

                entity.HasIndex(e => e.AnimalId)
                    .HasName("fk_tb_atendimento_tb_animal1_idx");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("fk_tb_atendimento_tb_cliente1_idx");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("fk_tb_atendimento_tb_funcionario1_idx");

                entity.HasIndex(e => e.IdPetshop)
                    .HasName("fk_tb_atendimento_tb_petshop1_idx");

                entity.Property(e => e.IdAtendimento)
                    .HasColumnName("id_atendimento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataAtendimento)
                    .HasColumnName("data_atendimento")
                    .HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPetshop)
                    .HasColumnName("id_petshop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.TbAtendimento)
                    .HasForeignKey(d => d.AnimalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_atendimento_tb_animal1");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbAtendimento)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_atendimento_tb_cliente1");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbAtendimento)
                    .HasForeignKey(d => d.IdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_atendimento_tb_funcionario1");

                entity.HasOne(d => d.IdPetshopNavigation)
                    .WithMany(p => p.TbAtendimento)
                    .HasForeignKey(d => d.IdPetshop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_atendimento_tb_petshop1");
            });

            modelBuilder.Entity<TbCidade>(entity =>
            {
                entity.HasKey(e => e.IdCidade)
                    .HasName("PRIMARY");

                entity.ToTable("tb_cidade");

                entity.HasIndex(e => e.EstadoId)
                    .HasName("fk_tb_cidade_tb_estado1_idx");

                entity.Property(e => e.IdCidade)
                    .HasColumnName("id_cidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EstadoId)
                    .HasColumnName("estado_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeCidade)
                    .IsRequired()
                    .HasColumnName("nome_cidade")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.TbCidade)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_cidade_tb_estado1");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("tb_cliente");

                entity.HasIndex(e => e.IdPetshop)
                    .HasName("fk_tb_cliente_tb_petshop1_idx");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPetshop)
                    .HasColumnName("id_petshop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPetshopNavigation)
                    .WithMany(p => p.TbCliente)
                    .HasForeignKey(d => d.IdPetshop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_cliente_tb_petshop1");
            });

            modelBuilder.Entity<TbEndereco>(entity =>
            {
                entity.ToTable("tb_endereco");

                entity.HasIndex(e => e.CidadeId)
                    .HasName("fk_tb_endereco_tb_cidade1_idx");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("fk_tb_endereco_tb_cliente1_idx");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("fk_tb_endereco_tb_funcionario1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasColumnName("bairro")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CidadeId)
                    .HasColumnName("cidade_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasColumnName("rua")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Cidade)
                    .WithMany(p => p.TbEndereco)
                    .HasForeignKey(d => d.CidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_endereco_tb_cidade1");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbEndereco)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("fk_tb_endereco_tb_cliente1");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbEndereco)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("fk_tb_endereco_tb_funcionario1");
            });

            modelBuilder.Entity<TbEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PRIMARY");

                entity.ToTable("tb_estado");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("id_estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeEstado)
                    .IsRequired()
                    .HasColumnName("nome_estado")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SiglaEstado)
                    .IsRequired()
                    .HasColumnName("sigla_estado")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.ToTable("tb_funcionario");

                entity.HasIndex(e => e.IdPetshop)
                    .HasName("fk_tb_funcionario_tb_petshop_idx");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdPetshop)
                    .HasColumnName("id_petshop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPetshopNavigation)
                    .WithMany(p => p.TbFuncionario)
                    .HasForeignKey(d => d.IdPetshop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_funcionario_tb_petshop");
            });

            modelBuilder.Entity<TbPetshop>(entity =>
            {
                entity.HasKey(e => e.IdPetshop)
                    .HasName("PRIMARY");

                entity.ToTable("tb_petshop");

                entity.Property(e => e.IdPetshop)
                    .HasColumnName("id_petshop")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
