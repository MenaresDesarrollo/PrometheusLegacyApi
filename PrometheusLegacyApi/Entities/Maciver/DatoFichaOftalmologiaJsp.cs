using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class DatoFichaOftalmologiaJsp
{
    public string DfoftalmologiaId { get; set; } = null!;

    public string? IdMedEspecialidad { get; set; }

    public int? Agudeza { get; set; }

    public string? ObservacionAgudeza { get; set; }

    public int? RefObjArf { get; set; }

    public int? RefObjSk { get; set; }

    public string? RefObjDerechoEspera { get; set; }

    public string? RefObjIzquierdoEspera { get; set; }

    public string? RefObjDerechoCilindro { get; set; }

    public string? RefObjIzquierdoCilindro { get; set; }

    public string? RefObjDerechoGrado { get; set; }

    public string? RefObjIzquierdoGrado { get; set; }

    public string? RefObjDerechoAv { get; set; }

    public string? RefObjIzquierdoAv { get; set; }

    public string? RefSublDerechoEspera { get; set; }

    public string? RefSublIzquierdoEspera { get; set; }

    public string? RefSublDerechoCilindro { get; set; }

    public string? RefSublIzquierdoCilindro { get; set; }

    public string? RefSublDerechoGrado { get; set; }

    public string? RefSublIzquierdoGrado { get; set; }

    public string? RefSublDerechoAv { get; set; }

    public string? RefSublIzquierdoAv { get; set; }

    public string? RefSublDistanciaL { get; set; }

    public string? RefSublDistanciaC { get; set; }

    public int? RefSublAdicion { get; set; }

    public string? RefSubdDerechoEspera { get; set; }

    public string? RefSubdIzquierdoEspera { get; set; }

    public string? RefSubdDerechoCilindro { get; set; }

    public string? RefSubdIzquierdoCilindro { get; set; }

    public string? RefSubdDerechoGrado { get; set; }

    public string? RefSubdIzquierdoGrado { get; set; }

    public string? RefSubdDerechoAv { get; set; }

    public string? RefSubdIzquierdoAv { get; set; }

    public string? Anteojos { get; set; }

    public string? LentesContacto { get; set; }

    public string? Biomicroscopia { get; set; }

    public int? PapilaDer { get; set; }

    public string? ExcavacionDer { get; set; }

    public int? PapilaIzq { get; set; }

    public string? ExcavacionIzq { get; set; }

    public int? PapilaAo { get; set; }

    public string? ExcavacionAo { get; set; }

    public string? ObservacionPapila { get; set; }

    public string? ObservacionBiomicroscopia { get; set; }

    public string? ObservacionNeurooftalmologico { get; set; }

    public int? MaculaDer { get; set; }

    public int? MaculaIzq { get; set; }

    public string? ObservacionMacula { get; set; }

    public int? RetinaDer { get; set; }

    public int? RetinaIzq { get; set; }

    public string? ObservacionRetina { get; set; }

    public string? TonometriaOd { get; set; }

    public string? TonometriaOi { get; set; }

    public string? ObservacionTonometria { get; set; }

    public string? NeuroOftalmologia { get; set; }

    public int? MaculaAo { get; set; }

    public int? RetinaAo { get; set; }
}
