using System;
using Season.Exercicio.Enum;

namespace Season.Exercicio
{
    public class PessoaJuridica: Pessoa
    {
        public string CNPJ { get; set; }
        public int IM { get; set; }

        public void Adiantamento(decimal valor)
        {
            if (valor < 0)
            {
                throw new ValicadaoException($"Valor de entrada incorreto");    
            }
            if (Status != Status.Ativo)
            {
                throw new ValicadaoException($"Apenas cadastros com Status Ativo podem pedir adiantamento");     
            }
            Saldo = Saldo + valor;
            Console.WriteLine($"Seu saldo agora é de {Saldo}");             
        }
    }
}