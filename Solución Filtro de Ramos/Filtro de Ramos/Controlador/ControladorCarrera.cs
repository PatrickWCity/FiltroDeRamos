using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorCarrera
    {
        Connection con = new Connection();
        public Carrera Agregar(Carrera carrera)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                carrera.Id = db.Query<int>("sp_agregarCarrera", carrera, commandType: CommandType.StoredProcedure).Single();
                return carrera;
            }
        }
        public Carrera Actualizar(Carrera carrera)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                carrera.Id = db.Execute("sp_actualizarCarrera", carrera, commandType: CommandType.StoredProcedure);
                return carrera;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Carrera>("sp_eliminarCarrera", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Carrera> ConsultarPorUno(int id, string palabraClave)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Carrera>("sp_consultarUnCarrera", new { id = id, palabraClave = palabraClave }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Carrera> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Carrera>("sp_consultarTodosCarrera", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}