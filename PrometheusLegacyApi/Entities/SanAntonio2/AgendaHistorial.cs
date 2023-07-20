using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class AgendaHistorial
{
    public string? AgeId { get; set; }

    public DateTime? AgeHInicio { get; set; }

    public DateTime? AgeHFinal { get; set; }

    public string? AgeCreador { get; set; }

    public DateTime? AgeCreacion { get; set; }

    public string? AgeModificador { get; set; }

    public DateTime? AgeModificacion { get; set; }

    public string SubUnidadSubId { get; set; } = null!;

    public string ProfesionalProId { get; set; } = null!;

    public string ProcedimientoProId { get; set; } = null!;

    public string SucursalSucId { get; set; } = null!;

    public string PacientePacId { get; set; } = null!;

    public int AgeEstado { get; set; }

    public int? Tipo { get; set; }

    public string? Sobrecupoid { get; set; }

    public string? AgeRecepcionId { get; set; }

    public bool? AgeMc { get; set; }

    public string? ResId { get; set; }

    public string? AgeComentario { get; set; }

    public virtual AgendaEstado AgeEstadoNavigation { get; set; } = null!;

    public virtual Paciente PacientePac { get; set; } = null!;

    public virtual Procedimiento ProcedimientoPro { get; set; } = null!;

    public virtual Profesional ProfesionalPro { get; set; } = null!;

    public virtual SubUnidad SubUnidadSub { get; set; } = null!;

    public virtual Sucursal SucursalSuc { get; set; } = null!;
}
