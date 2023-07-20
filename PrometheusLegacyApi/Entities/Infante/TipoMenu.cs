using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class TipoMenu
{
    public string TipMenId { get; set; } = null!;

    public string? TipMenDescripcion { get; set; }

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

    public virtual ICollection<SubMenu> SubMenus { get; set; } = new List<SubMenu>();
}
