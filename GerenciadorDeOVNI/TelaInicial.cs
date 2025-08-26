using BibliotecaOVNI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaOVNI;

namespace GerenciadorDeOVNI {
    public partial class TelaInicial : Form {
        public TelaInicial() {
            InitializeComponent();

            cmbPlanet.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);


        }

        private void btnIniciar_Click(object sender, EventArgs e) {

            if (txbMaxTrip.Text == null) {
                MessageBox.Show("informe o maximo de tripulantes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbMaxAbd.Text == null) {
                MessageBox.Show("informe a capacidade de abduzidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbPlanet.SelectedIndex == -1) {
                MessageBox.Show("selecione o planeta de origem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                int maxTripulantes = int.Parse(txbMaxTrip.Text);
                    int maxAbduzidos =  int.Parse(txbMaxAbd.Text);
                    string planetaOrigem = cmbPlanet.Text;

                OVNI ovni = new OVNI(maxTripulantes,maxAbduzidos,planetaOrigem);

                Gerenciador gerenciador = new Gerenciador(ovni);

                Hide();

                gerenciador.ShowDialog();

                Show();

            }





        }
    }
}
