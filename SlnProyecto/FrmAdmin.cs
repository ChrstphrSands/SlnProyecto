using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnProyecto
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            cbo_Genero.Text = "Elija Genero";
            cbo_Genero.Items.Add ("Rock");
            cbo_Genero.Items.Add("Pop");
            cbo_Genero.Items.Add("Jazz");
            cbo_Genero.Items.Add("FolK");
            cbo_Genero.Items.Add("Electronica");
            cbo_Genero.Items.Add("HipHop");
            cbo_Genero.Items.Add("Trance");
            cbo_Genero.Items.Add("Latino America");
            cbo_Genero.Items.Add("Otro");





        }

        public static string[,] g_album = new string[100, 100];
        public static int album_cont = 0;
        public static string[,] g_musica = new string[100, 100];
        public static int mp3_cont;
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            gb_Agregar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Borrar.Enabled = false;
            
        }

        private void txt_Precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //rebizar para id repetido
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("El Album Necesita Almenos 1 Cancion");

            }
            else
            {
                if (txt_Stock.Text == "" || txt_Duracion.Text == "")
                {
                    MessageBox.Show("Almenos un Disko en stock o El Disco Debe Tener Alguna Duracion");
                }
                else
                {
                    // empieza  aguardar los albunes
                    g_album [album_cont, 0] = txt_Id_Album.Text;
                    g_album[album_cont, 1] = txt_Album.Text;
                    g_album[album_cont, 2] = txt_Artista.Text;
                    g_album[album_cont, 3] = txt_Stock.Text;
                    g_album[album_cont, 4] = txt_Precio.Text;
                    g_album[album_cont, 5] = cbo_Genero.SelectedText;
                    g_album[album_cont, 6] = txt_Duracion.Text;
                    // arreglo distinto  con  los mimo datos  ya que  el usuario 
                    //vera mas que  todo el lisdado de caciones y no los  discos
                    





                }
            }

        }

        private void btn_Nuevo_Album_Click(object sender, EventArgs e)
        {
            gb_Agregar.Enabled = true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            gb_Agregar.Enabled = true;
            btn_Modificar.Enabled = true;
        }
    }
}
