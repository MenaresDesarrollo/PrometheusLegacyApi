using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class ListaPagProImed
{
    public string? Id { get; set; }

    public int? CodForPagP { get; set; }

    public int? MtoTransacP { get; set; }

    public int? FolioBono { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? UsuarioCreador { get; set; }
}
