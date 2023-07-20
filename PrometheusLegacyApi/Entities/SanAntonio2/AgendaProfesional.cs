using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class AgendaProfesional
{
    public string AgeProId { get; set; } = null!;

    public string? AgeProTitulo { get; set; }

    public sbyte? AgeProDia { get; set; }

    public TimeOnly? AgeProHInicio { get; set; }

    public TimeOnly? AgeProHFinal { get; set; }

    public sbyte? AgeProEstado { get; set; }

    public string? AgeProCreador { get; set; }

    public DateTime? AgeProFechaCreacion { get; set; }

    public string? AgeProModificador { get; set; }

    public DateTime? AgeProFechaModificacion { get; set; }

    public string ProfesionalHasSucursalHasSubUnidadProRelId { get; set; } = null!;

    public virtual ProfesionalHasSucursalHasSubUnidad ProfesionalHasSucursalHasSubUnidadProRel { get; set; } = null!;
}
