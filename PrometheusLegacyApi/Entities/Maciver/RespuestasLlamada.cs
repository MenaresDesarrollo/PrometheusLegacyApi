using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class RespuestasLlamada
{
    public string ResId { get; set; } = null!;

    public string? ResDescripcion { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();
}
