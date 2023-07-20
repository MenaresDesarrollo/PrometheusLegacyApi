using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class PartesCuerpo
{
    public string PcId { get; set; } = null!;

    public string? PcDescripcion { get; set; }

    public virtual ICollection<Procedimiento1> Procedimiento1s { get; set; } = new List<Procedimiento1>();

    public virtual ICollection<Procedimiento> Procedimientos { get; set; } = new List<Procedimiento>();
}
