using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class RetiroExamene
{
    public string RetId { get; set; } = null!;

    public string? RetPacRut { get; set; }

    public string? RetPacNombres { get; set; }

    public string? RetPacApePaterno { get; set; }

    public string? RetPacApeMaterno { get; set; }

    public string? RetRut { get; set; }

    public string? RetNombres { get; set; }

    public string? RetApePaterno { get; set; }

    public string? RetApeMaterno { get; set; }

    public DateTime? RetFechaRetiro { get; set; }

    public string RecepcionRecId { get; set; } = null!;

    public virtual Recepcion RecepcionRec { get; set; } = null!;
}
