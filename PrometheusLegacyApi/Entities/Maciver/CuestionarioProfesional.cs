using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class CuestionarioProfesional
{
    public string CueProId { get; set; } = null!;

    public string? CueId { get; set; }

    public string? CueProProfesionalId { get; set; }

    public virtual Cuestionario? Cue { get; set; }

    public virtual Profesional? CueProProfesional { get; set; }
}
