using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorRamo
    {
        Connection con = new Connection();
        public Ramo Agregar(Ramo ramo)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                ramo.Id = db.Query<int>("sp_agregarRamo", ramo, commandType: CommandType.StoredProcedure).Single();
                return ramo;
            }
        }
        public Ramo Actualizar(Ramo ramo)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                ramo.Id = db.Execute("sp_actualizarRamo", ramo, commandType: CommandType.StoredProcedure);
                return ramo;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Ramo>("sp_eliminarRamo", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Ramo> ConsultarPorUno(int id, string palabraClave)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Ramo>("sp_consultarUnRamo", new { id = id, palabraClave = palabraClave }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Ramo> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Ramo>("sp_consultarTodosRamo", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}