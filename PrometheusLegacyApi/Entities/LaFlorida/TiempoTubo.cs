using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class TiempoTubo
{
    public string TieId { get; set; } = null!;

    public string WorklistLaboratorioWllId { get; set; } = null!;

    public int NumeroTubo { get; set; }

    public DateTime? TieInicio { get; set; }

    public DateTime? TieFin { get; set; }

    public sbyte? TieEstado { get; set; }

    public virtual WorklistLaboratorio WorklistLaboratorioWll { get; set; } = null!;
}
