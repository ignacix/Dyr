using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Negocio
{
    public class AccesoDatos
    {
        //necesitamos un objeto SqlCOnection (REPRESENTA UNA CONECCIÖN A UNA DB) Permite conectarme a algun origen
        private SqlConnection conn;
        //Permite realizar acciones contra la DB.(Representa un procedimiento o operación q se ejecuta en un a DB)
        private SqlCommand cmd;
        private SqlDataReader reader; 

        public AccesoDatos()
        {
            this.conn = new SqlConnection("server=.\\SQLEXPRESS; database = dyr_DB; integrated security = true");
            this.cmd = new SqlCommand();                        
        }


        public void setearConsulta(string consulta)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = consulta;
            cmd.Connection = conn;


        }
        
        public void ejecutarLectura()
        {
            try
            {
                conn.Open();
                this.reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarConsulta()
        {
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch  (Exception ex)
            {
                throw ex; 
            }
        }

        public SqlDataReader Reader()
        {
            return this.reader;
        }

        public void cerrarConexion()
        {
            if(this.reader != null)
            {
                this.reader.Close();
            }
            conn.Close();
        }
        

       

    }
}
