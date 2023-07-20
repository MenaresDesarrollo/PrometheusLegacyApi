using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class Nacionalidad
{
    public string NacId { get; set; } = null!;

    public string? NacDescripcion { get; set; }

    public string? NacPais { get; set; }

    public string? NacCodNeolab { get; set; }

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public virtual ICollection<Profesional> Profesionals { get; set; } = new List<Profesional>();
}
