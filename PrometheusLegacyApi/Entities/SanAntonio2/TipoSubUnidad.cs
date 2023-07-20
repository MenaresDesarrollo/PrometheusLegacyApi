﻿using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class TipoSubUnidad
{
    public string TipSubId { get; set; } = null!;

    public string? TipSubDescripcion { get; set; }

    public virtual ICollection<SubUnidad> SubUnidads { get; set; } = new List<SubUnidad>();
}
