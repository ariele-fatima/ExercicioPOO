using System;
using Season.Exercicio.Enum;

namespace Season.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PessoaFisica joao = new PessoaFisica();
                joao.Nome = "João";
                joao.Nascimento = "10.07.1992";
                joao.Status = Status.Suspenso;

                Console.WriteLine($"Nome: {joao.Nome}, Nascimento: {joao.Nascimento}, Status: {joao.Status} ");

            }
            catch (ValicadaoException e)
            {
                Console.WriteLine($"Erro de validação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}. Entre em contato com o suporte.");
            }
            finally
            {   
                Console.WriteLine("Comando finalizado");
            }

        }
    }
}
