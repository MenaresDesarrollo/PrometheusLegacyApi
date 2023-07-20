﻿using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class ConveniosHasPrevision
{
    public string ConveniosConId { get; set; } = null!;

    public string PrevisionPreId { get; set; } = null!;

    public sbyte? Estado { get; set; }

    public sbyte? Tipo { get; set; }
}
