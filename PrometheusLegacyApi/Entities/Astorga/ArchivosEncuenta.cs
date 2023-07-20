using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class ArchivosEncuenta
{
    public string ArcId { get; set; } = null!;

    public byte[] ArcBase64 { get; set; } = null!;

    public string? ArcCreador { get; set; }

    public DateTime? ArcFechaCreador { get; set; }

    public string? ArcDetalle { get; set; }
}
