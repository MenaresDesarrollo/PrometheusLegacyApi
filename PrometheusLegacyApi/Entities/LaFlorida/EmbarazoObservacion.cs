using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class EmbarazoObservacion
{
    public string EmbId { get; set; } = null!;

    public DateOnly? EmbSemGestacional { get; set; }

    public string? EmbDetalle { get; set; }

    public string? RecId { get; set; }

    public virtual Recepcion? Rec { get; set; }
}
