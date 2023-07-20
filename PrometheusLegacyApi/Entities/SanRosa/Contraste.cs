using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class Contraste
{
    public string ConId { get; set; } = null!;

    public sbyte? ConEstado { get; set; }
}
