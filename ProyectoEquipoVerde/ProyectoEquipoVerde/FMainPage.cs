using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoEquipoVerde
{
    public partial class FMainPage : Form
    {
        List<Pelicula> listaPelis;
        bool peliLista2;

        List<Usuario> listaUsuarios;
        bool usuLista2;

        public FMainPage()
        {
            InitializeComponent();

            listaPelis = new List<Pelicula>(Pelicula.CargarListaPeliculasPorValoracion());
            peliLista2 = false;

            btnPeli1.BackgroundImage = listaPelis[0].Cartel;
            btnPeli2.BackgroundImage = listaPelis[1].Cartel;
            btnPeli3.BackgroundImage = listaPelis[2].Cartel;
            btnPeli4.BackgroundImage = listaPelis[3].Cartel;
            btnPeli5.BackgroundImage = listaPelis[4].Cartel;
            btnPeli6.BackgroundImage = listaPelis[5].Cartel;
            btnPeli7.BackgroundImage = listaPelis[6].Cartel;
            btnPeli8.BackgroundImage = listaPelis[7].Cartel;
            btnPeli9.BackgroundImage = listaPelis[8].Cartel;
            btnPeli10.BackgroundImage = listaPelis[9].Cartel;


            listaUsuarios = new List<Usuario>(Usuario.CargarUsuariosPorNumCriticas());
            usuLista2 = false;

            btnUser1.BackgroundImage = listaUsuarios[0].Imagen;
            btnUser2.BackgroundImage = listaUsuarios[1].Imagen;
            btnUser3.BackgroundImage = listaUsuarios[2].Imagen;
            btnUser4.BackgroundImage = listaUsuarios[3].Imagen;
            btnUser5.BackgroundImage = listaUsuarios[4].Imagen;
            btnUser6.BackgroundImage = listaUsuarios[5].Imagen;
            btnUser7.BackgroundImage = listaUsuarios[6].Imagen;
            btnUser8.BackgroundImage = listaUsuarios[7].Imagen;
            btnUser9.BackgroundImage = listaUsuarios[8].Imagen;
            btnUser10.BackgroundImage = listaUsuarios[9].Imagen;
        }

        private void BtnHeaderFB_Click(object sender, EventArgs e)
        {
            Process.Start("https://es-es.facebook.com/");
        }

        private void BtnHeaderInsta_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/?hl=es");
        }

        private void BtnHeaderTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/");
        }

        private void BtnHeaderBuscarPeli_Click(object sender, EventArgs e)
        {
            FBusqueda form = new FBusqueda();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnHeaderInicio_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnVerPerfil_Click(object sender, EventArgs e)
        {
            FPerfilUsuario form = new FPerfilUsuario(LoginInfo.IdUserLogged);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginInfo.CerrarSesion();

            FInicioSesion form = new FInicioSesion();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnDerecha_Click(object sender, EventArgs e)
        {
            peliLista2 = true;

            btnIzquierda.Visible = true;
            btnDerecha.Visible = false;

            btnPeli1.BackgroundImage = listaPelis[10].Cartel;
            btnPeli2.BackgroundImage = listaPelis[11].Cartel;
            btnPeli3.BackgroundImage = listaPelis[12].Cartel;
            btnPeli4.BackgroundImage = listaPelis[13].Cartel;
            btnPeli5.BackgroundImage = listaPelis[14].Cartel;
            btnPeli6.BackgroundImage = listaPelis[15].Cartel;
            btnPeli7.BackgroundImage = listaPelis[16].Cartel;
            btnPeli8.BackgroundImage = listaPelis[17].Cartel;
            btnPeli9.BackgroundImage = listaPelis[18].Cartel;
            btnPeli10.BackgroundImage = listaPelis[19].Cartel;
        }

        private void BtnIzquierda_Click(object sender, EventArgs e)
        {
            peliLista2 = false;

            btnDerecha.Visible = true;
            btnIzquierda.Visible = false;

            btnPeli1.BackgroundImage = listaPelis[0].Cartel;
            btnPeli2.BackgroundImage = listaPelis[1].Cartel;
            btnPeli3.BackgroundImage = listaPelis[2].Cartel;
            btnPeli4.BackgroundImage = listaPelis[3].Cartel;
            btnPeli5.BackgroundImage = listaPelis[4].Cartel;
            btnPeli6.BackgroundImage = listaPelis[5].Cartel;
            btnPeli7.BackgroundImage = listaPelis[6].Cartel;
            btnPeli8.BackgroundImage = listaPelis[7].Cartel;
            btnPeli9.BackgroundImage = listaPelis[8].Cartel;
            btnPeli10.BackgroundImage = listaPelis[9].Cartel;
        }

        private void BtnDerechaUsers_Click(object sender, EventArgs e)
        {
            usuLista2 = true;

            btnIzquierdaUsers.Visible = true;
            btnDerechaUsers.Visible = false;

            btnUser1.BackgroundImage = listaUsuarios[10].Imagen;
            btnUser2.BackgroundImage = listaUsuarios[11].Imagen;
            btnUser3.BackgroundImage = listaUsuarios[12].Imagen;
            btnUser4.BackgroundImage = listaUsuarios[13].Imagen;
            btnUser5.BackgroundImage = listaUsuarios[14].Imagen;
            btnUser6.BackgroundImage = listaUsuarios[15].Imagen;
            btnUser7.BackgroundImage = listaUsuarios[16].Imagen;
            btnUser8.BackgroundImage = listaUsuarios[17].Imagen;
            btnUser9.BackgroundImage = listaUsuarios[18].Imagen;
            btnUser10.BackgroundImage = listaUsuarios[19].Imagen;
        }

        private void BtnIzquierdaUsers_Click(object sender, EventArgs e)
        {
            usuLista2 = false;

            btnDerechaUsers.Visible = true;
            btnIzquierdaUsers.Visible = false;

            btnUser1.BackgroundImage = listaUsuarios[0].Imagen;
            btnUser2.BackgroundImage = listaUsuarios[1].Imagen;
            btnUser3.BackgroundImage = listaUsuarios[2].Imagen;
            btnUser4.BackgroundImage = listaUsuarios[3].Imagen;
            btnUser5.BackgroundImage = listaUsuarios[4].Imagen;
            btnUser6.BackgroundImage = listaUsuarios[5].Imagen;
            btnUser7.BackgroundImage = listaUsuarios[6].Imagen;
            btnUser8.BackgroundImage = listaUsuarios[7].Imagen;
            btnUser9.BackgroundImage = listaUsuarios[8].Imagen;
            btnUser10.BackgroundImage = listaUsuarios[9].Imagen;
        }

        private void BtnPeli1_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[0].Id_pelicula;
            else
                id = listaPelis[10].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli2_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[1].Id_pelicula;
            else
                id = listaPelis[11].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli3_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[2].Id_pelicula;
            else
                id = listaPelis[12].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli4_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[3].Id_pelicula;
            else
                id = listaPelis[13].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli5_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[4].Id_pelicula;
            else
                id = listaPelis[14].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli6_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[5].Id_pelicula;
            else
                id = listaPelis[15].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli7_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[6].Id_pelicula;
            else
                id = listaPelis[16].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli8_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[7].Id_pelicula;
            else
                id = listaPelis[17].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli9_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[8].Id_pelicula;
            else
                id = listaPelis[18].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnPeli10_Click(object sender, EventArgs e)
        {
            int id;

            if (!peliLista2)
                id = listaPelis[9].Id_pelicula;
            else
                id = listaPelis[19].Id_pelicula;

            FPerfilPeli form = new FPerfilPeli(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser1_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[0].Id;
            else
                id = listaUsuarios[10].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser2_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[1].Id;
            else
                id = listaUsuarios[11].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser3_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[2].Id;
            else
                id = listaUsuarios[12].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser4_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[3].Id;
            else
                id = listaUsuarios[13].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser5_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[4].Id;
            else
                id = listaUsuarios[14].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser6_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[5].Id;
            else
                id = listaUsuarios[15].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser7_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[6].Id;
            else
                id = listaUsuarios[16].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser8_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[7].Id;
            else
                id = listaUsuarios[17].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser9_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[8].Id;
            else
                id = listaUsuarios[18].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnUser10_Click(object sender, EventArgs e)
        {
            int id;

            if (!usuLista2)
                id = listaUsuarios[9].Id;
            else
                id = listaUsuarios[19].Id;

            FPerfilUsuario form = new FPerfilUsuario(id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }
    }
}
