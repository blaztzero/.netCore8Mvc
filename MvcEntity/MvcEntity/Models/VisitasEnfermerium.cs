using System;
using System.Collections.Generic;

namespace MvcEntity.Models;

public partial class VisitasEnfermerium
{
    public decimal IdVisita { get; set; }

    public string? RutPaciente { get; set; }

    public string? NombrePaciente { get; set; }

    public string? DireccionVisita { get; set; }

    public string? Afiliacion { get; set; }

    public string? FonoCliente { get; set; }

    public string? NombreProfesional { get; set; }

    public string? FechaVisita { get; set; }

    public string? Procedimientos { get; set; }

    public string? Medicamentos { get; set; }

    public string? Insumos { get; set; }

    public string? Tratamientos { get; set; }

    public string? Estado { get; set; }
}
