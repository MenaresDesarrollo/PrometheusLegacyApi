using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class PreguntasCuestionario
{
    public string PreId { get; set; } = null!;

    public string? PreDetalle { get; set; }

    public string? PreCuestionarioId { get; set; }

    public int? PreIndice { get; set; }

    public int? PreIndiceSec { get; set; }

    public virtual Cuestionario? PreCuestionario { get; set; }
}
