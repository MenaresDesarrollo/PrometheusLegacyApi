using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class AgendaEstado
{
    public int AgeEstId { get; set; }

    public string? Descripcion { get; set; }

    public string? Color { get; set; }

    public string? Caracter { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();
}
