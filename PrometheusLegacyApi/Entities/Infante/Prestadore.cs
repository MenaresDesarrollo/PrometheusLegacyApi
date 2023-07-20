using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Prestadore
{
    public string PreId { get; set; } = null!;

    public string? PreRut { get; set; }

    public string? PreRazonSocial { get; set; }

    public sbyte? PreTipo { get; set; }

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();
}
