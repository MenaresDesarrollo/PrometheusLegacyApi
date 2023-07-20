﻿using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class ArchivoOrdenMedica
{
    public string ArcId { get; set; } = null!;

    public byte[] ArcBase64 { get; set; } = null!;

    public string? ArcCreador { get; set; }

    public DateTime? ArcFechaCreador { get; set; }

    public string? RepcecionRepId { get; set; }

    public virtual Recepcion? RepcecionRep { get; set; }
}
