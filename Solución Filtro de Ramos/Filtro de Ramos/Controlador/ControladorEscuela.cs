using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorEscuela
    {
        Connection con = new Connection();
        public Escuela Agregar(Escuela escuela)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                escuela.Id = db.Query<int>("sp_agregarEscuela", escuela, commandType: CommandType.StoredProcedure).Single();
                return escuela;
            }
        }
        public Escuela Actualizar(Escuela escuela)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                escuela.Id = db.Execute("sp_actualizarEscuela", escuela, commandType: CommandType.StoredProcedure);
                return escuela;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Escuela>("sp_eliminarEscuela", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Escuela> ConsultarPorUno(int id, string palabraClave)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Escuela>("sp_consultarUnEscuela", new { id = id, palabraClave = palabraClave }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Escuela> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Escuela>("sp_consultarTodosEscuela", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}