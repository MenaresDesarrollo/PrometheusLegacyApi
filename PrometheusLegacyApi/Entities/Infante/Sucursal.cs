using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Sucursal
{
    public string SucId { get; set; } = null!;

    public string? SucDetalle { get; set; }

    public string? SucDireccion { get; set; }

    public string? ComunaComId { get; set; }

    public string? SucImagen { get; set; }

    public sbyte? SucEstado { get; set; }

    public string? SucCreador { get; set; }

    public DateTime? SucFechacreacion { get; set; }

    public string? SucModificador { get; set; }

    public DateTime? SucFechamodificacion { get; set; }

    public int? SucNumAtencionActual { get; set; }

    public int? SucNumHLaboratorio { get; set; }

    public int? SucNumHLaboratorioActual { get; set; }

    public string? SucNumeroSucursal { get; set; }

    public string? SucNumeroContacto { get; set; }

    public string? SucEmail { get; set; }

    public string? SucHorario { get; set; }

    public string? SucGoogle { get; set; }

    public string? SucDirImagen { get; set; }

    public int? SucLugarImed { get; set; }

    public string? SucRutConvenio { get; set; }

    public int? SucCorreoConvenio { get; set; }

    public string? SucEspecialidad { get; set; }

    public string? SucBd { get; set; }

    public string? SucBdTotem { get; set; }

    public string? SucBdIp { get; set; }

    public int? SucFolioGarantia { get; set; }

    public int? SucNumFicha { get; set; }

    public string? IpValidator { get; set; }

    /// <summary>
    /// 0 = interna ;  1 = externa
    /// </summary>
    public sbyte? TipoEntidad { get; set; }

    public string? FiltroPacs { get; set; }

    public string? SucursalReferencia { get; set; }

    public string? SucCodigo { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();

    public virtual Comuna? ComunaCom { get; set; }

    public virtual ICollection<SucursalHasSubUnidad> SucursalHasSubUnidads { get; set; } = new List<SucursalHasSubUnidad>();
}
