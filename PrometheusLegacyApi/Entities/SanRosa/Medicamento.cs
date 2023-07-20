using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class Medicamento
{
    public string RemId { get; set; } = null!;

    public string? RemNombre { get; set; }

    public string? RemProveedor { get; set; }

    public string? RemCondicion { get; set; }
}
