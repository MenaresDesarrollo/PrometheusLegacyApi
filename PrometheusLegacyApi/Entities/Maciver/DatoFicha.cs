using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Maciver;

public partial class DatoFicha
{
    public string DtfId { get; set; } = null!;

    public string? PresionArterial { get; set; }

    public string? FrecuenciaCardiaca { get; set; }

    public string? TemperaturaCorporal { get; set; }

    public string? Sao2 { get; set; }

    public int? Dolor { get; set; }

    public string? Descripcion { get; set; }

    public string? Morbidos { get; set; }

    public string? AlergiasMedicamentos { get; set; }

    public string? Farmacos { get; set; }

    public string? Quirurgicos { get; set; }

    public string? Familiares { get; set; }

    public string? Inmunizaciones { get; set; }

    public string? Alcohol { get; set; }

    public string? Tabaquismo { get; set; }

    public string? Drogas { get; set; }

    public string? Otro { get; set; }

    public string? Alimentacion { get; set; }

    public string? ActividadFisica { get; set; }

    public string? MotivoConsulta { get; set; }

    public string? AntEnfermedadActual { get; set; }

    public string? Diagnostico { get; set; }

    public string? Tratamiento { get; set; }

    public string? Comentario { get; set; }

    public string? Pestanias { get; set; }

    public int? Estado { get; set; }

    public string? PacId { get; set; }

    public string? PacEdad { get; set; }

    public string? AgeId { get; set; }

    public string? DfespId { get; set; }

    public string? ActividadesFisica { get; set; }

    public string? RegistroInformacion { get; set; }

    public string? OtroRegistro { get; set; }

    public double? Peso { get; set; }

    public double? Estatura { get; set; }

    public double? Imc { get; set; }

    public double? CirCintura { get; set; }

    public string? EspecialidadMedico { get; set; }

    public string? Procedimientos { get; set; }
}
