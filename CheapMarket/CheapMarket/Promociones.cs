﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheapMarket.Recursos;
using System.Globalization;
using System.Threading;

namespace CheapMarket
{
    public partial class Promociones : Form
    {
        public Promociones()
        {
            InitializeComponent();
            if (Sesion.Invitado)
            {
                label1.Text = "Invitado";
            }
            else
            {
                label1.Text = Sesion.NombreUsu;
            }
        }

        //Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            CheapMarket.Perfil perfil = new CheapMarket.Perfil();
            perfil.Show();
            this.Hide();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (Sesion.Invitado)
            {
                MessageBox.Show("Eres usuario invitado. No puedes realizar esta acción.");
            }
            else
            {
                Carrito carrito = new Carrito();
                carrito.Show();
                this.Hide();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            this.Hide();
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfil = new Perfil();
            perfil.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
                Application.ExitThread();
            }
        }

        private void btnPagina_Click(object sender, EventArgs e)
        {
            Process.Start("https://cheapmarket123.000webhostapp.com/index.html");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/CheapMarket_");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/CheapMarket_1/");
        }

        private void Promociones_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma.idioma);
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            label3.Text = CheapMarket.Recursos.StringRecursos.Supermercado;
            label10.Text = CheapMarket.Recursos.StringRecursos.Promociones;
            label4.Text = CheapMarket.Recursos.StringRecursos.Envío_Gratis;
            label7.Text = CheapMarket.Recursos.StringRecursos.diezporciento_descuento;
            label9.Text = CheapMarket.Recursos.StringRecursos.cincoeuros_descuento;
            label5.Text = CheapMarket.Recursos.StringRecursos.cuatromil_puntos;
            label6.Text = CheapMarket.Recursos.StringRecursos.milsetecientos_puntos;
            label8.Text = CheapMarket.Recursos.StringRecursos.dosmilquinientos_puntos;
            btnCanjear1.Text = CheapMarket.Recursos.StringRecursos.Canjear;
            btnCanjear2.Text = CheapMarket.Recursos.StringRecursos.Canjear;
            btnCanjear3.Text = CheapMarket.Recursos.StringRecursos.Canjear;
            label11.Text = CheapMarket.Recursos.StringRecursos.Puntos;
        }
    }
}
