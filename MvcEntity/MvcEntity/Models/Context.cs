using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MvcEntity.Models;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ArriendoVehiculo> ArriendoVehiculos { get; set; }

    public virtual DbSet<BonosFonasa> BonosFonasas { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<RolesUsuario> RolesUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VisitasEnfermerium> VisitasEnfermeria { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-0PI3SH3\\SQLEXPRESS;Database=GestionEnfermeria;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArriendoVehiculo>(entity =>
        {
            entity.HasKey(e => e.RutCliente);

            entity.Property(e => e.RutCliente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descuentos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiasArriendo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Interes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MetodoDePago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoVehiculo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TotalNominal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BonosFonasa>(entity =>
        {
            entity.HasKey(e => e.IdBonoFonasa);

            entity.ToTable("BonosFonasa");

            entity.Property(e => e.IdBonoFonasa)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idBonoFonasa");
            entity.Property(e => e.FechaHoraIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechaHoraIngreso");
            entity.Property(e => e.Folio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.Nivel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nivel");
            entity.Property(e => e.NombreBeneficiario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreBeneficiario");
            entity.Property(e => e.NombrePrestador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombrePrestador");
            entity.Property(e => e.NombreTitular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreTitular");
            entity.Property(e => e.PagaVisita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrestacionMedica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prestacionMedica");
            entity.Property(e => e.RutBeneficiario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rutBeneficiario");
            entity.Property(e => e.RutPrestador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rutPrestador");
            entity.Property(e => e.RutTitular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rutTitular");
            entity.Property(e => e.ValorTotal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("valorTotal");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Rut);

            entity.ToTable("pacientes");

            entity.Property(e => e.Rut)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Afiliacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fono).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RolesUsuario>(entity =>
        {
            entity.HasKey(e => e.IdPermiso);

            entity.ToTable("RolesUsuario");

            entity.Property(e => e.IdPermiso)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idPermiso");
            entity.Property(e => e.Eliminar)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IdUsuario)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idUsuario");
            entity.Property(e => e.Insertar)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Modificar)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Seleccionar)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Apellidos).HasMaxLength(50);
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);
            entity.Property(e => e.Nombres).HasMaxLength(50);
            entity.Property(e => e.TipoUsuario).HasMaxLength(50);
        });

        modelBuilder.Entity<VisitasEnfermerium>(entity =>
        {
            entity.HasKey(e => e.IdVisita);

            entity.Property(e => e.IdVisita)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Afiliacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DireccionVisita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaVisita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FonoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Insumos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Medicamentos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NombrePaciente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreProfesional)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Procedimientos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RutPaciente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tratamientos)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
