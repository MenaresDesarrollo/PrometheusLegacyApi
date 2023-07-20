using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class CuestionarioPacienteHistorial
{
    public string CuePacId { get; set; } = null!;

    public string? PacId { get; set; }

    public string? CueId { get; set; }

    public string? CueProfesional { get; set; }

    public byte[]? CuePdf { get; set; }

    public DateOnly? CuePacFecha { get; set; }

    public int? CueIndice { get; set; }

    public virtual Cuestionario? Cue { get; set; }

    public virtual Profesional? CueProfesionalNavigation { get; set; }

    public virtual Paciente? Pac { get; set; }
}
