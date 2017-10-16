using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparsa
{
    public class Consts
    {

        public static DateTime BaseDateTime = new DateTime(1899, 12, 31);

        public const int ESTATUS_AFECTADO_POR_REVISAR = 1;
        public const int ESTATUS_AFECTADO_AFECTACION_MENOR = 2; 
        public const int ESTATUS_AFECTADO_AFECTACION_MAYOR = 3;
        public const int ESTATUS_AFECTADO_SIN_DANOS = 4;
        public const int ESTATUS_AFECTADO_ATENDIDO = 5;

        public const int TIPO_CODIGO_COLABORADOR = 1;
        public const int TIPO_CODIGO_AFECTADO = 2;
        public const int TIPO_CODIGO_INSUMO = 3;
        public const int TIPO_NUMERO_INVENTARIO = 4;
        public const int TIPO_NUMERO_ENTRADA_ALMACEN = 5;
        public const int TIPO_NUMERO_SALIDA_ALMACEN = 6;

    }
}
