using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class SubMenuHasPerfil
{
    public string SubMenuSubId { get; set; } = null!;

    public string PerfilPerId { get; set; } = null!;

    public sbyte? SubPerEstado { get; set; }

    public virtual Perfil PerfilPer { get; set; } = null!;

    public virtual SubMenu SubMenuSub { get; set; } = null!;
}
