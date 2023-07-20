using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Especialidad
{
    public string EspId { get; set; } = null!;

    public string? EspDescripcion { get; set; }

    public virtual ICollection<Profesional> ProfesionalPros { get; set; } = new List<Profesional>();
}
