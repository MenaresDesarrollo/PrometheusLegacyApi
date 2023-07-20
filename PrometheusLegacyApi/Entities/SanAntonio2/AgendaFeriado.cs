using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class AgendaFeriado
{
    public string AgeFerId { get; set; } = null!;

    public string? AgeFerTitulo { get; set; }

    public DateTime? AgeFerHInicio { get; set; }

    public DateTime? AgeFerHFinal { get; set; }

    public int? AgeFerEstado { get; set; }

    public string? AgeFerCreador { get; set; }

    public DateTime? AgeFerFechaCreacion { get; set; }

    public string? AfeFerModificador { get; set; }

    public DateTime? AgeFerFechaModificacion { get; set; }

    public string ProfesionalHasSucursalHasSubUnidadProRelId { get; set; } = null!;

    public virtual ICollection<AgendaReemplazo> AgendaReemplazos { get; set; } = new List<AgendaReemplazo>();

    public virtual ProfesionalHasSucursalHasSubUnidad ProfesionalHasSucursalHasSubUnidadProRel { get; set; } = null!;
}
