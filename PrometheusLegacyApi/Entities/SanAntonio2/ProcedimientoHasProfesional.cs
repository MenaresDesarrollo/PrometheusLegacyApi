using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class ProcedimientoHasProfesional
{
    public string ProcedimientoProId { get; set; } = null!;

    public string ProfesionalProId { get; set; } = null!;

    public int? Duracion { get; set; }

    public virtual Procedimiento ProcedimientoPro { get; set; } = null!;

    public virtual Profesional ProfesionalPro { get; set; } = null!;
}
