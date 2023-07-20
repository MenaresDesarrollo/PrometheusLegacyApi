using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class CajaMaestra
{
    public string CajaCajId { get; set; } = null!;

    public float CajMontoPrestamo { get; set; }

    public float CajDeposito { get; set; }

    public string? CajCreador { get; set; }

    public DateTime? CajFechacreacion { get; set; }

    public string? CajModificador { get; set; }

    public DateTime? CajFechamodificacion { get; set; }

    public virtual Caja CajaCaj { get; set; } = null!;
}
