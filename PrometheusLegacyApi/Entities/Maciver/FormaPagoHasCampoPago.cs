using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class FormaPagoHasCampoPago
{
    public string FormaPagoForId { get; set; } = null!;

    public string CampoPagosCamId { get; set; } = null!;

    public bool? ForCamObligatorio { get; set; }

    public sbyte? ForCamEstado { get; set; }

    public virtual CampoPago CampoPagosCam { get; set; } = null!;

    public virtual FormaPago FormaPagoFor { get; set; } = null!;
}
