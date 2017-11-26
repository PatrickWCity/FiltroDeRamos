using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorDetalleS
    {
        Connection con = new Connection();
        public DetalleS Agregar(DetalleS detalle)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                detalle.Id = db.Query<int>("sp_agregarDetalleS", detalle, commandType: CommandType.StoredProcedure).Single();
                return detalle;
            }
        }
        public DetalleS Actualizar(DetalleS detalle)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                detalle.Id = db.Execute("sp_actualizarDetalleS", detalle, commandType: CommandType.StoredProcedure);
                return detalle;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<DetalleS>("sp_eliminarDetalleS", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<DetalleS> ConsultarPorUno(int id)//solo int//agregar
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<DetalleS>("sp_consultarUnDetalleS", new { id = id }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<DetalleS> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
            return db.Query<DetalleS>("sp_consultarTodosDetalleS", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<DetalleS> Filtrar(string ramo, string semestre, string seccion, string sala, string escuela, string sede, string carrera)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<DetalleS>("sp_Filtro", new { Ramo = ramo, Semestre = semestre, Seccion = seccion, Sala =sala,Escuela=escuela, Sede=sede, carrera=carrera }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}