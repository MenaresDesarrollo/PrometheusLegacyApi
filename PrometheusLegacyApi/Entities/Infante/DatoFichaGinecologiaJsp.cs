using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Infante;

public partial class DatoFichaGinecologiaJsp
{
    public string DfginecologiaId { get; set; } = null!;

    public string? IdMedEspecialidad { get; set; }

    public int? Menarca { get; set; }

    public int? Gestas { get; set; }

    public int? PartoPretermino { get; set; }

    public int? Ritmo { get; set; }

    public int? PartoTotales { get; set; }

    public int? PartoVaginal { get; set; }

    public int? Mortinato { get; set; }

    public int? Fur { get; set; }

    public int? Aborto { get; set; }

    public int? Cesarea { get; set; }

    public int? Mortineonato { get; set; }

    public string? Papanicolao { get; set; }

    public string? FechaProbable { get; set; }

    public string? ObservacionAntGine { get; set; }

    public string? MetodoAnticonceptivo { get; set; }

    public string? ObservacionMetAnt { get; set; }

    public double? AlturaUterina { get; set; }

    public int? EdadGestacional { get; set; }

    public string? Latidos { get; set; }

    public string? Presentacion { get; set; }

    public string? Edemas { get; set; }

    public string? OtraPresentacion { get; set; }

    public string? ObservacionSigVitales { get; set; }
}
