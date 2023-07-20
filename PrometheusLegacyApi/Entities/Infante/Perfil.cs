using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Perfil
{
    public string PerId { get; set; } = null!;

    public string? PerDetalle { get; set; }

    public string? PerCreador { get; set; }

    public DateTime? PerFechacreacion { get; set; }

    public string? PerModificador { get; set; }

    public DateTime? PerFechamodificacion { get; set; }

    public sbyte? PerEstado { get; set; }

    public string? PerDashboard { get; set; }

    public sbyte? PerIdentificar { get; set; }

    public sbyte? PerGestordocumental { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
