using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelo
{
    public class AccesoDatos
    {
        private SqlConnection con; 
        private SqlCommand cmd;
        private SqlDataReader reader;


        public SqlDataReader Reader()
        {
            return this.reader;
        }
            

        public AccesoDatos()
        {            
            this.con = new SqlConnection("server=.\\SQLEXPRESS; database = dyr_DB; integrated security = true");
            this.cmd = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.CommandText = consulta;
            this.cmd.Connection = con;
        } 

        public void realizarConsulta()
        {
            try
            {
                this.con.Open();
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
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        public void cerrarConexion()
        {
            if (reader != null)
            {
                reader.Close();
            }
            con.Close();
        }
    }
}
