using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class Boletum
{
    public string BolId { get; set; } = null!;

    public string? BolFolio { get; set; }

    public string? BolPrestacion { get; set; }

    public double? BolValorUnitario { get; set; }

    public sbyte? BolCantidad { get; set; }

    public double? BolValorTotal { get; set; }

    public sbyte? BolEstado { get; set; }

    public string? BolRecepcionRegistro { get; set; }

    public string? BolCreador { get; set; }

    public DateTime? BolFechaCreador { get; set; }

    public string? BolModificador { get; set; }

    public DateTime? BolFechaModificador { get; set; }

    public string RecepcionRecId { get; set; } = null!;

    public sbyte? BolEliminado { get; set; }

    public string? PrevisionPreId { get; set; }

    public string? SubUnidadSubId { get; set; }

    public string? BolProCod { get; set; }

    public string? BolDctoFuncionario { get; set; }

    public string? BolObs { get; set; }

    public virtual Recepcion RecepcionRec { get; set; } = null!;
}
