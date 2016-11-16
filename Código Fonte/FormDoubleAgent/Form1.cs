using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDoubleAgent { 
    public partial class Form1 : Form{
        private AgentObjects.IAgentCtlCharacter avatar;
        private Timer timer;

        public Form1(){
            InitializeComponent();
            timer = new Timer { Interval = 15000};
            timer.Tick += timer_Tick;
            cbVendedores.Items.Add("João");
            cbVendedores.Items.Add("Maria");
            cbVendedores.Items.Add("Pedro");
        }

        private void timer_Tick(object sender, EventArgs e){
            timer.Stop();
            avatar.StopAll();
            avatar.Speak("Você está perdido? Como posso ajudar?");
        }

        private void CarregarFormulario_Home(object sender, EventArgs e){
            controlAgent.Characters.Load("Merlin", "Merlin.acs");
            avatar = (AgentObjects.IAgentCtlCharacter)controlAgent.Characters["Merlin"];
            lbTotal.Text = "";
            avatar.Show(0);
            avatar.Speak("Olá! Eu sou o Merlin, estou aqui para ajudar você na inserção de produtos no gestor de nota fiscal. ", null);
        }
        

        private void textBox1_MouseHover(object sender, EventArgs e){
            avatar.StopAll();
            avatar.MoveTo(20, 95);
            avatar.Speak("Aqui você coloca o nome do cliente ou da empresa que está comprando os produtos", null);
        }

        private void tbPersonStateCode_MouseHover(object sender, EventArgs e){
            avatar.StopAll();
            avatar.MoveTo(20, 147);
            avatar.Speak("Aqui você coloca o CPF (no caso de pessoa física) ou CNPJ (em caso de pessoa jurídica)", null);
        }

        private void dgProdutos_Adicionado(object sender, DataGridViewRowEventArgs e){
            avatar.StopAll();
            avatar.MoveTo(20, 261);
            avatar.Speak("Produto adicionado!");
        }

        private void dgProdutos_FimEdicao(object sender, DataGridViewCellEventArgs e){
            int quant = 0;
            Double preco = 0;
            Double total = 0;
            for (int i = 0; i < dgProdutos.Rows.Count; ++i){                
                quant = Convert.ToInt32(dgProdutos.Rows[i].Cells[2].Value);
                preco = Convert.ToDouble(dgProdutos.Rows[i].Cells[3].Value);
                total = total + (preco * quant);
            }

            
            lbTotal.Text = "R$ " + total;
        }

        private void Formulario_Home_MudancaMouse(object sender, MouseEventArgs e){
            timer.Stop();
            timer.Start();
        }

        private void btFinalizar_Click(object sender, EventArgs e){
            avatar.StopAll();
            if (lbTotal.Text == ""){
                avatar.Speak("Ops! Faltou adicionar um produto! Para emitir nota, é necessário pelo menos um produto!");
            }
            else if(tbNomeCliente.Text == ""){
                avatar.Speak("Faltou inserir o nome do cliente. Preencha o campo e tente novamente!");
            }else if (tbPersonStateCode.Text == "") {
                avatar.Speak("Faltou inserir o CPF ou o CNPJ. Preencha o campo correspondente e tente de novo!");
            }
            else if (cbVendedores.Text == ""){
                avatar.Speak("Por favor, escolha seu nome na lista de vendedores e tente novamente!");
            }
            else{
                avatar.Speak("Compra realizada com sucesso!");
            }
        }

        private void btLimparCampos_Click(object sender, EventArgs e){
            tbNomeCliente.Text = "";
            tbPersonStateCode.Text = "";
            cbVendedores.Text = "";
            lbTotal.Text = "";
            dgProdutos.Rows.Clear();
            dgProdutos.Refresh();
        }

        private void btFinalizar_MouseHover(object sender, EventArgs e){
            avatar.StopAll();
            avatar.Speak("Finaliza a compra e emite a nota fiscal");
            btFinalizar.Width = 245;
            btFinalizar.Height = 42;
        }

        private void btFinalizar_MouseLeave(object sender, EventArgs e){
            avatar.StopAll();
            btFinalizar.Width = 228;
            btFinalizar.Height = 32;
        }

        private void btLimparCampos_MouseHover(object sender, EventArgs e){
            avatar.StopAll();
            avatar.Speak("Limpa os campos que você preencheu");
            btLimparCampos.Width = 115;
            btLimparCampos.Height = 35;
        }

        private void btLimparCampos_MouseLeave(object sender, EventArgs e){
            avatar.StopAll();
            btLimparCampos.Width = 112;
            btLimparCampos.Height = 31;
        }

        private void cbVendedores_MouseHover(object sender, EventArgs e){
            avatar.StopAll();
            avatar.MoveTo(20, 147);
            avatar.Speak("Por favor, escolha seu nome na lista de vendedores", null);
        }

        private void tbNomeCliente_TextChanged(object sender, EventArgs e)
        {
            avatar.StopAll();
        }

        private void tbPersonStateCode_TextChanged(object sender, EventArgs e)
        {
            avatar.StopAll();
        }

        private void cbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            avatar.StopAll();
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            avatar.StopAll();
        }
    }
}
