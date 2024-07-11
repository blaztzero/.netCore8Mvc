using System;
using System.Collections.Generic;

namespace MvcEntity.Models;

public partial class ArriendoVehiculo
{
    public string RutCliente { get; set; } = null!;

    public string? NombreCliente { get; set; }

    public string? TipoVehiculo { get; set; }

    public string? DiasArriendo { get; set; }

    public string? TotalNominal { get; set; }

    public string? Descuentos { get; set; }

    public string? Interes { get; set; }

    public string? MetodoDePago { get; set; }
}
