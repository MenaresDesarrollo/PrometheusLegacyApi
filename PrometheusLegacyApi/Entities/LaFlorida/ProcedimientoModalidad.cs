using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.LaFlorida;

public partial class ProcedimientoModalidad
{
    public string ProModalidadId { get; set; } = null!;

    public string? ProModalidadDescripcion { get; set; }

    public string? ProAcronimo { get; set; }

    public int? ProTipo { get; set; }

    public virtual ICollection<Procedimiento1> Procedimiento1s { get; set; } = new List<Procedimiento1>();

    public virtual ICollection<Procedimiento> Procedimientos { get; set; } = new List<Procedimiento>();

    public virtual ICollection<UnidadModalidad> UnidadModalidads { get; set; } = new List<UnidadModalidad>();

    public virtual ICollection<ModalidadInformacion> ModalidadInformacionMods { get; set; } = new List<ModalidadInformacion>();
}
