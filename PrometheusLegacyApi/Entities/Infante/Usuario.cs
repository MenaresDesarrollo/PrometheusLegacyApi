using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Usuario
{
    public string UsuId { get; set; } = null!;

    public string? UsuNombre { get; set; }

    public string? UsuPaterno { get; set; }

    public string? UsuMaterno { get; set; }

    public string? UsuRut { get; set; }

    public int? UsuTelefono { get; set; }

    public string? UsuCorreo { get; set; }

    public sbyte? UsuEstado { get; set; }

    public sbyte? UsuLog { get; set; }

    public string? UsuIp { get; set; }

    public string? UsuUsuario { get; set; }

    public string? UsuPass { get; set; }

    public string? UsuSucId { get; set; }

    public string? UsuCreador { get; set; }

    public DateTime? UsuFechacreacion { get; set; }

    public string? UsuModificador { get; set; }

    public DateTime? UsuFechamodificacion { get; set; }

    public string PerfilPerId { get; set; } = null!;

    public string? UsuProId { get; set; }

    public string? UsuPassImed { get; set; }

    public string? UsuGroupPcs { get; set; }

    public sbyte? UsuTipo { get; set; }

    public string? UsuUsuarioImed { get; set; }

    public string? UsuPassAnterior { get; set; }

    public string? UsuPassRandom { get; set; }

    public string? SucursalSucIdUbicacion { get; set; }

    public int? UsuValWorklist { get; set; }

    public bool? DarkMode { get; set; }

    public string? TokenNeolab { get; set; }

    public string? CajaSoftland { get; set; }

    public virtual Perfil PerfilPer { get; set; } = null!;
}
