using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class Provincium
{
    public string ProId { get; set; } = null!;

    public string? ProDetalle { get; set; }

    public string RegionRegId { get; set; } = null!;

    public virtual ICollection<Comuna> Comunas { get; set; } = new List<Comuna>();

    public virtual Region RegionReg { get; set; } = null!;
}
