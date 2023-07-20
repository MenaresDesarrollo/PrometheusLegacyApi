using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class BoletaSoftland
{
    public string? Folio { get; set; }

    public string? TipoDeDocumentoDeVenta { get; set; }

    public string? SubtipoDelDocumento { get; set; }

    public string? EstadoDelDocumento { get; set; }

    public string? BodegaOrigenDeLosProductos { get; set; }

    public string? NumeroDeDocumento { get; set; }

    public string? FechaDeGeneracionDelDocumento { get; set; }

    public string? ConceptoDelDocumento { get; set; }

    public string? FechaDeVencimientoDelDocumento { get; set; }

    public string? Observacion { get; set; }

    public string? CodigoDeCliente { get; set; }

    public string? NombreDelCliente { get; set; }

    public string? RutDelCliente { get; set; }

    public string? GiroDelCliente { get; set; }

    public string? MailDteDelCliente { get; set; }

    public string? DireccionDelCliente { get; set; }

    public string? NDireccionDelCliente { get; set; }

    public string? ComunaDelCliente { get; set; }

    public string? CiudadDelCliente { get; set; }

    public string? CodigoDeVendedor { get; set; }

    public string? CodigoCentroDeCosto { get; set; }

    public string? CodigoCondicionDePago { get; set; }

    public string? TotalFinal { get; set; }

    public string? CodigoDeProducto { get; set; }

    public string? CodigoUnidadDeMedida { get; set; }

    public string? DetalleDelProducto { get; set; }

    public string? DescripcionDelProducto { get; set; }

    public string? CantidadFacturada { get; set; }

    public string? CantidadDespachada { get; set; }

    public string? PrecioUnitarioMonedaBase { get; set; }

    public string? PrecioUnitarioMonedaDeVenta { get; set; }

    public string? ConservaFolioAsignadoAlDte { get; set; }

    public string? RecId { get; set; }
}
