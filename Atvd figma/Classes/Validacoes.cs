using System;
using System.Text.RegularExpressions;


namespace Atvd_figma
{
    public class Cpf
    {
        public static bool ValidaCPF(string CPF)
        {
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace(",", "");
            CPF = CPF.Replace("-", "");

            if (CPF.Length != 11)
            { return false; }

            int s = 0;
            int n1 = 10;
            for (int i = 0; i < 9; i++)
            {
                s += Convert.ToInt32(CPF[i].ToString()) * n1;
                n1--;
            }

            int res = s % 11;

            if (res < 2)
            { res = 0; }

            else
            { res = 11 - res; }


            int so = 0;
            int n2 = 11;
            for (int i = 0; i < 10; i++)
            {
                so += Convert.ToInt32(CPF[i].ToString()) * n2;
                n2--;
            }

            int res2 = so % 11;

            if (res2 < 2)
            { res2 = 0; }

            else
            { res2 = 11 - (so % 11); }

            if (res == Convert.ToInt32(CPF[9].ToString()) && res2 == Convert.ToInt32(CPF[10].ToString()))
            { return true; }

            return false;
        }


        public static bool ValidaEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(email);
            return match.Success;
        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}

