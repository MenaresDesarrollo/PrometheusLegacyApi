using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class FormaPago
{
    public string ForId { get; set; } = null!;

    public string? ForDetalle { get; set; }

    public bool? ForEstado { get; set; }

    public string? ForCreador { get; set; }

    public DateTime? ForFechaCreacion { get; set; }

    public string? ForModificador { get; set; }

    public DateTime? ForFechaModificacion { get; set; }

    public int? ForTipo { get; set; }

    public int? ForCodforpag { get; set; }

    public sbyte? ForVuelto { get; set; }

    public virtual ICollection<FormaPagoHasCampoPago> FormaPagoHasCampoPagos { get; set; } = new List<FormaPagoHasCampoPago>();

    public virtual ICollection<HistoricoPago> HistoricoPagos { get; set; } = new List<HistoricoPago>();
}
