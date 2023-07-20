using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class Procedimiento
{
    public string ProId { get; set; } = null!;

    public string? ProParticular { get; set; }

    public string? ProCodigo { get; set; }

    public string? ProNomInterno { get; set; }

    public string? ProCobro { get; set; }

    public string? ProCantidad { get; set; }

    public bool? ProEstadoMc { get; set; }

    public string? ProMContraste { get; set; }

    public string? ProAgendable { get; set; }

    public string? ProEtiqueta { get; set; }

    public int? ProEstado { get; set; }

    public string? ProTiempoEspera { get; set; }

    public string? ProPreventa { get; set; }

    public sbyte? ProEspecial { get; set; }

    public string? ProModalidadId { get; set; }

    public string? PcId { get; set; }

    public string? ProCodigoNeolab { get; set; }

    public string? ProEnvioWll { get; set; }

    public string? ProRutTributario { get; set; }

    public int CodItemPrest { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();

    public virtual ICollection<ExamenesPaciente> ExamenesPacientes { get; set; } = new List<ExamenesPaciente>();

    public virtual PartesCuerpo? Pc { get; set; }

    public virtual ProcedimientoModalidad? ProModalidad { get; set; }

    public virtual ICollection<ProcedimientoHasProfesional> ProcedimientoHasProfesionals { get; set; } = new List<ProcedimientoHasProfesional>();

    public virtual ICollection<SubUnidad> SubUnidadSubs { get; set; } = new List<SubUnidad>();
}
