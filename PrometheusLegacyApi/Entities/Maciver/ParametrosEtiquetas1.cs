using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class ParametrosEtiquetas1
{
    public string ParEtiId { get; set; } = null!;

    /// <summary>
    /// ORDEN DE IMPRESION 
    /// </summary>
    public sbyte? ParEtiOrden { get; set; }

    public string? ParEtiParametro { get; set; }

    /// <summary>
    /// FORMATO DE LINEA
    /// </summary>
    public string? ParEtiTipo { get; set; }

    /// <summary>
    /// POSICION  1
    /// </summary>
    public int? ParEtiPos1 { get; set; }

    /// <summary>
    /// POSICION 2
    /// </summary>
    public int? ParEtiPos2 { get; set; }

    /// <summary>
    /// POSICION 3
    /// </summary>
    public int? ParEtiPos3 { get; set; }

    /// <summary>
    /// TAMANO DE FUENTE 
    /// </summary>
    public string? ParEtiFont { get; set; }

    /// <summary>
    /// TAMAÑO EJE X
    /// </summary>
    public int? ParEtiExpx { get; set; }

    /// <summary>
    /// TAMAÑO EJE Y
    /// </summary>
    public int? ParEtiExpy { get; set; }

    /// <summary>
    /// FORMATO Y INICIO TEXTO
    /// </summary>
    public string? ParEtiIni { get; set; }

    /// <summary>
    /// FIN TEXTO
    /// </summary>
    public string? ParEtiFin { get; set; }
}
