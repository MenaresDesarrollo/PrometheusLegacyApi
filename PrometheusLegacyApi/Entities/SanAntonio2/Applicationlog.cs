﻿using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class Applicationlog
{
    public string? DataJson { get; set; }

    public string? TableAfected { get; set; }

    public string? ActionOverData { get; set; }

    public DateTime? DateTimestamp { get; set; }
}
