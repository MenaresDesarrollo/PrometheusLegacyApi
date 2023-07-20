using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class ProcedimientoValidacion
{
    public string PvId { get; set; } = null!;

    public string? PvDescripcion { get; set; }

    public bool? PvTipo { get; set; }

    public sbyte? PvEdad { get; set; }

    public bool? PvMc { get; set; }

    public bool? PvDiabetes { get; set; }

    public bool? PvHipertenso { get; set; }

    public bool? PvInsuficienciaRenal { get; set; }

    /// <summary>
    /// Restriccion de las nuevas validaciones del paciente.
    /// </summary>
    public int? PvOrden { get; set; }
}
