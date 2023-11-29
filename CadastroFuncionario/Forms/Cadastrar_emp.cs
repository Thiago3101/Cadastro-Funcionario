using CadastroFuncionario.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario.Forms
{
    public partial class Cadastrar_emp : Form
    {
        public Cadastrar_emp()
        {
            InitializeComponent();
        }

        void Inserir(Empresa empresa)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Empresa  VALUES (@id, @cnpj, @razao_social, @nome_fantasia, @situacao_cadastral, @regime_tributario, @data_inicio, @telefone, @capita_social, @rua, @bairro, @numero, @estado, @cidade, @tipo, @porte_empresa, @natureza_juridica, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
                comando.Parameters.AddWithValue("@razao_social", empresa.Razao_social);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.Nome_fantasia);
                comando.Parameters.AddWithValue("@situacao_cadastral", empresa.Situacao_cadastral);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.Regime_tributario);
                comando.Parameters.AddWithValue("@data_inicio", empresa.Data_inicio_atividade);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@capita_social", empresa.Capital_social);
                comando.Parameters.AddWithValue("@rua", empresa.Rua);
                comando.Parameters.AddWithValue("@bairro", empresa.Bairro);
                comando.Parameters.AddWithValue("@numero", empresa.Numero);
                comando.Parameters.AddWithValue("@estado", empresa.Estado);
                comando.Parameters.AddWithValue("@cidade", empresa.Cidade);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@porte_empresa", empresa.Porte_empresa);
                comando.Parameters.AddWithValue("@natureza_juridica", empresa.Natureza_juridica);
                comando.Parameters.AddWithValue("@nome_proprietario", empresa.Nome_proprietario);
                comando.Parameters.AddWithValue("@cpf_proprietario", empresa.CPF_proprietario);


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string cnpj = mtx_cnpj.Text;
                string razaoSocial = tx_razao_social.Text;
                string nomeFantasia = tx_nome_fantasia.Text;
                string situacaoCadastral = cb_situacao_cadastral.Text;
                string regimeTributario = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                DateTime data_inicio = Convert.ToDateTime(data_inicio_atividade.Text);
                string telefone = mtx_telefone.Text;
                double capital_social = Convert.ToDouble(tx_capital_social.Text);
                string rua = tx_rua.Text;
                string bairro = tx_bairro.Text;
                int numero = Convert.ToInt32(tx_numero.Text);
                string estado = cb_estado.Text;
                string cidade = tx_cidade.Text;
                string tipo = groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                string porte_empresa = groupBox3.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                string natureza_juridica = cb_natureza_juridica.Text;
                string nome_proprietario = tx_nome_proprietario.Text;
                string cpf_proprietario = mtx_cpf_proprietario.Text;
                if(Validacao.ValidaCPF(cpf_proprietario) == false)
                {
                    MessageBox.Show("CPF inválido");
                }
                
                    Empresa empresa = new Empresa(cnpj, razaoSocial, nomeFantasia, situacaoCadastral, regimeTributario, data_inicio, telefone, capital_social, rua, bairro, numero, estado, cidade, tipo, porte_empresa, natureza_juridica, nome_proprietario, cpf_proprietario);
                    Inserir(empresa);
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_inicial abriForms = new Tela_inicial();
            abriForms.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultar_emp abrirforms = new Consultar_emp();
            this.Visible = false;
            abrirforms.ShowDialog();
        }
    }
}
