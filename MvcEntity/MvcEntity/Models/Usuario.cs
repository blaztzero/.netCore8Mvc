using System;
using System.Collections.Generic;

namespace MvcEntity.Models;

public partial class Usuario
{
    public decimal IdUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Clave { get; set; }

    public string? TipoUsuario { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }
}
