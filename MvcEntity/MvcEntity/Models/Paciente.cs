using System;
using System.Collections.Generic;

namespace MvcEntity.Models;

public partial class Paciente
{
    public string Rut { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public decimal? Fono { get; set; }

    public string? Afiliacion { get; set; }
}
