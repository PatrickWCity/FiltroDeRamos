using Dapper;
using Filtro_de_Ramos.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Filtro_de_Ramos.Controlador
{
    class ControladorSeccion
    {
        Connection con = new Connection();
        public Seccion Agregar(Seccion seccion)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                seccion.Id = db.Query<int>("sp_agregarSeccion", seccion, commandType: CommandType.StoredProcedure).Single();
                return seccion;
            }
        }
        public Seccion Actualizar(Seccion seccion)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                seccion.Id = db.Execute("sp_actualizarSeccion", seccion, commandType: CommandType.StoredProcedure);
                return seccion;
            }
        }
        public void Eliminar(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                db.Query<Seccion>("sp_eliminarSeccion", new { id = id }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Seccion> ConsultarPorUno(int id)
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Seccion>("sp_consultarUnSeccion", new { id = id }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Seccion> ConsultarPorTodos()
        {
            using (IDbConnection db = new SqlConnection(con.connectionString))
            {
                return db.Query<Seccion>("sp_consultarTodosSeccion", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}