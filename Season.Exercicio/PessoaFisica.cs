using System;
using Season.Exercicio.Enum;

namespace Season.Exercicio
{
    public class PessoaFisica: Pessoa
    {
        public string CPF { get; set; }

        public void PedirEmprestimo(decimal valor)
        {

            if (valor < 0)
            {
                throw new ValicadaoException($"Valor de entrada incorreto");    
            }
            if (Status != Status.Ativo)
            {
                throw new ValicadaoException($"Apenas cadastros com Status Ativo podem pedir empréstimo");     
            }
            Saldo = Saldo + valor;
            Console.WriteLine($"Seu saldo agora é de {Saldo}"); 

        }

    }
}