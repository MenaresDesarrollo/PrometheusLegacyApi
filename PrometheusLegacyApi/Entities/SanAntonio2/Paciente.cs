using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanAntonio2;

public partial class Paciente
{
    public string PacId { get; set; } = null!;

    public string? PacRut { get; set; }

    public string? PacNombres { get; set; }

    public string? PacApPaterno { get; set; }

    public string? PacApMaterno { get; set; }

    public int? PacSexo { get; set; }

    public string? PacSexoC { get; set; }

    public DateOnly? PacFechaNacimiento { get; set; }

    public string? PacTelFijo { get; set; }

    public string? PacTelCelular { get; set; }

    public string? PacCorreo { get; set; }

    public sbyte? PacEstado { get; set; }

    public string? PacCreador { get; set; }

    public DateTime? PacCreacion { get; set; }

    public string? PacModificador { get; set; }

    public DateTime? PacModificacion { get; set; }

    public string NacionalidadNacId { get; set; } = null!;

    public string PrevisionPreId { get; set; } = null!;

    public string? PacNFicha { get; set; }

    public bool? PacDiabetico { get; set; }

    public bool? PacHipertenso { get; set; }

    public bool? PacInsuficienciarenal { get; set; }

    public string? PacComentario { get; set; }

    public string? PacTelFijoOpc { get; set; }

    public string? PacTelCelularOpc { get; set; }

    public int SucNumFicha { get; set; }

    public sbyte PacSobrepeso { get; set; }

    public sbyte PacAsmatico { get; set; }

    public sbyte PacMarcapasos { get; set; }

    public sbyte PacValvulaCardiaca { get; set; }

    public sbyte PacNeuroestimulador { get; set; }

    public sbyte PacImplanteCoclear { get; set; }

    public sbyte PacBombaInsulina { get; set; }

    public string? ConvenioConId { get; set; }

    public string? PacCalle { get; set; }

    public string? PacNumero { get; set; }

    public string? ComId { get; set; }

    public string? TipoIdentificacion { get; set; }

    public virtual ICollection<Agendum> Agenda { get; set; } = new List<Agendum>();

    public virtual Convenio? ConvenioCon { get; set; }

    public virtual ICollection<CuestionarioPacienteHistorial> CuestionarioPacienteHistorials { get; set; } = new List<CuestionarioPacienteHistorial>();

    public virtual ICollection<CuestionarioPaciente> CuestionarioPacientes { get; set; } = new List<CuestionarioPaciente>();

    public virtual Nacionalidad NacionalidadNac { get; set; } = null!;

    public virtual Prevision PrevisionPre { get; set; } = null!;

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();
}
