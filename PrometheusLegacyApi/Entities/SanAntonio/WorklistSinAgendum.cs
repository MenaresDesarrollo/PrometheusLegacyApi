using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class WorklistSinAgendum
{
    public string WllId { get; set; } = null!;

    public DateTime? WllIngreso { get; set; }

    public DateTime? WllLlamado { get; set; }

    public DateTime? WllTermino { get; set; }

    public string? WllPaciente { get; set; }

    public sbyte? WllPrioridad { get; set; }

    public int? WllEstado { get; set; }

    public string? WllSucursal { get; set; }

    public string? WllSubUnidad { get; set; }
}
