using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyr
{
    public partial class Form1 : Form
    {
        private bool flagMenu = true;
        private int[] listaRandoms = new int[10];
        private int count = 0;
        private List<Palabra> listaPalabras = new List<Palabra>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            menu();
            this.gbCargar.Visible = true;         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gbCargar.Visible = false;
            this.gbEditar.Visible = false;
            this.gbPracticar.Visible = false;            
        }




        private void btnPracticar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("la lista de números tiene : " + devolverDiezRandom().Count());
            menu();
            devolverDiezRandom();
            obtenerPalabras();
            Console.WriteLine("Los npumeros son:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("EN LA POSICIÓN :" + i + " : " + this.listaRandoms[i]);

            }



            this.gbPracticar.Visible = true;            
            
       
            this.gbPracticar.Visible= true;                                                                        
        }


        private void menu()
        {
            if (flagMenu)
            {
                this.btnCargar.Visible = false;
                this.btnEditar.Visible = false;
                this.btnPracticar.Visible = false;
            }
            else
            {
                this.btnCargar.Visible = true;
                this.btnEditar.Visible = true;
                this.btnPracticar.Visible = true;
            }
            flagMenu = !flagMenu;
        }

        private int[] devolverDiezRandom()
        {
            int[] listNumeros = new int[10];
            Random rand = new Random();
            PalabraNegocio negocio = new PalabraNegocio();
            int cantidad = negocio.leer().Count;
            
            for (int i = 0; i < 10; i++)
            {
                int random = rand.Next(0, cantidad);
                if (i == 0)
                {
                    listNumeros[i] = random;
                }
                else
                {                    
                    while (listNumeros.Contains(random))
                    {
                        random = rand.Next(0, cantidad);
                    }
                    listNumeros[i] = random; 
                }
            }

            return listNumeros;
            
        }

        private List<Palabra> obtenerPalabras()
        {
            this.listaRandoms = devolverDiezRandom();            
            PalabraNegocio negocio = new PalabraNegocio();
            List<Palabra> listaPalabras = negocio.leer();            
            List<Palabra> aux = new List<Palabra>();

            for (int i = 0; i < 10; i++)
            {
                aux.Add(listaPalabras[listaRandoms[i]]);
                Console.WriteLine(aux[i].word + "  : "+ aux[i].meaning);
            }
            
            return aux;
        }

        private void btnGbCargar_Click(object sender, EventArgs e)
        {
            if (this.txbCargarWord.Text.Length >1 && this.txbCargarMeaning.Text.Length > 1)
            {
                PalabraNegocio negocio = new PalabraNegocio();
                Palabra aux = new Palabra();
                aux.word = this.txbCargarWord.Text;
                aux.meaning = this.txbCargarMeaning.Text;
                negocio.Cargar(aux);
                MessageBox.Show($"La palabra : {aux.word}, se ha cargado exitosamente");
            }
            else
            {
                MessageBox.Show("Por favor cargue los campos");
            }
        }


        private void atras1_Click(object sender, EventArgs e)
        {
            atras();
        }

        private void atras2_Click(object sender, EventArgs e)
        {
            atras();
        }

        private void atras3_Click(object sender, EventArgs e)
        {
            atras();
        }
        
        private void atras()
        {
            this.gbCargar.Visible = false;
            this.gbEditar.Visible = false; 
            this.gbPracticar.Visible = false;
            menu();
            
        }

    }
}
