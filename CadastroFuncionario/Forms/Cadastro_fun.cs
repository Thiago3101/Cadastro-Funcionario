using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class Cadastro_fun : Form
    {
        public Cadastro_fun()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(tx_nome.Text == "" || data_nas.Text == "" || mtx_cpf.Text == "" || tx_rg.Text == "" ||
            tx_rg.Text == "" || tx_tel.Text == "" || tx_email.Text == "" || tx_endereco.Text == "" ||
            tx_est_civil.Text == "" || tx_funcao.Text == "" || tx_salario.Text == "" || tx_estado.Text == "" || tx_cidade.Text == "")      
            {
                MessageBox.Show("Alguns campos não foram preenchidos");
            }

            string nome = tx_nome.Text;
            DateTime data_nascimento = Convert.ToDateTime(data_nas.Text);
            string cpf = mtx_cpf.Text;
            if(Validacao.ValidaCPF(cpf) == false)
            {
                MessageBox.Show("CPF inválido.");
            }
            string rg = tx_rg.Text;
            string telefone = tx_tel.Text;
            string email = tx_email.Text;
            string endereco = tx_endereco.Text;
            string estado_civil = tx_est_civil.Text;
            string funcao = tx_funcao.Text;
            double salario = Convert.ToDouble(tx_salario.Text);
            string estado = tx_estado.Text;
            string cidade = tx_cidade.Text;

            Funcionario fun = new Funcionario(nome, data_nascimento, cpf, rg, telefone, email, endereco, estado_civil, funcao, salario, estado, cidade);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            mtx_cpf.Text = "";
            tx_rg.Text = "";
            tx_tel.Text = "";
            tx_email.Text = "";
            tx_endereco.Text = "";
            tx_est_civil.Text = "";
            tx_funcao.Text = "";
            tx_salario.Text = "";
            tx_estado.Text = "";
            tx_cidade.Text = "";

        }
    }
}
