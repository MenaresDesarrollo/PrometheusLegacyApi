using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class SucursalHasUsuario
{
    public string SucursalSucId { get; set; } = null!;

    public string UsuarioUsuId { get; set; } = null!;

    public int? SucUsuEstado { get; set; }

    public virtual Sucursal SucursalSuc { get; set; } = null!;

    public virtual Usuario UsuarioUsu { get; set; } = null!;
}
