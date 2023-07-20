using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class Garantium
{
    public string GarId { get; set; } = null!;

    public string? GarFolio { get; set; }

    public string? GarPrestacion { get; set; }

    public int? GarCantidad { get; set; }

    public double? GarValor { get; set; }

    public DateTime? GarFecha { get; set; }

    public string? GarCreador { get; set; }

    public DateTime? GarFechaCreador { get; set; }

    public string? GarModificador { get; set; }

    public DateTime? GarFechaModificador { get; set; }

    public string RecepcionRecId { get; set; } = null!;

    public string? GarDescripcion { get; set; }

    public sbyte? GarDiasHabiles { get; set; }

    public double? GarTotal { get; set; }

    public sbyte? GarEstado { get; set; }

    public string? GarRecepcionRegistro { get; set; }

    public sbyte? GarEliminado { get; set; }

    public string? SubUnidadSubId { get; set; }

    public string? GarProCod { get; set; }

    public string? PrevisionPreId { get; set; }

    public string? GarObs { get; set; }

    public virtual Recepcion RecepcionRec { get; set; } = null!;
}
