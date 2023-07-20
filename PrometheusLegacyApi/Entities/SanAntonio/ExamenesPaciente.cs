using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class ExamenesPaciente
{
    public string IdExamenesPaciente { get; set; } = null!;

    public string? IdEntrega { get; set; }

    public string? IdExamen { get; set; }

    public sbyte? Placa { get; set; }

    public bool? SobreCarpeta { get; set; }

    public bool? Cd { get; set; }

    public virtual Entregaexamene? IdEntregaNavigation { get; set; }

    public virtual Procedimiento? IdExamenNavigation { get; set; }
}
