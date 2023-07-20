using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class Profesional
{
    public string ProId { get; set; } = null!;

    public string? ProNombres { get; set; }

    public string? ProApPaterno { get; set; }

    public string? ProApMaterno { get; set; }

    public string? ProRut { get; set; }

    public sbyte? ProEstado { get; set; }

    public string? NacionalidadNacId { get; set; }

    public string? ProCreador { get; set; }

    public DateTime? ProFechacreacion { get; set; }

    public string? ProModificador { get; set; }

    public DateTime? ProFechamodificacion { get; set; }

    public int? ProSobrecupo { get; set; }

    public sbyte? ProTipo { get; set; }

    public byte[]? ProFirma { get; set; }

    public string? ProRnpi { get; set; }

    public string? MedEspId { get; set; }

    public string? Comentarios { get; set; }

    public string? Frecuencia { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();

    public virtual ICollection<AgendaReemplazo> AgendaReemplazos { get; set; } = new List<AgendaReemplazo>();

    public virtual ICollection<CuestionarioPacienteHistorial> CuestionarioPacienteHistorials { get; set; } = new List<CuestionarioPacienteHistorial>();

    public virtual ICollection<CuestionarioPaciente> CuestionarioPacientes { get; set; } = new List<CuestionarioPaciente>();

    public virtual ICollection<CuestionarioProfesional> CuestionarioProfesionals { get; set; } = new List<CuestionarioProfesional>();

    public virtual Nacionalidad? NacionalidadNac { get; set; }

    public virtual ICollection<ProcedimientoHasProfesional> ProcedimientoHasProfesionals { get; set; } = new List<ProcedimientoHasProfesional>();

    public virtual ICollection<ProfesionalHasSucursalHasSubUnidad> ProfesionalHasSucursalHasSubUnidads { get; set; } = new List<ProfesionalHasSucursalHasSubUnidad>();

    public virtual ICollection<Especialidad> EspecialidadEsps { get; set; } = new List<Especialidad>();
}
