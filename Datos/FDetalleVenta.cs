﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisVenttas.Datos;
using SistemaVentas.Entidades;
using System.Data.SqlClient;

namespace SistemaVentas.Datos
{
   public static class FDetalleVenta
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_FDetalleVenta_GetAll", dbParams);

        }
        public static int Insertar(DetalleVenta detalleVenta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                 

                    FDBHelper.MakeParam("@VentaId", SqlDbType.Int, 0, detalleVenta.Venta.Id),
                    FDBHelper.MakeParam("@ProductoId", SqlDbType.Date, 0, detalleVenta.Producto.Id),
                    FDBHelper.MakeParam("@Cantidad", SqlDbType.VarChar, 0, detalleVenta.Cantidad),
                    FDBHelper.MakeParam("@PrecioUnitario", SqlDbType.VarChar, 0, detalleVenta.PrecioUnitario),
                };

            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FDetalleVenta_Insertar", dbParams));

        }

        public static int Actualizar(DetalleVenta detalleVenta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, detalleVenta.Id),
                    FDBHelper.MakeParam("@VentaId", SqlDbType.Int, 0, detalleVenta.Venta.Id),
                    FDBHelper.MakeParam("@ProductoId", SqlDbType.Date, 0, detalleVenta.Producto.Id),
                    FDBHelper.MakeParam("@Cantidad", SqlDbType.VarChar, 0, detalleVenta.Cantidad),
                    FDBHelper.MakeParam("@PrecioUnitario", SqlDbType.VarChar, 0, detalleVenta.PrecioUnitario),
                };

            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FDetalleVenta_Actualizar", dbParams));

        }

        public static int Eliminar(DetalleVenta detalleVenta)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, detalleVenta.Id),

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FDetalleVenta_Eliminar", dbParams));

        }
    }
}
