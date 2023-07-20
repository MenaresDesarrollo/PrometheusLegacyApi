using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class Convenio
{
    public string ConId { get; set; } = null!;

    public string? ConDescripcion { get; set; }

    public string? ConProcedencia { get; set; }

    public sbyte? ConEstado { get; set; }

    public sbyte? ConTipo { get; set; }

    public int? ConDescuento { get; set; }

    public sbyte? ConCobro { get; set; }

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();
}
