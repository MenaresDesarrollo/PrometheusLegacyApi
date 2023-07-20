using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Registro
{
    public string RegId { get; set; } = null!;

    public string CajaCajId { get; set; } = null!;

    public string UsuarioUsuId { get; set; } = null!;

    public DateTime RegFechaApertura { get; set; }

    public double RegMontoPrestamo { get; set; }

    public int? RegCantidadCheque { get; set; }

    public double? RegMontoCheque { get; set; }

    public int? RegCantidadCredito { get; set; }

    public double? RegMontoCredito { get; set; }

    public int? RegCantidadDebito { get; set; }

    public double? RegMontoDebito { get; set; }

    public int? RegCantidadGarantia { get; set; }

    public double? RegMontoGarantia { get; set; }

    public int? RegCantidadPagare { get; set; }

    public double? RegMontoPagare { get; set; }

    public int? RegCantidadOtros { get; set; }

    public double? RegMontoOtros { get; set; }

    public sbyte? RegEstado { get; set; }

    public DateTime? RegFechaCierre { get; set; }

    public DateTime? RegFechaSolicitudCierre { get; set; }

    public double? RegMontoAjuste { get; set; }

    public string? RegComentario { get; set; }

    public string? RegUsuCierre { get; set; }

    public double? RegMontoEfectivo { get; set; }

    public string? RegNumDocDeposito { get; set; }

    public virtual ICollection<HistoricoPago> HistoricoPagos { get; set; } = new List<HistoricoPago>();

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();
}
