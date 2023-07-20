﻿using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class CoordinadorMedico
{
    public string? Coordinador { get; set; }

    public string? Medico { get; set; }

    public virtual Profesional? CoordinadorNavigation { get; set; }

    public virtual Profesional? MedicoNavigation { get; set; }
}
