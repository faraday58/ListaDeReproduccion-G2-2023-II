using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListaDeReproduccion_G2_2023_II
{
    public partial class Form1 : Form
    {
        List<Musica> canciones;
        Form FormPadre; //Atributo que asigna al presente formulario al Form de Autenticación
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
    }
}
