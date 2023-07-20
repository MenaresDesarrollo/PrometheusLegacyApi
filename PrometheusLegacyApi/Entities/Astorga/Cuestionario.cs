using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class Cuestionario
{
    public string CueId { get; set; } = null!;

    public string? CueDetalle { get; set; }

    public int? CueEstado { get; set; }

    public string? CueTipo { get; set; }

    public int? CueIndice { get; set; }

    public virtual CuestionarioTipo? CueTipoNavigation { get; set; }

    public virtual ICollection<CuestionarioPacienteHistorial> CuestionarioPacienteHistorials { get; set; } = new List<CuestionarioPacienteHistorial>();

    public virtual ICollection<CuestionarioPaciente> CuestionarioPacientes { get; set; } = new List<CuestionarioPaciente>();

    public virtual ICollection<CuestionarioProfesional> CuestionarioProfesionals { get; set; } = new List<CuestionarioProfesional>();

    public virtual ICollection<PreguntasCuestionario> PreguntasCuestionarios { get; set; } = new List<PreguntasCuestionario>();
}
