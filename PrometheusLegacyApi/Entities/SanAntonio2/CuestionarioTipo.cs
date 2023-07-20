using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class CuestionarioTipo
{
    public string TipoId { get; set; } = null!;

    public string? TipoDetalle { get; set; }

    public string? TipoColor { get; set; }

    public virtual ICollection<Cuestionario> Cuestionarios { get; set; } = new List<Cuestionario>();
}
