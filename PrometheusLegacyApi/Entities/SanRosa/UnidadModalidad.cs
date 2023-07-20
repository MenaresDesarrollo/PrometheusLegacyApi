using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class UnidadModalidad
{
    public string Id { get; set; } = null!;

    public string? IdUnidad { get; set; }

    public string? IdModalidad { get; set; }

    public virtual ProcedimientoModalidad? IdModalidadNavigation { get; set; }

    public virtual Unidad? IdUnidadNavigation { get; set; }
}
