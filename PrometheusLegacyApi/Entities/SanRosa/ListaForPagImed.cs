using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class ListaForPagImed
{
    public int? CodForPag { get; set; }

    public string? NumDoc { get; set; }

    public int? CodInst { get; set; }

    public int? CodEmi { get; set; }

    public string? EmiTarBan { get; set; }

    public string? CodAuto { get; set; }

    public int? MtoTransac { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? UsuarioCreador { get; set; }

    public string? RecepcionId { get; set; }

    public string? Id { get; set; }
}
