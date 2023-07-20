using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PrometheusLegacyApi.Entities.SanRosa;

namespace PrometheusLegacyApi.Persistence;

public partial class SantaRosaDbContext : DbContext
{
    public SantaRosaDbContext()
    {
    }

    public SantaRosaDbContext(DbContextOptions<SantaRosaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdicionalProcedimiento> AdicionalProcedimientos { get; set; }

    public virtual DbSet<AgendaEstado> AgendaEstados { get; set; }

    public virtual DbSet<AgendaFeriado> AgendaFeriados { get; set; }

    public virtual DbSet<AgendaHistorial> AgendaHistorials { get; set; }

    public virtual DbSet<AgendaProfesional> AgendaProfesionals { get; set; }

    public virtual DbSet<AgendaReemplazo> AgendaReemplazos { get; set; }

    public virtual DbSet<Agendum> Agenda { get; set; }

    public virtual DbSet<Applicationlog> Applicationlogs { get; set; }

    public virtual DbSet<Aran2NoActualizadosTemp2> Aran2NoActualizadosTemp2s { get; set; }

    public virtual DbSet<Arancel> Arancels { get; set; }

    public virtual DbSet<ArancelesImed> ArancelesImeds { get; set; }

    public virtual DbSet<ArancelesNoActualizadosTemp> ArancelesNoActualizadosTemps { get; set; }

    public virtual DbSet<ArancelesTemp> ArancelesTemps { get; set; }

    public virtual DbSet<ArchivoOrdenMedica> ArchivoOrdenMedicas { get; set; }

    public virtual DbSet<ArchivosEncuenta> ArchivosEncuentas { get; set; }

    public virtual DbSet<Asociado> Asociados { get; set; }

    public virtual DbSet<AvisosMedico> AvisosMedicos { get; set; }

    public virtual DbSet<Boletum> Boleta { get; set; }

    public virtual DbSet<Bono> Bonos { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<CajaMaestra> CajaMaestras { get; set; }

    public virtual DbSet<CampoPago> CampoPagos { get; set; }

    public virtual DbSet<Comuna> Comunas { get; set; }

    public virtual DbSet<ConsultaTipo> ConsultaTipos { get; set; }

    public virtual DbSet<Contraste> Contrastes { get; set; }

    public virtual DbSet<Convenio> Convenios { get; set; }

    public virtual DbSet<ConveniosHasPrevision> ConveniosHasPrevisions { get; set; }

    public virtual DbSet<ConveniosImed> ConveniosImeds { get; set; }

    public virtual DbSet<ConveniosSubUnidade> ConveniosSubUnidades { get; set; }

    public virtual DbSet<CoordinadorMedico> CoordinadorMedicos { get; set; }

    public virtual DbSet<Cuestionario> Cuestionarios { get; set; }

    public virtual DbSet<CuestionarioPaciente> CuestionarioPacientes { get; set; }

    public virtual DbSet<CuestionarioPacienteHistorial> CuestionarioPacienteHistorials { get; set; }

    public virtual DbSet<CuestionarioProfesional> CuestionarioProfesionals { get; set; }

    public virtual DbSet<CuestionarioTipo> CuestionarioTipos { get; set; }

    public virtual DbSet<DatoFicha> DatoFichas { get; set; }

    public virtual DbSet<DatoFichaGinecologiaJsp> DatoFichaGinecologiaJsps { get; set; }

    public virtual DbSet<DatoFichaOftalmologiaJsp> DatoFichaOftalmologiaJsps { get; set; }

    public virtual DbSet<DatoFichaPsicologiaJsp> DatoFichaPsicologiaJsps { get; set; }

    public virtual DbSet<Droga> Drogas { get; set; }

    public virtual DbSet<EmbarazoObservacion> EmbarazoObservacions { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Entregaexamene> Entregaexamenes { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<EstadoOperacione> EstadoOperaciones { get; set; }

    public virtual DbSet<EstadosNumero> EstadosNumeros { get; set; }

    public virtual DbSet<Etiqueta> Etiquetas { get; set; }

    public virtual DbSet<ExamenesPaciente> ExamenesPacientes { get; set; }

    public virtual DbSet<Feriado> Feriados { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<FormaPagoHasCampoPago> FormaPagoHasCampoPagos { get; set; }

    public virtual DbSet<Garantium> Garantia { get; set; }

    public virtual DbSet<HistoricoPago> HistoricoPagos { get; set; }

    public virtual DbSet<ImedSoapMessage> ImedSoapMessages { get; set; }

    public virtual DbSet<LaboratorioRestMessage> LaboratorioRestMessages { get; set; }

    public virtual DbSet<ListaForPagImed> ListaForPagImeds { get; set; }

    public virtual DbSet<ListaPagProImed> ListaPagProImeds { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<MedicoEspecialidad> MedicoEspecialidads { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<ModalidadInformacion> ModalidadInformacions { get; set; }

    public virtual DbSet<ModalidadPcPdf> ModalidadPcPdfs { get; set; }

    public virtual DbSet<MontoCaja> MontoCajas { get; set; }

    public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }

    public virtual DbSet<Number> Numbers { get; set; }

    public virtual DbSet<Observacione> Observaciones { get; set; }

    public virtual DbSet<OperacionesCaja> OperacionesCajas { get; set; }

    public virtual DbSet<OtrasBonificacionesImed> OtrasBonificacionesImeds { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<ParametrosEtiqueta> ParametrosEtiquetas { get; set; }

    public virtual DbSet<ParametrosEtiquetas1> ParametrosEtiquetas1s { get; set; }

    public virtual DbSet<PartesCuerpo> PartesCuerpos { get; set; }

    public virtual DbSet<PatologiasGe> PatologiasGes { get; set; }

    public virtual DbSet<PdfAvisosMedico> PdfAvisosMedicos { get; set; }

    public virtual DbSet<Perfil> Perfils { get; set; }

    public virtual DbSet<PreguntasCuestionario> PreguntasCuestionarios { get; set; }

    public virtual DbSet<Prestadore> Prestadores { get; set; }

    public virtual DbSet<Prevision> Previsions { get; set; }

    public virtual DbSet<Procedimiento> Procedimientos { get; set; }

    public virtual DbSet<Procedimiento1> Procedimiento1s { get; set; }

    public virtual DbSet<ProcedimientoHasProfesional> ProcedimientoHasProfesionals { get; set; }

    public virtual DbSet<ProcedimientoModalidad> ProcedimientoModalidads { get; set; }

    public virtual DbSet<ProcedimientoValidacion> ProcedimientoValidacions { get; set; }

    public virtual DbSet<ProcedimientosNeolab> ProcedimientosNeolabs { get; set; }

    public virtual DbSet<Profesional> Profesionals { get; set; }

    public virtual DbSet<ProfesionalHasSucursalHasSubUnidad> ProfesionalHasSucursalHasSubUnidads { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Recepcion> Recepcions { get; set; }

    public virtual DbSet<RecepcionHasProcedimiento> RecepcionHasProcedimientos { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<RespuestasLlamada> RespuestasLlamadas { get; set; }

    public virtual DbSet<ResultadosExamene> ResultadosExamenes { get; set; }

    public virtual DbSet<RetiroExamene> RetiroExamenes { get; set; }

    public virtual DbSet<SoftlandSoapMessage> SoftlandSoapMessages { get; set; }

    public virtual DbSet<SubMenu> SubMenus { get; set; }

    public virtual DbSet<SubMenuHasPerfil> SubMenuHasPerfils { get; set; }

    public virtual DbSet<SubUnidad> SubUnidads { get; set; }

    public virtual DbSet<SubunidadHasTarjeta> SubunidadHasTarjetas { get; set; }

    public virtual DbSet<SubunidadTesorerium> SubunidadTesoreria { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<SucursalHasSubUnidad> SucursalHasSubUnidads { get; set; }

    public virtual DbSet<SucursalHasUsuario> SucursalHasUsuarios { get; set; }

    public virtual DbSet<TiempoTubo> TiempoTubos { get; set; }

    public virtual DbSet<TipoConvenio> TipoConvenios { get; set; }

    public virtual DbSet<TipoMenu> TipoMenus { get; set; }

    public virtual DbSet<TipoSubUnidad> TipoSubUnidads { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<UnidadModalidad> UnidadModalidads { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Validacione> Validaciones { get; set; }

    public virtual DbSet<WorklistLaboratorio> WorklistLaboratorios { get; set; }

    public virtual DbSet<WorklistSinAgendum> WorklistSinAgenda { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<AdicionalProcedimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("adicional_procedimiento");

            entity.Property(e => e.AdiEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("adi_estado");
            entity.Property(e => e.AdiId)
                .HasMaxLength(100)
                .HasColumnName("adi_id");
            entity.Property(e => e.Examen1)
                .HasMaxLength(100)
                .HasColumnName("examen_1");
            entity.Property(e => e.Examen2)
                .HasMaxLength(100)
                .HasColumnName("examen_2");
            entity.Property(e => e.ExamenNuevo)
                .HasMaxLength(100)
                .HasColumnName("examen_nuevo");
            entity.Property(e => e.ExamenNuevoId)
                .HasMaxLength(100)
                .HasColumnName("examen_nuevo_id");
        });

        modelBuilder.Entity<AgendaEstado>(entity =>
        {
            entity.HasKey(e => e.AgeEstId).HasName("PRIMARY");

            entity.ToTable("agenda_estado");

            entity.Property(e => e.AgeEstId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("AGE_EST_ID");
            entity.Property(e => e.Caracter)
                .HasMaxLength(2)
                .HasColumnName("caracter");
            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .HasColumnName("COLOR");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPCION");
        });

        modelBuilder.Entity<AgendaFeriado>(entity =>
        {
            entity.HasKey(e => e.AgeFerId).HasName("PRIMARY");

            entity.ToTable("agenda_feriado");

            entity.HasIndex(e => e.ProfesionalHasSucursalHasSubUnidadProRelId, "fk_agenda_feriado_profesional_has_sucursal_has_sub_unidad1_idx");

            entity.Property(e => e.AgeFerId)
                .HasMaxLength(255)
                .HasColumnName("AGE_FER_ID");
            entity.Property(e => e.AfeFerModificador)
                .HasMaxLength(255)
                .HasColumnName("AFE_FER_MODIFICADOR");
            entity.Property(e => e.AgeFerCreador)
                .HasMaxLength(255)
                .HasColumnName("AGE_FER_CREADOR");
            entity.Property(e => e.AgeFerEstado)
                .HasColumnType("int(5)")
                .HasColumnName("AGE_FER_ESTADO");
            entity.Property(e => e.AgeFerFechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_FER_FECHA_CREACION");
            entity.Property(e => e.AgeFerFechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_FER_FECHA_MODIFICACION");
            entity.Property(e => e.AgeFerHFinal)
                .HasColumnType("datetime")
                .HasColumnName("AGE_FER_H_FINAL");
            entity.Property(e => e.AgeFerHInicio)
                .HasColumnType("datetime")
                .HasColumnName("AGE_FER_H_INICIO");
            entity.Property(e => e.AgeFerTitulo)
                .HasMaxLength(100)
                .HasColumnName("AGE_FER_TITULO");
            entity.Property(e => e.ProfesionalHasSucursalHasSubUnidadProRelId)
                .HasMaxLength(255)
                .HasColumnName("profesional_has_sucursal_has_sub_unidad_PRO_REL_ID");

            entity.HasOne(d => d.ProfesionalHasSucursalHasSubUnidadProRel).WithMany(p => p.AgendaFeriados)
                .HasForeignKey(d => d.ProfesionalHasSucursalHasSubUnidadProRelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agenda_feriado_profesional_has_sucursal_has_sub_unidad1");
        });

        modelBuilder.Entity<AgendaHistorial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("agenda_historial");

            entity.HasIndex(e => e.PacientePacId, "fk_AGENDA_PACIENTE1_idx");

            entity.HasIndex(e => e.ProcedimientoProId, "fk_AGENDA_PROCEDIMIENTO1_idx");

            entity.HasIndex(e => e.ProfesionalProId, "fk_AGENDA_PROFESIONAL1_idx");

            entity.HasIndex(e => e.SubUnidadSubId, "fk_AGENDA_SUB_UNIDAD1_idx");

            entity.HasIndex(e => e.SucursalSucId, "fk_AGENDA_SUCURSAL1_idx");

            entity.HasIndex(e => e.AgeEstado, "fk_agenda_agenda_estado1_idx");

            entity.Property(e => e.AgeComentario)
                .HasMaxLength(255)
                .HasColumnName("AGE_COMENTARIO");
            entity.Property(e => e.AgeCreacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_CREACION");
            entity.Property(e => e.AgeCreador)
                .HasMaxLength(255)
                .HasColumnName("AGE_CREADOR");
            entity.Property(e => e.AgeEstado)
                .HasColumnType("int(11)")
                .HasColumnName("AGE_ESTADO");
            entity.Property(e => e.AgeHFinal)
                .HasColumnType("datetime")
                .HasColumnName("AGE_H_FINAL");
            entity.Property(e => e.AgeHInicio)
                .HasColumnType("datetime")
                .HasColumnName("AGE_H_INICIO");
            entity.Property(e => e.AgeId)
                .HasMaxLength(255)
                .HasColumnName("AGE_ID");
            entity.Property(e => e.AgeMc).HasColumnName("AGE_MC");
            entity.Property(e => e.AgeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_MODIFICACION");
            entity.Property(e => e.AgeModificador)
                .HasMaxLength(255)
                .HasColumnName("AGE_MODIFICADOR");
            entity.Property(e => e.AgeRecepcionId)
                .HasMaxLength(255)
                .HasColumnName("AGE_RECEPCION_ID");
            entity.Property(e => e.PacientePacId)
                .HasMaxLength(255)
                .HasColumnName("PACIENTE_PAC_ID");
            entity.Property(e => e.ProcedimientoProId)
                .HasMaxLength(255)
                .HasColumnName("PROCEDIMIENTO_PRO_ID");
            entity.Property(e => e.ProfesionalProId)
                .HasMaxLength(255)
                .HasColumnName("PROFESIONAL_PRO_ID");
            entity.Property(e => e.ResId)
                .HasMaxLength(255)
                .HasColumnName("res_id");
            entity.Property(e => e.Sobrecupoid)
                .HasMaxLength(255)
                .HasColumnName("SOBRECUPOID");
            entity.Property(e => e.SubUnidadSubId)
                .HasMaxLength(255)
                .HasColumnName("SUB_UNIDAD_SUB_ID");
            entity.Property(e => e.SucursalSucId)
                .HasMaxLength(255)
                .HasColumnName("SUCURSAL_SUC_ID");
            entity.Property(e => e.Tipo)
                .HasColumnType("int(11)")
                .HasColumnName("TIPO");

            entity.HasOne(d => d.AgeEstadoNavigation).WithMany()
                .HasForeignKey(d => d.AgeEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agenda_agenda_estado10");

            entity.HasOne(d => d.PacientePac).WithMany()
                .HasForeignKey(d => d.PacientePacId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_PACIENTE10");

            entity.HasOne(d => d.ProcedimientoPro).WithMany()
                .HasForeignKey(d => d.ProcedimientoProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_PROCEDIMIENTO10");

            entity.HasOne(d => d.ProfesionalPro).WithMany()
                .HasForeignKey(d => d.ProfesionalProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_PROFESIONAL10");

            entity.HasOne(d => d.SubUnidadSub).WithMany()
                .HasForeignKey(d => d.SubUnidadSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_SUB_UNIDAD10");

            entity.HasOne(d => d.SucursalSuc).WithMany()
                .HasForeignKey(d => d.SucursalSucId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_SUCURSAL10");
        });

        modelBuilder.Entity<AgendaProfesional>(entity =>
        {
            entity.HasKey(e => e.AgeProId).HasName("PRIMARY");

            entity.ToTable("agenda_profesional");

            entity.HasIndex(e => e.ProfesionalHasSucursalHasSubUnidadProRelId, "fk_agenda_profesional_profesional_has_sucursal_has_sub_unid_idx");

            entity.Property(e => e.AgeProId)
                .HasMaxLength(255)
                .HasColumnName("AGE_PRO_ID");
            entity.Property(e => e.AgeProCreador)
                .HasMaxLength(255)
                .HasColumnName("AGE_PRO_CREADOR");
            entity.Property(e => e.AgeProDia)
                .HasColumnType("tinyint(4)")
                .HasColumnName("AGE_PRO_DIA");
            entity.Property(e => e.AgeProEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("AGE_PRO_ESTADO");
            entity.Property(e => e.AgeProFechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_PRO_FECHA_CREACION");
            entity.Property(e => e.AgeProFechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_PRO_FECHA_MODIFICACION");
            entity.Property(e => e.AgeProHFinal)
                .HasColumnType("time")
                .HasColumnName("AGE_PRO_H_FINAL");
            entity.Property(e => e.AgeProHInicio)
                .HasColumnType("time")
                .HasColumnName("AGE_PRO_H_INICIO");
            entity.Property(e => e.AgeProModificador)
                .HasMaxLength(255)
                .HasColumnName("AGE_PRO_MODIFICADOR");
            entity.Property(e => e.AgeProTitulo)
                .HasMaxLength(100)
                .HasColumnName("AGE_PRO_TITULO");
            entity.Property(e => e.ProfesionalHasSucursalHasSubUnidadProRelId)
                .HasMaxLength(255)
                .HasColumnName("profesional_has_sucursal_has_sub_unidad_PRO_REL_ID");

            entity.HasOne(d => d.ProfesionalHasSucursalHasSubUnidadProRel).WithMany(p => p.AgendaProfesionals)
                .HasForeignKey(d => d.ProfesionalHasSucursalHasSubUnidadProRelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agenda_profesional_profesional_has_sucursal_has_sub_unidad1");
        });

        modelBuilder.Entity<AgendaReemplazo>(entity =>
        {
            entity.HasKey(e => e.AgeRemId).HasName("PRIMARY");

            entity.ToTable("agenda_reemplazo");

            entity.HasIndex(e => e.AgendaFeriadoAgeFerId, "fk_AGENDA_REEMPLAZO_AGENDA_FERIADO1_idx");

            entity.HasIndex(e => e.ProfesionalProId, "fk_AGENDA_REEMPLAZO_PROFESIONAL1_idx");

            entity.Property(e => e.AgeRemId)
                .HasMaxLength(255)
                .HasColumnName("AGE_REM_ID");
            entity.Property(e => e.AgeRemCreacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_REM_CREACION");
            entity.Property(e => e.AgeRemCreador)
                .HasMaxLength(255)
                .HasColumnName("AGE_REM_CREADOR");
            entity.Property(e => e.AgeRemModificacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_REM_MODIFICACION");
            entity.Property(e => e.AgeRemModificador)
                .HasMaxLength(255)
                .HasColumnName("AGE_REM_MODIFICADOR");
            entity.Property(e => e.AgendaFeriadoAgeFerId)
                .HasMaxLength(255)
                .HasColumnName("AGENDA_FERIADO_AGE_FER_ID");
            entity.Property(e => e.ProfesionalProId)
                .HasMaxLength(255)
                .HasColumnName("PROFESIONAL_PRO_ID");

            entity.HasOne(d => d.AgendaFeriadoAgeFer).WithMany(p => p.AgendaReemplazos)
                .HasForeignKey(d => d.AgendaFeriadoAgeFerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_REEMPLAZO_AGENDA_FERIADO1");

            entity.HasOne(d => d.ProfesionalPro).WithMany(p => p.AgendaReemplazos)
                .HasForeignKey(d => d.ProfesionalProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_REEMPLAZO_PROFESIONAL1");
        });

        modelBuilder.Entity<Agendum>(entity =>
        {
            entity.HasKey(e => e.AgeId).HasName("PRIMARY");

            entity.ToTable("agenda");

            entity.HasIndex(e => e.ResId, "agenda_respuestas_llamadas_fk");

            entity.HasIndex(e => e.PacientePacId, "fk_AGENDA_PACIENTE1_idx");

            entity.HasIndex(e => e.ProcedimientoProId, "fk_AGENDA_PROCEDIMIENTO1_idx");

            entity.HasIndex(e => e.ProfesionalProId, "fk_AGENDA_PROFESIONAL1_idx");

            entity.HasIndex(e => e.SubUnidadSubId, "fk_AGENDA_SUB_UNIDAD1_idx");

            entity.HasIndex(e => e.SucursalSucId, "fk_AGENDA_SUCURSAL1_idx");

            entity.HasIndex(e => e.AgeEstado, "fk_agenda_agenda_estado1_idx");

            entity.Property(e => e.AgeId)
                .HasMaxLength(255)
                .HasColumnName("AGE_ID");
            entity.Property(e => e.AgeAvisoMed)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("age_aviso_med");
            entity.Property(e => e.AgeComentario)
                .HasMaxLength(255)
                .HasColumnName("AGE_COMENTARIO");
            entity.Property(e => e.AgeCreacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_CREACION");
            entity.Property(e => e.AgeCreador)
                .HasMaxLength(255)
                .HasColumnName("AGE_CREADOR");
            entity.Property(e => e.AgeEstado)
                .HasColumnType("int(11)")
                .HasColumnName("AGE_ESTADO");
            entity.Property(e => e.AgeHFinal)
                .HasColumnType("datetime")
                .HasColumnName("AGE_H_FINAL");
            entity.Property(e => e.AgeHInicio)
                .HasColumnType("datetime")
                .HasColumnName("AGE_H_INICIO");
            entity.Property(e => e.AgeMc).HasColumnName("AGE_MC");
            entity.Property(e => e.AgeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("AGE_MODIFICACION");
            entity.Property(e => e.AgeModificador)
                .HasMaxLength(255)
                .HasColumnName("AGE_MODIFICADOR");
            entity.Property(e => e.AgeRecepcionId)
                .HasMaxLength(255)
                .HasColumnName("AGE_RECEPCION_ID");
            entity.Property(e => e.ConfFicha)
                .HasColumnType("tinyint(4)")
                .HasColumnName("conf_ficha");
            entity.Property(e => e.PacientePacId)
                .HasMaxLength(255)
                .HasColumnName("PACIENTE_PAC_ID");
            entity.Property(e => e.ProcedimientoProId)
                .HasMaxLength(255)
                .HasColumnName("PROCEDIMIENTO_PRO_ID");
            entity.Property(e => e.ProfesionalProId)
                .HasMaxLength(255)
                .HasColumnName("PROFESIONAL_PRO_ID");
            entity.Property(e => e.ResId)
                .HasMaxLength(255)
                .HasColumnName("res_id");
            entity.Property(e => e.Sobrecupoid)
                .HasMaxLength(255)
                .HasColumnName("SOBRECUPOID");
            entity.Property(e => e.SubUnidadSubId)
                .HasMaxLength(255)
                .HasColumnName("SUB_UNIDAD_SUB_ID");
            entity.Property(e => e.SucursalSucId)
                .HasMaxLength(255)
                .HasColumnName("SUCURSAL_SUC_ID");
            entity.Property(e => e.Tipo)
                .HasColumnType("int(11)")
                .HasColumnName("TIPO");

            entity.HasOne(d => d.AgeEstadoNavigation).WithMany(p => p.Agenda)
                .HasForeignKey(d => d.AgeEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agenda_agenda_estado1");

            entity.HasOne(d => d.PacientePac).WithMany(p => p.Agenda)
                .HasForeignKey(d => d.PacientePacId)
                .HasConstraintName("fk_AGENDA_PACIENTE1");

            entity.HasOne(d => d.ProcedimientoPro).WithMany(p => p.Agenda)
                .HasForeignKey(d => d.ProcedimientoProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AGENDA_PROCEDIMIENTO1");

            entity.HasOne(d => d.ProfesionalPro).WithMany(p => p.Agenda)
                .HasForeignKey(d => d.ProfesionalProId)
                .HasConstraintName("fk_AGENDA_PROFESIONAL1");

            entity.HasOne(d => d.Res).WithMany(p => p.Agenda)
                .HasForeignKey(d => d.ResId)
                .HasConstraintName("agenda_respuestas_llamadas_fk");

            entity.HasOne(d => d.SubUnidadSub).WithMany(p => p.Agenda)
                .HasForeignKey(d => d.SubUnidadSubId)
                .HasConstraintName("fk_AGENDA_SUB_UNIDAD1");

            entity.HasOne(d => d.SucursalSuc).WithMany(p => p.Agenda)
                .HasForeignKey(d => d.SucursalSucId)
                .HasConstraintName("fk_AGENDA_SUCURSAL1");
        });

        modelBuilder.Entity<Applicationlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("applicationlog");

            entity.Property(e => e.ActionOverData).HasMaxLength(100);
            entity.Property(e => e.DataJson)
                .HasColumnType("text")
                .HasColumnName("DataJSON");
            entity.Property(e => e.DateTimestamp).HasColumnType("datetime");
            entity.Property(e => e.TableAfected).HasMaxLength(100);
        });

        modelBuilder.Entity<Aran2NoActualizadosTemp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aran2_no_actualizados_temp2");

            entity.Property(e => e.CodigoFonasa).HasMaxLength(100);
            entity.Property(e => e.Copago)
                .HasMaxLength(100)
                .HasColumnName("COPAGO");
            entity.Property(e => e.Fonasa).HasMaxLength(100);
            entity.Property(e => e.Modalidad).HasMaxLength(100);
            entity.Property(e => e.NombreExamen).HasColumnType("text");
            entity.Property(e => e.Obs1)
                .HasMaxLength(100)
                .HasColumnName("OBS1");
            entity.Property(e => e.Obs2)
                .HasMaxLength(100)
                .HasColumnName("OBS2");
            entity.Property(e => e.Obs3)
                .HasMaxLength(100)
                .HasColumnName("OBS3");
            entity.Property(e => e.Particular).HasMaxLength(100);
        });

        modelBuilder.Entity<Arancel>(entity =>
        {
            entity.HasKey(e => e.AranId).HasName("PRIMARY");

            entity.ToTable("arancel");

            entity.Property(e => e.AranId)
                .HasMaxLength(255)
                .HasColumnName("ARAN_ID");
            entity.Property(e => e.AranCreador)
                .HasMaxLength(255)
                .HasColumnName("ARAN_CREADOR");
            entity.Property(e => e.AranFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("ARAN_FECHACREACION");
            entity.Property(e => e.AranFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("ARAN_FECHAMODIFICACION");
            entity.Property(e => e.AranModificador)
                .HasMaxLength(255)
                .HasColumnName("ARAN_MODIFICADOR");
            entity.Property(e => e.CodFonasa)
                .HasMaxLength(255)
                .HasColumnName("COD_FONASA");
            entity.Property(e => e.Homologacion0)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_0");
            entity.Property(e => e.Homologacion1)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_1");
            entity.Property(e => e.Homologacion10)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_10");
            entity.Property(e => e.Homologacion11)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_11");
            entity.Property(e => e.Homologacion12)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_12");
            entity.Property(e => e.Homologacion13)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_13");
            entity.Property(e => e.Homologacion14)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_14");
            entity.Property(e => e.Homologacion15)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_15");
            entity.Property(e => e.Homologacion16)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_16");
            entity.Property(e => e.Homologacion17)
                .HasMaxLength(100)
                .HasColumnName("homologacion_17");
            entity.Property(e => e.Homologacion18)
                .HasMaxLength(100)
                .HasColumnName("homologacion_18");
            entity.Property(e => e.Homologacion19)
                .HasMaxLength(100)
                .HasColumnName("homologacion_19");
            entity.Property(e => e.Homologacion2)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_2");
            entity.Property(e => e.Homologacion20)
                .HasMaxLength(100)
                .HasColumnName("homologacion_20");
            entity.Property(e => e.Homologacion3)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_3");
            entity.Property(e => e.Homologacion4)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_4");
            entity.Property(e => e.Homologacion5)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_5");
            entity.Property(e => e.Homologacion6)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_6");
            entity.Property(e => e.Homologacion7)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_7");
            entity.Property(e => e.Homologacion8)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_8");
            entity.Property(e => e.Homologacion9)
                .HasMaxLength(100)
                .HasColumnName("HOMOLOGACION_9");
            entity.Property(e => e.Lista0)
                .HasMaxLength(255)
                .HasColumnName("LISTA_0");
            entity.Property(e => e.Lista1)
                .HasMaxLength(255)
                .HasColumnName("LISTA_1");
            entity.Property(e => e.Lista10)
                .HasMaxLength(255)
                .HasColumnName("LISTA_10");
            entity.Property(e => e.Lista11)
                .HasMaxLength(100)
                .HasColumnName("LISTA_11");
            entity.Property(e => e.Lista12)
                .HasMaxLength(255)
                .HasColumnName("LISTA_12");
            entity.Property(e => e.Lista13)
                .HasMaxLength(255)
                .HasColumnName("LISTA_13");
            entity.Property(e => e.Lista14)
                .HasMaxLength(255)
                .HasColumnName("LISTA_14");
            entity.Property(e => e.Lista15)
                .HasMaxLength(100)
                .HasColumnName("LISTA_15");
            entity.Property(e => e.Lista16)
                .HasMaxLength(255)
                .HasColumnName("LISTA_16");
            entity.Property(e => e.Lista17)
                .HasMaxLength(100)
                .HasColumnName("lista_17");
            entity.Property(e => e.Lista18)
                .HasMaxLength(100)
                .HasColumnName("lista_18");
            entity.Property(e => e.Lista19)
                .HasMaxLength(100)
                .HasColumnName("lista_19");
            entity.Property(e => e.Lista2)
                .HasMaxLength(255)
                .HasColumnName("LISTA_2");
            entity.Property(e => e.Lista20)
                .HasMaxLength(100)
                .HasColumnName("lista_20");
            entity.Property(e => e.Lista21)
                .HasMaxLength(100)
                .HasColumnName("lista_21");
            entity.Property(e => e.Lista22)
                .HasMaxLength(100)
                .HasComment("CRS traumatologico")
                .HasColumnName("lista_22");
            entity.Property(e => e.Lista23)
                .HasMaxLength(100)
                .HasComment("san borja")
                .HasColumnName("lista_23");
            entity.Property(e => e.Lista3)
                .HasMaxLength(255)
                .HasColumnName("LISTA_3");
            entity.Property(e => e.Lista4)
                .HasMaxLength(255)
                .HasColumnName("LISTA_4");
            entity.Property(e => e.Lista5)
                .HasMaxLength(255)
                .HasColumnName("LISTA_5");
            entity.Property(e => e.Lista6)
                .HasMaxLength(255)
                .HasColumnName("LISTA_6");
            entity.Property(e => e.Lista7)
                .HasMaxLength(255)
                .HasColumnName("LISTA_7");
            entity.Property(e => e.Lista8)
                .HasMaxLength(255)
                .HasColumnName("lista_8");
            entity.Property(e => e.Lista9)
                .HasMaxLength(255)
                .HasColumnName("lista_9");
            entity.Property(e => e.NomFonasa)
                .HasMaxLength(1000)
                .HasColumnName("NOM_FONASA");
        });

        modelBuilder.Entity<ArancelesImed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aranceles_imed");

            entity.Property(e => e.CodAdicional).HasMaxLength(255);
            entity.Property(e => e.CodArancelInterface).HasMaxLength(255);
            entity.Property(e => e.CodHomologo).HasMaxLength(255);
            entity.Property(e => e.CodHomologoItem).HasMaxLength(255);
            entity.Property(e => e.CodItemCert).HasMaxLength(255);
            entity.Property(e => e.CodItemPrest).HasMaxLength(255);
            entity.Property(e => e.CodPrestacionCert).HasMaxLength(255);
            entity.Property(e => e.CodPrestacionPrest).HasMaxLength(255);
            entity.Property(e => e.FechaCarga).HasMaxLength(255);
            entity.Property(e => e.FechaTermino)
                .HasMaxLength(255)
                .HasColumnName("Fecha Termino");
            entity.Property(e => e.GlosaPrestacion).HasMaxLength(255);
            entity.Property(e => e.IndPrestAdicional).HasMaxLength(255);
            entity.Property(e => e.IndPrestInsumo).HasMaxLength(255);
            entity.Property(e => e.IndPrestPqte).HasMaxLength(255);
            entity.Property(e => e.Vigente).HasMaxLength(255);
            entity.Property(e => e._5)
                .HasMaxLength(255)
                .HasColumnName("5");
        });

        modelBuilder.Entity<ArancelesNoActualizadosTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aranceles_no_actualizados_temp");

            entity.Property(e => e.CodigoFonasa).HasMaxLength(100);
            entity.Property(e => e.Copago)
                .HasMaxLength(100)
                .HasColumnName("COPAGO");
            entity.Property(e => e.Fonasa).HasMaxLength(100);
            entity.Property(e => e.Modalidad).HasMaxLength(100);
            entity.Property(e => e.NombreExamen).HasColumnType("text");
            entity.Property(e => e.Obs1)
                .HasMaxLength(100)
                .HasColumnName("OBS1");
            entity.Property(e => e.Obs2)
                .HasMaxLength(100)
                .HasColumnName("OBS2");
            entity.Property(e => e.Obs3)
                .HasMaxLength(100)
                .HasColumnName("OBS3");
            entity.Property(e => e.Particular).HasMaxLength(100);
        });

        modelBuilder.Entity<ArancelesTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aranceles_temp");

            entity.Property(e => e.CodigoFonasa).HasMaxLength(100);
            entity.Property(e => e.Copago)
                .HasMaxLength(100)
                .HasColumnName("COPAGO");
            entity.Property(e => e.Fonasa).HasMaxLength(100);
            entity.Property(e => e.Modalidad).HasMaxLength(100);
            entity.Property(e => e.NombreExamen).HasColumnType("text");
            entity.Property(e => e.Obs1)
                .HasMaxLength(100)
                .HasColumnName("OBS1");
            entity.Property(e => e.Obs2)
                .HasMaxLength(100)
                .HasColumnName("OBS2");
            entity.Property(e => e.Obs3)
                .HasMaxLength(100)
                .HasColumnName("OBS3");
            entity.Property(e => e.Particular).HasMaxLength(100);
        });

        modelBuilder.Entity<ArchivoOrdenMedica>(entity =>
        {
            entity.HasKey(e => e.ArcId).HasName("PRIMARY");

            entity.ToTable("archivo_orden_medica");

            entity.HasIndex(e => e.RepcecionRepId, "archivo_orden_medica_recepcion_fk");

            entity.Property(e => e.ArcId)
                .HasMaxLength(100)
                .HasColumnName("ARC_ID");
            entity.Property(e => e.ArcBase64).HasColumnName("ARC_BASE64");
            entity.Property(e => e.ArcCreador)
                .HasMaxLength(100)
                .HasColumnName("ARC_CREADOR");
            entity.Property(e => e.ArcFechaCreador)
                .HasColumnType("datetime")
                .HasColumnName("ARC_FECHA_CREADOR");
            entity.Property(e => e.RepcecionRepId)
                .HasMaxLength(100)
                .HasColumnName("REPCECION_REP_ID");

            entity.HasOne(d => d.RepcecionRep).WithMany(p => p.ArchivoOrdenMedicas)
                .HasForeignKey(d => d.RepcecionRepId)
                .HasConstraintName("archivo_orden_medica_recepcion_fk");
        });

        modelBuilder.Entity<ArchivosEncuenta>(entity =>
        {
            entity.HasKey(e => e.ArcId).HasName("PRIMARY");

            entity.ToTable("archivos_encuentas");

            entity.Property(e => e.ArcId)
                .HasMaxLength(100)
                .HasColumnName("ARC_ID");
            entity.Property(e => e.ArcBase64).HasColumnName("ARC_BASE64");
            entity.Property(e => e.ArcCreador)
                .HasMaxLength(100)
                .HasColumnName("ARC_CREADOR");
            entity.Property(e => e.ArcDetalle)
                .HasMaxLength(500)
                .HasColumnName("arc_detalle");
            entity.Property(e => e.ArcFechaCreador)
                .HasColumnType("datetime")
                .HasColumnName("ARC_FECHA_CREADOR");
        });

        modelBuilder.Entity<Asociado>(entity =>
        {
            entity.HasKey(e => e.AsoId).HasName("PRIMARY");

            entity.ToTable("asociados");

            entity.Property(e => e.AsoId)
                .HasMaxLength(100)
                .HasColumnName("aso_id");
            entity.Property(e => e.AsoEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("aso_estado");
            entity.Property(e => e.AsoMaterno)
                .HasMaxLength(100)
                .HasColumnName("aso_materno");
            entity.Property(e => e.AsoNombres)
                .HasMaxLength(100)
                .HasColumnName("aso_nombres");
            entity.Property(e => e.AsoObservacion)
                .HasMaxLength(100)
                .HasColumnName("aso_observacion");
            entity.Property(e => e.AsoPaterno)
                .HasMaxLength(100)
                .HasColumnName("aso_paterno");
            entity.Property(e => e.AsoRut)
                .HasMaxLength(100)
                .HasColumnName("aso_rut");
            entity.Property(e => e.ConvenioConId)
                .HasMaxLength(100)
                .HasColumnName("convenio_con_id");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modificacion");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(100)
                .HasColumnName("usuario_creacion");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(100)
                .HasColumnName("usuario_modificacion");
        });

        modelBuilder.Entity<AvisosMedico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("avisos_medicos");

            entity.Property(e => e.AviAviso)
                .HasMaxLength(255)
                .HasColumnName("AVI_AVISO");
            entity.Property(e => e.AviCodFonasa)
                .HasMaxLength(255)
                .HasColumnName("AVI_COD_FONASA");
        });

        modelBuilder.Entity<Boletum>(entity =>
        {
            entity.HasKey(e => e.BolId).HasName("PRIMARY");

            entity.ToTable("boleta");

            entity.HasIndex(e => e.RecepcionRecId, "fk_BOLETA_recepcion1_idx");

            entity.Property(e => e.BolId)
                .HasMaxLength(255)
                .HasColumnName("BOL_ID");
            entity.Property(e => e.BolCantidad)
                .HasColumnType("tinyint(4)")
                .HasColumnName("BOL_CANTIDAD");
            entity.Property(e => e.BolCreador)
                .HasMaxLength(255)
                .HasColumnName("BOL_CREADOR");
            entity.Property(e => e.BolDctoFuncionario)
                .HasMaxLength(100)
                .HasColumnName("BOL_DCTO_FUNCIONARIO");
            entity.Property(e => e.BolEliminado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("BOL_ELIMINADO");
            entity.Property(e => e.BolEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("BOL_ESTADO");
            entity.Property(e => e.BolFechaCreador)
                .HasColumnType("datetime")
                .HasColumnName("BOL_FECHA_CREADOR");
            entity.Property(e => e.BolFechaModificador)
                .HasColumnType("datetime")
                .HasColumnName("BOL_FECHA_MODIFICADOR");
            entity.Property(e => e.BolFolio)
                .HasMaxLength(255)
                .HasColumnName("BOL_FOLIO");
            entity.Property(e => e.BolModificador)
                .HasMaxLength(255)
                .HasColumnName("BOL_MODIFICADOR");
            entity.Property(e => e.BolObs)
                .HasMaxLength(500)
                .HasColumnName("BOL_OBS");
            entity.Property(e => e.BolPrestacion)
                .HasMaxLength(255)
                .HasColumnName("BOL_PRESTACION");
            entity.Property(e => e.BolProCod)
                .HasMaxLength(255)
                .HasColumnName("BOL_PRO_COD");
            entity.Property(e => e.BolRecepcionRegistro)
                .HasMaxLength(255)
                .HasColumnName("BOL_RECEPCION_REGISTRO");
            entity.Property(e => e.BolValorTotal).HasColumnName("BOL_VALOR_TOTAL");
            entity.Property(e => e.BolValorUnitario).HasColumnName("BOL_VALOR_UNITARIO");
            entity.Property(e => e.PrevisionPreId)
                .HasMaxLength(255)
                .HasColumnName("PREVISION_PRE_ID");
            entity.Property(e => e.RecepcionRecId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_REC_ID");
            entity.Property(e => e.SubUnidadSubId)
                .HasMaxLength(255)
                .HasColumnName("SUB_UNIDAD_SUB_ID");

            entity.HasOne(d => d.RecepcionRec).WithMany(p => p.Boleta)
                .HasForeignKey(d => d.RecepcionRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_BOLETA_recepcion1");
        });

        modelBuilder.Entity<Bono>(entity =>
        {
            entity.HasKey(e => e.BonId).HasName("PRIMARY");

            entity.ToTable("bono");

            entity.HasIndex(e => e.RecepcionRecId, "fk_bono_recepcion1_idx");

            entity.Property(e => e.BonId)
                .HasMaxLength(255)
                .HasColumnName("bon_id");
            entity.Property(e => e.BonBeneficio).HasColumnName("BON_BENEFICIO");
            entity.Property(e => e.BonCant)
                .HasMaxLength(45)
                .HasColumnName("BON_CANT");
            entity.Property(e => e.BonCodBonAdic)
                .HasColumnType("int(11)")
                .HasColumnName("BON_COD_BON_ADIC");
            entity.Property(e => e.BonCodFinanciador)
                .HasColumnType("int(11)")
                .HasColumnName("BON_COD_FINANCIADOR");
            entity.Property(e => e.BonCopago).HasColumnName("BON_COPAGO");
            entity.Property(e => e.BonCreador)
                .HasMaxLength(255)
                .HasColumnName("BON_CREADOR");
            entity.Property(e => e.BonDctoFuncionario)
                .HasMaxLength(100)
                .HasColumnName("bon_dcto_funcionario");
            entity.Property(e => e.BonEliminado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("BON_ELIMINADO");
            entity.Property(e => e.BonEsGes)
                .HasMaxLength(5)
                .HasColumnName("BON_ES_GES");
            entity.Property(e => e.BonEstado).HasColumnName("BON_ESTADO");
            entity.Property(e => e.BonFechaBono)
                .HasColumnType("datetime")
                .HasColumnName("BON_FECHA_BONO");
            entity.Property(e => e.BonFechaCreador)
                .HasColumnType("datetime")
                .HasColumnName("BON_FECHA_CREADOR");
            entity.Property(e => e.BonFolio)
                .HasMaxLength(100)
                .HasColumnName("BON_FOLIO");
            entity.Property(e => e.BonGloBonAdic)
                .HasMaxLength(100)
                .HasColumnName("BON_GLO_BON_ADIC");
            entity.Property(e => e.BonMontoBon)
                .HasColumnType("int(11)")
                .HasColumnName("BON_MONTO_BON");
            entity.Property(e => e.BonMontoCopago)
                .HasColumnType("int(11)")
                .HasColumnName("BON_MONTO_COPAGO");
            entity.Property(e => e.BonMontoPrest)
                .HasColumnType("int(11)")
                .HasColumnName("BON_MONTO_PREST");
            entity.Property(e => e.BonMtoBonAdic)
                .HasColumnType("int(11)")
                .HasColumnName("BON_MTO_BON_ADIC");
            entity.Property(e => e.BonMtoOtrMedPag)
                .HasColumnType("int(11)")
                .HasColumnName("BON_MTO_OTR_MED_PAG");
            entity.Property(e => e.BonNumero)
                .HasColumnType("int(11)")
                .HasColumnName("BON_NUMERO");
            entity.Property(e => e.BonObs)
                .HasMaxLength(500)
                .HasColumnName("bon_obs");
            entity.Property(e => e.BonPrestacion)
                .HasMaxLength(45)
                .HasColumnName("BON_PRESTACION");
            entity.Property(e => e.BonProCod)
                .HasMaxLength(255)
                .HasColumnName("BON_PRO_COD");
            entity.Property(e => e.BonRecepcionRegistro)
                .HasMaxLength(255)
                .HasColumnName("BON_RECEPCION_REGISTRO");
            entity.Property(e => e.BonSeguro).HasColumnName("BON_SEGURO");
            entity.Property(e => e.BonTipoDocumento)
                .HasColumnType("tinyint(4)")
                .HasColumnName("BON_TIPO_DOCUMENTO");
            entity.Property(e => e.BonVtaInterfaz)
                .HasColumnType("tinyint(4)")
                .HasColumnName("BON_VTA_INTERFAZ");
            entity.Property(e => e.PrevisionPreId)
                .HasMaxLength(255)
                .HasColumnName("PREVISION_PRE_ID");
            entity.Property(e => e.RecepcionRecId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_REC_ID");
            entity.Property(e => e.SubUnidadSubId)
                .HasMaxLength(255)
                .HasColumnName("SUB_UNIDAD_SUB_ID");

            entity.HasOne(d => d.RecepcionRec).WithMany(p => p.Bonos)
                .HasForeignKey(d => d.RecepcionRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bono_recepcion1");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.HasKey(e => e.CajId).HasName("PRIMARY");

            entity.ToTable("caja");

            entity.Property(e => e.CajId)
                .HasMaxLength(255)
                .HasColumnName("CAJ_ID");
            entity.Property(e => e.CajCreador)
                .HasMaxLength(255)
                .HasColumnName("CAJ_CREADOR");
            entity.Property(e => e.CajDetalle)
                .HasMaxLength(45)
                .HasColumnName("CAJ_DETALLE");
            entity.Property(e => e.CajEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("CAJ_ESTADO");
            entity.Property(e => e.CajFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("CAJ_FECHACREACION");
            entity.Property(e => e.CajFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("CAJ_FECHAMODIFICACION");
            entity.Property(e => e.CajIpPredeterminada)
                .HasMaxLength(100)
                .HasColumnName("CAJ_IP_PREDETERMINADA");
            entity.Property(e => e.CajModificador)
                .HasMaxLength(255)
                .HasColumnName("CAJ_MODIFICADOR");
            entity.Property(e => e.CajTipo)
                .HasColumnType("tinyint(4)")
                .HasColumnName("CAJ_TIPO");
        });

        modelBuilder.Entity<CajaMaestra>(entity =>
        {
            entity.HasKey(e => e.CajaCajId).HasName("PRIMARY");

            entity.ToTable("caja_maestra");

            entity.Property(e => e.CajaCajId)
                .HasMaxLength(255)
                .HasColumnName("CAJA_CAJ_ID");
            entity.Property(e => e.CajCreador)
                .HasMaxLength(255)
                .HasColumnName("CAJ_CREADOR");
            entity.Property(e => e.CajDeposito)
                .HasColumnType("float(20,4)")
                .HasColumnName("CAJ_DEPOSITO");
            entity.Property(e => e.CajFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("CAJ_FECHACREACION");
            entity.Property(e => e.CajFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("CAJ_FECHAMODIFICACION");
            entity.Property(e => e.CajModificador)
                .HasMaxLength(255)
                .HasColumnName("CAJ_MODIFICADOR");
            entity.Property(e => e.CajMontoPrestamo)
                .HasColumnType("float(20,4)")
                .HasColumnName("CAJ_MONTO_PRESTAMO");

            entity.HasOne(d => d.CajaCaj).WithOne(p => p.CajaMaestra)
                .HasForeignKey<CajaMaestra>(d => d.CajaCajId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("caja_maestra_caja_fk");
        });

        modelBuilder.Entity<CampoPago>(entity =>
        {
            entity.HasKey(e => e.CamId).HasName("PRIMARY");

            entity.ToTable("campo_pagos");

            entity.Property(e => e.CamId)
                .HasMaxLength(255)
                .HasColumnName("CAM_ID");
            entity.Property(e => e.CamDetalle)
                .HasMaxLength(150)
                .HasColumnName("CAM_DETALLE");
            entity.Property(e => e.CamInput)
                .HasMaxLength(300)
                .HasColumnName("CAM_INPUT");
        });

        modelBuilder.Entity<Comuna>(entity =>
        {
            entity.HasKey(e => e.ComId).HasName("PRIMARY");

            entity.ToTable("comuna");

            entity.HasIndex(e => e.ProvinciaProId, "fk_COMUNA_PROVINCIA1_idx");

            entity.Property(e => e.ComId)
                .HasMaxLength(255)
                .HasColumnName("COM_ID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .HasColumnName("codigo");
            entity.Property(e => e.ComDetalle)
                .HasMaxLength(100)
                .HasColumnName("COM_DETALLE");
            entity.Property(e => e.ProvinciaProId)
                .HasMaxLength(255)
                .HasColumnName("PROVINCIA_PRO_ID");

            entity.HasOne(d => d.ProvinciaPro).WithMany(p => p.Comunas)
                .HasForeignKey(d => d.ProvinciaProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_COMUNA_PROVINCIA1");
        });

        modelBuilder.Entity<ConsultaTipo>(entity =>
        {
            entity.HasKey(e => e.ConId).HasName("PRIMARY");

            entity.ToTable("consulta_tipo");

            entity.Property(e => e.ConId)
                .ValueGeneratedNever()
                .HasColumnType("tinyint(4)")
                .HasColumnName("CON_ID");
            entity.Property(e => e.ConDetalle)
                .HasMaxLength(255)
                .HasColumnName("CON_DETALLE");
        });

        modelBuilder.Entity<Contraste>(entity =>
        {
            entity.HasKey(e => e.ConId).HasName("PRIMARY");

            entity.ToTable("contraste");

            entity.Property(e => e.ConId)
                .HasMaxLength(255)
                .HasColumnName("CON_ID");
            entity.Property(e => e.ConEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("CON_ESTADO");
        });

        modelBuilder.Entity<Convenio>(entity =>
        {
            entity.HasKey(e => e.ConId).HasName("PRIMARY");

            entity.ToTable("convenios");

            entity.Property(e => e.ConId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("con_id");
            entity.Property(e => e.ConCobro)
                .HasColumnType("tinyint(4)")
                .HasColumnName("con_cobro");
            entity.Property(e => e.ConDescripcion)
                .HasMaxLength(255)
                .HasColumnName("con_descripcion");
            entity.Property(e => e.ConDescuento)
                .HasColumnType("int(11)")
                .HasColumnName("con_descuento");
            entity.Property(e => e.ConEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("con_estado");
            entity.Property(e => e.ConProcedencia)
                .HasMaxLength(100)
                .HasColumnName("con_procedencia");
            entity.Property(e => e.ConTipo)
                .HasColumnType("tinyint(4)")
                .HasColumnName("con_tipo");
        });

        modelBuilder.Entity<ConveniosHasPrevision>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("convenios_has_prevision");

            entity.Property(e => e.ConveniosConId)
                .HasMaxLength(255)
                .HasColumnName("convenios_con_id");
            entity.Property(e => e.Estado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("estado");
            entity.Property(e => e.PrevisionPreId)
                .HasMaxLength(255)
                .HasColumnName("prevision_pre_id");
            entity.Property(e => e.Tipo)
                .HasColumnType("tinyint(4)")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<ConveniosImed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("convenios_imed");

            entity.Property(e => e.CodArancelInterface).HasMaxLength(255);
            entity.Property(e => e.CodFinanciador).HasMaxLength(3);
            entity.Property(e => e.CorrConvenio).HasColumnType("int(11)");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.RutConvenio).HasMaxLength(11);
        });

        modelBuilder.Entity<ConveniosSubUnidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("convenios_sub_unidades");

            entity.HasIndex(e => e.ConvenioId, "convenios_sub_unidades_convenios_fk");

            entity.HasIndex(e => e.SubUnidadId, "convenios_sub_unidades_sub_unidad_fk");

            entity.Property(e => e.ConvenioId)
                .HasMaxLength(255)
                .HasColumnName("convenio_id");
            entity.Property(e => e.Descuento)
                .HasColumnType("int(11)")
                .HasColumnName("descuento");
            entity.Property(e => e.SubUnidadId)
                .HasMaxLength(255)
                .HasColumnName("sub_unidad_id");

            entity.HasOne(d => d.Convenio).WithMany()
                .HasForeignKey(d => d.ConvenioId)
                .HasConstraintName("convenios_sub_unidades_convenios_fk");

            entity.HasOne(d => d.SubUnidad).WithMany()
                .HasForeignKey(d => d.SubUnidadId)
                .HasConstraintName("convenios_sub_unidades_sub_unidad_fk");
        });

        modelBuilder.Entity<CoordinadorMedico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordinador_medicos");

            entity.HasIndex(e => e.Medico, "coordinador_medicos_profesional_fk");

            entity.HasIndex(e => e.Coordinador, "coordinador_medicos_profesional_fk_1");

            entity.Property(e => e.Coordinador)
                .HasMaxLength(255)
                .HasColumnName("coordinador");
            entity.Property(e => e.Medico)
                .HasMaxLength(255)
                .HasColumnName("medico");

            entity.HasOne(d => d.CoordinadorNavigation).WithMany()
                .HasForeignKey(d => d.Coordinador)
                .HasConstraintName("coordinador_medicos_profesional_fk_1");

            entity.HasOne(d => d.MedicoNavigation).WithMany()
                .HasForeignKey(d => d.Medico)
                .HasConstraintName("coordinador_medicos_profesional_fk");
        });

        modelBuilder.Entity<Cuestionario>(entity =>
        {
            entity.HasKey(e => e.CueId).HasName("PRIMARY");

            entity.ToTable("cuestionario");

            entity.HasIndex(e => e.CueTipo, "cuestionario_fk");

            entity.Property(e => e.CueId)
                .HasMaxLength(255)
                .HasColumnName("CUE_ID");
            entity.Property(e => e.CueDetalle)
                .HasMaxLength(100)
                .HasColumnName("CUE_DETALLE");
            entity.Property(e => e.CueEstado)
                .HasColumnType("int(11)")
                .HasColumnName("CUE_ESTADO");
            entity.Property(e => e.CueIndice)
                .HasColumnType("int(11)")
                .HasColumnName("cue_indice");
            entity.Property(e => e.CueTipo)
                .HasMaxLength(255)
                .HasColumnName("CUE_TIPO");

            entity.HasOne(d => d.CueTipoNavigation).WithMany(p => p.Cuestionarios)
                .HasForeignKey(d => d.CueTipo)
                .HasConstraintName("cuestionario_fk");
        });

        modelBuilder.Entity<CuestionarioPaciente>(entity =>
        {
            entity.HasKey(e => e.CuePacId).HasName("PRIMARY");

            entity.ToTable("cuestionario_paciente");

            entity.HasIndex(e => e.CueId, "cuestionario_paciente_fk_cuestionario");

            entity.HasIndex(e => e.PacId, "cuestionario_paciente_fk_paciente");

            entity.HasIndex(e => e.CueProfesional, "cuestionario_paciente_fk_profesional");

            entity.Property(e => e.CuePacId)
                .HasMaxLength(255)
                .HasColumnName("CUE_PAC_ID");
            entity.Property(e => e.CueId)
                .HasMaxLength(225)
                .HasColumnName("CUE_ID");
            entity.Property(e => e.CueIndice)
                .HasColumnType("int(11)")
                .HasColumnName("cue_indice");
            entity.Property(e => e.CuePacFecha)
                .HasColumnType("datetime")
                .HasColumnName("CUE_PAC_FECHA");
            entity.Property(e => e.CuePdf).HasColumnName("CUE_PDF");
            entity.Property(e => e.CueProfesional)
                .HasMaxLength(255)
                .HasColumnName("CUE_PROFESIONAL");
            entity.Property(e => e.PacId)
                .HasMaxLength(255)
                .HasColumnName("PAC_ID");

            entity.HasOne(d => d.Cue).WithMany(p => p.CuestionarioPacientes)
                .HasForeignKey(d => d.CueId)
                .HasConstraintName("cuestionario_paciente_fk_cuestionario");

            entity.HasOne(d => d.CueProfesionalNavigation).WithMany(p => p.CuestionarioPacientes)
                .HasForeignKey(d => d.CueProfesional)
                .HasConstraintName("cuestionario_paciente_fk_profesional");

            entity.HasOne(d => d.Pac).WithMany(p => p.CuestionarioPacientes)
                .HasForeignKey(d => d.PacId)
                .HasConstraintName("cuestionario_paciente_fk_paciente");
        });

        modelBuilder.Entity<CuestionarioPacienteHistorial>(entity =>
        {
            entity.HasKey(e => e.CuePacId).HasName("PRIMARY");

            entity.ToTable("cuestionario_paciente_historial");

            entity.HasIndex(e => e.CueId, "cuestionario_paciente_fk_cuestionario_2");

            entity.HasIndex(e => e.PacId, "cuestionario_paciente_fk_paciente_2");

            entity.HasIndex(e => e.CueProfesional, "cuestionario_paciente_fk_profesional_2");

            entity.Property(e => e.CuePacId)
                .HasMaxLength(255)
                .HasColumnName("CUE_PAC_ID");
            entity.Property(e => e.CueId)
                .HasMaxLength(225)
                .HasColumnName("CUE_ID");
            entity.Property(e => e.CueIndice)
                .HasColumnType("int(11)")
                .HasColumnName("cue_indice");
            entity.Property(e => e.CuePacFecha).HasColumnName("CUE_PAC_FECHA");
            entity.Property(e => e.CuePdf).HasColumnName("CUE_PDF");
            entity.Property(e => e.CueProfesional)
                .HasMaxLength(255)
                .HasColumnName("CUE_PROFESIONAL");
            entity.Property(e => e.PacId)
                .HasMaxLength(255)
                .HasColumnName("PAC_ID");

            entity.HasOne(d => d.Cue).WithMany(p => p.CuestionarioPacienteHistorials)
                .HasForeignKey(d => d.CueId)
                .HasConstraintName("cuestionario_paciente_fk_cuestionario_2");

            entity.HasOne(d => d.CueProfesionalNavigation).WithMany(p => p.CuestionarioPacienteHistorials)
                .HasForeignKey(d => d.CueProfesional)
                .HasConstraintName("cuestionario_paciente_fk_profesional_2");

            entity.HasOne(d => d.Pac).WithMany(p => p.CuestionarioPacienteHistorials)
                .HasForeignKey(d => d.PacId)
                .HasConstraintName("cuestionario_paciente_fk_paciente_2");
        });

        modelBuilder.Entity<CuestionarioProfesional>(entity =>
        {
            entity.HasKey(e => e.CueProId).HasName("PRIMARY");

            entity.ToTable("cuestionario_profesional");

            entity.HasIndex(e => e.CueProProfesionalId, "cuestionario_profesional_fk");

            entity.HasIndex(e => e.CueId, "cuestionario_profesional_fk_cuestionario");

            entity.Property(e => e.CueProId)
                .HasMaxLength(255)
                .HasColumnName("CUE_PRO_ID");
            entity.Property(e => e.CueId)
                .HasMaxLength(255)
                .HasColumnName("CUE_ID");
            entity.Property(e => e.CueProProfesionalId)
                .HasMaxLength(255)
                .HasColumnName("CUE_PRO_PROFESIONAL_ID");

            entity.HasOne(d => d.Cue).WithMany(p => p.CuestionarioProfesionals)
                .HasForeignKey(d => d.CueId)
                .HasConstraintName("cuestionario_profesional_fk_cuestionario");

            entity.HasOne(d => d.CueProProfesional).WithMany(p => p.CuestionarioProfesionals)
                .HasForeignKey(d => d.CueProProfesionalId)
                .HasConstraintName("cuestionario_profesional_fk");
        });

        modelBuilder.Entity<CuestionarioTipo>(entity =>
        {
            entity.HasKey(e => e.TipoId).HasName("PRIMARY");

            entity.ToTable("cuestionario_tipo");

            entity.Property(e => e.TipoId)
                .HasMaxLength(255)
                .HasColumnName("TIPO_ID");
            entity.Property(e => e.TipoColor)
                .HasMaxLength(25)
                .HasColumnName("TIPO_COLOR");
            entity.Property(e => e.TipoDetalle)
                .HasMaxLength(100)
                .HasColumnName("TIPO_DETALLE");
        });

        modelBuilder.Entity<DatoFicha>(entity =>
        {
            entity.HasKey(e => e.DtfId).HasName("PRIMARY");

            entity.ToTable("dato_ficha");

            entity.Property(e => e.DtfId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("dtf_id")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ActividadFisica)
                .HasColumnType("text")
                .HasColumnName("actividad_fisica");
            entity.Property(e => e.ActividadesFisica)
                .HasMaxLength(255)
                .HasColumnName("actividades_fisica");
            entity.Property(e => e.AgeId)
                .HasMaxLength(255)
                .HasColumnName("age_id")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Alcohol)
                .HasMaxLength(100)
                .HasColumnName("alcohol");
            entity.Property(e => e.AlergiasMedicamentos)
                .HasColumnType("text")
                .HasColumnName("alergias_medicamentos");
            entity.Property(e => e.Alimentacion)
                .HasMaxLength(1000)
                .HasColumnName("alimentacion")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.AntEnfermedadActual)
                .HasMaxLength(2000)
                .HasColumnName("ant_enfermedad_actual")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CirCintura).HasColumnName("cir_cintura");
            entity.Property(e => e.Comentario)
                .HasMaxLength(1000)
                .HasColumnName("comentario")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .HasColumnName("descripcion")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.DfespId)
                .HasMaxLength(255)
                .HasColumnName("dfesp_id");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(1000)
                .HasColumnName("diagnostico")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Dolor)
                .HasColumnType("int(11)")
                .HasColumnName("dolor");
            entity.Property(e => e.Drogas)
                .HasMaxLength(500)
                .HasColumnName("drogas");
            entity.Property(e => e.EspecialidadMedico)
                .HasMaxLength(255)
                .HasColumnName("especialidad_medico")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Estado)
                .HasColumnType("int(11)")
                .HasColumnName("estado");
            entity.Property(e => e.Estatura).HasColumnName("estatura");
            entity.Property(e => e.Familiares)
                .HasColumnType("text")
                .HasColumnName("familiares");
            entity.Property(e => e.Farmacos)
                .HasColumnType("text")
                .HasColumnName("farmacos");
            entity.Property(e => e.FrecuenciaCardiaca)
                .HasMaxLength(60)
                .HasColumnName("frecuencia_cardiaca")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Imc).HasColumnName("imc");
            entity.Property(e => e.Inmunizaciones)
                .HasColumnType("text")
                .HasColumnName("inmunizaciones");
            entity.Property(e => e.Morbidos)
                .HasColumnType("text")
                .HasColumnName("morbidos");
            entity.Property(e => e.MotivoConsulta)
                .HasMaxLength(1000)
                .HasColumnName("motivo_consulta")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Otro)
                .HasMaxLength(1000)
                .HasColumnName("otro")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.OtroRegistro)
                .HasColumnType("text")
                .HasColumnName("otro_registro");
            entity.Property(e => e.PacEdad)
                .HasMaxLength(255)
                .HasColumnName("pac_edad")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.PacId)
                .HasMaxLength(255)
                .HasColumnName("pac_id")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Peso).HasColumnName("peso");
            entity.Property(e => e.Pestanias)
                .HasColumnType("text")
                .HasColumnName("pestanias");
            entity.Property(e => e.PresionArterial)
                .HasMaxLength(60)
                .HasColumnName("presion_arterial")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Procedimientos)
                .HasColumnType("text")
                .HasColumnName("procedimientos")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Quirurgicos)
                .HasColumnType("text")
                .HasColumnName("quirurgicos");
            entity.Property(e => e.RegistroInformacion)
                .HasMaxLength(100)
                .HasColumnName("registro_informacion");
            entity.Property(e => e.Sao2)
                .HasMaxLength(60)
                .HasColumnName("sao2")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Tabaquismo)
                .HasMaxLength(100)
                .HasColumnName("tabaquismo");
            entity.Property(e => e.TemperaturaCorporal)
                .HasMaxLength(60)
                .HasColumnName("temperatura_corporal")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(1000)
                .HasColumnName("tratamiento")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
        });

        modelBuilder.Entity<DatoFichaGinecologiaJsp>(entity =>
        {
            entity.HasKey(e => e.DfginecologiaId).HasName("PRIMARY");

            entity.ToTable("dato_ficha_ginecologia_jsp");

            entity.Property(e => e.DfginecologiaId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("dfginecologia_id");
            entity.Property(e => e.Aborto)
                .HasColumnType("int(11)")
                .HasColumnName("aborto");
            entity.Property(e => e.AlturaUterina).HasColumnName("altura_uterina");
            entity.Property(e => e.Cesarea)
                .HasColumnType("int(11)")
                .HasColumnName("cesarea");
            entity.Property(e => e.EdadGestacional)
                .HasColumnType("int(11)")
                .HasColumnName("edad_gestacional");
            entity.Property(e => e.Edemas)
                .HasMaxLength(50)
                .HasColumnName("edemas");
            entity.Property(e => e.FechaProbable)
                .HasMaxLength(100)
                .HasColumnName("fecha_probable");
            entity.Property(e => e.Fur)
                .HasColumnType("int(11)")
                .HasColumnName("fur");
            entity.Property(e => e.Gestas)
                .HasColumnType("int(11)")
                .HasColumnName("gestas");
            entity.Property(e => e.IdMedEspecialidad)
                .HasMaxLength(255)
                .HasColumnName("id_med_especialidad");
            entity.Property(e => e.Latidos)
                .HasMaxLength(50)
                .HasColumnName("latidos");
            entity.Property(e => e.Menarca)
                .HasColumnType("int(11)")
                .HasColumnName("menarca");
            entity.Property(e => e.MetodoAnticonceptivo)
                .HasMaxLength(50)
                .HasColumnName("metodo_anticonceptivo");
            entity.Property(e => e.Mortinato)
                .HasColumnType("int(11)")
                .HasColumnName("mortinato");
            entity.Property(e => e.Mortineonato)
                .HasColumnType("int(11)")
                .HasColumnName("mortineonato");
            entity.Property(e => e.ObservacionAntGine)
                .HasMaxLength(500)
                .HasColumnName("observacion_ant_gine");
            entity.Property(e => e.ObservacionMetAnt)
                .HasMaxLength(500)
                .HasColumnName("observacion_met_ant");
            entity.Property(e => e.ObservacionSigVitales)
                .HasMaxLength(500)
                .HasColumnName("observacion_sig_vitales");
            entity.Property(e => e.OtraPresentacion)
                .HasMaxLength(500)
                .HasColumnName("otra_presentacion");
            entity.Property(e => e.Papanicolao)
                .HasMaxLength(50)
                .HasColumnName("papanicolao");
            entity.Property(e => e.PartoPretermino)
                .HasColumnType("int(11)")
                .HasColumnName("parto_pretermino");
            entity.Property(e => e.PartoTotales)
                .HasColumnType("int(11)")
                .HasColumnName("parto_totales");
            entity.Property(e => e.PartoVaginal)
                .HasColumnType("int(11)")
                .HasColumnName("parto_vaginal");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(50)
                .HasColumnName("presentacion");
            entity.Property(e => e.Ritmo)
                .HasColumnType("int(11)")
                .HasColumnName("ritmo");
        });

        modelBuilder.Entity<DatoFichaOftalmologiaJsp>(entity =>
        {
            entity.HasKey(e => e.DfoftalmologiaId).HasName("PRIMARY");

            entity.ToTable("dato_ficha_oftalmologia_jsp");

            entity.Property(e => e.DfoftalmologiaId)
                .HasMaxLength(255)
                .HasColumnName("dfoftalmologia_id");
            entity.Property(e => e.Agudeza)
                .HasColumnType("int(11)")
                .HasColumnName("agudeza");
            entity.Property(e => e.Anteojos)
                .HasMaxLength(50)
                .HasColumnName("anteojos");
            entity.Property(e => e.Biomicroscopia)
                .HasMaxLength(50)
                .HasColumnName("biomicroscopia");
            entity.Property(e => e.ExcavacionAo)
                .HasMaxLength(50)
                .HasColumnName("excavacion_ao");
            entity.Property(e => e.ExcavacionDer)
                .HasMaxLength(50)
                .HasColumnName("excavacion_der");
            entity.Property(e => e.ExcavacionIzq)
                .HasMaxLength(50)
                .HasColumnName("excavacion_izq");
            entity.Property(e => e.IdMedEspecialidad)
                .HasMaxLength(255)
                .HasColumnName("id_med_especialidad");
            entity.Property(e => e.LentesContacto)
                .HasMaxLength(50)
                .HasColumnName("lentes_contacto");
            entity.Property(e => e.MaculaAo)
                .HasColumnType("int(11)")
                .HasColumnName("macula_ao");
            entity.Property(e => e.MaculaDer)
                .HasColumnType("int(11)")
                .HasColumnName("macula_der");
            entity.Property(e => e.MaculaIzq)
                .HasColumnType("int(11)")
                .HasColumnName("macula_izq");
            entity.Property(e => e.NeuroOftalmologia)
                .HasMaxLength(50)
                .HasColumnName("neuro_oftalmologia");
            entity.Property(e => e.ObservacionAgudeza)
                .HasMaxLength(500)
                .HasColumnName("observacion_agudeza");
            entity.Property(e => e.ObservacionBiomicroscopia)
                .HasMaxLength(500)
                .HasColumnName("observacion_biomicroscopia");
            entity.Property(e => e.ObservacionMacula)
                .HasMaxLength(500)
                .HasColumnName("observacion_macula");
            entity.Property(e => e.ObservacionNeurooftalmologico)
                .HasMaxLength(500)
                .HasColumnName("observacion_neurooftalmologico");
            entity.Property(e => e.ObservacionPapila)
                .HasMaxLength(500)
                .HasColumnName("observacion_papila");
            entity.Property(e => e.ObservacionRetina)
                .HasMaxLength(500)
                .HasColumnName("observacion_retina");
            entity.Property(e => e.ObservacionTonometria)
                .HasMaxLength(500)
                .HasColumnName("observacion_tonometria");
            entity.Property(e => e.PapilaAo)
                .HasColumnType("int(11)")
                .HasColumnName("papila_ao");
            entity.Property(e => e.PapilaDer)
                .HasColumnType("int(11)")
                .HasColumnName("papila_der");
            entity.Property(e => e.PapilaIzq)
                .HasColumnType("int(11)")
                .HasColumnName("papila_izq");
            entity.Property(e => e.RefObjArf)
                .HasColumnType("int(11)")
                .HasColumnName("ref_obj_arf");
            entity.Property(e => e.RefObjDerechoAv)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_derecho_av");
            entity.Property(e => e.RefObjDerechoCilindro)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_derecho_cilindro");
            entity.Property(e => e.RefObjDerechoEspera)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_derecho_espera");
            entity.Property(e => e.RefObjDerechoGrado)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_derecho_grado");
            entity.Property(e => e.RefObjIzquierdoAv)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_izquierdo_av");
            entity.Property(e => e.RefObjIzquierdoCilindro)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_izquierdo_cilindro");
            entity.Property(e => e.RefObjIzquierdoEspera)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_izquierdo_espera");
            entity.Property(e => e.RefObjIzquierdoGrado)
                .HasMaxLength(20)
                .HasColumnName("ref_obj_izquierdo_grado");
            entity.Property(e => e.RefObjSk)
                .HasColumnType("int(11)")
                .HasColumnName("ref_obj_sk");
            entity.Property(e => e.RefSubdDerechoAv)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_derecho_av");
            entity.Property(e => e.RefSubdDerechoCilindro)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_derecho_cilindro");
            entity.Property(e => e.RefSubdDerechoEspera)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_derecho_espera");
            entity.Property(e => e.RefSubdDerechoGrado)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_derecho_grado");
            entity.Property(e => e.RefSubdIzquierdoAv)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_izquierdo_av");
            entity.Property(e => e.RefSubdIzquierdoCilindro)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_izquierdo_cilindro");
            entity.Property(e => e.RefSubdIzquierdoEspera)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_izquierdo_espera");
            entity.Property(e => e.RefSubdIzquierdoGrado)
                .HasMaxLength(20)
                .HasColumnName("ref_subd_izquierdo_grado");
            entity.Property(e => e.RefSublAdicion)
                .HasColumnType("int(11)")
                .HasColumnName("ref_subl_adicion");
            entity.Property(e => e.RefSublDerechoAv)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_derecho_av");
            entity.Property(e => e.RefSublDerechoCilindro)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_derecho_cilindro");
            entity.Property(e => e.RefSublDerechoEspera)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_derecho_espera");
            entity.Property(e => e.RefSublDerechoGrado)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_derecho_grado");
            entity.Property(e => e.RefSublDistanciaC)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_distancia_c");
            entity.Property(e => e.RefSublDistanciaL)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_distancia_l");
            entity.Property(e => e.RefSublIzquierdoAv)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_izquierdo_av");
            entity.Property(e => e.RefSublIzquierdoCilindro)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_izquierdo_cilindro");
            entity.Property(e => e.RefSublIzquierdoEspera)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_izquierdo_espera");
            entity.Property(e => e.RefSublIzquierdoGrado)
                .HasMaxLength(20)
                .HasColumnName("ref_subl_izquierdo_grado");
            entity.Property(e => e.RetinaAo)
                .HasColumnType("int(11)")
                .HasColumnName("retina_ao");
            entity.Property(e => e.RetinaDer)
                .HasColumnType("int(11)")
                .HasColumnName("retina_der");
            entity.Property(e => e.RetinaIzq)
                .HasColumnType("int(11)")
                .HasColumnName("retina_izq");
            entity.Property(e => e.TonometriaOd)
                .HasMaxLength(20)
                .HasColumnName("tonometria_od");
            entity.Property(e => e.TonometriaOi)
                .HasMaxLength(20)
                .HasColumnName("tonometria_oi");
        });

        modelBuilder.Entity<DatoFichaPsicologiaJsp>(entity =>
        {
            entity.HasKey(e => e.DfpsicologiaId).HasName("PRIMARY");

            entity.ToTable("dato_ficha_psicologia_jsp");

            entity.Property(e => e.DfpsicologiaId)
                .HasMaxLength(255)
                .HasColumnName("dfpsicologia_id");
            entity.Property(e => e.Actividad1)
                .HasMaxLength(100)
                .HasColumnName("actividad1");
            entity.Property(e => e.Actividad2)
                .HasMaxLength(100)
                .HasColumnName("actividad2");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .HasColumnName("estado_civil");
            entity.Property(e => e.IdMedEspecialidad)
                .HasMaxLength(255)
                .HasColumnName("id_med_especialidad");
            entity.Property(e => e.NumHijos)
                .HasColumnType("int(11)")
                .HasColumnName("num_hijos");
            entity.Property(e => e.ObservacionIntervenciones)
                .HasMaxLength(500)
                .HasColumnName("observacion_intervenciones");
            entity.Property(e => e.ObservacionPsicologica)
                .HasMaxLength(500)
                .HasColumnName("observacion_psicologica");
            entity.Property(e => e.ObservacionSintomas)
                .HasMaxLength(500)
                .HasColumnName("observacion_sintomas");
            entity.Property(e => e.Profesion1)
                .HasMaxLength(100)
                .HasColumnName("profesion1");
            entity.Property(e => e.Profesion2)
                .HasMaxLength(100)
                .HasColumnName("profesion2");
            entity.Property(e => e.SintomasPsicologicos)
                .HasMaxLength(50)
                .HasColumnName("sintomas_psicologicos");
        });

        modelBuilder.Entity<Droga>(entity =>
        {
            entity.HasKey(e => e.DroId).HasName("PRIMARY");

            entity.ToTable("drogas");

            entity.Property(e => e.DroId)
                .HasMaxLength(255)
                .HasColumnName("dro_id");
            entity.Property(e => e.DroDetalle)
                .HasMaxLength(100)
                .HasColumnName("dro_detalle");
            entity.Property(e => e.DroEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("dro_estado");
        });

        modelBuilder.Entity<EmbarazoObservacion>(entity =>
        {
            entity.HasKey(e => e.EmbId).HasName("PRIMARY");

            entity.ToTable("embarazo_observacion");

            entity.HasIndex(e => e.RecId, "embarazo_observacion_fk_recepcion");

            entity.Property(e => e.EmbId)
                .HasMaxLength(100)
                .HasColumnName("EMB_ID");
            entity.Property(e => e.EmbDetalle)
                .HasMaxLength(1000)
                .HasColumnName("EMB_DETALLE");
            entity.Property(e => e.EmbSemGestacional).HasColumnName("EMB_SEM_GESTACIONAL");
            entity.Property(e => e.RecId)
                .HasMaxLength(255)
                .HasColumnName("REC_ID");

            entity.HasOne(d => d.Rec).WithMany(p => p.EmbarazoObservacions)
                .HasForeignKey(d => d.RecId)
                .HasConstraintName("embarazo_observacion_fk_recepcion");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("empresa");

            entity.Property(e => e.EsEmpresa)
                .HasColumnType("tinyint(4)")
                .HasColumnName("es_empresa");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(255)
                .HasColumnName("id_empresa");
            entity.Property(e => e.NomEmpresa)
                .HasMaxLength(255)
                .HasColumnName("nom_empresa");
            entity.Property(e => e.OrdenEmpresa)
                .HasColumnType("int(11)")
                .HasColumnName("orden_empresa");
            entity.Property(e => e.RutEmpresa)
                .HasMaxLength(12)
                .HasColumnName("rut_empresa");
        });

        modelBuilder.Entity<Entregaexamene>(entity =>
        {
            entity.HasKey(e => e.EaId).HasName("PRIMARY");

            entity.ToTable("entregaexamenes");

            entity.Property(e => e.EaId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("EA_ID");
            entity.Property(e => e.ChkCd).HasColumnName("chk_cd");
            entity.Property(e => e.ChkExamen).HasColumnName("chk_examen");
            entity.Property(e => e.ChkPaciente).HasColumnName("chk_paciente");
            entity.Property(e => e.ChkPlaca).HasColumnName("chk_placa");
            entity.Property(e => e.EaFechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("ea_fechaEntrega");
            entity.Property(e => e.EaPacNombre)
                .HasMaxLength(255)
                .HasColumnName("ea_pac_nombre");
            entity.Property(e => e.EaPacRut)
                .HasMaxLength(100)
                .HasColumnName("ea_pac_rut");
            entity.Property(e => e.EaRetExamen)
                .HasMaxLength(100)
                .HasColumnName("ea_ret_examen");
            entity.Property(e => e.EaRetNombre)
                .HasMaxLength(255)
                .HasColumnName("ea_ret_nombre");
            entity.Property(e => e.EaRetRut)
                .HasMaxLength(100)
                .HasColumnName("ea_ret_rut");
            entity.Property(e => e.EaUsuId)
                .HasMaxLength(255)
                .HasColumnName("ea_usu_id");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.EspId).HasName("PRIMARY");

            entity.ToTable("especialidad");

            entity.Property(e => e.EspId)
                .HasMaxLength(255)
                .HasColumnName("ESP_ID");
            entity.Property(e => e.EspDescripcion)
                .HasMaxLength(100)
                .HasColumnName("ESP_DESCRIPCION");
        });

        modelBuilder.Entity<EstadoOperacione>(entity =>
        {
            entity.HasKey(e => e.EstId).HasName("PRIMARY");

            entity.ToTable("estado_operaciones");

            entity.Property(e => e.EstId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("EST_ID");
            entity.Property(e => e.EstDetalle)
                .HasMaxLength(45)
                .HasColumnName("EST_DETALLE");
        });

        modelBuilder.Entity<EstadosNumero>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("estados_numeros");

            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .HasColumnName("color");
            entity.Property(e => e.EsnDescripcion)
                .HasMaxLength(45)
                .HasColumnName("ESN_DESCRIPCION");
            entity.Property(e => e.EsnEstado)
                .HasColumnType("int(11)")
                .HasColumnName("ESN_ESTADO");
        });

        modelBuilder.Entity<Etiqueta>(entity =>
        {
            entity.HasKey(e => e.EtiId).HasName("PRIMARY");

            entity.ToTable("etiquetas");

            entity.Property(e => e.EtiId)
                .HasMaxLength(255)
                .HasColumnName("ETI_ID");
            entity.Property(e => e.EtiCodigo)
                .HasMaxLength(45)
                .HasColumnName("ETI_CODIGO");
            entity.Property(e => e.EtiDescripcion)
                .HasMaxLength(45)
                .HasColumnName("ETI_DESCRIPCION");
            entity.Property(e => e.EtiSubDescripcion)
                .HasMaxLength(45)
                .HasColumnName("eti_sub_descripcion");
            entity.Property(e => e.EtiTiempo)
                .HasColumnType("int(3)")
                .HasColumnName("ETI_TIEMPO");
        });

        modelBuilder.Entity<ExamenesPaciente>(entity =>
        {
            entity.HasKey(e => e.IdExamenesPaciente).HasName("PRIMARY");

            entity.ToTable("examenes_paciente");

            entity.HasIndex(e => e.IdExamen, "examenes_paciente_fk_examenes");

            entity.HasIndex(e => e.IdEntrega, "examenes_paciente_fk_paciente");

            entity.Property(e => e.IdExamenesPaciente)
                .HasMaxLength(255)
                .HasColumnName("ID_examenes_paciente");
            entity.Property(e => e.Cd).HasColumnName("cd");
            entity.Property(e => e.IdEntrega)
                .HasMaxLength(255)
                .HasColumnName("id_entrega");
            entity.Property(e => e.IdExamen)
                .HasMaxLength(255)
                .HasColumnName("id_examen");
            entity.Property(e => e.Placa)
                .HasColumnType("tinyint(4)")
                .HasColumnName("placa");
            entity.Property(e => e.SobreCarpeta).HasColumnName("sobre_carpeta");

            entity.HasOne(d => d.IdEntregaNavigation).WithMany(p => p.ExamenesPacientes)
                .HasForeignKey(d => d.IdEntrega)
                .HasConstraintName("examenes_paciente_fk_paciente");

            entity.HasOne(d => d.IdExamenNavigation).WithMany(p => p.ExamenesPacientes)
                .HasForeignKey(d => d.IdExamen)
                .HasConstraintName("examenes_paciente_fk_examenes");
        });

        modelBuilder.Entity<Feriado>(entity =>
        {
            entity.HasKey(e => e.FerId).HasName("PRIMARY");

            entity.ToTable("feriado");

            entity.Property(e => e.FerId)
                .HasMaxLength(255)
                .HasColumnName("FER_ID");
            entity.Property(e => e.FerCreador)
                .HasMaxLength(255)
                .HasColumnName("fer_creador");
            entity.Property(e => e.FerEstado).HasColumnName("FER_ESTADO");
            entity.Property(e => e.FerFechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FER_FECHA_CREACION");
            entity.Property(e => e.FerFechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FER_FECHA_MODIFICACION");
            entity.Property(e => e.FerInicio).HasColumnName("FER_INICIO");
            entity.Property(e => e.FerModificador)
                .HasMaxLength(255)
                .HasColumnName("fer_modificador");
            entity.Property(e => e.FerTitulo)
                .HasMaxLength(100)
                .HasColumnName("FER_TITULO");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.ForId).HasName("PRIMARY");

            entity.ToTable("forma_pago");

            entity.Property(e => e.ForId)
                .HasMaxLength(255)
                .HasColumnName("FOR_ID");
            entity.Property(e => e.ForCodforpag)
                .HasColumnType("int(11)")
                .HasColumnName("FOR_CODFORPAG");
            entity.Property(e => e.ForCreador)
                .HasMaxLength(255)
                .HasColumnName("FOR_CREADOR");
            entity.Property(e => e.ForDetalle)
                .HasMaxLength(100)
                .HasColumnName("FOR_DETALLE");
            entity.Property(e => e.ForEstado).HasColumnName("FOR_ESTADO");
            entity.Property(e => e.ForFechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FOR_FECHA_CREACION");
            entity.Property(e => e.ForFechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FOR_FECHA_MODIFICACION");
            entity.Property(e => e.ForModificador)
                .HasMaxLength(255)
                .HasColumnName("FOR_MODIFICADOR");
            entity.Property(e => e.ForTipo)
                .HasColumnType("int(11)")
                .HasColumnName("FOR_TIPO");
            entity.Property(e => e.ForVuelto)
                .HasColumnType("tinyint(4)")
                .HasColumnName("FOR_VUELTO");
        });

        modelBuilder.Entity<FormaPagoHasCampoPago>(entity =>
        {
            entity.HasKey(e => new { e.FormaPagoForId, e.CampoPagosCamId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("forma_pago_has_campo_pagos");

            entity.HasIndex(e => e.CampoPagosCamId, "fk_forma_pago_has_campo_pagos_campo_pagos1_idx");

            entity.HasIndex(e => e.FormaPagoForId, "fk_forma_pago_has_campo_pagos_forma_pago1_idx");

            entity.Property(e => e.FormaPagoForId)
                .HasMaxLength(255)
                .HasColumnName("forma_pago_FOR_ID");
            entity.Property(e => e.CampoPagosCamId)
                .HasMaxLength(255)
                .HasColumnName("campo_pagos_CAM_ID");
            entity.Property(e => e.ForCamEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("for_cam_estado");
            entity.Property(e => e.ForCamObligatorio).HasColumnName("for_cam_obligatorio");

            entity.HasOne(d => d.CampoPagosCam).WithMany(p => p.FormaPagoHasCampoPagos)
                .HasForeignKey(d => d.CampoPagosCamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_forma_pago_has_campo_pagos_campo_pagos1");

            entity.HasOne(d => d.FormaPagoFor).WithMany(p => p.FormaPagoHasCampoPagos)
                .HasForeignKey(d => d.FormaPagoForId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_forma_pago_has_campo_pagos_forma_pago1");
        });

        modelBuilder.Entity<Garantium>(entity =>
        {
            entity.HasKey(e => e.GarId).HasName("PRIMARY");

            entity.ToTable("garantia");

            entity.HasIndex(e => e.RecepcionRecId, "fk_GARANTIA_recepcion1_idx");

            entity.Property(e => e.GarId)
                .HasMaxLength(255)
                .HasColumnName("GAR_ID");
            entity.Property(e => e.GarCantidad)
                .HasColumnType("int(11)")
                .HasColumnName("GAR_CANTIDAD");
            entity.Property(e => e.GarCreador)
                .HasMaxLength(255)
                .HasColumnName("GAR_CREADOR");
            entity.Property(e => e.GarDescripcion)
                .HasMaxLength(255)
                .HasColumnName("GAR_DESCRIPCION");
            entity.Property(e => e.GarDiasHabiles)
                .HasColumnType("tinyint(4)")
                .HasColumnName("gar_dias_habiles");
            entity.Property(e => e.GarEliminado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("GAR_ELIMINADO");
            entity.Property(e => e.GarEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("gar_estado");
            entity.Property(e => e.GarFecha)
                .HasColumnType("datetime")
                .HasColumnName("GAR_FECHA");
            entity.Property(e => e.GarFechaCreador)
                .HasColumnType("datetime")
                .HasColumnName("GAR_FECHA_CREADOR");
            entity.Property(e => e.GarFechaModificador)
                .HasColumnType("datetime")
                .HasColumnName("GAR_FECHA_MODIFICADOR");
            entity.Property(e => e.GarFolio)
                .HasMaxLength(255)
                .HasColumnName("GAR_FOLIO");
            entity.Property(e => e.GarModificador)
                .HasMaxLength(255)
                .HasColumnName("GAR_MODIFICADOR");
            entity.Property(e => e.GarObs)
                .HasMaxLength(500)
                .HasColumnName("GAR_OBS");
            entity.Property(e => e.GarPrestacion)
                .HasMaxLength(255)
                .HasColumnName("GAR_PRESTACION");
            entity.Property(e => e.GarProCod)
                .HasMaxLength(255)
                .HasColumnName("GAR_PRO_COD");
            entity.Property(e => e.GarRecepcionRegistro)
                .HasMaxLength(255)
                .HasColumnName("GAR_RECEPCION_REGISTRO");
            entity.Property(e => e.GarTotal).HasColumnName("GAR_TOTAL");
            entity.Property(e => e.GarValor).HasColumnName("GAR_VALOR");
            entity.Property(e => e.PrevisionPreId)
                .HasMaxLength(255)
                .HasColumnName("PREVISION_PRE_ID");
            entity.Property(e => e.RecepcionRecId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_REC_ID");
            entity.Property(e => e.SubUnidadSubId)
                .HasMaxLength(255)
                .HasColumnName("SUB_UNIDAD_SUB_ID");

            entity.HasOne(d => d.RecepcionRec).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.RecepcionRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_GARANTIA_recepcion1");
        });

        modelBuilder.Entity<HistoricoPago>(entity =>
        {
            entity.HasKey(e => e.HisId).HasName("PRIMARY");

            entity.ToTable("historico_pagos");

            entity.HasIndex(e => e.RecepcionRecId, "fk_historico_pagos_recepcion1_idx");

            entity.HasIndex(e => e.RegistrosRegId, "fk_historico_pagos_registros1_idx");

            entity.HasIndex(e => e.FormaPagoForId, "historico_pagos_forma_pago_fk");

            entity.Property(e => e.HisId)
                .HasMaxLength(255)
                .HasColumnName("HIS_ID");
            entity.Property(e => e.FormaPagoForId)
                .HasMaxLength(255)
                .HasColumnName("FORMA_PAGO_FOR_ID");
            entity.Property(e => e.HisBanco)
                .HasMaxLength(255)
                .HasColumnName("HIS_BANCO");
            entity.Property(e => e.HisCreador)
                .HasMaxLength(255)
                .HasColumnName("HIS_CREADOR");
            entity.Property(e => e.HisCuotas)
                .HasColumnType("int(11)")
                .HasColumnName("HIS_CUOTAS");
            entity.Property(e => e.HisDctoFuncionarioParticular)
                .HasMaxLength(100)
                .HasColumnName("HIS_DCTO_FUNCIONARIO_PARTICULAR");
            entity.Property(e => e.HisEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("HIS_ESTADO");
            entity.Property(e => e.HisFechaCreador)
                .HasColumnType("datetime")
                .HasColumnName("HIS_FECHA_CREADOR");
            entity.Property(e => e.HisFolio)
                .HasMaxLength(255)
                .HasColumnName("HIS_FOLIO");
            entity.Property(e => e.HisFolioBoleta)
                .HasMaxLength(255)
                .HasColumnName("his_folio_boleta");
            entity.Property(e => e.HisGarantia)
                .HasColumnType("tinyint(4)")
                .HasColumnName("HIS_GARANTIA");
            entity.Property(e => e.HisMonto)
                .HasColumnType("int(11)")
                .HasColumnName("HIS_MONTO");
            entity.Property(e => e.HisNumeroAtencion)
                .HasMaxLength(255)
                .HasColumnName("HIS_NUMERO_ATENCION");
            entity.Property(e => e.HisNumeroCheque)
                .HasMaxLength(255)
                .HasColumnName("HIS_NUMERO_CHEQUE");
            entity.Property(e => e.HisNumeroTarjeta)
                .HasMaxLength(255)
                .HasColumnName("HIS_NUMERO_TARJETA");
            entity.Property(e => e.HisRecepcionRegistro)
                .HasMaxLength(255)
                .HasColumnName("HIS_RECEPCION_REGISTRO");
            entity.Property(e => e.HisSerie)
                .HasMaxLength(255)
                .HasColumnName("HIS_SERIE");
            entity.Property(e => e.HisTipoCuenta)
                .HasMaxLength(255)
                .HasColumnName("HIS_TIPO_CUENTA");
            entity.Property(e => e.RecepcionRecId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_REC_ID");
            entity.Property(e => e.RegistrosRegId)
                .HasMaxLength(255)
                .HasColumnName("registros_REG_ID");
            entity.Property(e => e.Voucher)
                .HasMaxLength(255)
                .HasColumnName("VOUCHER");

            entity.HasOne(d => d.FormaPagoFor).WithMany(p => p.HistoricoPagos)
                .HasForeignKey(d => d.FormaPagoForId)
                .HasConstraintName("historico_pagos_forma_pago_fk");

            entity.HasOne(d => d.RecepcionRec).WithMany(p => p.HistoricoPagos)
                .HasForeignKey(d => d.RecepcionRecId)
                .HasConstraintName("fk_historico_pagos_recepcion1");

            entity.HasOne(d => d.RegistrosReg).WithMany(p => p.HistoricoPagos)
                .HasForeignKey(d => d.RegistrosRegId)
                .HasConstraintName("fk_historico_pagos_registros1");
        });

        modelBuilder.Entity<ImedSoapMessage>(entity =>
        {
            entity.HasKey(e => e.MsgId).HasName("PRIMARY");

            entity.ToTable("imed_soap_messages");

            entity.Property(e => e.MsgId)
                .HasMaxLength(255)
                .HasColumnName("msg_id");
            entity.Property(e => e.MsgDate)
                .HasColumnType("datetime")
                .HasColumnName("msg_date");
            entity.Property(e => e.MsgReference)
                .HasMaxLength(255)
                .HasColumnName("msg_reference");
            entity.Property(e => e.MsgStatus)
                .HasColumnType("int(11)")
                .HasColumnName("msg_status");
            entity.Property(e => e.MsgType)
                .HasMaxLength(10)
                .HasColumnName("msg_type");
            entity.Property(e => e.MsgXml).HasColumnName("msg_xml");
            entity.Property(e => e.RecepcionId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_id");
            entity.Property(e => e.UserRef)
                .HasMaxLength(255)
                .HasColumnName("user_ref");
            entity.Property(e => e.WsMethod)
                .HasMaxLength(25)
                .HasColumnName("ws_method");
        });

        modelBuilder.Entity<LaboratorioRestMessage>(entity =>
        {
            entity.HasKey(e => e.MsgId).HasName("PRIMARY");

            entity.ToTable("laboratorio_rest_messages");

            entity.Property(e => e.MsgId)
                .HasMaxLength(255)
                .HasColumnName("msg_id");
            entity.Property(e => e.MsgDate)
                .HasColumnType("datetime")
                .HasColumnName("msg_date");
            entity.Property(e => e.MsgJson).HasColumnName("msg_json");
            entity.Property(e => e.MsgReference)
                .HasMaxLength(255)
                .HasColumnName("msg_reference");
            entity.Property(e => e.MsgStatus)
                .HasColumnType("int(11)")
                .HasColumnName("msg_status");
            entity.Property(e => e.MsgType)
                .HasMaxLength(10)
                .HasColumnName("msg_type");
            entity.Property(e => e.RecepcionId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_id");
            entity.Property(e => e.UserRef)
                .HasMaxLength(255)
                .HasColumnName("user_ref");
            entity.Property(e => e.WsMethod)
                .HasMaxLength(255)
                .HasColumnName("ws_method");
        });

        modelBuilder.Entity<ListaForPagImed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lista_for_pag_imed");

            entity.Property(e => e.CodAuto).HasMaxLength(20);
            entity.Property(e => e.CodEmi).HasColumnType("int(11)");
            entity.Property(e => e.CodForPag).HasColumnType("int(11)");
            entity.Property(e => e.CodInst).HasColumnType("int(11)");
            entity.Property(e => e.EmiTarBan).HasMaxLength(20);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.MtoTransac).HasColumnType("int(11)");
            entity.Property(e => e.NumDoc).HasMaxLength(20);
            entity.Property(e => e.RecepcionId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_id");
            entity.Property(e => e.UsuarioCreador).HasMaxLength(255);
        });

        modelBuilder.Entity<ListaPagProImed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lista_pag_pro_imed");

            entity.Property(e => e.CodForPagP).HasColumnType("int(11)");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FolioBono).HasColumnType("int(11)");
            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.MtoTransacP).HasColumnType("int(11)");
            entity.Property(e => e.UsuarioCreador).HasMaxLength(255);
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.RemId).HasName("PRIMARY");

            entity
                .ToTable("medicamentos")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.RemId)
                .HasMaxLength(100)
                .HasColumnName("rem_id");
            entity.Property(e => e.RemCondicion)
                .HasMaxLength(100)
                .HasColumnName("rem_condicion");
            entity.Property(e => e.RemNombre)
                .HasMaxLength(255)
                .HasColumnName("rem_nombre");
            entity.Property(e => e.RemProveedor)
                .HasMaxLength(255)
                .HasColumnName("rem_proveedor");
        });

        modelBuilder.Entity<MedicoEspecialidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("medico_especialidad");

            entity.Property(e => e.MedEspDetalle)
                .HasMaxLength(255)
                .HasColumnName("med_esp_detalle")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.MedEspId)
                .HasMaxLength(255)
                .HasColumnName("med_esp_id");
            entity.Property(e => e.MedEspPagina)
                .HasMaxLength(255)
                .HasColumnName("med_esp_pagina")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenId).HasName("PRIMARY");

            entity.ToTable("menu");

            entity.HasIndex(e => e.TipoMenuTipMenId, "fk_MENU_TIPO_MENU1_idx");

            entity.Property(e => e.MenId)
                .HasMaxLength(255)
                .HasColumnName("MEN_ID");
            entity.Property(e => e.MenAccion)
                .HasMaxLength(100)
                .HasColumnName("MEN_ACCION");
            entity.Property(e => e.MenCreador)
                .HasMaxLength(255)
                .HasColumnName("MEN_CREADOR");
            entity.Property(e => e.MenDescripcion)
                .HasMaxLength(250)
                .HasColumnName("MEN_DESCRIPCION");
            entity.Property(e => e.MenEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("MEN_ESTADO");
            entity.Property(e => e.MenFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("MEN_FECHACREACION");
            entity.Property(e => e.MenFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("MEN_FECHAMODIFICACION");
            entity.Property(e => e.MenIcono)
                .HasMaxLength(100)
                .HasColumnName("MEN_ICONO");
            entity.Property(e => e.MenImagen).HasColumnName("men_imagen");
            entity.Property(e => e.MenModificador)
                .HasMaxLength(255)
                .HasColumnName("MEN_MODIFICADOR");
            entity.Property(e => e.MenTitulo)
                .HasMaxLength(100)
                .HasColumnName("MEN_TITULO");
            entity.Property(e => e.TipoMenuTipMenId)
                .HasMaxLength(255)
                .HasColumnName("TIPO_MENU_TIP_MEN_ID");

            entity.HasOne(d => d.TipoMenuTipMen).WithMany(p => p.Menus)
                .HasForeignKey(d => d.TipoMenuTipMenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MENU_TIPO_MENU1");
        });

        modelBuilder.Entity<ModalidadInformacion>(entity =>
        {
            entity.HasKey(e => e.ModId).HasName("PRIMARY");

            entity.ToTable("modalidad_informacion");

            entity.Property(e => e.ModId)
                .HasMaxLength(255)
                .HasColumnName("mod_id");
            entity.Property(e => e.ModDescripcion)
                .HasColumnType("mediumtext")
                .HasColumnName("mod_descripcion");
            entity.Property(e => e.ModDetalle)
                .HasMaxLength(100)
                .HasColumnName("mod_detalle");
        });

        modelBuilder.Entity<ModalidadPcPdf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("modalidad_pc_pdf");

            entity.Property(e => e.ModId)
                .HasMaxLength(255)
                .HasColumnName("mod_id");
            entity.Property(e => e.PcId)
                .HasMaxLength(255)
                .HasColumnName("pc_id");
            entity.Property(e => e.PdfId)
                .HasMaxLength(255)
                .HasColumnName("pdf_id");
        });

        modelBuilder.Entity<MontoCaja>(entity =>
        {
            entity.HasKey(e => e.MontoId).HasName("PRIMARY");

            entity.ToTable("monto_caja");

            entity.HasIndex(e => e.CajaId, "CAJA_ID_idx");

            entity.Property(e => e.MontoId)
                .HasMaxLength(255)
                .HasColumnName("MONTO_ID");
            entity.Property(e => e.CajaId)
                .HasMaxLength(255)
                .HasColumnName("CAJA_ID");
            entity.Property(e => e.Monto)
                .HasColumnType("int(20)")
                .HasColumnName("MONTO");
            entity.Property(e => e.MontoCreador)
                .HasMaxLength(255)
                .HasColumnName("MONTO_CREADOR");
            entity.Property(e => e.MontoFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("MONTO_FECHACREACION");
            entity.Property(e => e.MontoFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("MONTO_FECHAMODIFICACION");
            entity.Property(e => e.MontoModificador)
                .HasMaxLength(255)
                .HasColumnName("MONTO_MODIFICADOR");

            entity.HasOne(d => d.Caja).WithMany(p => p.MontoCajas)
                .HasForeignKey(d => d.CajaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CAJA_ID");
        });

        modelBuilder.Entity<Nacionalidad>(entity =>
        {
            entity.HasKey(e => e.NacId).HasName("PRIMARY");

            entity.ToTable("nacionalidad");

            entity.Property(e => e.NacId)
                .HasMaxLength(255)
                .HasColumnName("NAC_ID");
            entity.Property(e => e.NacCodNeolab)
                .HasMaxLength(50)
                .HasColumnName("NAC_COD_NEOLAB");
            entity.Property(e => e.NacDescripcion)
                .HasMaxLength(100)
                .HasColumnName("NAC_DESCRIPCION");
            entity.Property(e => e.NacPais)
                .HasMaxLength(100)
                .HasColumnName("NAC_PAIS");
        });

        modelBuilder.Entity<Number>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("numbers");

            entity.Property(e => e.N)
                .HasColumnType("int(11)")
                .HasColumnName("n");
        });

        modelBuilder.Entity<Observacione>(entity =>
        {
            entity.HasKey(e => e.ObsId).HasName("PRIMARY");

            entity.ToTable("observaciones");

            entity.HasIndex(e => e.ObsRecId, "observaciones_fk_recepcion");

            entity.Property(e => e.ObsId)
                .HasMaxLength(100)
                .HasColumnName("OBS_ID");
            entity.Property(e => e.ObsDetalle)
                .HasMaxLength(1000)
                .HasColumnName("OBS_DETALLE");
            entity.Property(e => e.ObsRecId)
                .HasMaxLength(255)
                .HasColumnName("OBS_REC_ID");

            entity.HasOne(d => d.ObsRec).WithMany(p => p.Observaciones)
                .HasForeignKey(d => d.ObsRecId)
                .HasConstraintName("observaciones_fk_recepcion");
        });

        modelBuilder.Entity<OperacionesCaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("operaciones_cajas");

            entity.Property(e => e.OpeAccion)
                .HasMaxLength(255)
                .HasColumnName("OPE_ACCION");
            entity.Property(e => e.OpeCreador)
                .HasMaxLength(255)
                .HasColumnName("OPE_CREADOR");
            entity.Property(e => e.OpeEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("OPE_ESTADO");
            entity.Property(e => e.OpeFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("OPE_FECHACREACION");
            entity.Property(e => e.OpeMonto)
                .HasColumnType("float(20,4)")
                .HasColumnName("OPE_MONTO");
            entity.Property(e => e.RegistrosRegId)
                .HasMaxLength(255)
                .HasColumnName("REGISTROS_REG_ID");
        });

        modelBuilder.Entity<OtrasBonificacionesImed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("otras_bonificaciones_imed");

            entity.Property(e => e.CodBonAdic).HasColumnType("int(11)");
            entity.Property(e => e.CodPrestacion).HasMaxLength(20);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FolioBono).HasColumnType("int(11)");
            entity.Property(e => e.GloBonAdic).HasMaxLength(30);
            entity.Property(e => e.MtoBonAdic).HasColumnType("int(11)");
            entity.Property(e => e.UsuarioCreador).HasMaxLength(255);
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.PacId).HasName("PRIMARY");

            entity.ToTable("paciente");

            entity.HasIndex(e => e.NacionalidadNacId, "fk_PACIENTE_NACIONALIDAD1_idx");

            entity.HasIndex(e => e.PrevisionPreId, "fk_PACIENTE_PREVISION1_idx");

            entity.HasIndex(e => e.ConvenioConId, "paciente_convenios_fk");

            entity.Property(e => e.PacId)
                .HasMaxLength(255)
                .HasColumnName("PAC_ID");
            entity.Property(e => e.ComId)
                .HasMaxLength(255)
                .HasColumnName("COM_ID");
            entity.Property(e => e.ConvenioConId)
                .HasMaxLength(255)
                .HasColumnName("convenio_con_id");
            entity.Property(e => e.NacionalidadNacId)
                .HasMaxLength(255)
                .HasColumnName("NACIONALIDAD_NAC_ID");
            entity.Property(e => e.PacApMaterno)
                .HasMaxLength(45)
                .HasColumnName("PAC_AP_MATERNO");
            entity.Property(e => e.PacApPaterno)
                .HasMaxLength(45)
                .HasColumnName("PAC_AP_PATERNO");
            entity.Property(e => e.PacAsmatico)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pac_asmatico");
            entity.Property(e => e.PacBombaInsulina)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pac_bomba_insulina");
            entity.Property(e => e.PacCalle)
                .HasMaxLength(255)
                .HasColumnName("PAC_CALLE");
            entity.Property(e => e.PacComentario)
                .HasMaxLength(500)
                .HasColumnName("PAC_COMENTARIO");
            entity.Property(e => e.PacCorreo)
                .HasMaxLength(45)
                .HasColumnName("PAC_CORREO");
            entity.Property(e => e.PacCreacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("PAC_CREACION");
            entity.Property(e => e.PacCreador)
                .HasMaxLength(255)
                .HasColumnName("PAC_CREADOR");
            entity.Property(e => e.PacDiabetico).HasColumnName("PAC_DIABETICO");
            entity.Property(e => e.PacEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PAC_ESTADO");
            entity.Property(e => e.PacFechaNacimiento).HasColumnName("PAC_FECHA_NACIMIENTO");
            entity.Property(e => e.PacHipertenso).HasColumnName("PAC_HIPERTENSO");
            entity.Property(e => e.PacImplanteCoclear)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pac_implante_coclear");
            entity.Property(e => e.PacInsuficienciarenal).HasColumnName("PAC_INSUFICIENCIARENAL");
            entity.Property(e => e.PacMarcapasos)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pac_marcapasos");
            entity.Property(e => e.PacModificacion)
                .HasColumnType("datetime")
                .HasColumnName("PAC_MODIFICACION");
            entity.Property(e => e.PacModificador)
                .HasMaxLength(255)
                .HasColumnName("PAC_MODIFICADOR");
            entity.Property(e => e.PacNFicha)
                .HasMaxLength(255)
                .HasColumnName("PAC_N_FICHA");
            entity.Property(e => e.PacNeuroestimulador)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pac_neuroestimulador");
            entity.Property(e => e.PacNombres)
                .HasMaxLength(50)
                .HasColumnName("PAC_NOMBRES");
            entity.Property(e => e.PacNumero)
                .HasMaxLength(100)
                .HasColumnName("PAC_NUMERO");
            entity.Property(e => e.PacRut)
                .HasMaxLength(50)
                .HasColumnName("PAC_RUT");
            entity.Property(e => e.PacSexo)
                .HasColumnType("int(11)")
                .HasColumnName("PAC_SEXO");
            entity.Property(e => e.PacSexoC)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("PAC_SEXO_C");
            entity.Property(e => e.PacSobrepeso)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pac_sobrepeso");
            entity.Property(e => e.PacTelCelular)
                .HasMaxLength(20)
                .HasColumnName("PAC_TEL_CELULAR");
            entity.Property(e => e.PacTelCelularOpc)
                .HasMaxLength(20)
                .HasColumnName("PAC_TEL_CELULAR_OPC");
            entity.Property(e => e.PacTelFijo)
                .HasMaxLength(20)
                .HasColumnName("PAC_TEL_FIJO");
            entity.Property(e => e.PacTelFijoOpc)
                .HasMaxLength(20)
                .HasColumnName("PAC_TEL_FIJO_OPC");
            entity.Property(e => e.PacValvulaCardiaca)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pac_valvula_cardiaca");
            entity.Property(e => e.PrevisionPreId)
                .HasMaxLength(255)
                .HasColumnName("PREVISION_PRE_ID");
            entity.Property(e => e.SucNumFicha)
                .HasColumnType("int(11)")
                .HasColumnName("suc_num_ficha");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(1)
                .HasColumnName("TIPO_IDENTIFICACION");

            entity.HasOne(d => d.ConvenioCon).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.ConvenioConId)
                .HasConstraintName("paciente_convenios_fk");

            entity.HasOne(d => d.NacionalidadNac).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.NacionalidadNacId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_PACIENTE_NACIONALIDAD1");

            entity.HasOne(d => d.PrevisionPre).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.PrevisionPreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_PACIENTE_PREVISION1");
        });

        modelBuilder.Entity<ParametrosEtiqueta>(entity =>
        {
            entity.HasKey(e => e.ParEtiId).HasName("PRIMARY");

            entity.ToTable("parametros_etiquetas");

            entity.Property(e => e.ParEtiId)
                .HasMaxLength(255)
                .HasColumnName("PAR_ETI_ID");
            entity.Property(e => e.ParEtiAlt)
                .HasComment("50-100")
                .HasColumnType("int(3)")
                .HasColumnName("PAR_ETI_ALT");
            entity.Property(e => e.ParEtiEsp)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("B/N/R")
                .HasColumnName("PAR_ETI_ESP");
            entity.Property(e => e.ParEtiExpx)
                .HasComment("1/2/3")
                .HasColumnName("PAR_ETI_EXPX");
            entity.Property(e => e.ParEtiExpy)
                .HasComment("1/2/3")
                .HasColumnName("PAR_ETI_EXPY");
            entity.Property(e => e.ParEtiFont)
                .HasComment("TAMANO DE FUENTE 1/3")
                .HasColumnName("PAR_ETI_FONT");
            entity.Property(e => e.ParEtiOrden)
                .HasComment("ORDEN DE IMPRESION ")
                .HasColumnType("tinyint(2)")
                .HasColumnName("PAR_ETI_ORDEN");
            entity.Property(e => e.ParEtiParametro)
                .HasMaxLength(50)
                .HasColumnName("par_eti_parametro");
            entity.Property(e => e.ParEtiPosx)
                .HasComment("POSICION  EJE X 0-500")
                .HasColumnType("int(3)")
                .HasColumnName("PAR_ETI_POSX");
            entity.Property(e => e.ParEtiPosy)
                .HasComment("POSICION EJE Y 0-250")
                .HasColumnType("int(3)")
                .HasColumnName("PAR_ETI_POSY");
            entity.Property(e => e.ParEtiRot)
                .HasComment("ROTACION DE TEXTO  0/1/2/3")
                .HasColumnName("PAR_ETI_ROT");
            entity.Property(e => e.ParEtiTipo)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("A-B")
                .HasColumnName("PAR_ETI_TIPO");
        });

        modelBuilder.Entity<ParametrosEtiquetas1>(entity =>
        {
            entity.HasKey(e => e.ParEtiId).HasName("PRIMARY");

            entity.ToTable("parametros_etiquetas_1");

            entity.Property(e => e.ParEtiId)
                .HasMaxLength(255)
                .HasColumnName("PAR_ETI_ID");
            entity.Property(e => e.ParEtiExpx)
                .HasComment("TAMAÑO EJE X")
                .HasColumnType("int(11)")
                .HasColumnName("PAR_ETI_EXPX");
            entity.Property(e => e.ParEtiExpy)
                .HasComment("TAMAÑO EJE Y")
                .HasColumnType("int(11)")
                .HasColumnName("PAR_ETI_EXPY");
            entity.Property(e => e.ParEtiFin)
                .HasMaxLength(50)
                .HasComment("FIN TEXTO")
                .HasColumnName("PAR_ETI_FIN");
            entity.Property(e => e.ParEtiFont)
                .HasMaxLength(50)
                .HasComment("TAMANO DE FUENTE ")
                .HasColumnName("PAR_ETI_FONT");
            entity.Property(e => e.ParEtiIni)
                .HasMaxLength(50)
                .HasComment("FORMATO Y INICIO TEXTO")
                .HasColumnName("PAR_ETI_INI");
            entity.Property(e => e.ParEtiOrden)
                .HasComment("ORDEN DE IMPRESION ")
                .HasColumnType("tinyint(2)")
                .HasColumnName("PAR_ETI_ORDEN");
            entity.Property(e => e.ParEtiParametro)
                .HasMaxLength(50)
                .HasColumnName("par_eti_parametro");
            entity.Property(e => e.ParEtiPos1)
                .HasComment("POSICION  1")
                .HasColumnType("int(11)")
                .HasColumnName("PAR_ETI_POS1");
            entity.Property(e => e.ParEtiPos2)
                .HasComment("POSICION 2")
                .HasColumnType("int(11)")
                .HasColumnName("PAR_ETI_POS2");
            entity.Property(e => e.ParEtiPos3)
                .HasComment("POSICION 3")
                .HasColumnType("int(11)")
                .HasColumnName("PAR_ETI_POS3");
            entity.Property(e => e.ParEtiTipo)
                .HasMaxLength(50)
                .HasComment("FORMATO DE LINEA")
                .HasColumnName("PAR_ETI_TIPO");
        });

        modelBuilder.Entity<PartesCuerpo>(entity =>
        {
            entity.HasKey(e => e.PcId).HasName("PRIMARY");

            entity.ToTable("partes_cuerpo");

            entity.Property(e => e.PcId)
                .HasMaxLength(255)
                .HasColumnName("pc_id");
            entity.Property(e => e.PcDescripcion)
                .HasMaxLength(100)
                .HasColumnName("pc_descripcion");
        });

        modelBuilder.Entity<PatologiasGe>(entity =>
        {
            entity.HasKey(e => e.PatGesId).HasName("PRIMARY");

            entity.ToTable("patologias_ges");

            entity.Property(e => e.PatGesId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("pat_ges_id");
            entity.Property(e => e.CodigoGes)
                .HasMaxLength(100)
                .HasColumnName("codigo_ges");
            entity.Property(e => e.DescripcionGes)
                .HasMaxLength(500)
                .HasColumnName("descripcion_ges");
        });

        modelBuilder.Entity<PdfAvisosMedico>(entity =>
        {
            entity.HasKey(e => e.PdfId).HasName("PRIMARY");

            entity.ToTable("pdf_avisos_medicos");

            entity.Property(e => e.PdfId)
                .HasMaxLength(255)
                .HasColumnName("pdf_id");
            entity.Property(e => e.Base64).HasColumnName("base_64");
            entity.Property(e => e.Detalle)
                .HasMaxLength(255)
                .HasColumnName("detalle");
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.HasKey(e => e.PerId).HasName("PRIMARY");

            entity.ToTable("perfil");

            entity.Property(e => e.PerId)
                .HasMaxLength(255)
                .HasColumnName("PER_ID");
            entity.Property(e => e.PerCreador)
                .HasMaxLength(255)
                .HasColumnName("PER_CREADOR");
            entity.Property(e => e.PerDashboard)
                .HasMaxLength(100)
                .HasColumnName("PER_DASHBOARD");
            entity.Property(e => e.PerDetalle)
                .HasMaxLength(150)
                .HasColumnName("PER_DETALLE");
            entity.Property(e => e.PerEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PER_ESTADO");
            entity.Property(e => e.PerFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("PER_FECHACREACION");
            entity.Property(e => e.PerFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("PER_FECHAMODIFICACION");
            entity.Property(e => e.PerGestordocumental)
                .HasColumnType("tinyint(4)")
                .HasColumnName("per_gestordocumental");
            entity.Property(e => e.PerIdentificar)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PER_IDENTIFICAR");
            entity.Property(e => e.PerModificador)
                .HasMaxLength(255)
                .HasColumnName("PER_MODIFICADOR");
        });

        modelBuilder.Entity<PreguntasCuestionario>(entity =>
        {
            entity.HasKey(e => e.PreId).HasName("PRIMARY");

            entity.ToTable("preguntas_cuestionario");

            entity.HasIndex(e => e.PreCuestionarioId, "preguntas_cuestionario_cue");

            entity.Property(e => e.PreId)
                .HasMaxLength(255)
                .HasColumnName("PRE_ID");
            entity.Property(e => e.PreCuestionarioId)
                .HasMaxLength(255)
                .HasColumnName("PRE_CUESTIONARIO_ID");
            entity.Property(e => e.PreDetalle)
                .HasMaxLength(100)
                .HasColumnName("PRE_DETALLE");
            entity.Property(e => e.PreIndice)
                .HasColumnType("int(11)")
                .HasColumnName("PRE_INDICE");
            entity.Property(e => e.PreIndiceSec)
                .HasColumnType("int(11)")
                .HasColumnName("PRE_INDICE_SEC");

            entity.HasOne(d => d.PreCuestionario).WithMany(p => p.PreguntasCuestionarios)
                .HasForeignKey(d => d.PreCuestionarioId)
                .HasConstraintName("preguntas_cuestionario_cue");
        });

        modelBuilder.Entity<Prestadore>(entity =>
        {
            entity.HasKey(e => e.PreId).HasName("PRIMARY");

            entity.ToTable("prestadores");

            entity.Property(e => e.PreId)
                .HasMaxLength(255)
                .HasColumnName("PRE_ID");
            entity.Property(e => e.PreRazonSocial)
                .HasMaxLength(45)
                .HasColumnName("PRE_RAZON_SOCIAL");
            entity.Property(e => e.PreRut)
                .HasMaxLength(12)
                .HasColumnName("PRE_RUT");
            entity.Property(e => e.PreTipo)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PRE_TIPO");
        });

        modelBuilder.Entity<Prevision>(entity =>
        {
            entity.HasKey(e => e.PreId).HasName("PRIMARY");

            entity.ToTable("prevision");

            entity.Property(e => e.PreId)
                .HasMaxLength(255)
                .HasColumnName("PRE_ID");
            entity.Property(e => e.Activo)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ACTIVO");
            entity.Property(e => e.CodigoNeolab)
                .HasMaxLength(5)
                .HasColumnName("codigo_neolab");
            entity.Property(e => e.PreCobroLista)
                .HasColumnType("int(11)")
                .HasColumnName("PRE_COBRO_LISTA");
            entity.Property(e => e.PreCodFinanciador)
                .HasColumnType("int(11)")
                .HasColumnName("PRE_COD_FINANCIADOR");
            entity.Property(e => e.PreCodProcedencia)
                .HasMaxLength(100)
                .HasColumnName("pre_cod_procedencia");
            entity.Property(e => e.PreCodigo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("pre_codigo");
            entity.Property(e => e.PreDescipcion)
                .HasMaxLength(45)
                .HasColumnName("PRE_DESCIPCION");
            entity.Property(e => e.PreDocPago)
                .HasDefaultValueSql("'0'")
                .HasComment("Es para realizar el cobro por documento")
                .HasColumnType("tinyint(4)")
                .HasColumnName("pre_doc_pago");
            entity.Property(e => e.PreEspecial)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PRE_ESPECIAL");
            entity.Property(e => e.PreEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pre_estado");
            entity.Property(e => e.PreInformar)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("pre_informar");
            entity.Property(e => e.PrePrograma)
                .HasMaxLength(100)
                .HasColumnName("pre_programa");
            entity.Property(e => e.RepOrd)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("REP_ORD");
            entity.Property(e => e.TipoLista)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0'")
                .HasColumnName("TIPO_LISTA");
        });

        modelBuilder.Entity<Procedimiento>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("PRIMARY");

            entity.ToTable("procedimiento");

            entity.HasIndex(e => e.PcId, "procedimiento_partes_cuerpo_fk");

            entity.HasIndex(e => e.ProModalidadId, "procedimiento_procedimiento_modalidad_fk");

            entity.Property(e => e.ProId)
                .HasMaxLength(255)
                .HasColumnName("PRO_ID");
            entity.Property(e => e.CodItemPrest)
                .HasColumnType("int(11)")
                .HasColumnName("cod_item_prest");
            entity.Property(e => e.FechaActualizacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.PcId)
                .HasMaxLength(255)
                .HasColumnName("pc_id");
            entity.Property(e => e.ProAgendable)
                .HasMaxLength(255)
                .HasColumnName("PRO_AGENDABLE");
            entity.Property(e => e.ProCantidad)
                .HasMaxLength(255)
                .HasColumnName("PRO_CANTIDAD");
            entity.Property(e => e.ProCobro)
                .HasMaxLength(255)
                .HasColumnName("PRO_COBRO");
            entity.Property(e => e.ProCodigo)
                .HasMaxLength(255)
                .HasColumnName("PRO_CODIGO");
            entity.Property(e => e.ProCodigoNeolab)
                .HasMaxLength(20)
                .HasColumnName("pro_codigo_neolab");
            entity.Property(e => e.ProEnvioWll)
                .HasMaxLength(150)
                .HasColumnName("pro_envio_wll");
            entity.Property(e => e.ProEspecial)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PRO_ESPECIAL");
            entity.Property(e => e.ProEstado)
                .HasColumnType("int(11)")
                .HasColumnName("PRO_ESTADO");
            entity.Property(e => e.ProEstadoMc).HasColumnName("pro_estado_mc");
            entity.Property(e => e.ProEtiqueta)
                .HasMaxLength(255)
                .HasColumnName("PRO_ETIQUETA");
            entity.Property(e => e.ProMContraste)
                .HasMaxLength(255)
                .HasColumnName("PRO_M_CONTRASTE");
            entity.Property(e => e.ProModalidadId)
                .HasMaxLength(255)
                .HasColumnName("pro_modalidad_id");
            entity.Property(e => e.ProNomInterno)
                .HasMaxLength(255)
                .HasColumnName("PRO_NOM_INTERNO");
            entity.Property(e => e.ProParticular)
                .HasMaxLength(255)
                .HasColumnName("PRO_PARTICULAR");
            entity.Property(e => e.ProPreventa)
                .HasMaxLength(255)
                .HasColumnName("PRO_PREVENTA");
            entity.Property(e => e.ProRutTributario)
                .HasMaxLength(12)
                .HasColumnName("pro_rut_tributario");
            entity.Property(e => e.ProTiempoEspera)
                .HasMaxLength(255)
                .HasColumnName("PRO_TIEMPO_ESPERA");

            entity.HasOne(d => d.Pc).WithMany(p => p.Procedimientos)
                .HasForeignKey(d => d.PcId)
                .HasConstraintName("procedimiento_partes_cuerpo_fk");

            entity.HasOne(d => d.ProModalidad).WithMany(p => p.Procedimientos)
                .HasForeignKey(d => d.ProModalidadId)
                .HasConstraintName("procedimiento_procedimiento_modalidad_fk");
        });

        modelBuilder.Entity<Procedimiento1>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("PRIMARY");

            entity.ToTable("procedimiento_1");

            entity.HasIndex(e => e.PcId, "procedimiento_partes_cuerpo_fk");

            entity.HasIndex(e => e.ProModalidadId, "procedimiento_procedimiento_modalidad_fk");

            entity.Property(e => e.ProId)
                .HasMaxLength(255)
                .HasColumnName("PRO_ID");
            entity.Property(e => e.PcId)
                .HasMaxLength(255)
                .HasColumnName("pc_id");
            entity.Property(e => e.ProAgendable)
                .HasMaxLength(255)
                .HasColumnName("PRO_AGENDABLE");
            entity.Property(e => e.ProCantidad)
                .HasMaxLength(255)
                .HasColumnName("PRO_CANTIDAD");
            entity.Property(e => e.ProCobro)
                .HasMaxLength(255)
                .HasColumnName("PRO_COBRO");
            entity.Property(e => e.ProCodigo)
                .HasMaxLength(255)
                .HasColumnName("PRO_CODIGO");
            entity.Property(e => e.ProEspecial)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PRO_ESPECIAL");
            entity.Property(e => e.ProEstado)
                .HasColumnType("int(11)")
                .HasColumnName("PRO_ESTADO");
            entity.Property(e => e.ProEstadoMc).HasColumnName("pro_estado_mc");
            entity.Property(e => e.ProEtiqueta)
                .HasMaxLength(255)
                .HasColumnName("PRO_ETIQUETA");
            entity.Property(e => e.ProMContraste)
                .HasMaxLength(255)
                .HasColumnName("PRO_M_CONTRASTE");
            entity.Property(e => e.ProModalidadId)
                .HasMaxLength(255)
                .HasColumnName("pro_modalidad_id");
            entity.Property(e => e.ProNomInterno)
                .HasMaxLength(255)
                .HasColumnName("PRO_NOM_INTERNO");
            entity.Property(e => e.ProParticular)
                .HasMaxLength(255)
                .HasColumnName("PRO_PARTICULAR");
            entity.Property(e => e.ProPreventa)
                .HasMaxLength(255)
                .HasColumnName("PRO_PREVENTA");
            entity.Property(e => e.ProTiempoEspera)
                .HasMaxLength(255)
                .HasColumnName("PRO_TIEMPO_ESPERA");

            entity.HasOne(d => d.Pc).WithMany(p => p.Procedimiento1s)
                .HasForeignKey(d => d.PcId)
                .HasConstraintName("procedimiento_partes_cuerpo_fk_copy");

            entity.HasOne(d => d.ProModalidad).WithMany(p => p.Procedimiento1s)
                .HasForeignKey(d => d.ProModalidadId)
                .HasConstraintName("procedimiento_procedimiento_modalidad_fk_copy");
        });

        modelBuilder.Entity<ProcedimientoHasProfesional>(entity =>
        {
            entity.HasKey(e => new { e.ProcedimientoProId, e.ProfesionalProId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("procedimiento_has_profesional");

            entity.HasIndex(e => e.ProcedimientoProId, "fk_procedimiento_has_profesional_procedimiento1_idx");

            entity.HasIndex(e => e.ProfesionalProId, "fk_procedimiento_has_profesional_profesional1_idx");

            entity.Property(e => e.ProcedimientoProId)
                .HasMaxLength(255)
                .HasColumnName("procedimiento_PRO_ID");
            entity.Property(e => e.ProfesionalProId)
                .HasMaxLength(255)
                .HasColumnName("profesional_PRO_ID");
            entity.Property(e => e.Duracion)
                .HasColumnType("int(3)")
                .HasColumnName("duracion");

            entity.HasOne(d => d.ProcedimientoPro).WithMany(p => p.ProcedimientoHasProfesionals)
                .HasForeignKey(d => d.ProcedimientoProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_procedimiento_has_profesional_procedimiento1");

            entity.HasOne(d => d.ProfesionalPro).WithMany(p => p.ProcedimientoHasProfesionals)
                .HasForeignKey(d => d.ProfesionalProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_procedimiento_has_profesional_profesional1");
        });

        modelBuilder.Entity<ProcedimientoModalidad>(entity =>
        {
            entity.HasKey(e => e.ProModalidadId).HasName("PRIMARY");

            entity.ToTable("procedimiento_modalidad");

            entity.Property(e => e.ProModalidadId)
                .HasMaxLength(255)
                .HasColumnName("pro_modalidad_id");
            entity.Property(e => e.ProAcronimo)
                .HasMaxLength(100)
                .HasColumnName("pro_acronimo");
            entity.Property(e => e.ProModalidadDescripcion)
                .HasMaxLength(100)
                .HasColumnName("pro_modalidad_descripcion");
            entity.Property(e => e.ProTipo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("pro_tipo");

            entity.HasMany(d => d.ModalidadInformacionMods).WithMany(p => p.ProcedimientoModalidadProModalidads)
                .UsingEntity<Dictionary<string, object>>(
                    "ProcedimientoModalidadHasModalidadInformacion",
                    r => r.HasOne<ModalidadInformacion>().WithMany()
                        .HasForeignKey("ModalidadInformacionModId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_procedimiento_modalidad_has_modalidad_informacion_modalida1"),
                    l => l.HasOne<ProcedimientoModalidad>().WithMany()
                        .HasForeignKey("ProcedimientoModalidadProModalidadId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_procedimiento_modalidad_has_modalidad_informacion_procedim1"),
                    j =>
                    {
                        j.HasKey("ProcedimientoModalidadProModalidadId", "ModalidadInformacionModId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("procedimiento_modalidad_has_modalidad_informacion");
                        j.HasIndex(new[] { "ModalidadInformacionModId" }, "fk_procedimiento_modalidad_has_modalidad_informacion_modali_idx");
                        j.HasIndex(new[] { "ProcedimientoModalidadProModalidadId" }, "fk_procedimiento_modalidad_has_modalidad_informacion_proced_idx");
                        j.IndexerProperty<string>("ProcedimientoModalidadProModalidadId")
                            .HasMaxLength(255)
                            .HasColumnName("procedimiento_modalidad_pro_modalidad_id");
                        j.IndexerProperty<string>("ModalidadInformacionModId")
                            .HasMaxLength(255)
                            .HasColumnName("modalidad_informacion_mod_id");
                    });
        });

        modelBuilder.Entity<ProcedimientoValidacion>(entity =>
        {
            entity.HasKey(e => e.PvId).HasName("PRIMARY");

            entity.ToTable("procedimiento_validacion");

            entity.Property(e => e.PvId)
                .HasMaxLength(255)
                .HasColumnName("pv_id");
            entity.Property(e => e.PvDescripcion)
                .HasMaxLength(255)
                .HasColumnName("pv_descripcion");
            entity.Property(e => e.PvDiabetes).HasColumnName("pv_diabetes");
            entity.Property(e => e.PvEdad)
                .HasColumnType("tinyint(2)")
                .HasColumnName("pv_edad");
            entity.Property(e => e.PvHipertenso).HasColumnName("pv_hipertenso");
            entity.Property(e => e.PvInsuficienciaRenal).HasColumnName("pv_insuficienciaRenal");
            entity.Property(e => e.PvMc).HasColumnName("pv_mc");
            entity.Property(e => e.PvOrden)
                .HasComment("Restriccion de las nuevas validaciones del paciente.")
                .HasColumnType("int(11)")
                .HasColumnName("pv_orden");
            entity.Property(e => e.PvTipo).HasColumnName("pv_tipo");
        });

        modelBuilder.Entity<ProcedimientosNeolab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("procedimientos_neolab");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Fonasa)
                .HasMaxLength(20)
                .HasColumnName("fonasa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Profesional>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("PRIMARY");

            entity.ToTable("profesional");

            entity.HasIndex(e => e.NacionalidadNacId, "fk_PROFESIONAL_NACIONALIDAD1_idx");

            entity.Property(e => e.ProId)
                .HasMaxLength(255)
                .HasColumnName("PRO_ID");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(1000)
                .HasColumnName("comentarios");
            entity.Property(e => e.Frecuencia)
                .HasMaxLength(2)
                .HasColumnName("frecuencia");
            entity.Property(e => e.MedEspId)
                .HasMaxLength(255)
                .HasColumnName("med_esp_id");
            entity.Property(e => e.NacionalidadNacId)
                .HasMaxLength(255)
                .HasColumnName("NACIONALIDAD_NAC_ID");
            entity.Property(e => e.ProApMaterno)
                .HasMaxLength(45)
                .HasColumnName("PRO_AP_MATERNO");
            entity.Property(e => e.ProApPaterno)
                .HasMaxLength(45)
                .HasColumnName("PRO_AP_PATERNO");
            entity.Property(e => e.ProCreador)
                .HasMaxLength(255)
                .HasColumnName("PRO_CREADOR");
            entity.Property(e => e.ProEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("PRO_ESTADO");
            entity.Property(e => e.ProFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("PRO_FECHACREACION");
            entity.Property(e => e.ProFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("PRO_FECHAMODIFICACION");
            entity.Property(e => e.ProFirma).HasColumnName("pro_firma");
            entity.Property(e => e.ProModificador)
                .HasMaxLength(255)
                .HasColumnName("PRO_MODIFICADOR");
            entity.Property(e => e.ProNombres)
                .HasMaxLength(100)
                .HasColumnName("PRO_NOMBRES");
            entity.Property(e => e.ProRnpi)
                .HasMaxLength(100)
                .HasColumnName("pro_rnpi");
            entity.Property(e => e.ProRut)
                .HasMaxLength(45)
                .HasColumnName("PRO_RUT");
            entity.Property(e => e.ProSobrecupo)
                .HasColumnType("int(11)")
                .HasColumnName("PRO_SOBRECUPO");
            entity.Property(e => e.ProTipo)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pro_tipo");

            entity.HasOne(d => d.NacionalidadNac).WithMany(p => p.Profesionals)
                .HasForeignKey(d => d.NacionalidadNacId)
                .HasConstraintName("fk_PROFESIONAL_NACIONALIDAD1");

            entity.HasMany(d => d.EspecialidadEsps).WithMany(p => p.ProfesionalPros)
                .UsingEntity<Dictionary<string, object>>(
                    "ProfesionalHasEspecialidad",
                    r => r.HasOne<Especialidad>().WithMany()
                        .HasForeignKey("EspecialidadEspId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_PROFESIONAL_has_ESPECIALIDAD_ESPECIALIDAD1"),
                    l => l.HasOne<Profesional>().WithMany()
                        .HasForeignKey("ProfesionalProId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_PROFESIONAL_has_ESPECIALIDAD_PROFESIONAL1"),
                    j =>
                    {
                        j.HasKey("ProfesionalProId", "EspecialidadEspId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("profesional_has_especialidad");
                        j.HasIndex(new[] { "EspecialidadEspId" }, "fk_PROFESIONAL_has_ESPECIALIDAD_ESPECIALIDAD1_idx");
                        j.HasIndex(new[] { "ProfesionalProId" }, "fk_PROFESIONAL_has_ESPECIALIDAD_PROFESIONAL1_idx");
                        j.IndexerProperty<string>("ProfesionalProId")
                            .HasMaxLength(255)
                            .HasColumnName("PROFESIONAL_PRO_ID");
                        j.IndexerProperty<string>("EspecialidadEspId")
                            .HasMaxLength(255)
                            .HasColumnName("ESPECIALIDAD_ESP_ID");
                    });
        });

        modelBuilder.Entity<ProfesionalHasSucursalHasSubUnidad>(entity =>
        {
            entity.HasKey(e => e.ProRelId).HasName("PRIMARY");

            entity.ToTable("profesional_has_sucursal_has_sub_unidad");

            entity.HasIndex(e => e.ProfesionalProId, "fk_profesional_has_sucursal_has_sub_unidad_profesional1_idx");

            entity.HasIndex(e => e.SucursalHasSubUnidadSucSubId, "fk_profesional_has_sucursal_has_sub_unidad_sucursal_has_sub_idx");

            entity.Property(e => e.ProRelId)
                .HasMaxLength(255)
                .HasColumnName("PRO_REL_ID");
            entity.Property(e => e.ProfesionalProId)
                .HasMaxLength(255)
                .HasColumnName("profesional_PRO_ID");
            entity.Property(e => e.SucursalHasSubUnidadSucSubId)
                .HasMaxLength(255)
                .HasColumnName("sucursal_has_sub_unidad_SUC_SUB_ID");

            entity.HasOne(d => d.ProfesionalPro).WithMany(p => p.ProfesionalHasSucursalHasSubUnidads)
                .HasForeignKey(d => d.ProfesionalProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesional_has_sucursal_has_sub_unidad_profesional1");

            entity.HasOne(d => d.SucursalHasSubUnidadSucSub).WithMany(p => p.ProfesionalHasSucursalHasSubUnidads)
                .HasForeignKey(d => d.SucursalHasSubUnidadSucSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesional_has_sucursal_has_sub_unidad_sucursal_has_sub_u1");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("PRIMARY");

            entity.ToTable("provincia");

            entity.HasIndex(e => e.RegionRegId, "fk_PROVINCIA_REGION_idx");

            entity.Property(e => e.ProId)
                .HasMaxLength(255)
                .HasColumnName("PRO_ID");
            entity.Property(e => e.ProDetalle)
                .HasMaxLength(100)
                .HasColumnName("PRO_DETALLE");
            entity.Property(e => e.RegionRegId)
                .HasMaxLength(255)
                .HasColumnName("REGION_REG_ID");

            entity.HasOne(d => d.RegionReg).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.RegionRegId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_PROVINCIA_REGION");
        });

        modelBuilder.Entity<Recepcion>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PRIMARY");

            entity.ToTable("recepcion");

            entity.HasIndex(e => e.PacientePacId, "fk_recepcion_paciente1_idx");

            entity.HasIndex(e => e.PrestadoresPreId, "fk_recepcion_prestadores1_idx");

            entity.HasIndex(e => e.PrevisionPreId, "fk_recepcion_prevision1_idx");

            entity.HasIndex(e => e.ConveniosConId, "recepcion_convenios_fk");

            entity.HasIndex(e => e.RegistrosRegId, "recepcion_registros_fk");

            entity.Property(e => e.RecId)
                .HasMaxLength(255)
                .HasColumnName("REC_ID");
            entity.Property(e => e.AsociadoAsoId)
                .HasMaxLength(100)
                .HasColumnName("asociado_aso_id");
            entity.Property(e => e.ConveniosConId)
                .HasMaxLength(255)
                .HasColumnName("convenios_con_id");
            entity.Property(e => e.PacientePacId)
                .HasMaxLength(255)
                .HasColumnName("paciente_PAC_ID");
            entity.Property(e => e.PrestadoresPreId)
                .HasMaxLength(255)
                .HasColumnName("prestadores_PRE_ID");
            entity.Property(e => e.PrevisionPreId)
                .HasMaxLength(255)
                .HasColumnName("prevision_PRE_ID");
            entity.Property(e => e.ProfesionalId)
                .HasMaxLength(255)
                .HasColumnName("profesional_id");
            entity.Property(e => e.RecCodAuditoria)
                .HasMaxLength(255)
                .HasColumnName("REC_COD_AUDITORIA");
            entity.Property(e => e.RecComentario)
                .HasMaxLength(500)
                .HasColumnName("rec_comentario");
            entity.Property(e => e.RecCopagoEspecialBono).HasColumnName("rec_copago_especial_bono");
            entity.Property(e => e.RecEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("REC_ESTADO");
            entity.Property(e => e.RecEstadoConsulta)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("rec_estado_consulta");
            entity.Property(e => e.RecEstadoEntrega)
                .HasColumnType("tinyint(4)")
                .HasColumnName("rec_estado_entrega");
            entity.Property(e => e.RecFechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("rec_fecha_modificacion");
            entity.Property(e => e.RecHoraRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("REC_HORA_RECEPCION");
            entity.Property(e => e.RecMontoBoleta).HasColumnName("rec_monto_boleta");
            entity.Property(e => e.RecMontoFonasa).HasColumnName("rec_monto_fonasa");
            entity.Property(e => e.RecMontoGarantia).HasColumnName("rec_monto_garantia");
            entity.Property(e => e.RecNAtencion)
                .HasColumnType("int(8)")
                .HasColumnName("REC_N_ATENCION");
            entity.Property(e => e.RecNTransaccion)
                .HasMaxLength(255)
                .HasColumnName("REC_N_TRANSACCION");
            entity.Property(e => e.RecNumeroTotem)
                .HasMaxLength(45)
                .HasColumnName("REC_NUMERO_TOTEM");
            entity.Property(e => e.RecObs)
                .HasMaxLength(500)
                .HasColumnName("REC_OBS");
            entity.Property(e => e.RecSaldo).HasColumnName("rec_saldo");
            entity.Property(e => e.RecUltimoEstado)
                .HasColumnType("int(11)")
                .HasColumnName("REC_ULTIMO_ESTADO");
            entity.Property(e => e.RecValidarAsociado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("rec_validar_asociado");
            entity.Property(e => e.RegistrosRegId)
                .HasMaxLength(255)
                .HasColumnName("REGISTROS_REG_ID");
            entity.Property(e => e.RegistrosRegIdModificador)
                .HasMaxLength(100)
                .HasColumnName("registros_reg_id_modificador");

            entity.HasOne(d => d.ConveniosCon).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.ConveniosConId)
                .HasConstraintName("recepcion_convenios_fk");

            entity.HasOne(d => d.PacientePac).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.PacientePacId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recepcion_paciente1");

            entity.HasOne(d => d.PrestadoresPre).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.PrestadoresPreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recepcion_prestadores1");

            entity.HasOne(d => d.PrevisionPre).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.PrevisionPreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recepcion_prevision1");

            entity.HasOne(d => d.RegistrosReg).WithMany(p => p.Recepcions)
                .HasForeignKey(d => d.RegistrosRegId)
                .HasConstraintName("recepcion_registros_fk");
        });

        modelBuilder.Entity<RecepcionHasProcedimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recepcion_has_procedimiento");

            entity.HasIndex(e => e.ProcedimientoProId, "fk_recepcion_has_procedimiento_procedimiento1_idx");

            entity.HasIndex(e => e.RecepcionRecId, "fk_recepcion_has_procedimiento_recepcion1_idx");

            entity.Property(e => e.Eliminado)
                .HasColumnType("int(11)")
                .HasColumnName("eliminado");
            entity.Property(e => e.ProcedimientoProId)
                .HasMaxLength(255)
                .HasColumnName("procedimiento_PRO_ID");
            entity.Property(e => e.RecHProHoraFin)
                .HasColumnType("datetime")
                .HasColumnName("REC_H_PRO_HORA_FIN");
            entity.Property(e => e.RecHProHoraInicio)
                .HasColumnType("datetime")
                .HasColumnName("REC_H_PRO_HORA_INICIO");
            entity.Property(e => e.RecMContraste)
                .HasMaxLength(255)
                .HasColumnName("rec_m_contraste");
            entity.Property(e => e.RecepcionRecId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_REC_ID");
            entity.Property(e => e.SubUnidadSubId)
                .HasMaxLength(255)
                .HasColumnName("sub_unidad_sub_id");

            entity.HasOne(d => d.ProcedimientoPro).WithMany()
                .HasForeignKey(d => d.ProcedimientoProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recepcion_has_procedimiento_procedimiento1");

            entity.HasOne(d => d.RecepcionRec).WithMany()
                .HasForeignKey(d => d.RecepcionRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recepcion_has_procedimiento_recepcion1");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegId).HasName("PRIMARY");

            entity.ToTable("region");

            entity.Property(e => e.RegId)
                .HasMaxLength(255)
                .HasColumnName("REG_ID");
            entity.Property(e => e.RegDetalle)
                .HasMaxLength(100)
                .HasColumnName("REG_DETALLE");
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.RegId).HasName("PRIMARY");

            entity.ToTable("registros");

            entity.Property(e => e.RegId)
                .HasMaxLength(255)
                .HasColumnName("REG_ID");
            entity.Property(e => e.CajaCajId)
                .HasMaxLength(255)
                .HasColumnName("CAJA_CAJ_ID");
            entity.Property(e => e.RegCantidadCheque)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("REG_CANTIDAD_CHEQUE");
            entity.Property(e => e.RegCantidadCredito)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("REG_CANTIDAD_CREDITO");
            entity.Property(e => e.RegCantidadDebito)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("REG_CANTIDAD_DEBITO");
            entity.Property(e => e.RegCantidadGarantia)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("REG_CANTIDAD_GARANTIA");
            entity.Property(e => e.RegCantidadOtros)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("REG_CANTIDAD_OTROS");
            entity.Property(e => e.RegCantidadPagare)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("REG_CANTIDAD_PAGARE");
            entity.Property(e => e.RegComentario)
                .HasColumnType("text")
                .HasColumnName("REG_COMENTARIO");
            entity.Property(e => e.RegEstado)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("REG_ESTADO");
            entity.Property(e => e.RegFechaApertura)
                .HasColumnType("datetime")
                .HasColumnName("REG_FECHA_APERTURA");
            entity.Property(e => e.RegFechaCierre)
                .HasColumnType("datetime")
                .HasColumnName("REG_FECHA_CIERRE");
            entity.Property(e => e.RegFechaSolicitudCierre)
                .HasColumnType("datetime")
                .HasColumnName("REG_FECHA_SOLICITUD_CIERRE");
            entity.Property(e => e.RegMontoAjuste).HasColumnName("REG_MONTO_AJUSTE");
            entity.Property(e => e.RegMontoCheque)
                .HasDefaultValueSql("'0'")
                .HasColumnName("REG_MONTO_CHEQUE");
            entity.Property(e => e.RegMontoCredito)
                .HasDefaultValueSql("'0'")
                .HasColumnName("REG_MONTO_CREDITO");
            entity.Property(e => e.RegMontoDebito)
                .HasDefaultValueSql("'0'")
                .HasColumnName("REG_MONTO_DEBITO");
            entity.Property(e => e.RegMontoEfectivo).HasColumnName("REG_MONTO_EFECTIVO");
            entity.Property(e => e.RegMontoGarantia)
                .HasDefaultValueSql("'0'")
                .HasColumnName("REG_MONTO_GARANTIA");
            entity.Property(e => e.RegMontoOtros)
                .HasDefaultValueSql("'0'")
                .HasColumnName("REG_MONTO_OTROS");
            entity.Property(e => e.RegMontoPagare)
                .HasDefaultValueSql("'0'")
                .HasColumnName("REG_MONTO_PAGARE");
            entity.Property(e => e.RegMontoPrestamo).HasColumnName("REG_MONTO_PRESTAMO");
            entity.Property(e => e.RegNumDocDeposito)
                .HasMaxLength(100)
                .HasColumnName("reg_num_doc_deposito");
            entity.Property(e => e.RegUsuCierre)
                .HasMaxLength(255)
                .HasColumnName("REG_USU_CIERRE");
            entity.Property(e => e.UsuarioUsuId)
                .HasMaxLength(255)
                .HasColumnName("USUARIO_USU_ID");
        });

        modelBuilder.Entity<RespuestasLlamada>(entity =>
        {
            entity.HasKey(e => e.ResId).HasName("PRIMARY");

            entity.ToTable("respuestas_llamadas");

            entity.Property(e => e.ResId)
                .HasMaxLength(255)
                .HasColumnName("res_id");
            entity.Property(e => e.ResDescripcion)
                .HasMaxLength(255)
                .HasColumnName("res_descripcion");
        });

        modelBuilder.Entity<ResultadosExamene>(entity =>
        {
            entity.HasKey(e => e.ResId).HasName("PRIMARY");

            entity.ToTable("resultados_examenes");

            entity.HasIndex(e => e.ResRecepcionId, "resultados_examenes");

            entity.Property(e => e.ResId)
                .HasMaxLength(255)
                .HasColumnName("RES_ID");
            entity.Property(e => e.ResNomExamen)
                .HasMaxLength(255)
                .HasColumnName("RES_NOM_EXAMEN");
            entity.Property(e => e.ResRecepcionId)
                .HasMaxLength(255)
                .HasColumnName("RES_RECEPCION_ID");
            entity.Property(e => e.ResResultado)
                .HasMaxLength(500)
                .HasColumnName("RES_RESULTADO");

            entity.HasOne(d => d.ResRecepcion).WithMany(p => p.ResultadosExamenes)
                .HasForeignKey(d => d.ResRecepcionId)
                .HasConstraintName("resultados_examenes");
        });

        modelBuilder.Entity<RetiroExamene>(entity =>
        {
            entity.HasKey(e => e.RetId).HasName("PRIMARY");

            entity.ToTable("retiro_examenes");

            entity.HasIndex(e => e.RecepcionRecId, "fk_retiro_examenes_recepcion1_idx");

            entity.Property(e => e.RetId)
                .HasMaxLength(100)
                .HasColumnName("ret_id");
            entity.Property(e => e.RecepcionRecId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_REC_ID");
            entity.Property(e => e.RetApeMaterno)
                .HasMaxLength(255)
                .HasColumnName("ret_ape_materno");
            entity.Property(e => e.RetApePaterno)
                .HasMaxLength(255)
                .HasColumnName("ret_ape_paterno");
            entity.Property(e => e.RetFechaRetiro)
                .HasColumnType("datetime")
                .HasColumnName("ret_fecha_retiro");
            entity.Property(e => e.RetNombres)
                .HasMaxLength(255)
                .HasColumnName("ret_nombres");
            entity.Property(e => e.RetPacApeMaterno)
                .HasMaxLength(255)
                .HasColumnName("ret_pac_ape_materno");
            entity.Property(e => e.RetPacApePaterno)
                .HasMaxLength(255)
                .HasColumnName("ret_pac_ape_paterno");
            entity.Property(e => e.RetPacNombres)
                .HasMaxLength(255)
                .HasColumnName("ret_pac_nombres");
            entity.Property(e => e.RetPacRut)
                .HasMaxLength(100)
                .HasColumnName("ret_pac_rut");
            entity.Property(e => e.RetRut)
                .HasMaxLength(100)
                .HasColumnName("ret_rut");

            entity.HasOne(d => d.RecepcionRec).WithMany(p => p.RetiroExamenes)
                .HasForeignKey(d => d.RecepcionRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_retiro_examenes_recepcion1");
        });

        modelBuilder.Entity<SoftlandSoapMessage>(entity =>
        {
            entity.HasKey(e => e.MsgId).HasName("PRIMARY");

            entity.ToTable("softland_soap_messages");

            entity.Property(e => e.MsgId)
                .HasMaxLength(255)
                .HasColumnName("msg_id");
            entity.Property(e => e.MsgDate)
                .HasColumnType("datetime")
                .HasColumnName("msg_date");
            entity.Property(e => e.MsgReference)
                .HasMaxLength(255)
                .HasColumnName("msg_reference");
            entity.Property(e => e.MsgStatus)
                .HasColumnType("int(11)")
                .HasColumnName("msg_status");
            entity.Property(e => e.MsgType)
                .HasMaxLength(10)
                .HasColumnName("msg_type");
            entity.Property(e => e.MsgXml).HasColumnName("msg_xml");
            entity.Property(e => e.RecepcionId)
                .HasMaxLength(255)
                .HasColumnName("recepcion_id");
            entity.Property(e => e.UserRef)
                .HasMaxLength(255)
                .HasColumnName("user_ref");
            entity.Property(e => e.WsMethod)
                .HasMaxLength(25)
                .HasColumnName("ws_method");
        });

        modelBuilder.Entity<SubMenu>(entity =>
        {
            entity.HasKey(e => e.SubId).HasName("PRIMARY");

            entity.ToTable("sub_menu");

            entity.HasIndex(e => e.MenuMenId, "fk_SUB_MENU_MENU1_idx");

            entity.HasIndex(e => e.TipoMenuTipMenId, "fk_SUB_MENU_TIPO_MENU1_idx");

            entity.Property(e => e.SubId)
                .HasMaxLength(255)
                .HasColumnName("SUB_ID");
            entity.Property(e => e.MenuDirecto)
                .HasColumnType("tinyint(4)")
                .HasColumnName("menu_directo");
            entity.Property(e => e.MenuMenId)
                .HasMaxLength(255)
                .HasColumnName("MENU_MEN_ID");
            entity.Property(e => e.SubCreador)
                .HasMaxLength(255)
                .HasColumnName("SUB_CREADOR");
            entity.Property(e => e.SubDireccion)
                .HasMaxLength(255)
                .HasColumnName("SUB_DIRECCION");
            entity.Property(e => e.SubEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("sub_estado");
            entity.Property(e => e.SubFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("SUB_FECHACREACION");
            entity.Property(e => e.SubFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("SUB_FECHAMODIFICACION");
            entity.Property(e => e.SubIcono)
                .HasMaxLength(100)
                .HasColumnName("SUB_ICONO");
            entity.Property(e => e.SubMenuId)
                .HasMaxLength(255)
                .HasColumnName("SUB_MENU_ID");
            entity.Property(e => e.SubModificador)
                .HasMaxLength(255)
                .HasColumnName("SUB_MODIFICADOR");
            entity.Property(e => e.SubTitulo)
                .HasMaxLength(200)
                .HasColumnName("SUB_TITULO");
            entity.Property(e => e.SubUrl)
                .HasMaxLength(200)
                .HasColumnName("SUB_URL");
            entity.Property(e => e.TipoMenuTipMenId)
                .HasMaxLength(255)
                .HasColumnName("TIPO_MENU_TIP_MEN_ID");

            entity.HasOne(d => d.MenuMen).WithMany(p => p.SubMenus)
                .HasForeignKey(d => d.MenuMenId)
                .HasConstraintName("fk_SUB_MENU_MENU1");

            entity.HasOne(d => d.TipoMenuTipMen).WithMany(p => p.SubMenus)
                .HasForeignKey(d => d.TipoMenuTipMenId)
                .HasConstraintName("fk_SUB_MENU_TIPO_MENU1");
        });

        modelBuilder.Entity<SubMenuHasPerfil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sub_menu_has_perfil");

            entity.HasIndex(e => e.PerfilPerId, "fk_SUB_MENU_has_PERFIL_PERFIL1_idx");

            entity.HasIndex(e => e.SubMenuSubId, "fk_SUB_MENU_has_PERFIL_SUB_MENU1_idx");

            entity.Property(e => e.PerfilPerId)
                .HasMaxLength(255)
                .HasColumnName("PERFIL_PER_ID");
            entity.Property(e => e.SubMenuSubId)
                .HasMaxLength(255)
                .HasColumnName("SUB_MENU_SUB_ID");
            entity.Property(e => e.SubPerEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("SUB_PER_ESTADO");

            entity.HasOne(d => d.PerfilPer).WithMany()
                .HasForeignKey(d => d.PerfilPerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SUB_MENU_has_PERFIL_PERFIL1");

            entity.HasOne(d => d.SubMenuSub).WithMany()
                .HasForeignKey(d => d.SubMenuSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SUB_MENU_has_PERFIL_SUB_MENU1");
        });

        modelBuilder.Entity<SubUnidad>(entity =>
        {
            entity.HasKey(e => e.SubUniId).HasName("PRIMARY");

            entity.ToTable("sub_unidad");

            entity.HasIndex(e => e.UnidadUniId, "fk_SUB_MENU_UNIDAD1_idx");

            entity.HasIndex(e => e.TipoSubUnidadTipSubId, "fk_SUB_UNIDAD_TIPO_SUB_UNIDAD1_idx");

            entity.Property(e => e.SubUniId)
                .HasMaxLength(255)
                .HasColumnName("SUB_UNI_ID");
            entity.Property(e => e.SubCreador)
                .HasMaxLength(255)
                .HasColumnName("SUB_CREADOR");
            entity.Property(e => e.SubDetalle)
                .HasMaxLength(150)
                .HasColumnName("SUB_DETALLE");
            entity.Property(e => e.SubEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("SUB_ESTADO");
            entity.Property(e => e.SubFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("SUB_FECHACREACION");
            entity.Property(e => e.SubFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("SUB_FECHAMODIFICACION");
            entity.Property(e => e.SubMaestra)
                .HasColumnType("int(11)")
                .HasColumnName("SUB_MAESTRA");
            entity.Property(e => e.SubModalidad)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("sub_modalidad");
            entity.Property(e => e.SubModalidadAgrupar)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("sub_modalidad_agrupar");
            entity.Property(e => e.SubModificador)
                .HasMaxLength(255)
                .HasColumnName("SUB_MODIFICADOR");
            entity.Property(e => e.SubPin)
                .HasColumnType("int(4)")
                .HasColumnName("SUB_PIN");
            entity.Property(e => e.SubTarId)
                .HasMaxLength(10)
                .HasColumnName("SUB_TAR_ID");
            entity.Property(e => e.TipoSubUnidadTipSubId)
                .HasMaxLength(255)
                .HasColumnName("TIPO_SUB_UNIDAD_TIP_SUB_ID");
            entity.Property(e => e.UnidadUniId)
                .HasMaxLength(255)
                .HasColumnName("UNIDAD_UNI_ID");

            entity.HasOne(d => d.TipoSubUnidadTipSub).WithMany(p => p.SubUnidads)
                .HasForeignKey(d => d.TipoSubUnidadTipSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SUB_UNIDAD_TIPO_SUB_UNIDAD1");

            entity.HasOne(d => d.UnidadUni).WithMany(p => p.SubUnidads)
                .HasForeignKey(d => d.UnidadUniId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SUB_MENU_UNIDAD1");

            entity.HasMany(d => d.ProcedimientoPros).WithMany(p => p.SubUnidadSubs)
                .UsingEntity<Dictionary<string, object>>(
                    "SubUnidadHasProcedimiento",
                    r => r.HasOne<Procedimiento>().WithMany()
                        .HasForeignKey("ProcedimientoProId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_SUB_UNIDAD_has_PROCEDIMIENTO_PROCEDIMIENTO1"),
                    l => l.HasOne<SubUnidad>().WithMany()
                        .HasForeignKey("SubUnidadSubId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_SUB_UNIDAD_has_PROCEDIMIENTO_SUB_UNIDAD1"),
                    j =>
                    {
                        j.HasKey("SubUnidadSubId", "ProcedimientoProId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("sub_unidad_has_procedimiento");
                        j.HasIndex(new[] { "ProcedimientoProId" }, "fk_SUB_UNIDAD_has_PROCEDIMIENTO_PROCEDIMIENTO1_idx");
                        j.HasIndex(new[] { "SubUnidadSubId" }, "fk_SUB_UNIDAD_has_PROCEDIMIENTO_SUB_UNIDAD1_idx");
                        j.IndexerProperty<string>("SubUnidadSubId")
                            .HasMaxLength(255)
                            .HasColumnName("SUB_UNIDAD_SUB_ID");
                        j.IndexerProperty<string>("ProcedimientoProId")
                            .HasMaxLength(255)
                            .HasColumnName("PROCEDIMIENTO_PRO_ID");
                    });
        });

        modelBuilder.Entity<SubunidadHasTarjeta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("subunidad_has_tarjetas");

            entity.Property(e => e.Estado)
                .HasColumnType("int(4)")
                .HasColumnName("estado");
            entity.Property(e => e.NTarjeta)
                .HasMaxLength(255)
                .HasColumnName("n_tarjeta");
            entity.Property(e => e.SubUnidadId)
                .HasMaxLength(255)
                .HasColumnName("sub_unidad_id");
        });

        modelBuilder.Entity<SubunidadTesorerium>(entity =>
        {
            entity.HasKey(e => e.SubTesId).HasName("PRIMARY");

            entity.ToTable("subunidad_tesoreria");

            entity.Property(e => e.SubTesId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sub_tes_id");
            entity.Property(e => e.SubTesoreria)
                .HasMaxLength(255)
                .HasColumnName("sub_tesoreria");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.SucId).HasName("PRIMARY");

            entity.ToTable("sucursal");

            entity.HasIndex(e => e.ComunaComId, "fk_SUCURSAL_COMUNA1_idx");

            entity.Property(e => e.SucId)
                .HasMaxLength(255)
                .HasColumnName("SUC_ID");
            entity.Property(e => e.ComunaComId)
                .HasMaxLength(255)
                .HasColumnName("COMUNA_COM_ID");
            entity.Property(e => e.FiltroPacs)
                .HasMaxLength(100)
                .HasColumnName("filtro_pacs");
            entity.Property(e => e.IpValidator)
                .HasMaxLength(100)
                .HasColumnName("ip_validator");
            entity.Property(e => e.SucBd)
                .HasMaxLength(100)
                .HasColumnName("suc_bd");
            entity.Property(e => e.SucBdIp)
                .HasMaxLength(100)
                .HasColumnName("suc_bd_ip");
            entity.Property(e => e.SucBdTotem)
                .HasMaxLength(100)
                .HasColumnName("suc_bd_totem");
            entity.Property(e => e.SucCorreoConvenio)
                .HasColumnType("int(11)")
                .HasColumnName("SUC_CORREO_CONVENIO");
            entity.Property(e => e.SucCreador)
                .HasMaxLength(255)
                .HasColumnName("SUC_CREADOR");
            entity.Property(e => e.SucDetalle)
                .HasMaxLength(100)
                .HasColumnName("SUC_DETALLE");
            entity.Property(e => e.SucDirImagen)
                .HasMaxLength(255)
                .HasColumnName("SUC_DIR_IMAGEN");
            entity.Property(e => e.SucDireccion)
                .HasMaxLength(250)
                .HasColumnName("SUC_DIRECCION");
            entity.Property(e => e.SucEmail)
                .HasMaxLength(100)
                .HasColumnName("SUC_EMAIL");
            entity.Property(e => e.SucEspecialidad)
                .HasMaxLength(100)
                .HasColumnName("SUC_ESPECIALIDAD");
            entity.Property(e => e.SucEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("SUC_ESTADO");
            entity.Property(e => e.SucFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("SUC_FECHACREACION");
            entity.Property(e => e.SucFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("SUC_FECHAMODIFICACION");
            entity.Property(e => e.SucFolioGarantia)
                .HasColumnType("int(11)")
                .HasColumnName("SUC_FOLIO_GARANTIA");
            entity.Property(e => e.SucGoogle)
                .HasMaxLength(255)
                .HasColumnName("SUC_GOOGLE");
            entity.Property(e => e.SucHorario)
                .HasMaxLength(100)
                .HasColumnName("SUC_HORARIO");
            entity.Property(e => e.SucImagen).HasColumnName("suc_imagen");
            entity.Property(e => e.SucLugarImed)
                .HasColumnType("int(11)")
                .HasColumnName("SUC_LUGAR_IMED");
            entity.Property(e => e.SucModificador)
                .HasMaxLength(255)
                .HasColumnName("SUC_MODIFICADOR");
            entity.Property(e => e.SucNumAtencionActual)
                .HasColumnType("int(6)")
                .HasColumnName("SUC_NUM_ATENCION_ACTUAL");
            entity.Property(e => e.SucNumFicha)
                .HasColumnType("mediumint(9)")
                .HasColumnName("suc_num_ficha");
            entity.Property(e => e.SucNumHLaboratorio)
                .HasColumnType("int(8)")
                .HasColumnName("SUC_NUM_H_LABORATORIO");
            entity.Property(e => e.SucNumHLaboratorioActual)
                .HasColumnType("int(8)")
                .HasColumnName("SUC_NUM_H_LABORATORIO_ACTUAL");
            entity.Property(e => e.SucNumeroContacto)
                .HasMaxLength(20)
                .HasColumnName("SUC_NUMERO_CONTACTO");
            entity.Property(e => e.SucNumeroSucursal)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("SUC_NUMERO_SUCURSAL");
            entity.Property(e => e.SucRutConvenio)
                .HasMaxLength(255)
                .HasColumnName("SUC_RUT_CONVENIO");
            entity.Property(e => e.SucursalReferencia)
                .HasMaxLength(255)
                .HasColumnName("sucursal_referencia");
            entity.Property(e => e.TipoEntidad)
                .HasComment("0 = interna ;  1 = externa")
                .HasColumnType("tinyint(4)")
                .HasColumnName("tipo_entidad");

            entity.HasOne(d => d.ComunaCom).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.ComunaComId)
                .HasConstraintName("fk_SUCURSAL_COMUNA1");
        });

        modelBuilder.Entity<SucursalHasSubUnidad>(entity =>
        {
            entity.HasKey(e => e.SucSubId).HasName("PRIMARY");

            entity.ToTable("sucursal_has_sub_unidad");

            entity.HasIndex(e => e.SubUnidadSubId, "fk_sucursal_has_sub_unidad_sub_unidad1_idx");

            entity.HasIndex(e => e.SucursalSucId, "fk_sucursal_has_sub_unidad_sucursal1_idx");

            entity.Property(e => e.SucSubId)
                .HasMaxLength(255)
                .HasColumnName("SUC_SUB_ID");
            entity.Property(e => e.SubUnidadSubId)
                .HasMaxLength(255)
                .HasColumnName("sub_unidad_SUB_ID");
            entity.Property(e => e.SucursalSucId)
                .HasMaxLength(255)
                .HasColumnName("sucursal_SUC_ID");

            entity.HasOne(d => d.SubUnidadSub).WithMany(p => p.SucursalHasSubUnidads)
                .HasForeignKey(d => d.SubUnidadSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sucursal_has_sub_unidad_sub_unidad1");

            entity.HasOne(d => d.SucursalSuc).WithMany(p => p.SucursalHasSubUnidads)
                .HasForeignKey(d => d.SucursalSucId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sucursal_has_sub_unidad_sucursal1");
        });

        modelBuilder.Entity<SucursalHasUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sucursal_has_usuario");

            entity.HasIndex(e => e.SucursalSucId, "fk_sucursal_has_usuario_sucursal1_idx");

            entity.HasIndex(e => e.UsuarioUsuId, "fk_sucursal_has_usuario_usuario1_idx");

            entity.Property(e => e.SucUsuEstado)
                .HasColumnType("int(11)")
                .HasColumnName("SUC_USU_ESTADO");
            entity.Property(e => e.SucursalSucId)
                .HasMaxLength(255)
                .HasColumnName("sucursal_SUC_ID");
            entity.Property(e => e.UsuarioUsuId)
                .HasMaxLength(255)
                .HasColumnName("usuario_USU_ID");

            entity.HasOne(d => d.SucursalSuc).WithMany()
                .HasForeignKey(d => d.SucursalSucId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sucursal_has_usuario_sucursal1");

            entity.HasOne(d => d.UsuarioUsu).WithMany()
                .HasForeignKey(d => d.UsuarioUsuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sucursal_has_usuario_usuario1");
        });

        modelBuilder.Entity<TiempoTubo>(entity =>
        {
            entity.HasKey(e => e.TieId).HasName("PRIMARY");

            entity.ToTable("tiempo_tubo");

            entity.HasIndex(e => e.NumeroTubo, "tiempo_tubo_etiquetas_fk");

            entity.HasIndex(e => e.WorklistLaboratorioWllId, "tiempo_tubo_worklist_laboratorio_fk");

            entity.Property(e => e.TieId)
                .HasMaxLength(100)
                .HasColumnName("TIE_ID");
            entity.Property(e => e.NumeroTubo)
                .HasColumnType("int(11)")
                .HasColumnName("NUMERO_TUBO");
            entity.Property(e => e.TieEstado)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("tie_estado");
            entity.Property(e => e.TieFin)
                .HasColumnType("datetime")
                .HasColumnName("TIE_FIN");
            entity.Property(e => e.TieInicio)
                .HasColumnType("datetime")
                .HasColumnName("TIE_INICIO");
            entity.Property(e => e.WorklistLaboratorioWllId)
                .HasMaxLength(100)
                .HasColumnName("WORKLIST_LABORATORIO_WLL_ID");

            entity.HasOne(d => d.WorklistLaboratorioWll).WithMany(p => p.TiempoTubos)
                .HasForeignKey(d => d.WorklistLaboratorioWllId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tiempo_tubo_worklist_laboratorio_fk");
        });

        modelBuilder.Entity<TipoConvenio>(entity =>
        {
            entity.HasKey(e => e.TipId).HasName("PRIMARY");

            entity.ToTable("tipo_convenio");

            entity.Property(e => e.TipId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("tip_id");
            entity.Property(e => e.TipDetalle)
                .HasMaxLength(150)
                .HasColumnName("tip_detalle");
        });

        modelBuilder.Entity<TipoMenu>(entity =>
        {
            entity.HasKey(e => e.TipMenId).HasName("PRIMARY");

            entity.ToTable("tipo_menu");

            entity.Property(e => e.TipMenId)
                .HasMaxLength(255)
                .HasColumnName("TIP_MEN_ID");
            entity.Property(e => e.TipMenDescripcion)
                .HasMaxLength(45)
                .HasColumnName("TIP_MEN_DESCRIPCION");
        });

        modelBuilder.Entity<TipoSubUnidad>(entity =>
        {
            entity.HasKey(e => e.TipSubId).HasName("PRIMARY");

            entity.ToTable("tipo_sub_unidad");

            entity.Property(e => e.TipSubId)
                .HasMaxLength(255)
                .HasColumnName("TIP_SUB_ID");
            entity.Property(e => e.TipSubDescripcion)
                .HasMaxLength(100)
                .HasColumnName("TIP_SUB_DESCRIPCION");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => e.UniId).HasName("PRIMARY");

            entity.ToTable("unidad");

            entity.Property(e => e.UniId)
                .HasMaxLength(255)
                .HasColumnName("UNI_ID");
            entity.Property(e => e.UniCreador)
                .HasMaxLength(255)
                .HasColumnName("UNI_CREADOR");
            entity.Property(e => e.UniDetalle)
                .HasMaxLength(100)
                .HasColumnName("UNI_DETALLE");
            entity.Property(e => e.UniEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("UNI_ESTADO");
            entity.Property(e => e.UniFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("UNI_FECHACREACION");
            entity.Property(e => e.UniFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("UNI_FECHAMODIFICACION");
            entity.Property(e => e.UniModificador)
                .HasMaxLength(255)
                .HasColumnName("UNI_MODIFICADOR");
            entity.Property(e => e.UniTipo)
                .HasColumnType("int(11)")
                .HasColumnName("uni_tipo");
        });

        modelBuilder.Entity<UnidadModalidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("unidad_modalidad");

            entity.HasIndex(e => e.IdModalidad, "unidad_modalidad_fk_modalidad");

            entity.HasIndex(e => e.IdUnidad, "unidad_modalidad_fk_unidad");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.IdModalidad)
                .HasMaxLength(255)
                .HasColumnName("id_modalidad");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(255)
                .HasColumnName("id_unidad");

            entity.HasOne(d => d.IdModalidadNavigation).WithMany(p => p.UnidadModalidads)
                .HasForeignKey(d => d.IdModalidad)
                .HasConstraintName("unidad_modalidad_fk_modalidad");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.UnidadModalidads)
                .HasForeignKey(d => d.IdUnidad)
                .HasConstraintName("unidad_modalidad_fk_unidad");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuId).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.UsuTipo, "CONSULTA_TIPO_USUARIO");

            entity.HasIndex(e => e.PerfilPerId, "fk_USUARIO_PERFIL1_idx");

            entity.Property(e => e.UsuId)
                .HasMaxLength(255)
                .HasColumnName("USU_ID");
            entity.Property(e => e.CajaSoftland)
                .HasMaxLength(100)
                .HasColumnName("caja_softland");
            entity.Property(e => e.DarkMode).HasColumnName("dark_mode");
            entity.Property(e => e.PerfilPerId)
                .HasMaxLength(255)
                .HasColumnName("PERFIL_PER_ID");
            entity.Property(e => e.SucursalSucIdUbicacion)
                .HasMaxLength(100)
                .HasColumnName("sucursal_suc_id_ubicacion");
            entity.Property(e => e.TokenNeolab)
                .HasMaxLength(255)
                .HasColumnName("token_neolab");
            entity.Property(e => e.UsuCorreo)
                .HasMaxLength(100)
                .HasColumnName("USU_CORREO");
            entity.Property(e => e.UsuCreador)
                .HasMaxLength(255)
                .HasColumnName("USU_CREADOR");
            entity.Property(e => e.UsuEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("USU_ESTADO");
            entity.Property(e => e.UsuFechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("USU_FECHACREACION");
            entity.Property(e => e.UsuFechamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("USU_FECHAMODIFICACION");
            entity.Property(e => e.UsuGroupPcs)
                .HasMaxLength(100)
                .HasColumnName("USU_GROUP_PCS");
            entity.Property(e => e.UsuIp)
                .HasMaxLength(100)
                .HasColumnName("usu_ip");
            entity.Property(e => e.UsuLog)
                .HasColumnType("tinyint(4)")
                .HasColumnName("USU_LOG");
            entity.Property(e => e.UsuMaterno)
                .HasMaxLength(200)
                .HasColumnName("USU_MATERNO");
            entity.Property(e => e.UsuModificador)
                .HasMaxLength(255)
                .HasColumnName("USU_MODIFICADOR");
            entity.Property(e => e.UsuNombre)
                .HasMaxLength(200)
                .HasColumnName("USU_NOMBRE");
            entity.Property(e => e.UsuPass)
                .HasMaxLength(255)
                .HasColumnName("usu_pass");
            entity.Property(e => e.UsuPassAnterior)
                .HasMaxLength(100)
                .HasColumnName("usu_pass_anterior");
            entity.Property(e => e.UsuPassImed)
                .HasMaxLength(255)
                .HasColumnName("USU_PASS_IMED");
            entity.Property(e => e.UsuPassRandom)
                .HasMaxLength(100)
                .HasColumnName("usu_pass_random");
            entity.Property(e => e.UsuPaterno)
                .HasMaxLength(200)
                .HasColumnName("USU_PATERNO");
            entity.Property(e => e.UsuProId)
                .HasMaxLength(255)
                .HasColumnName("USU_PRO_ID");
            entity.Property(e => e.UsuRut)
                .HasMaxLength(100)
                .HasColumnName("USU_RUT");
            entity.Property(e => e.UsuSucId)
                .HasMaxLength(255)
                .HasColumnName("usu_suc_id");
            entity.Property(e => e.UsuTelefono)
                .HasColumnType("int(11)")
                .HasColumnName("USU_TELEFONO");
            entity.Property(e => e.UsuTipo)
                .HasColumnType("tinyint(4)")
                .HasColumnName("USU_TIPO");
            entity.Property(e => e.UsuUsuario)
                .HasMaxLength(100)
                .HasColumnName("USU_USUARIO");
            entity.Property(e => e.UsuUsuarioImed)
                .HasMaxLength(100)
                .HasColumnName("usu_usuario_imed");
            entity.Property(e => e.UsuValWorklist)
                .HasColumnType("int(11)")
                .HasColumnName("USU_VAL_WORKLIST");

            entity.HasOne(d => d.PerfilPer).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.PerfilPerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_USUARIO_PERFIL1");
        });

        modelBuilder.Entity<Validacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("validaciones");

            entity.HasIndex(e => e.PcId, "validaciones_partes_cuerpo_fk");

            entity.HasIndex(e => e.ProModalidadId, "validaciones_procedimiento_modalidad_fk");

            entity.HasIndex(e => e.PvId, "validaciones_procedimiento_validacion_fk");

            entity.Property(e => e.PcId)
                .HasMaxLength(255)
                .HasColumnName("pc_id");
            entity.Property(e => e.ProModalidadId)
                .HasMaxLength(255)
                .HasColumnName("pro_modalidad_id");
            entity.Property(e => e.PvId)
                .HasMaxLength(255)
                .HasColumnName("pv_id");

            entity.HasOne(d => d.Pc).WithMany()
                .HasForeignKey(d => d.PcId)
                .HasConstraintName("validaciones_partes_cuerpo_fk");

            entity.HasOne(d => d.ProModalidad).WithMany()
                .HasForeignKey(d => d.ProModalidadId)
                .HasConstraintName("validaciones_procedimiento_modalidad_fk");

            entity.HasOne(d => d.Pv).WithMany()
                .HasForeignKey(d => d.PvId)
                .HasConstraintName("validaciones_procedimiento_validacion_fk");
        });

        modelBuilder.Entity<WorklistLaboratorio>(entity =>
        {
            entity.HasKey(e => e.WllId).HasName("PRIMARY");

            entity.ToTable("worklist_laboratorio");

            entity.Property(e => e.WllId)
                .HasMaxLength(255)
                .HasColumnName("WLL_ID");
            entity.Property(e => e.WllEstado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("WLL_ESTADO");
            entity.Property(e => e.WllIngreso)
                .HasColumnType("datetime")
                .HasColumnName("WLL_INGRESO");
            entity.Property(e => e.WllLlamado)
                .HasColumnType("datetime")
                .HasColumnName("WLL_LLAMADO");
            entity.Property(e => e.WllNLaboratorio)
                .HasColumnType("int(8)")
                .HasColumnName("WLL_N_LABORATORIO");
            entity.Property(e => e.WllPaciente)
                .HasMaxLength(255)
                .HasColumnName("WLL_PACIENTE");
            entity.Property(e => e.WllPrioridad)
                .HasColumnType("tinyint(4)")
                .HasColumnName("WLL_PRIORIDAD");
            entity.Property(e => e.WllSubUnidad)
                .HasMaxLength(100)
                .HasColumnName("wll_sub_unidad");
            entity.Property(e => e.WllSucursal)
                .HasMaxLength(255)
                .HasColumnName("WLL_SUCURSAL");
            entity.Property(e => e.WllTermino)
                .HasColumnType("datetime")
                .HasColumnName("WLL_TERMINO");
        });

        modelBuilder.Entity<WorklistSinAgendum>(entity =>
        {
            entity.HasKey(e => e.WllId).HasName("PRIMARY");

            entity.ToTable("worklist_sin_agenda");

            entity.Property(e => e.WllId)
                .HasMaxLength(255)
                .HasColumnName("WLL_ID");
            entity.Property(e => e.WllEstado)
                .HasColumnType("int(4)")
                .HasColumnName("WLL_ESTADO");
            entity.Property(e => e.WllIngreso)
                .HasColumnType("datetime")
                .HasColumnName("WLL_INGRESO");
            entity.Property(e => e.WllLlamado)
                .HasColumnType("datetime")
                .HasColumnName("WLL_LLAMADO");
            entity.Property(e => e.WllPaciente)
                .HasMaxLength(255)
                .HasColumnName("WLL_PACIENTE");
            entity.Property(e => e.WllPrioridad)
                .HasColumnType("tinyint(4)")
                .HasColumnName("WLL_PRIORIDAD");
            entity.Property(e => e.WllSubUnidad)
                .HasMaxLength(255)
                .HasColumnName("WLL_SUB_UNIDAD");
            entity.Property(e => e.WllSucursal)
                .HasMaxLength(255)
                .HasColumnName("WLL_SUCURSAL");
            entity.Property(e => e.WllTermino)
                .HasColumnType("datetime")
                .HasColumnName("WLL_TERMINO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
