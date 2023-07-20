using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class Menu
{
    public string MenId { get; set; } = null!;

    public string? MenTitulo { get; set; }

    public string? MenAccion { get; set; }

    public string? MenIcono { get; set; }

    public string? MenDescripcion { get; set; }

    public sbyte? MenEstado { get; set; }

    public string? MenCreador { get; set; }

    public DateTime? MenFechacreacion { get; set; }

    public string? MenModificador { get; set; }

    public DateTime? MenFechamodificacion { get; set; }

    public string TipoMenuTipMenId { get; set; } = null!;

    public byte[]? MenImagen { get; set; }

    public virtual ICollection<SubMenu> SubMenus { get; set; } = new List<SubMenu>();

    public virtual TipoMenu TipoMenuTipMen { get; set; } = null!;
}
