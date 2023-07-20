using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class ArancelesImed
{
    public string CodArancelInterface { get; set; } = null!;

    public string FechaCarga { get; set; } = null!;

    public string CodPrestacionPrest { get; set; } = null!;

    public string CodItemPrest { get; set; } = null!;

    public string CodPrestacionCert { get; set; } = null!;

    public string CodItemCert { get; set; } = null!;

    public string CodAdicional { get; set; } = null!;

    public string _5 { get; set; } = null!;

    public string IndPrestPqte { get; set; } = null!;

    public string IndPrestAdicional { get; set; } = null!;

    public string FechaTermino { get; set; } = null!;

    public string IndPrestInsumo { get; set; } = null!;

    public string Vigente { get; set; } = null!;

    public string CodHomologo { get; set; } = null!;

    public string CodHomologoItem { get; set; } = null!;

    public string GlosaPrestacion { get; set; } = null!;
}
