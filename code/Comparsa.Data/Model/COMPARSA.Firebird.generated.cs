//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace Comparsa.Data
{
	/// <summary>
	/// Database       : COMPARSA
	/// Data Source    : localhost
	/// Server Version : WI-V2.5.7.27050 Firebird 2.5/tcp (JULIO-TP)/P12
	/// </summary>
	public partial class COMPARSADB : LinqToDB.Data.DataConnection
	{
		public ITable<AFECTADO>          AFECTADOes         { get { return this.GetTable<AFECTADO>(); } }
		public ITable<AFECTADOREQ>       AFECTADOREQs       { get { return this.GetTable<AFECTADOREQ>(); } }
		public ITable<COLABORADOR>       COLABORADORs       { get { return this.GetTable<COLABORADOR>(); } }
		public ITable<COLABORADORAPORTA> COLABORADORAPORTAs { get { return this.GetTable<COLABORADORAPORTA>(); } }
		public ITable<ENTRADA>           ENTRADAs           { get { return this.GetTable<ENTRADA>(); } }
		public ITable<ENTRADADET>        ENTRADADETs        { get { return this.GetTable<ENTRADADET>(); } }
		public ITable<INSUMO>            INSUMOes           { get { return this.GetTable<INSUMO>(); } }
		public ITable<INVENTARIO>        INVENTARIOs        { get { return this.GetTable<INVENTARIO>(); } }
		public ITable<INVENTARIODET>     INVENTARIODETs     { get { return this.GetTable<INVENTARIODET>(); } }
		public ITable<LOCALIDAD>         LOCALIDADs         { get { return this.GetTable<LOCALIDAD>(); } }
		public ITable<NUMEROBLOQ>        NUMEROBLOQs        { get { return this.GetTable<NUMEROBLOQ>(); } }
		public ITable<SALIDA>            SALIDAs            { get { return this.GetTable<SALIDA>(); } }
		public ITable<SALIDADET>         SALIDADETs         { get { return this.GetTable<SALIDADET>(); } }
		public ITable<TIPOINSUMO>        TIPOINSUMOes       { get { return this.GetTable<TIPOINSUMO>(); } }

		public COMPARSADB()
		{
			InitDataContext();
		}

		public COMPARSADB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		partial void InitDataContext();
	}

	[Table("AFECTADO")]
	public partial class AFECTADO
	{
		[PrimaryKey, NotNull    ] public int    AFECTADOID  { get; set; } // integer
		[Column,        Nullable] public string CODIGO      { get; set; } // varchar(10)
		[Column,        Nullable] public string NOMBRE      { get; set; } // varchar(100)
		/// <summary>
		/// 1=Por revisar
		/// 2=Afectaci�n menor
		/// 3=Afectaci�n mayor
		/// 4=Sin da�os
		/// 5=Atendido
		/// </summary>
		[Column,        Nullable] public int?   ESTATUS     { get; set; } // integer
		[Column,        Nullable] public string CALLE       { get; set; } // varchar(50)
		[Column,        Nullable] public string NUMEXT      { get; set; } // varchar(10)
		[Column,        Nullable] public string NUMINT      { get; set; } // varchar(10)
		[Column,        Nullable] public string COLONIA     { get; set; } // varchar(50)
		[Column,        Nullable] public int?   LOCALIDADID { get; set; } // integer
		[Column,        Nullable] public string MUNICIPIO   { get; set; } // varchar(50)
		[Column,        Nullable] public string ESTADO      { get; set; } // varchar(50)
		[Column,        Nullable] public string TELEFONO    { get; set; } // varchar(50)
		[Column,        Nullable] public string EMAIL       { get; set; } // varchar(50)
		[Column,        Nullable] public string TWITTER     { get; set; } // varchar(200)
		[Column,        Nullable] public string FACEBOOK    { get; set; } // varchar(200)
		[Column,        Nullable] public string DICTAMEN    { get; set; } // blob sub_type 1
		[Column,        Nullable] public string NOTAS       { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_AFECTADOREQ_AFECTADO_BackReference
		/// </summary>
		[Association(ThisKey="AFECTADOID", OtherKey="AFECTADOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<AFECTADOREQ> AFECTADOREQs { get; set; }

		/// <summary>
		/// FK_AFECTADO_LOCALIDAD
		/// </summary>
		[Association(ThisKey="LOCALIDADID", OtherKey="LOCALIDADID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_AFECTADO_LOCALIDAD", BackReferenceName="AFECTADOes")]
		public LOCALIDAD LOCALIDAD { get; set; }

		#endregion
	}

	[Table("AFECTADOREQ")]
	public partial class AFECTADOREQ
	{
		[PrimaryKey, NotNull    ] public int  AFECTADOREQID { get; set; } // integer
		[Column,        Nullable] public int? AFECTADOID    { get; set; } // integer
		[Column,        Nullable] public int? TIPOINSUMOID  { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_AFECTADOREQ_AFECTADO
		/// </summary>
		[Association(ThisKey="AFECTADOID", OtherKey="AFECTADOID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_AFECTADOREQ_AFECTADO", BackReferenceName="AFECTADOREQs")]
		public AFECTADO AFECTADO { get; set; }

		/// <summary>
		/// FK_AFECTADOREQ_TIPOINSUMO
		/// </summary>
		[Association(ThisKey="TIPOINSUMOID", OtherKey="TIPOINSUMOID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_AFECTADOREQ_TIPOINSUMO", BackReferenceName="AFECTADOREQs")]
		public TIPOINSUMO TIPOINSUMO { get; set; }

		#endregion
	}

	[Table("COLABORADOR")]
	public partial class COLABORADOR
	{
		[PrimaryKey, NotNull    ] public int    COLABORADORID { get; set; } // integer
		[Column,        Nullable] public string CODIGO        { get; set; } // varchar(10)
		[Column,        Nullable] public string NOMBRE        { get; set; } // varchar(100)
		[Column,        Nullable] public string CALLE         { get; set; } // varchar(50)
		[Column,        Nullable] public string NUMEXT        { get; set; } // varchar(10)
		[Column,        Nullable] public string NUMINT        { get; set; } // varchar(10)
		[Column,        Nullable] public string COLONIA       { get; set; } // varchar(50)
		[Column,        Nullable] public string MUNICIPIO     { get; set; } // varchar(50)
		[Column,        Nullable] public string ESTADO        { get; set; } // varchar(50)
		[Column,        Nullable] public short? ESBRIGADISTA  { get; set; } // smallint
		[Column,        Nullable] public short? ESDONANTE     { get; set; } // smallint
		[Column,        Nullable] public string INSTITUCION   { get; set; } // varchar(100)
		[Column,        Nullable] public string NOTAS         { get; set; } // blob sub_type 1
		[Column,        Nullable] public string TWITTER       { get; set; } // varchar(200)
		[Column,        Nullable] public string FACEBOOK      { get; set; } // varchar(200)
		[Column,        Nullable] public string TELEFONO      { get; set; } // varchar(50)
		[Column,        Nullable] public string EMAIL         { get; set; } // varchar(50)
		[Column,        Nullable] public string POBLACION     { get; set; } // varchar(50)
		[Column,        Nullable] public string REFERIDOPOR   { get; set; } // varchar(100)

		#region Associations

		/// <summary>
		/// FK_COLABORADORAPORTA_COLAB_BackReference
		/// </summary>
		[Association(ThisKey="COLABORADORID", OtherKey="COLABORADORID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<COLABORADORAPORTA> COLABORADORAPORTACOLABs { get; set; }

		/// <summary>
		/// FK_ENTRADA_DONANTE_BackReference
		/// </summary>
		[Association(ThisKey="COLABORADORID", OtherKey="DONANTEID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ENTRADA> ENTRADADONANTEs { get; set; }

		/// <summary>
		/// FK_ENTRADA_RESPONSABLE_BackReference
		/// </summary>
		[Association(ThisKey="COLABORADORID", OtherKey="RESPONSABLEID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ENTRADA> ENTRADARESPONSABLEs { get; set; }

		/// <summary>
		/// FK_SALIDA_RESPONSABLE_BackReference
		/// </summary>
		[Association(ThisKey="COLABORADORID", OtherKey="RESPONSABLEID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<SALIDA> SALIDARESPONSABLEs { get; set; }

		#endregion
	}

	[Table("COLABORADORAPORTA")]
	public partial class COLABORADORAPORTA
	{
		[PrimaryKey, NotNull    ] public int  COLABORADORAPORTAID { get; set; } // integer
		[Column,        Nullable] public int? COLABORADORID       { get; set; } // integer
		[Column,        Nullable] public int? TIPOINSUMOID        { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_COLABORADORAPORTA_COLAB
		/// </summary>
		[Association(ThisKey="COLABORADORID", OtherKey="COLABORADORID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_COLABORADORAPORTA_COLAB", BackReferenceName="COLABORADORAPORTACOLABs")]
		public COLABORADOR COLAB { get; set; }

		/// <summary>
		/// FK_COLABORADORAPORTA_TIPOINS
		/// </summary>
		[Association(ThisKey="TIPOINSUMOID", OtherKey="TIPOINSUMOID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_COLABORADORAPORTA_TIPOINS", BackReferenceName="COLABORADORAPORTATIPOINS")]
		public TIPOINSUMO TIPOIN { get; set; }

		#endregion
	}

	[Table("ENTRADA")]
	public partial class ENTRADA
	{
		[PrimaryKey, NotNull    ] public int       ENTRADAID     { get; set; } // integer
		[Column,        Nullable] public string    NUMERO        { get; set; } // varchar(10)
		[Column,        Nullable] public DateTime? FECHA         { get; set; } // date
		[Column,        Nullable] public TimeSpan? HORA          { get; set; } // time
		[Column,        Nullable] public int?      DONANTEID     { get; set; } // integer
		[Column,        Nullable] public int?      RESPONSABLEID { get; set; } // integer
		[Column,        Nullable] public string    NOTAS         { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_ENTRADA_DONANTE
		/// </summary>
		[Association(ThisKey="DONANTEID", OtherKey="COLABORADORID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_ENTRADA_DONANTE", BackReferenceName="ENTRADADONANTEs")]
		public COLABORADOR DONANTE { get; set; }

		/// <summary>
		/// FK_ENTRADADET_ENTRADA_BackReference
		/// </summary>
		[Association(ThisKey="ENTRADAID", OtherKey="ENTRADAID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ENTRADADET> ENTRADADETs { get; set; }

		/// <summary>
		/// FK_ENTRADA_RESPONSABLE
		/// </summary>
		[Association(ThisKey="RESPONSABLEID", OtherKey="COLABORADORID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_ENTRADA_RESPONSABLE", BackReferenceName="ENTRADARESPONSABLEs")]
		public COLABORADOR RESPONSABLE { get; set; }

		#endregion
	}

	[Table("ENTRADADET")]
	public partial class ENTRADADET
	{
		[PrimaryKey, NotNull    ] public int      ENTRADADETID { get; set; } // integer
		[Column,     NotNull    ] public int      ENTRADAID    { get; set; } // integer
		[Column,     NotNull    ] public int      INSUMOID     { get; set; } // integer
		[Column,        Nullable] public decimal? CANTIDAD     { get; set; } // numeric(15,4)
		[Column,        Nullable] public string   NOTAS        { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_ENTRADADET_ENTRADA
		/// </summary>
		[Association(ThisKey="ENTRADAID", OtherKey="ENTRADAID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_ENTRADADET_ENTRADA", BackReferenceName="ENTRADADETs")]
		public ENTRADA ENTRADA { get; set; }

		/// <summary>
		/// FK_ENTRADADET_INSUMO
		/// </summary>
		[Association(ThisKey="INSUMOID", OtherKey="INSUMOID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_ENTRADADET_INSUMO", BackReferenceName="ENTRADADETs")]
		public INSUMO INSUMO { get; set; }

		#endregion
	}

	[Table("INSUMO")]
	public partial class INSUMO
	{
		[PrimaryKey, NotNull    ] public int      INSUMOID      { get; set; } // integer
		[Column,        Nullable] public string   CODIGO        { get; set; } // varchar(20)
		[Column,        Nullable] public string   NOMBRE        { get; set; } // varchar(100)
		[Column,        Nullable] public int?     TIPOINSUMOID  { get; set; } // integer
		[Column,        Nullable] public decimal? TOTALENTRADAS { get; set; } // numeric(15,4)
		[Column,        Nullable] public decimal? TOTALSALIDAS  { get; set; } // numeric(15,4)
		[Column,        Nullable] public decimal? EXISTENCIA    { get; set; } // numeric(15,4)
		[Column,        Nullable] public string   NOTAS         { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_ENTRADADET_INSUMO_BackReference
		/// </summary>
		[Association(ThisKey="INSUMOID", OtherKey="INSUMOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<ENTRADADET> ENTRADADETs { get; set; }

		/// <summary>
		/// FK_INVENTARIODET_INSUMO_BackReference
		/// </summary>
		[Association(ThisKey="INSUMOID", OtherKey="INSUMOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<INVENTARIODET> INVENTARIODETs { get; set; }

		/// <summary>
		/// FK_SALIDADET_INSUMO_BackReference
		/// </summary>
		[Association(ThisKey="INSUMOID", OtherKey="INSUMOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<SALIDADET> SALIDADETs { get; set; }

		/// <summary>
		/// FK_INSUMO
		/// </summary>
		[Association(ThisKey="TIPOINSUMOID", OtherKey="TIPOINSUMOID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_INSUMO", BackReferenceName="INSUMOes")]
		public TIPOINSUMO TIPOINSUMO { get; set; }

		#endregion
	}

	[Table("INVENTARIO")]
	public partial class INVENTARIO
	{
		[PrimaryKey, NotNull    ] public int       INVENTARIOID { get; set; } // integer
		[Column,        Nullable] public string    NUMERO       { get; set; } // varchar(10)
		[Column,        Nullable] public DateTime? FECHA        { get; set; } // date
		[Column,        Nullable] public TimeSpan? HORA         { get; set; } // time
		[Column,        Nullable] public string    NOTAS        { get; set; } // blob sub_type 1
		[Column,        Nullable] public short?    ACTUAL       { get; set; } // smallint

		#region Associations

		/// <summary>
		/// FK_INVENTARIODET_INVENTARIO_BackReference
		/// </summary>
		[Association(ThisKey="INVENTARIOID", OtherKey="INVENTARIOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<INVENTARIODET> INVENTARIODETs { get; set; }

		#endregion
	}

	[Table("INVENTARIODET")]
	public partial class INVENTARIODET
	{
		[PrimaryKey, NotNull    ] public int      INVENTARIODETID { get; set; } // integer
		[Column,     NotNull    ] public int      INVENTARIOID    { get; set; } // integer
		[Column,     NotNull    ] public int      INSUMOID        { get; set; } // integer
		[Column,        Nullable] public decimal? EXISTTEORICA    { get; set; } // numeric(15,4)
		[Column,        Nullable] public decimal? EXISTREAL       { get; set; } // numeric(15,4)
		[Column,        Nullable] public decimal? EXISTDIFERENCIA { get; set; } // numeric(15,4)
		[Column,        Nullable] public string   NOTAS           { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_INVENTARIODET_INSUMO
		/// </summary>
		[Association(ThisKey="INSUMOID", OtherKey="INSUMOID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_INVENTARIODET_INSUMO", BackReferenceName="INVENTARIODETs")]
		public INSUMO INSUMO { get; set; }

		/// <summary>
		/// FK_INVENTARIODET_INVENTARIO
		/// </summary>
		[Association(ThisKey="INVENTARIOID", OtherKey="INVENTARIOID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_INVENTARIODET_INVENTARIO", BackReferenceName="INVENTARIODETs")]
		public INVENTARIO INVENTARIO { get; set; }

		#endregion
	}

	[Table("LOCALIDAD")]
	public partial class LOCALIDAD
	{
		[PrimaryKey, NotNull    ] public int    LOCALIDADID { get; set; } // integer
		[Column,        Nullable] public string NOMBRE      { get; set; } // varchar(100)
		[Column,        Nullable] public string ESTADO      { get; set; } // varchar(50)
		[Column,        Nullable] public string MUNICIPIO   { get; set; } // varchar(50)
		[Column,        Nullable] public string NOTAS       { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_AFECTADO_LOCALIDAD_BackReference
		/// </summary>
		[Association(ThisKey="LOCALIDADID", OtherKey="LOCALIDADID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<AFECTADO> AFECTADOes { get; set; }

		/// <summary>
		/// FK_SALIDA_LOCALIDAD_BackReference
		/// </summary>
		[Association(ThisKey="LOCALIDADID", OtherKey="LOCALIDADID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<SALIDA> SALIDAs { get; set; }

		#endregion
	}

	[Table("NUMEROBLOQ")]
	public partial class NUMEROBLOQ
	{
		[PrimaryKey, NotNull    ] public int       NUMEROBLOQID { get; set; } // integer
		[Column,        Nullable] public int?      TIPONUMERO   { get; set; } // integer
		[Column,        Nullable] public string    NUMERO       { get; set; } // varchar(20)
		[Column,        Nullable] public DateTime? FECHAHORA    { get; set; } // timestamp
		[Column,        Nullable] public int?      USUARIOID    { get; set; } // integer
		[Column,        Nullable] public string    NOMBREPC     { get; set; } // varchar(50)
	}

	[Table("SALIDA")]
	public partial class SALIDA
	{
		[PrimaryKey, NotNull    ] public int       SALIDAID      { get; set; } // integer
		[Column,        Nullable] public string    NUMERO        { get; set; } // varchar(10)
		[Column,        Nullable] public DateTime? FECHA         { get; set; } // date
		[Column,        Nullable] public TimeSpan? HORA          { get; set; } // time
		[Column,        Nullable] public int?      RESPONSABLEID { get; set; } // integer
		[Column,        Nullable] public int?      LOCALIDADID   { get; set; } // integer
		[Column,        Nullable] public string    NOTAS         { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_SALIDA_LOCALIDAD
		/// </summary>
		[Association(ThisKey="LOCALIDADID", OtherKey="LOCALIDADID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_SALIDA_LOCALIDAD", BackReferenceName="SALIDAs")]
		public LOCALIDAD LOCALIDAD { get; set; }

		/// <summary>
		/// FK_SALIDA_RESPONSABLE
		/// </summary>
		[Association(ThisKey="RESPONSABLEID", OtherKey="COLABORADORID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_SALIDA_RESPONSABLE", BackReferenceName="SALIDARESPONSABLEs")]
		public COLABORADOR RESPONSABLE { get; set; }

		/// <summary>
		/// FK_SALIDADET_SALIDA_BackReference
		/// </summary>
		[Association(ThisKey="SALIDAID", OtherKey="SALIDAID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<SALIDADET> SALIDADETs { get; set; }

		#endregion
	}

	[Table("SALIDADET")]
	public partial class SALIDADET
	{
		[PrimaryKey, NotNull    ] public int      SALIDADETID { get; set; } // integer
		[Column,     NotNull    ] public int      SALIDAID    { get; set; } // integer
		[Column,        Nullable] public int?     INSUMOID    { get; set; } // integer
		[Column,        Nullable] public decimal? CANTIDAD    { get; set; } // numeric(15,4)
		[Column,        Nullable] public decimal? CANTIDADRET { get; set; } // numeric(15,4)
		[Column,        Nullable] public string   NOTAS       { get; set; } // blob sub_type 1

		#region Associations

		/// <summary>
		/// FK_SALIDADET_INSUMO
		/// </summary>
		[Association(ThisKey="INSUMOID", OtherKey="INSUMOID", CanBeNull=true, Relationship=Relationship.ManyToOne, KeyName="FK_SALIDADET_INSUMO", BackReferenceName="SALIDADETs")]
		public INSUMO INSUMO { get; set; }

		/// <summary>
		/// FK_SALIDADET_SALIDA
		/// </summary>
		[Association(ThisKey="SALIDAID", OtherKey="SALIDAID", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_SALIDADET_SALIDA", BackReferenceName="SALIDADETs")]
		public SALIDA SALIDA { get; set; }

		#endregion
	}

	[Table("TIPOINSUMO")]
	public partial class TIPOINSUMO
	{
		[PrimaryKey, NotNull    ] public int    TIPOINSUMOID { get; set; } // integer
		[Column,        Nullable] public string NOMBRE       { get; set; } // varchar(100)

		#region Associations

		/// <summary>
		/// FK_AFECTADOREQ_TIPOINSUMO_BackReference
		/// </summary>
		[Association(ThisKey="TIPOINSUMOID", OtherKey="TIPOINSUMOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<AFECTADOREQ> AFECTADOREQs { get; set; }

		/// <summary>
		/// FK_COLABORADORAPORTA_TIPOINS_BackReference
		/// </summary>
		[Association(ThisKey="TIPOINSUMOID", OtherKey="TIPOINSUMOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<COLABORADORAPORTA> COLABORADORAPORTATIPOINS { get; set; }

		/// <summary>
		/// FK_INSUMO_BackReference
		/// </summary>
		[Association(ThisKey="TIPOINSUMOID", OtherKey="TIPOINSUMOID", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<INSUMO> INSUMOes { get; set; }

		#endregion
	}

	public static partial class COMPARSADBStoredProcedures
	{
		#region FGENCODIGO

		public static IEnumerable<FGENCODIGOResult> FGENCODIGO(this DataConnection dataConnection, int? TIPOCODIGO, out string CODIGO)
		{
			var ret = dataConnection.QueryProc<FGENCODIGOResult>("F_GEN_CODIGO",
				new DataParameter("TIPOCODIGO", TIPOCODIGO, DataType.Int32));

			CODIGO = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["CODIGO"]).Value);

			return ret;
		}

		public partial class FGENCODIGOResult
		{
			public string CODIGO { get; set; }
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static AFECTADO Find(this ITable<AFECTADO> table, int AFECTADOID)
		{
			return table.FirstOrDefault(t =>
				t.AFECTADOID == AFECTADOID);
		}

		public static AFECTADOREQ Find(this ITable<AFECTADOREQ> table, int AFECTADOREQID)
		{
			return table.FirstOrDefault(t =>
				t.AFECTADOREQID == AFECTADOREQID);
		}

		public static COLABORADOR Find(this ITable<COLABORADOR> table, int COLABORADORID)
		{
			return table.FirstOrDefault(t =>
				t.COLABORADORID == COLABORADORID);
		}

		public static COLABORADORAPORTA Find(this ITable<COLABORADORAPORTA> table, int COLABORADORAPORTAID)
		{
			return table.FirstOrDefault(t =>
				t.COLABORADORAPORTAID == COLABORADORAPORTAID);
		}

		public static ENTRADA Find(this ITable<ENTRADA> table, int ENTRADAID)
		{
			return table.FirstOrDefault(t =>
				t.ENTRADAID == ENTRADAID);
		}

		public static ENTRADADET Find(this ITable<ENTRADADET> table, int ENTRADADETID)
		{
			return table.FirstOrDefault(t =>
				t.ENTRADADETID == ENTRADADETID);
		}

		public static INSUMO Find(this ITable<INSUMO> table, int INSUMOID)
		{
			return table.FirstOrDefault(t =>
				t.INSUMOID == INSUMOID);
		}

		public static INVENTARIO Find(this ITable<INVENTARIO> table, int INVENTARIOID)
		{
			return table.FirstOrDefault(t =>
				t.INVENTARIOID == INVENTARIOID);
		}

		public static INVENTARIODET Find(this ITable<INVENTARIODET> table, int INVENTARIODETID)
		{
			return table.FirstOrDefault(t =>
				t.INVENTARIODETID == INVENTARIODETID);
		}

		public static LOCALIDAD Find(this ITable<LOCALIDAD> table, int LOCALIDADID)
		{
			return table.FirstOrDefault(t =>
				t.LOCALIDADID == LOCALIDADID);
		}

		public static NUMEROBLOQ Find(this ITable<NUMEROBLOQ> table, int NUMEROBLOQID)
		{
			return table.FirstOrDefault(t =>
				t.NUMEROBLOQID == NUMEROBLOQID);
		}

		public static SALIDA Find(this ITable<SALIDA> table, int SALIDAID)
		{
			return table.FirstOrDefault(t =>
				t.SALIDAID == SALIDAID);
		}

		public static SALIDADET Find(this ITable<SALIDADET> table, int SALIDADETID)
		{
			return table.FirstOrDefault(t =>
				t.SALIDADETID == SALIDADETID);
		}

		public static TIPOINSUMO Find(this ITable<TIPOINSUMO> table, int TIPOINSUMOID)
		{
			return table.FirstOrDefault(t =>
				t.TIPOINSUMOID == TIPOINSUMOID);
		}
	}
}
