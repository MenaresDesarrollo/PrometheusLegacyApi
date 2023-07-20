using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class MontoCaja
{
    public string MontoId { get; set; } = null!;

    public string CajaId { get; set; } = null!;

    public int? Monto { get; set; }

    public string? MontoCreador { get; set; }

    public DateTime? MontoFechacreacion { get; set; }

    public string? MontoModificador { get; set; }

    public DateTime? MontoFechamodificacion { get; set; }

    public virtual Caja Caja { get; set; } = null!;
}
