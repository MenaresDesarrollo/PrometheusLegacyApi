using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class Agendum
{
    public string AgeId { get; set; } = null!;

    public DateTime? AgeHInicio { get; set; }

    public DateTime? AgeHFinal { get; set; }

    public string? AgeCreador { get; set; }

    public DateTime? AgeCreacion { get; set; }

    public string? AgeModificador { get; set; }

    public DateTime? AgeModificacion { get; set; }

    public string? SubUnidadSubId { get; set; }

    public string? ProfesionalProId { get; set; }

    public string ProcedimientoProId { get; set; } = null!;

    public string? SucursalSucId { get; set; }

    public string? PacientePacId { get; set; }

    public int AgeEstado { get; set; }

    public int? Tipo { get; set; }

    public string? Sobrecupoid { get; set; }

    public string? AgeRecepcionId { get; set; }

    public bool? AgeMc { get; set; }

    public string? ResId { get; set; }

    public string? AgeComentario { get; set; }

    public sbyte? AgeAvisoMed { get; set; }

    public sbyte? ConfFicha { get; set; }

    public virtual AgendaEstado AgeEstadoNavigation { get; set; } = null!;

    public virtual Paciente? PacientePac { get; set; }

    public virtual Procedimiento ProcedimientoPro { get; set; } = null!;

    public virtual Profesional? ProfesionalPro { get; set; }

    public virtual RespuestasLlamada? Res { get; set; }

    public virtual SubUnidad? SubUnidadSub { get; set; }

    public virtual Sucursal? SucursalSuc { get; set; }
}
