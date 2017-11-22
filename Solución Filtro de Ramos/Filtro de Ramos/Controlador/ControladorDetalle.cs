using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorDetalle
    {
        Connection con = new Connection();
        public Detalle Agregar(Detalle detalle)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                detalle.Id = db.Query<int>("sp_agregarDetalle", detalle, commandType: CommandType.StoredProcedure).Single();
                return detalle;
            }
        }
        public Detalle Actualizar(Detalle detalle)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                detalle.Id = db.Execute("sp_actualizarDetalle", detalle, commandType: CommandType.StoredProcedure);
                return detalle;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Detalle>("sp_eliminarDetalle", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<DetalleS> ConsultarPorUno(int id)//solo int//agregar
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<DetalleS>("sp_consultarUnDetalle", new { id = id }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<DetalleS> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
            return db.Query<DetalleS>("sp_consultarTodosDetalle", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}