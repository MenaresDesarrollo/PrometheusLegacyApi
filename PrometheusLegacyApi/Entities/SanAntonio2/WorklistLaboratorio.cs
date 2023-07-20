using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class WorklistLaboratorio
{
    public string WllId { get; set; } = null!;

    public DateTime? WllIngreso { get; set; }

    public DateTime? WllLlamado { get; set; }

    public DateTime? WllTermino { get; set; }

    public string? WllPaciente { get; set; }

    public sbyte? WllPrioridad { get; set; }

    public sbyte? WllEstado { get; set; }

    public string? WllSucursal { get; set; }

    public int? WllNLaboratorio { get; set; }

    public string? WllSubUnidad { get; set; }

    public virtual ICollection<TiempoTubo> TiempoTubos { get; set; } = new List<TiempoTubo>();
}
