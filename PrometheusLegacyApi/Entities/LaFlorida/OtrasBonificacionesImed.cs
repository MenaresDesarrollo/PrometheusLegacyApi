using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class OtrasBonificacionesImed
{
    public int? CodBonAdic { get; set; }

    public string? GloBonAdic { get; set; }

    public int? MtoBonAdic { get; set; }

    public string? CodPrestacion { get; set; }

    public int? FolioBono { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? UsuarioCreador { get; set; }
}
