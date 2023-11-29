using CadastroFuncionario.Class;
using CadastroFuncionario.Uteis;
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
    public partial class Consultar_emp : Form
    {
        List<Empresa> listaEmpresa = new List<Empresa>();
        public Consultar_emp()
        {
            InitializeComponent();
            Consultar();
        }
        void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Empresa");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var empresa = new Empresa();
                    empresa.Id = leitor.GetInt32("id_emp");
                    empresa.CNPJ = DAOHelper.GetString(leitor, "cnpj_emp");
                    empresa.Razao_social = DAOHelper.GetString(leitor, "razao_social_emp");
                    empresa.Nome_fantasia = DAOHelper.GetString(leitor, "nome_fantasia_emp");
                    empresa.Situacao_cadastral = DAOHelper.GetString(leitor, "situacao_cadastral_emp");
                    empresa.Regime_tributario = DAOHelper.GetString(leitor, "regime_tributario_emp");
                    empresa.Data_inicio_atividade = DAOHelper.GetDateTime(leitor, "data_inicio_atividade_emp");
                    empresa.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    empresa.Capital_social = DAOHelper.GetDouble(leitor, "capital_social_emp");
                    empresa.Rua = DAOHelper.GetString(leitor, "rua_emp");
                    empresa.Bairro = DAOHelper.GetString(leitor, "bairro_emp");
                    empresa.Numero = leitor.GetInt32("numero_emp");
                    empresa.Estado = DAOHelper.GetString(leitor, "estado_emp");
                    empresa.Cidade = DAOHelper.GetString(leitor, "cidade_emp");
                    empresa.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    empresa.Porte_empresa = DAOHelper.GetString(leitor, "porte_empresa_emp");
                    empresa.Natureza_juridica = DAOHelper.GetString(leitor, "natureza_juridica_emp");
                    empresa.Nome_proprietario = DAOHelper.GetString(leitor, "nome_propietario_emp");
                    empresa.CPF_proprietario = DAOHelper.GetString(leitor, "cpf_proprietario_emp");


                    listaEmpresa.Add(empresa);
                }
                dataGridViewEmpresa.DataSource = listaEmpresa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_inicial abriForms = new Tela_inicial();
            abriForms.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrar_emp abrirforms = new Cadastrar_emp();
            this.Visible = false;
            abrirforms.ShowDialog();
        }
    }
}
