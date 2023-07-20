using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class ParametrosEtiqueta
{
    public string ParEtiId { get; set; } = null!;

    /// <summary>
    /// ORDEN DE IMPRESION 
    /// </summary>
    public sbyte? ParEtiOrden { get; set; }

    public string? ParEtiParametro { get; set; }

    /// <summary>
    /// A-B
    /// </summary>
    public string? ParEtiTipo { get; set; }

    /// <summary>
    /// POSICION  EJE X 0-500
    /// </summary>
    public int? ParEtiPosx { get; set; }

    /// <summary>
    /// POSICION EJE Y 0-250
    /// </summary>
    public int? ParEtiPosy { get; set; }

    /// <summary>
    /// ROTACION DE TEXTO  0/1/2/3
    /// </summary>
    public bool? ParEtiRot { get; set; }

    /// <summary>
    /// TAMANO DE FUENTE 1/3
    /// </summary>
    public bool? ParEtiFont { get; set; }

    /// <summary>
    /// 1/2/3
    /// </summary>
    public bool? ParEtiExpx { get; set; }

    /// <summary>
    /// 1/2/3
    /// </summary>
    public bool? ParEtiExpy { get; set; }

    /// <summary>
    /// 50-100
    /// </summary>
    public int? ParEtiAlt { get; set; }

    /// <summary>
    /// B/N/R
    /// </summary>
    public string? ParEtiEsp { get; set; }
}
