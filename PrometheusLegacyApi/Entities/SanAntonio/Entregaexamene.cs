using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class Entregaexamene
{
    public string EaId { get; set; } = null!;

    public string? EaPacRut { get; set; }

    public string? EaPacNombre { get; set; }

    public string? EaRetRut { get; set; }

    public string? EaRetNombre { get; set; }

    public string? EaRetExamen { get; set; }

    public string? EaUsuId { get; set; }

    public DateTime? EaFechaEntrega { get; set; }

    public bool? ChkCd { get; set; }

    public bool? ChkPlaca { get; set; }

    public bool? ChkPaciente { get; set; }

    public bool? ChkExamen { get; set; }

    public virtual ICollection<ExamenesPaciente> ExamenesPacientes { get; set; } = new List<ExamenesPaciente>();
}
