using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Comuna
{
    public string ComId { get; set; } = null!;

    public string? ComDetalle { get; set; }

    public string ProvinciaProId { get; set; } = null!;

    public string? Codigo { get; set; }

    public virtual Provincium ProvinciaPro { get; set; } = null!;

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();
}
