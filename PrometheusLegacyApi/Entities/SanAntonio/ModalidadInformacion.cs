using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class ModalidadInformacion
{
    public string ModId { get; set; } = null!;

    public string? ModDescripcion { get; set; }

    public string? ModDetalle { get; set; }

    public virtual ICollection<ProcedimientoModalidad> ProcedimientoModalidadProModalidads { get; set; } = new List<ProcedimientoModalidad>();
}
