using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class ResultadosExamene
{
    public string ResId { get; set; } = null!;

    public string? ResNomExamen { get; set; }

    public string? ResResultado { get; set; }

    public string? ResRecepcionId { get; set; }

    public virtual Recepcion? ResRecepcion { get; set; }
}
