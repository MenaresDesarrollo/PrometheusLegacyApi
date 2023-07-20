using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class SucursalHasSubUnidad
{
    public string SucSubId { get; set; } = null!;

    public string SucursalSucId { get; set; } = null!;

    public string SubUnidadSubId { get; set; } = null!;

    public virtual ICollection<ProfesionalHasSucursalHasSubUnidad> ProfesionalHasSucursalHasSubUnidads { get; set; } = new List<ProfesionalHasSucursalHasSubUnidad>();

    public virtual SubUnidad SubUnidadSub { get; set; } = null!;

    public virtual Sucursal SucursalSuc { get; set; } = null!;
}
