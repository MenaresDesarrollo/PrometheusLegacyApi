using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class RecepcionHasProcedimiento
{
    public string RecepcionRecId { get; set; } = null!;

    public string ProcedimientoProId { get; set; } = null!;

    public DateTime? RecHProHoraFin { get; set; }

    public DateTime? RecHProHoraInicio { get; set; }

    public string? RecMContraste { get; set; }

    public string? SubUnidadSubId { get; set; }

    public int? Eliminado { get; set; }

    public virtual Procedimiento ProcedimientoPro { get; set; } = null!;

    public virtual Recepcion RecepcionRec { get; set; } = null!;
}
