using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class Procedimiento1
{
    public string ProId { get; set; } = null!;

    public string? ProParticular { get; set; }

    public string? ProCodigo { get; set; }

    public string? ProNomInterno { get; set; }

    public string? ProCobro { get; set; }

    public string? ProCantidad { get; set; }

    public bool? ProEstadoMc { get; set; }

    public string? ProMContraste { get; set; }

    public string? ProAgendable { get; set; }

    public string? ProEtiqueta { get; set; }

    public int? ProEstado { get; set; }

    public string? ProTiempoEspera { get; set; }

    public string? ProPreventa { get; set; }

    public sbyte? ProEspecial { get; set; }

    public string? ProModalidadId { get; set; }

    public string? PcId { get; set; }

    public virtual PartesCuerpo? Pc { get; set; }

    public virtual ProcedimientoModalidad? ProModalidad { get; set; }
}
