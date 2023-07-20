using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class HistoricoPago
{
    public string HisId { get; set; } = null!;

    public int? HisMonto { get; set; }

    public string? FormaPagoForId { get; set; }

    public string? HisBanco { get; set; }

    public string? HisSerie { get; set; }

    public int? HisCuotas { get; set; }

    public string? HisFolio { get; set; }

    public string? HisTipoCuenta { get; set; }

    public string? HisNumeroCheque { get; set; }

    public string? HisNumeroTarjeta { get; set; }

    public string? HisCreador { get; set; }

    public DateTime? HisFechaCreador { get; set; }

    public string? RecepcionRecId { get; set; }

    public string? HisNumeroAtencion { get; set; }

    public string? RegistrosRegId { get; set; }

    public string? HisFolioBoleta { get; set; }

    public string? HisRecepcionRegistro { get; set; }

    public sbyte? HisGarantia { get; set; }

    public sbyte? HisEstado { get; set; }

    public string? HisDctoFuncionarioParticular { get; set; }

    public string? Voucher { get; set; }

    public virtual FormaPago? FormaPagoFor { get; set; }

    public virtual Recepcion? RecepcionRec { get; set; }

    public virtual Registro? RegistrosReg { get; set; }
}
