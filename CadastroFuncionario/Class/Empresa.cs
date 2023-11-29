using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario.Class
{
    internal class Empresa
    {
        public int Id { get; set; }
        public string CNPJ {  get; set; }
        public string Razao_social { get; set; }
        public string Nome_fantasia { get; set; }
        public string Situacao_cadastral { get; set; }
        public string Regime_tributario { get; set; }
        public DateTime? Data_inicio_atividade { get; set; }
        public string Telefone { get; set; }
        public double Capital_social { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Tipo { get; set; }
        public string Porte_empresa { get; set; }
        public string Natureza_juridica { get; set;}
        public string Nome_proprietario { get; set;}
        public string CPF_proprietario { get; set; }

        public Empresa() { }
        public Empresa(string cNPJ, string razao_social, string nome_fantasia, string situacao_cadastral, string regime_tributario, DateTime? data_inicio_atividade, string telefone, double capital_social, string rua, string bairro, int numero, string estado, string cidade, string tipo, string porte_empresa, string natureza_juridica, string nome_proprietario, string cPF_proprietario)
        {
            CNPJ = cNPJ;
            Razao_social = razao_social;
            Nome_fantasia = nome_fantasia;
            Situacao_cadastral = situacao_cadastral;
            Regime_tributario = regime_tributario;
            Data_inicio_atividade = data_inicio_atividade;
            Telefone = telefone;
            Capital_social = capital_social;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Estado = estado;
            Cidade = cidade;
            Tipo = tipo;
            Porte_empresa = porte_empresa;
            Natureza_juridica = natureza_juridica;
            Nome_proprietario = nome_proprietario;
            CPF_proprietario = cPF_proprietario;
        }
    }
}
