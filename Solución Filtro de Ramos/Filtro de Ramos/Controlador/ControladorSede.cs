using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorSede
    {
        Connection con = new Connection();
        public Sede Agregar(Sede sede)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                sede.Id = db.Query<int>("sp_agregarSede", sede, commandType: CommandType.StoredProcedure).Single();
                return sede;
            }
        }
        public Sede Actualizar(Sede sede)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                sede.Id = db.Execute("sp_actualizarSede", sede, commandType: CommandType.StoredProcedure);
                return sede;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Sede>("sp_eliminarSede", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Sede> ConsultarPorUno(int id, string palabraClave)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Sede>("sp_consultarUnSede", new { id = id, palabraClave = palabraClave }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Sede> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Sede>("sp_consultarTodosSede", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}