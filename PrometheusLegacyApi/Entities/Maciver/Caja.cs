using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class Caja
{
    public string CajId { get; set; } = null!;

    public string CajDetalle { get; set; } = null!;

    public string? CajCreador { get; set; }

    public DateTime? CajFechacreacion { get; set; }

    public string? CajModificador { get; set; }

    public DateTime? CajFechamodificacion { get; set; }

    public sbyte? CajTipo { get; set; }

    public sbyte? CajEstado { get; set; }

    public string? CajIpPredeterminada { get; set; }

    public virtual CajaMaestra? CajaMaestra { get; set; }

    public virtual ICollection<MontoCaja> MontoCajas { get; set; } = new List<MontoCaja>();
}
