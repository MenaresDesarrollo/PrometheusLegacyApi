using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class Observacione
{
    public string ObsId { get; set; } = null!;

    public string? ObsDetalle { get; set; }

    public string? ObsRecId { get; set; }

    public virtual Recepcion? ObsRec { get; set; }
}
