using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheapMarket
{
    public partial class Promociones : Form
    {
        public Promociones()
        {
            InitializeComponent();
        }

<<<<<<< HEAD

=======
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheapMarket.Perfil perfil = new CheapMarket.Perfil();
            perfil.Show();
        }
>>>>>>> 47cc210e8528af7d53b20be67cb146449a2d3838
    }
}
