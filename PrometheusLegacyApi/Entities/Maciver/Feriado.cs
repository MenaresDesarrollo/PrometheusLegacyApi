using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class Feriado
{
    public string FerId { get; set; } = null!;

    public string? FerTitulo { get; set; }

    public DateOnly? FerInicio { get; set; }

    public bool? FerEstado { get; set; }

    public string? FerCreador { get; set; }

    public DateTime? FerFechaCreacion { get; set; }

    public string? FerModificador { get; set; }

    public DateTime? FerFechaModificacion { get; set; }
}
