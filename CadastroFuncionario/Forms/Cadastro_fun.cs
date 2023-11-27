using CadastroFuncionario.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        void Inserir(Funcionario funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Funcionario VALUES (@id,@nome, @data_nascimento, @cpf, @rg, @telefone, @email, @rua, @bairro, @numero, @complemento, @estado_civil, @funcao, @salario, @estado, @cidade)");

                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data_nascimento", funcionario.Data_nas);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@rua", funcionario.Rua);
                comando.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                comando.Parameters.AddWithValue("@estado_civil", funcionario.Estado_civil);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);
                comando.Parameters.AddWithValue("@estado", funcionario.Estado);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);

                var resultado = comando.ExecuteNonQuery();

                if(resultado > 0)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_nome.Text == "" || data_nas.Text == "" || mtx_cpf.Text == "" || mtx_rg.Text == "" || mtx_tel.Text == "" || tx_email.Text == "" || tx_rua.Text == "" ||
                tx_bairro.Text == "" || tx_numero.Text == "" || tx_complemento.Text == "" || cb_estado_civil.Text == "" || tx_funcao.Text == "" || tx_salario.Text == "" || tx_estado.Text == "" || tx_cidade.Text == "")
                {
                    MessageBox.Show("Alguns campos não foram preenchidos");
                }

                string nome = tx_nome.Text;
                DateTime data_nascimento = Convert.ToDateTime(data_nas.Text);
                string cpf = mtx_cpf.Text;
                if (Validacao.ValidaCPF(cpf) == false)
                {
                    MessageBox.Show("CPF inválido.");
                }
                string rg = mtx_rg.Text;
                string telefone = mtx_tel.Text;
                string email = tx_email.Text;
                if (Validacao.ValidarEmail(email) == false)
                {
                    MessageBox.Show("Email invalido");
                }
                string rua = tx_rua.Text;
                string bairro = tx_bairro.Text;
                int numero = Convert.ToInt32(tx_numero.Text);
                string complemento = tx_complemento.Text;
                string estado_civil = cb_estado_civil.Text;
                string funcao = tx_funcao.Text;
                double salario = Convert.ToDouble(tx_salario.Text);
                string estado = tx_estado.Text;
                string cidade = tx_cidade.Text;

                Funcionario fun = new Funcionario(nome, data_nascimento, cpf, rg, telefone, email, rua, bairro, numero, complemento, estado_civil, funcao, salario, estado, cidade);

                Inserir(fun);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            mtx_cpf.Text = "";
            mtx_rg.Text = "";
            mtx_tel.Text = "";
            tx_email.Text = "";
            tx_rua.Text = "";
            tx_bairro.Text = "";
            tx_numero.Text = "";
            tx_complemento.Text = "";
            cb_estado_civil.Text = "";
            tx_funcao.Text = "";
            tx_salario.Text = "";
            tx_estado.Text = "";
            tx_cidade.Text = "";
        }
   

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tela_inicial AbrirForms = new Tela_inicial();
            AbrirForms.Visible = true;
            this.Close();
        }
    }
}
