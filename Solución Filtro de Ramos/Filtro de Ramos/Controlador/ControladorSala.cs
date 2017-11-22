using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorSala
    {
        Connection con = new Connection();
        public Sala Agregar(Sala sala)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                sala.Id = db.Query<int>("sp_agregarSala", sala, commandType: CommandType.StoredProcedure).Single();
                return sala;
            }
        }
        public Sala Actualizar(Sala sala)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                sala.Id = db.Execute("sp_actualizarSala", sala, commandType: CommandType.StoredProcedure);
                return sala;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Sala>("sp_eliminarSala", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Sala> ConsultarPorUno(int id, string palabraClave)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Sala>("sp_consultarUnSala", new { id = id, palabraClave = palabraClave }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Sala> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Sala>("sp_consultarTodosSala", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}