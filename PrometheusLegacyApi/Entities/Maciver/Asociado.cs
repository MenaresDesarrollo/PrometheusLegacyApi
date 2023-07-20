using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class Asociado
{
    public string AsoId { get; set; } = null!;

    public string? AsoRut { get; set; }

    public string? AsoNombres { get; set; }

    public string? AsoPaterno { get; set; }

    public string? AsoMaterno { get; set; }

    public string? AsoObservacion { get; set; }

    public string? ConvenioConId { get; set; }

    public sbyte? AsoEstado { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? UsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }
}
