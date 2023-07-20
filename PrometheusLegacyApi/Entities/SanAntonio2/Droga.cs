using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class Droga
{
    public string DroId { get; set; } = null!;

    public string? DroDetalle { get; set; }

    public sbyte? DroEstado { get; set; }
}
