using System;
using System.Collections.Generic;

namespace MvcEntity.Models;

public partial class BonosFonasa
{
    public decimal IdBonoFonasa { get; set; }

    public string? RutBeneficiario { get; set; }

    public string? NombreBeneficiario { get; set; }

    public string? RutTitular { get; set; }

    public string? NombreTitular { get; set; }

    public string? RutPrestador { get; set; }

    public string? NombrePrestador { get; set; }

    public string? PrestacionMedica { get; set; }

    public string? ValorTotal { get; set; }

    public string? Nivel { get; set; }

    public string? Folio { get; set; }

    public string? FechaHoraIngreso { get; set; }

    public string? PagaVisita { get; set; }
}
