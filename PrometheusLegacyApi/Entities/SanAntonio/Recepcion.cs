using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio;

public partial class Recepcion
{
    public string RecId { get; set; } = null!;

    public int? RecNAtencion { get; set; }

    public DateTime? RecHoraRecepcion { get; set; }

    public string PacientePacId { get; set; } = null!;

    public string PrevisionPreId { get; set; } = null!;

    public double? RecMontoFonasa { get; set; }

    public double? RecMontoBoleta { get; set; }

    public double? RecSaldo { get; set; }

    public string PrestadoresPreId { get; set; } = null!;

    public string? RecNumeroTotem { get; set; }

    public sbyte? RecEstado { get; set; }

    public string? RegistrosRegId { get; set; }

    public double? RecMontoGarantia { get; set; }

    public string? RecNTransaccion { get; set; }

    public string? RecCodAuditoria { get; set; }

    public int? RecUltimoEstado { get; set; }

    public string? RecObs { get; set; }

    public string? RecComentario { get; set; }

    public double? RecCopagoEspecialBono { get; set; }

    public string? RegistrosRegIdModificador { get; set; }

    public sbyte? RecEstadoEntrega { get; set; }

    public DateTime? RecFechaModificacion { get; set; }

    public int? RecEstadoConsulta { get; set; }

    public string? ConveniosConId { get; set; }

    public sbyte? RecValidarAsociado { get; set; }

    public string? AsociadoAsoId { get; set; }

    public string? ProfesionalId { get; set; }

    public virtual ICollection<ArchivoOrdenMedica> ArchivoOrdenMedicas { get; set; } = new List<ArchivoOrdenMedica>();

    public virtual ICollection<Boletum> Boleta { get; set; } = new List<Boletum>();

    public virtual ICollection<Bono> Bonos { get; set; } = new List<Bono>();

    public virtual Convenio? ConveniosCon { get; set; }

    public virtual ICollection<EmbarazoObservacion> EmbarazoObservacions { get; set; } = new List<EmbarazoObservacion>();

    public virtual ICollection<Garantium> Garantia { get; set; } = new List<Garantium>();

    public virtual ICollection<HistoricoPago> HistoricoPagos { get; set; } = new List<HistoricoPago>();

    public virtual ICollection<Observacione> Observaciones { get; set; } = new List<Observacione>();

    public virtual Paciente PacientePac { get; set; } = null!;

    public virtual Prestadore PrestadoresPre { get; set; } = null!;

    public virtual Prevision PrevisionPre { get; set; } = null!;

    public virtual Registro? RegistrosReg { get; set; }

    public virtual ICollection<ResultadosExamene> ResultadosExamenes { get; set; } = new List<ResultadosExamene>();

    public virtual ICollection<RetiroExamene> RetiroExamenes { get; set; } = new List<RetiroExamene>();
}
