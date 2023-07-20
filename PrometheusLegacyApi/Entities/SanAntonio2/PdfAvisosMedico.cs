using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class PdfAvisosMedico
{
    public string PdfId { get; set; } = null!;

    public string? Detalle { get; set; }

    public byte[]? Base64 { get; set; }
}
