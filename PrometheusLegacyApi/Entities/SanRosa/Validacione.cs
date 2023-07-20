using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class Validacione
{
    public string? ProModalidadId { get; set; }

    public string? PcId { get; set; }

    public string? PvId { get; set; }

    public virtual PartesCuerpo? Pc { get; set; }

    public virtual ProcedimientoModalidad? ProModalidad { get; set; }

    public virtual ProcedimientoValidacion? Pv { get; set; }
}
