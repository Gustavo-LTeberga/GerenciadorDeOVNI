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

namespace GerenciadorDeOVNI {
    public partial class Gerenciador : Form {

        //objetos globais

        BibliotecaOVNI.OVNI ovni;

        public Gerenciador(BibliotecaOVNI.OVNI ovni) {



            InitializeComponent();
            this.ovni = ovni;
            AtualizarInformacoes();
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);


        }
        public void checarPlaneta() {
            if (ovni.PlanetaAtual == "Terra") {
                pibIcon.Image = Properties.Resources.e_tIconEarthSemFundo;
               
            }
            else {
                pibIcon.Image = Properties.Resources.e_tIcon;
                

            }
        }

        public void AtualizarInformacoes() {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduções: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "Ligado" : "Desligar")}";
            lblPlanetaAtual.Text = $"Planeta atual: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;


            btnDesligar.Enabled = ovni.Situacao ;
            btnLigar.Enabled = !ovni.Situacao ;

            grbAbduzidos.Enabled = ovni.Situacao ;
            grbTripulantes.Enabled = ovni.Situacao ;
            grbPlanetas.Enabled = ovni.Situacao ;
            checarPlaneta();




        }

        private void btnLigar_Click(object sender, EventArgs e) {

            if (ovni.Ligar()) {
                MessageBox.Show("O OVNI foi ligado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            else {
                MessageBox.Show("O OVNI ja esta ligado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes();

        }

        private void btnDesligar_Click(object sender, EventArgs e) {

            if (ovni.Desligar()) {
                MessageBox.Show("O OVNI foi desligado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("O OVNI ja foi desligado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInformacoes();



        }

        private void btnAdicionarTrip_Click(object sender, EventArgs e) {
            if (ovni.AdicionarTripulante()) {
                MessageBox.Show("Foi adicionado tripulante!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("A nave esta lotada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }


        private void btnRemoverTrip_Click(object sender, EventArgs e) {

            if (ovni.RemoverTripulante()) {
                MessageBox.Show("Tripulante foi removido!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("não é possivel remover tripulante!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        
    }

        private void btnAdicionarAbduzidos_Click(object sender, EventArgs e) {
            if (ovni.Abduzir()) {
                MessageBox.Show("OWN OWN WON", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("não teve OWN OWN WON", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnRemoverAbduzidos_Click(object sender, EventArgs e) {
            if (ovni.Desabduzir()) {
                MessageBox.Show("ZHU ZHU ZUN", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Erro ao desabduzir", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e) {
            if (ovni.MudarPlaneta(cmbPlanetas.Text)) {
                MessageBox.Show("CHUUUUU", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Erro ao Transitar de planeta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnRetornar_Click(object sender, EventArgs e) {

            if (ovni.RetornarAoPlanetaDeOrigem()) {
                MessageBox.Show("A nave retornou ao Planeta mãe", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Erro ao retornar", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();

        }





    }
}
