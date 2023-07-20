using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class SubunidadHasTarjeta
{
    public string SubUnidadId { get; set; } = null!;

    public string NTarjeta { get; set; } = null!;

    public int? Estado { get; set; }
}
