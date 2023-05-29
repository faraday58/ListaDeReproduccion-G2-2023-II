using System;

namespace ListaDeReproduccion_G2_2023_II
{
    public class Musica
    {
        #region atributos
        private string artista;
        private string cancion;
        private string album;


        #endregion


        #region Construcores
        public Musica(string artista, string cancion, string album)
        {
            Artista = artista;
            Cancion = cancion;
            Album = album;
        }
        #endregion

        #region  Propiedades
        public string Artista { 
            get => artista;
            set
            {
                if( value == "")
                {
                    artista = "Drowning Pool";
                }
                else
                {
                    artista = value;
                }
                
            }
        }
        public string Cancion { 
            get => cancion;
            set {
                if( value == "")
                {
                    cancion = "Bodies";
                }
                else
                {
                    cancion = value;
                }
                
            }   
        }
        public string Album { 
            get => album;

            set
            {
                if (value == "")
                {
                    album = "Sinner";
                }
                else
                {
                    album = value;
                }
                
            }
        }
    }

    #endregion
}
