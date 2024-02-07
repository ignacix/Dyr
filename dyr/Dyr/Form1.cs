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
using System.Speech.Synthesis;
using FluentValidation.Results;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dyr
{
    public partial class Form1 : Form
    {
        private bool flagMenu = true;
        private int[] listaRandoms = new int[10];
        private int count = 0, rPositivos = 0, rnegativos = 0; 
        private List<Palabra> listaPalabras = new List<Palabra>();
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private Palabra palabraSeleccionada;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            menu();
            this.gbCargar.Location = new Point(289, 165);
            this.gbCargar.Visible = true;         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.gbCargar.Visible = false;
            this.gbEditar.Visible = false;
            this.gbPracticar.Visible = false;
            this.gbResultado.Visible = false;
            this.gbEditarPalabra.Visible = false;
        }




        private void btnPracticar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("la lista de números tiene : " + devolverDiezRandom().Count());
            menu();
            devolverDiezRandom();
            this.listaPalabras = obtenerPalabras();            

            lblMeaning.Visible = false; 
            lblWord.Text = listaPalabras[count].word;
            this.gbPracticar.Location = new Point(289, 165);

            this.gbPracticar.Visible= true;
            this.btnCargarSi.Visible = false;
            this.btnCargarNo.Visible = false;
            this.lblPregunta.Visible = false; 
            speech.Speak(listaPalabras[count].word);

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
            }
            
            return aux;
        }

        private void btnGbCargar_Click(object sender, EventArgs e)
        {

            PalabraValidation validator = new PalabraValidation();
            Palabra aux = new Palabra();
            aux.word = this.txbCargarWord.Text;
            aux.meaning = this.txbCargarMeaning.Text;
            aux.url = this.txbCargarImagen.Text;
            ValidationResult resultado = validator.Validate(aux);
            
            

            if (resultado.IsValid)
            {
                PalabraNegocio negocio = new PalabraNegocio();
                negocio.Cargar(aux);
                MessageBox.Show($"La palabra : {aux.word}, se ha cargado exitosamente");
                this.txbCargarMeaning.Text = ""; 
                this.txbCargarWord.Text = "";
                this.txbCargarImagen.Text = ""; 
            }
            else
            {
                foreach (var error in resultado.Errors)
                {
                    switch (error.ErrorMessage)
                    {
                        case ("Ingrese una palabra"):
                            this.txbCargarWord.BackColor = Color.LightPink;
                            break;
                        case ("Ingrese un significado"):
                            this.txbCargarMeaning.BackColor = Color.LightPink;
                            break;


                    }                    
                    MessageBox.Show(error.ErrorMessage);
                }
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
            this.gbResultado.Visible = false; 
            menu();
            this.count = 0;
            this.rPositivos = 0;
            this.rnegativos = 0;

        }

        private void btnCargarSi_Click(object sender, EventArgs e)
        {
            rPositivos++;
            count++;
            bool estado = comprobarJuego();
            esconderSiNo();
            decirPalabra(estado);
        }

        private void btnCargarNo_Click(object sender, EventArgs e)
        {
            rnegativos++;
            count++;
            bool estado = comprobarJuego();
            esconderSiNo();
            decirPalabra(estado);
        }

        private void btnResultadoDenuevo_Click(object sender, EventArgs e)
        {
             this.gbResultado.Visible = false;
            devolverDiezRandom();
            this.listaPalabras = obtenerPalabras();


            lblMeaning.Visible = false;
            lblWord.Text = listaPalabras[count].word;


            this.gbPracticar.Visible = true;
            speech.Speak(listaPalabras[count].word);

        }

        private void btnResultadoAtras_Click(object sender, EventArgs e)
        {
            atras();
        }

        private void btnCargarMostrar_Click(object sender, EventArgs e)
        {

            lblMeaning.Text = this.listaPalabras[count].meaning;
            lblMeaning.Visible = true;
            lblPregunta.Visible = true;
            this.btnCargarSi.Visible = true;
            this.btnCargarNo.Visible = true; 
        }

        private bool comprobarJuego()
        {
            if (count == 10)
            {
                this.gbResultado.Location = new Point(289, 165);
                this.gbResultado.Visible = true;
                this.gbPracticar.Visible = false;
                this.lblResultado.Text = $"Aciertos: {rPositivos}  Fallos: {rnegativos}";
                this.count = 0;
                this.rPositivos = 0;
                this.rnegativos = 0;
                return false;
            }
            else
            {
                lblMeaning.Visible = false;
                lblWord.Text = listaPalabras[count].word;
                return true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            menu();
            this.gbEditar.Location= new Point(289, 165);
            this.gbEditar.Visible = true;
            PalabraNegocio negocio = new PalabraNegocio();
            
            this.dataGridView1.DataSource = negocio.leer();
            this.dataGridView1.Columns["id"].Visible = false;
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.palabraSeleccionada = (Palabra)this.dataGridView1.CurrentRow.DataBoundItem;
            this.gbEditarPalabra.Visible = true;
            this.gbEditarPalabra.Location = new Point(179, 165);
            this.gbEditar.Location = new Point(389, 165);
            this.txbEditarWord.Text = palabraSeleccionada.word;
            this.txbEditarMeaning.Text = palabraSeleccionada.meaning;
            this.txbEditarUrl.Text = palabraSeleccionada.url;
                                    
            MessageBox.Show(palabraSeleccionada.id + palabraSeleccionada.word);            
        }

        private void btnGbEditar_Click(object sender, EventArgs e)
        {
            this.palabraSeleccionada.word =  this.txbEditarWord.Text;
            this.palabraSeleccionada.meaning = this.txbEditarMeaning.Text;

            try
            {
                PalabraNegocio negocio = new PalabraNegocio();         
                negocio.editar(palabraSeleccionada);
                this.gbEditarPalabra.Visible = false;
                this.gbEditar.Location = new Point(289, 165);
                this.dataGridView1.DataSource = negocio.leer();
                MessageBox.Show($"La palabra {palabraSeleccionada.word} ha sido actualizada con éxito");
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txbCargarWord_Click(object sender, EventArgs e)
        {
            this.txbCargarWord.BackColor = Color.White;
            
        }

        private void txbCargarMeaning_Click(object sender, EventArgs e)
        {
            
            this.txbCargarMeaning.BackColor = Color.White;
        }

        private void txbCargarImagen_TextChanged(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = this.txbCargarImagen.Text;
        }

        private void txbEditarUrl_TextChanged(object sender, EventArgs e)
        {
            this.pictureBox2.ImageLocation = this.txbEditarUrl.Text;
        }

        private void esconderSiNo()
        {
            this.lblPregunta.Visible = false; 
            this.btnCargarSi.Visible = false;
            this.btnCargarNo.Visible = false;
        }

        private void decirPalabra(bool estado)
        {
            if (estado)
            {
                this.speech.Speak(listaPalabras[count].word);
            }
        }
    }
}
