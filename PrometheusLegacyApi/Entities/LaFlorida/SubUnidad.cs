using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class SubUnidad
{
    public string SubUniId { get; set; } = null!;

    public string? SubDetalle { get; set; }

    public string? SubCreador { get; set; }

    public DateTime? SubFechacreacion { get; set; }

    public string? SubModificador { get; set; }

    public DateTime? SubFechamodificacion { get; set; }

    public sbyte? SubEstado { get; set; }

    public string UnidadUniId { get; set; } = null!;

    public string TipoSubUnidadTipSubId { get; set; } = null!;

    public int? SubPin { get; set; }

    public string? SubTarId { get; set; }

    public int? SubMaestra { get; set; }

    public int? SubModalidad { get; set; }

    public int? SubModalidadAgrupar { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();

    public virtual ICollection<SucursalHasSubUnidad> SucursalHasSubUnidads { get; set; } = new List<SucursalHasSubUnidad>();

    public virtual TipoSubUnidad TipoSubUnidadTipSub { get; set; } = null!;

    public virtual Unidad UnidadUni { get; set; } = null!;

    public virtual ICollection<Procedimiento> ProcedimientoPros { get; set; } = new List<Procedimiento>();
}
