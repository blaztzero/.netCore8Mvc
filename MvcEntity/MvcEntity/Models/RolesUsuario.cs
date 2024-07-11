using System;
using System.Collections.Generic;

namespace MvcEntity.Models;

public partial class RolesUsuario
{
    public decimal IdPermiso { get; set; }

    public decimal? IdUsuario { get; set; }

    public string? Seleccionar { get; set; }

    public string? Insertar { get; set; }

    public string? Modificar { get; set; }

    public string? Eliminar { get; set; }
}
