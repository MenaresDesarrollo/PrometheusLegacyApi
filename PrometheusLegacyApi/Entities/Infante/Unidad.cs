using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Unidad
{
    public string UniId { get; set; } = null!;

    public string? UniDetalle { get; set; }

    public string? UniCreador { get; set; }

    public DateTime? UniFechacreacion { get; set; }

    public string? UniModificador { get; set; }

    public DateTime? UniFechamodificacion { get; set; }

    public sbyte? UniEstado { get; set; }

    public int? UniTipo { get; set; }

    public virtual ICollection<SubUnidad> SubUnidads { get; set; } = new List<SubUnidad>();

    public virtual ICollection<UnidadModalidad> UnidadModalidads { get; set; } = new List<UnidadModalidad>();
}
