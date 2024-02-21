﻿using System;
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
                acceso.setearConsulta($"insert into PALABRAS (word, meaning, img, cp) values ('{palabra.word}','{palabra.meaning}','{palabra.url}', 0)");
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
                acceso.setearConsulta("select * from PALABRAS order by word");
                acceso.realizarConsulta();

                while (acceso.Reader().Read())
                {
                    Palabra aux = new Palabra();
                    aux.id = (int)acceso.Reader()["id"];
                    aux.word = (string)acceso.Reader()["word"];
                    aux.meaning = (string)acceso.Reader()["meaning"];
                    if (acceso.Reader()["img"] != DBNull.Value)
                    {
                        aux.url = (string)acceso.Reader()["img"];
                    }
                    else{
                        aux.url = "*";
                    }
                    if (acceso.Reader()["cp"] != DBNull.Value)
                    {
                        aux.cp = (short)acceso.Reader()["cp"];
                    }
                    else
                    {
                        aux.cp = 0;
                    }
                    

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
        
        public void editar(Palabra palabra)
        {
            try
            {                
                acceso.setearConsulta($"update PALABRAS set word = '{palabra.word}', meaning= '{palabra.meaning}', img = '{palabra.url}' where id = {palabra.id}");
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



    }
}
