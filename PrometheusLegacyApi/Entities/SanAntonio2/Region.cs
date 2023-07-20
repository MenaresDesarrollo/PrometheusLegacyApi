using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class Region
{
    public string RegId { get; set; } = null!;

    public string? RegDetalle { get; set; }

    public virtual ICollection<Provincium> Provincia { get; set; } = new List<Provincium>();
}
