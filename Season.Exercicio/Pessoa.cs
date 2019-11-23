using Season.Exercicio.Enum;
using System;

namespace Season.Exercicio
{
    public class Pessoa: ISacavel
    {
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string Endereco { get; set; }
        protected decimal Saldo { get; set; }
        public Status Status { get; set; }           


        public void Sacar(decimal valor)
        {
            if (valor < 0)
            {
                throw new ValicadaoException($"Valor de entrada incorreto");    
            }
            if (Status != Status.Ativo)
            {
                throw new ValicadaoException($"Apenas cadastros com Status Ativo podem sacar");     
            }
            if(Saldo < valor)
            {
                throw new ValicadaoException($"Saldo insuficiente, seu saldo é de {Saldo}"); 
            }
            Saldo = Saldo - valor;
            Console.WriteLine($"Seu saldo agora é de {Saldo}"); 
        }

        public void Receber(decimal valor)
        {
            if (valor < 0)
            {
                throw new ValicadaoException($"Valor de entrada incorreto");    
            }
            if (Status != Status.Ativo)
            {
                throw new ValicadaoException($"Apenas cadastros com Status Ativo podem receber");     
            }            
            Saldo = Saldo + valor;
            Console.WriteLine($"Seu saldo agora é de {Saldo}");
        }

        public override int GetHashCode()
        {
            int hash = 17;
            return  (this.Nome.GetHashCode() * hash) +
                    (this.Nascimento.GetHashCode() * hash) +
                    (this.Endereco.GetHashCode() * hash) +
                    (this.Saldo.GetHashCode() * hash) +
                    (this.Status.GetHashCode() * hash);
        }

        public override string ToString()
        {
            return $"[Nome = {this.Nome}; Status = {this.Status}]";
        }
    }
}