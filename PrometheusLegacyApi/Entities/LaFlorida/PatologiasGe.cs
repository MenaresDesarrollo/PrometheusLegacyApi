﻿using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class PatologiasGe
{
    public string PatGesId { get; set; } = null!;

    public string? DescripcionGes { get; set; }

    public string? CodigoGes { get; set; }
}
