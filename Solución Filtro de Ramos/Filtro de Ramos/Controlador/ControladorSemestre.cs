using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorSemestre
    {
        Connection con = new Connection();
        public Semestre Agregar(Semestre semestre)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                semestre.Id = db.Query<int>("sp_agregarSemestre", semestre, commandType: CommandType.StoredProcedure).Single();
                return semestre;
            }
        }
        public Semestre Actualizar(Semestre semestre)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                semestre.Id = db.Execute("sp_actualizarSemestre", semestre, commandType: CommandType.StoredProcedure);
                return semestre;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Semestre>("sp_eliminarSemestre", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Semestre> ConsultarPorUno(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Semestre>("sp_consultarUnSemestre", new { id = id }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Semestre> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Semestre>("sp_consultarTodosSemestre", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}