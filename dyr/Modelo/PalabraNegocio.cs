using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PalabraNegocio
    {

        private AccesoDatos acceso;
        public PalabraNegocio()
        {
            this.acceso = new AccesoDatos();
        }


        public void Cargar(Palabra palabra)
        {
            try
            {
                acceso.setearConsulta($"insert into PALABRAS (word, meaning) values ('{palabra.word}','{palabra.meaning}')");
                acceso.ejecutarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }





        public List<Palabra> leer()
        {
            List<Palabra> lista = new List<Palabra>(); ;
                
            try
            {
                acceso.setearConsulta("select * from PALABRAS");
                acceso.realizarConsulta();

                while (acceso.Reader().Read())
                {
                    Palabra aux = new Palabra();
                    aux.word = (string)acceso.Reader()["word"];
                    aux.meaning = (string)acceso.Reader()["meaning"];

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
                acceso.cerrarConexion();
            }            
        }
        

    }
}
