using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class ProfesionalHasSucursalHasSubUnidad
{
    public string ProRelId { get; set; } = null!;

    public string ProfesionalProId { get; set; } = null!;

    public string SucursalHasSubUnidadSucSubId { get; set; } = null!;

    public virtual ICollection<AgendaFeriado> AgendaFeriados { get; set; } = new List<AgendaFeriado>();

    public virtual ICollection<AgendaProfesional> AgendaProfesionals { get; set; } = new List<AgendaProfesional>();

    public virtual Profesional ProfesionalPro { get; set; } = null!;

    public virtual SucursalHasSubUnidad SucursalHasSubUnidadSucSub { get; set; } = null!;
}
