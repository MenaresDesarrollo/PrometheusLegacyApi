using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class Bono
{
    public string? BonFolio { get; set; }

    public string? BonPrestacion { get; set; }

    public string? BonCant { get; set; }

    public double? BonBeneficio { get; set; }

    public double? BonSeguro { get; set; }

    public double? BonCopago { get; set; }

    public string RecepcionRecId { get; set; } = null!;

    public string? BonCreador { get; set; }

    public DateTime? BonFechaCreador { get; set; }

    public DateTime? BonFechaBono { get; set; }

    public string? BonRecepcionRegistro { get; set; }

    public sbyte? BonTipoDocumento { get; set; }

    public bool? BonEstado { get; set; }

    public sbyte? BonEliminado { get; set; }

    public string? PrevisionPreId { get; set; }

    public string? SubUnidadSubId { get; set; }

    public string? BonProCod { get; set; }

    public string BonId { get; set; } = null!;

    public int? BonNumero { get; set; }

    public string? BonDctoFuncionario { get; set; }

    public string? BonObs { get; set; }

    public int? BonMontoPrest { get; set; }

    public int? BonMontoBon { get; set; }

    public int? BonMontoCopago { get; set; }

    public string? BonEsGes { get; set; }

    public int? BonCodBonAdic { get; set; }

    public string? BonGloBonAdic { get; set; }

    public int? BonMtoBonAdic { get; set; }

    public int? BonCodFinanciador { get; set; }

    public sbyte? BonVtaInterfaz { get; set; }

    public int? BonMtoOtrMedPag { get; set; }

    public virtual Recepcion RecepcionRec { get; set; } = null!;
}
