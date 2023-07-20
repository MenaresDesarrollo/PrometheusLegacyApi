using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class AgendaReemplazo
{
    public string AgeRemId { get; set; } = null!;

    public string ProfesionalProId { get; set; } = null!;

    public string AgendaFeriadoAgeFerId { get; set; } = null!;

    public string? AgeRemCreador { get; set; }

    public DateTime? AgeRemCreacion { get; set; }

    public string? AgeRemModificador { get; set; }

    public DateTime? AgeRemModificacion { get; set; }

    public virtual AgendaFeriado AgendaFeriadoAgeFer { get; set; } = null!;

    public virtual Profesional ProfesionalPro { get; set; } = null!;
}
