using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class AdicionalProcedimiento
{
    public string AdiId { get; set; } = null!;

    public string Examen1 { get; set; } = null!;

    public string Examen2 { get; set; } = null!;

    public string ExamenNuevo { get; set; } = null!;

    public string? ExamenNuevoId { get; set; }

    public sbyte? AdiEstado { get; set; }
}
