using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Etiqueta
{
    public string EtiId { get; set; } = null!;

    public string? EtiCodigo { get; set; }

    public string? EtiDescripcion { get; set; }

    public string? EtiSubDescripcion { get; set; }

    public int? EtiTiempo { get; set; }
}
