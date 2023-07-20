using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class CampoPago
{
    public string CamId { get; set; } = null!;

    public string? CamDetalle { get; set; }

    public string? CamInput { get; set; }

    public virtual ICollection<FormaPagoHasCampoPago> FormaPagoHasCampoPagos { get; set; } = new List<FormaPagoHasCampoPago>();
}
