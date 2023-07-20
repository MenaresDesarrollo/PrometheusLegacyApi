using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class Empresa
{
    public string? IdEmpresa { get; set; }

    public string? NomEmpresa { get; set; }

    public string? RutEmpresa { get; set; }

    public int? OrdenEmpresa { get; set; }

    public sbyte? EsEmpresa { get; set; }
}
