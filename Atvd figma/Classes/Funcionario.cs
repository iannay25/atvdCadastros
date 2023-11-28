using System;
using System.Windows.Forms;

namespace Atvd_figma
{
    public class Funcionario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime Datanasc { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string EstadoCivil { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string id, string nome, DateTime datanasc, string cpf, string rg, string telefone, string estadocivil,
            string funcao, string email, string endereco, double salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Datanasc = datanasc;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Telefone = telefone;
            this.Email = email;
            this.EstadoCivil = estadocivil;
            this.Funcao = funcao;
            this.Endereco = endereco;
            this.Salario = salario;
        }
    }
}