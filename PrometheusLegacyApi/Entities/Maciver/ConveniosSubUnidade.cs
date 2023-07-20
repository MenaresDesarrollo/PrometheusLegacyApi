using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class ConveniosSubUnidade
{
    public string? ConvenioId { get; set; }

    public string? SubUnidadId { get; set; }

    public int? Descuento { get; set; }

    public virtual Convenio? Convenio { get; set; }

    public virtual SubUnidad? SubUnidad { get; set; }
}
