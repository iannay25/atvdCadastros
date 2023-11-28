using System;
using System.Windows.Forms;


namespace Atvd_figma
{
    public class ConsultarEmpresa
    {
        public string NomePropietario { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Data { get; set; }
        public string SituacaoCads { get; set; }
        public string RegimeTributario { get; set; }
        public string Endereco { get; set; }
        public string Tipo { get; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJur { get; set; }
        public double Capital { get; set; }
        public ConsultarEmpresa (string nomePropietario, string razaoSocial, string nomeFantasia, string telefone, string cnpj, string cpf, string data, string endereco, string naturezaJur, double capital)
        {
            this.NomePropietario = nomePropietario;
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
            this.Telefone = telefone;
            this.Cnpj = cnpj;
            this.Cpf = cpf;
            this.Data = data;
            this.Endereco = endereco;
            this.NaturezaJur = naturezaJur;
            this.Capital = capital;
        }
        public ConsultarEmpresa() { }
    }
}