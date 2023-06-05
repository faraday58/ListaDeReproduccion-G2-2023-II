using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ListaDeReproduccion_G2_2023_II
{
    public partial class Form1 : Form
    {
        List<Musica> canciones;
        Form FormPadre; //Atributo que asigna al presente formulario al Form de Autenticación
        private int tiempoInicio;
        private int indCan;

        public int IndCan { get => indCan;
            set
            {
                if( indCan < 0 && indCan > lstbReproduccion.Items.Count    )
                {
                    indCan = 0;
                }
                else
                {
                    indCan = value;
                }
                
            }
        }

        public Form1(Form FormPadre)
        {
            this.FormPadre = FormPadre;
            InitializeComponent();
            CargarCanciones();
        }

        public void CargarCanciones()
        {
            lstbReproduccion.Items.Clear();
            canciones = new List<Musica>();
                        
            canciones.Add(new Musica("Reavenhead","Reavenhead","OrdenoGan"));
            canciones.Add(new Musica("Luis Miguel", "Cuando Calienta el Sol", "Soy como quiero ser"));
            canciones.Add(new Musica("Drowning Pool", "Bodies", "Sinner"));
            foreach (Musica cancion in canciones  )
            {
                lstbReproduccion.Items.Add(cancion.Cancion);
            }

        }

        private void lstbReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Musica cancion = canciones[lstbReproduccion.SelectedIndex];
            lbCancion.Text = cancion.Cancion;
            lbArtista.Text = cancion.Artista;
            lbAlbum.Text = cancion.Album;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPadre.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarMusica += AgregarCancion;
            formAgregar.ShowDialog();
        }

        

        public void AgregarCancion(Musica musica)
        {
            canciones.Add(musica);
            lstbReproduccion.Items.Add(musica.Cancion);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbInicio.Text= String.Format( " {0} [s] ",  tiempoInicio );
             
            switch(IndCan)
            {
                case 0:
                    ptbPortada.Image = global::ListaDeReproduccion_G2_2023_II.Properties.Resources.simens;
                    break;
                case 1:
                    ptbPortada.Image = global::ListaDeReproduccion_G2_2023_II.Properties.Resources.luismiguel;
                    break;
                case 2:
                    ptbPortada.Image = global::ListaDeReproduccion_G2_2023_II.Properties.Resources.ravenhead;
                    break;
                   
            }
            if ( lstbReproduccion.SelectedIndex >= 0 && lstbReproduccion.SelectedIndex < lstbReproduccion.Items.Count-1)
            {

                IndCan= lstbReproduccion.SelectedIndex++;
            }
            else
            {
                lstbReproduccion.SelectedIndex = 0;
            }

            tiempoInicio++;

        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            tiempoInicio = 0;
        }
    }
}
