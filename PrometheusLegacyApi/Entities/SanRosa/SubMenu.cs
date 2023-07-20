using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class SubMenu
{
    public string SubId { get; set; } = null!;

    public string? SubTitulo { get; set; }

    public string? SubUrl { get; set; }

    public string? SubDireccion { get; set; }

    public sbyte? SubEstado { get; set; }

    public string? SubCreador { get; set; }

    public DateTime? SubFechacreacion { get; set; }

    public string? SubModificador { get; set; }

    public DateTime? SubFechamodificacion { get; set; }

    public string? MenuMenId { get; set; }

    public string? TipoMenuTipMenId { get; set; }

    public string? SubIcono { get; set; }

    public string? SubMenuId { get; set; }

    public sbyte? MenuDirecto { get; set; }

    public virtual Menu? MenuMen { get; set; }

    public virtual TipoMenu? TipoMenuTipMen { get; set; }
}
