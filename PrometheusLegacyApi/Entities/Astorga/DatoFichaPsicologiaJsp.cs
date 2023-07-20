using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class DatoFichaPsicologiaJsp
{
    public string DfpsicologiaId { get; set; } = null!;

    public string? IdMedEspecialidad { get; set; }

    public string? Profesion1 { get; set; }

    public string? Profesion2 { get; set; }

    public string? Actividad1 { get; set; }

    public string? Actividad2 { get; set; }

    public string? EstadoCivil { get; set; }

    public int? NumHijos { get; set; }

    public string? ObservacionPsicologica { get; set; }

    public string? SintomasPsicologicos { get; set; }

    public string? ObservacionIntervenciones { get; set; }

    public string? ObservacionSintomas { get; set; }
}
