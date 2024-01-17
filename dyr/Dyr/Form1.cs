using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.gbCargar.Visible = true;

            PalabraNegocio negocio = new PalabraNegocio();
            
            List<Palabra> lista = negocio.leer();

            this.lblCargarPalabra.Text = $"{lista[0].word}";
            this.lblCargarMeaning.Text = $"{lista[0].meaning}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gbCargar.Visible = false;
            this.gbEditar.Visible = false;
            this.gbPracticar.Visible = false;
        }



        private int[] devolverDiezRandom()
        {


            return new int[] { 1,2,3};
        }
    }
}
