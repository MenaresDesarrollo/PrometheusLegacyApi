using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class Prevision
{
    public string PreId { get; set; } = null!;

    public string? PreDescipcion { get; set; }

    public sbyte? PreCodigo { get; set; }

    public string? PreCodProcedencia { get; set; }

    public string? PrePrograma { get; set; }

    public string? TipoLista { get; set; }

    public bool? Activo { get; set; }

    public string? RepOrd { get; set; }

    public int? PreCodFinanciador { get; set; }

    public int? PreCobroLista { get; set; }

    public sbyte? PreEspecial { get; set; }

    public sbyte? PreInformar { get; set; }

    /// <summary>
    /// Es para realizar el cobro por documento
    /// </summary>
    public sbyte? PreDocPago { get; set; }

    public sbyte? PreEstado { get; set; }

    public string? CodigoNeolab { get; set; }

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();
}
