using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Net.NetworkInformation;

namespace dyrApp
{
    public partial class Form1 : Form
    {
        public List<Palabra> lista;
        public PalabraNegocio negocio;
        public int[] randoms;
        public int cont = 0;
        public int correctas = 0;
        public int incorrectas = 0;

        public Palabra palabra = null; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            this.btnCargar.Visible = false;
            this.btnPracticar.Visible = false;
            this.gbCargar.Location = new Point(250, 111);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.gbCargar.Visible = true;            
            //this.gbCargar.Enabled = false;
            //this.gbCargar.Visible = false;
            this.gbPracticar.Visible = false;
            this.gbResultado.Visible = false;
            this.gbEditar.Visible = false; 


        }

        private void btngbCargar_Click(object sender, EventArgs e)
        {
            if (palabra != null)
            {
                btnCargar.Text = "Modificar";
            }
            else { 
            
                if (txbPalabra.Text.Length < 1 || txbDefinición.Text.Length <1 )
                {
                    MessageBox.Show("Please enter the word and the meaning");
                }
                else
                {
                    string word = txbPalabra.Text;
                    string meaning = txbDefinición.Text;

                    Palabra palabra = new Palabra();
                    palabra.word = word;
                    palabra.meaning = meaning; 

     

                    PalabraNegocio negocio = new PalabraNegocio();
                    negocio.crear(palabra);                

                    MessageBox.Show($"{palabra.word} = {palabra.meaning} ha sido cargado con éxito");
                }
            


            }
        }

        private void btnAtrasgbCargar_Click(object sender, EventArgs e)
        {
            volverAlMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarPracticar();

            seleccionarPalabras();
                      
          
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {            
            lblmeaning.Text = lista[randoms[cont]].meaning;
            
            btnSi.Visible = true;
            btnNo.Visible = true;
            lblAsk.Visible = true;

           
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            deshabilitarLimpiar();
            cont++;
            correctas++;
            if (cont < 10)
            {
                lblWord.Text = lista[randoms[cont]].word;
            }
            else
            {
                comprobarFin();
            }
        }



        private void btnNo_Click(object sender, EventArgs e)
        {
            deshabilitarLimpiar();
            cont++;
            incorrectas++;
            if (cont<10)
            {   
                lblWord.Text = lista[randoms[cont]].word;
            }
            else
            {
                comprobarFin();
            }
        }

        private int[] devolverDiezRandoms(int max)
        {

            //lista que se va a retornar
            int[] array = new int[10];
            
            Random rnd = new Random();

            for (int i = 0; i<10; i++)
            {
                int aux = rnd.Next(10);

                if (i==0)
                {
                    array[i] = aux;
                }
                else
                {
                    while (array.Contains(aux))
                    {
                        aux = rnd.Next(max);
                    }
                    array[i] = aux;
                }
            }
            return array;
        }
        
        
        private void deshabilitarLimpiar()
        {
            btnSi.Visible = false;
            btnNo.Visible = false;
            lblmeaning.Text = "";
            lblAsk.Visible = false;
        }

        private void comprobarFin()
        {
            if (cont==10)
            {
                this.gbPracticar.Visible = false;
                this.gbResultado.Visible = true;
                lblResultado.Text = $"Correctas: {correctas}     Incorrectas: {incorrectas}";
                
                cont = 0;
                correctas = 0;
                incorrectas = 0;
            }
        }

        private void btnResultadoAtras_Click(object sender, EventArgs e)
        {
            volverAlMenu();
        }

        private void volverAlMenu()
        {
            //gbCargar.Visible = false;
            btnCargar.Visible = true;
            btnEditar.Visible = true;
            btnPracticar.Visible = true;
            gbResultado.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mostrarPracticar();
            seleccionarPalabras();
        }

        private void seleccionarPalabras()
        {
            lista = new List<Palabra>();

            negocio = new PalabraNegocio();

            lista = negocio.listar();

            int cantidad = lista.Count;

            randoms = devolverDiezRandoms(cantidad);

            lblWord.Text = lista[randoms[cont]].word;
        }
        private void mostrarPracticar()
        {
            this.btnNo.Visible = false;
            this.btnSi.Visible = false;
            this.btnPracticar.Visible = true;
            this.btnPracticar.Visible = false;
            this.btnCargar.Visible = false;
            this.btnEditar.Visible = false; 
            this.gbPracticar.Location = new Point(230, 111);
            this.gbPracticar.Visible = true;
            this.gbResultado.Visible = false;           
            lblAsk.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.btnCargar.Visible = false;
            this.btnPracticar.Visible = false;
            this.btnEditar.Visible = false; 
            this.gbEditar.Visible = true;
            this.gbEditar.Location = new Point(230, 111); 
                      
            PalabraNegocio negocio = new PalabraNegocio();

            dataGridView1.DataSource = negocio.listar();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            this.gbEditar.Location = new Point(400, 111);
            this.gbCargar.Visible = true;
            this.gbCargar.Enabled = true;
            this.gbCargar.Location = new Point(200, 111);
            Palabra seleccionado = (Palabra)dataGridView1.CurrentRow.DataBoundItem;
            palabra = seleccionado;


            
            //gbCargar.Visible = true;
            //if (id.){

            //}
           



        }

        
    }

}
