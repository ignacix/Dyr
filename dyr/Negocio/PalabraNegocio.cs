using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Dynamic;
using System.Collections;

namespace Negocio
{
    public class PalabraNegocio
    {

        private AccesoDatos accesoDatos;

        public PalabraNegocio()
        {
            //con esto centralizamos la conección 
            this.accesoDatos = new AccesoDatos();
        }

        //Este método devuelve una lista de Palabras
        public List<Palabra> listar()
        {                        
            //Lista que devuelve este método al ejecutarse
            List<Palabra> lista = new List<Palabra>();

            // Este objeto ofrece una manera de los datos en un flujjo de filas que solo avanza de3sde una DB.(No tiene constructor)
            SqlDataReader reader;                                    
            try
            {
                accesoDatos.setearConsulta("SELECT WORD, MEANING FROM PALABRAS");



                accesoDatos.ejecutarLectura();
                reader = accesoDatos.Reader();                
               
                while (reader.Read())
                {
                    Palabra aux = new Palabra();

                    aux.word = (string)reader["word"];
                    aux.meaning = (string)reader["meaning"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }




        public void crear(Palabra palabra)
        {

            this.accesoDatos.setearConsulta($"INSERT INTO PALABRAS (word, meaning) VALUES ('{palabra.word}' , '{palabra.meaning}')");
                                                
            try
            {
                accesoDatos.ejecutarConsulta();                                              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void editar(Palabra palabra)
        {

            //necesito saber cuál voy a editar


            //después la edito 

            accesoDatos.setearConsulta($"update palabras set word = 'hello' where id = 1");
        }


        

    }
}