using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class OperacionesCaja
{
    public string RegistrosRegId { get; set; } = null!;

    public string OpeAccion { get; set; } = null!;

    public float OpeMonto { get; set; }

    public string? OpeCreador { get; set; }

    public DateTime? OpeFechacreacion { get; set; }

    public sbyte? OpeEstado { get; set; }
}
