using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    internal class Funcionario
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public DateTime Data_nas { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Estado_civil { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, DateTime data_nas, string cpf, string rg, string telefone, string email, string rua, string bairro, int numero, string complemento, string estado_civil, string funcao, double salario, string estado, string cidade) 
        {
            Nome = nome;
            Data_nas = data_nas;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Email = email; 
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
            Estado_civil = estado_civil;
            Funcao = funcao;
            Salario = salario;
            Estado = estado;
            Cidade = cidade;
        }
    }
}
