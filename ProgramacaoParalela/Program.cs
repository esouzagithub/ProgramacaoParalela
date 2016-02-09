using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoParalela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            // Invocar os métodos que vamos executar
            Parallel.Invoke(
            new Action(ExibirDias),
            new Action(ExibirMeses),
            new Action(ExibirCidades));

            // Aguardar a continuação do programa
            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
        }

        static void ExibirDias()
        {
            string[] diasArray = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
            foreach (var dia in diasArray)
            {
                Console.WriteLine("Dia da semana: {0}", dia);
                Thread.Sleep(500);
            }
        }

        static void ExibirMeses()
        {
            string[] messArray = { "Jan", "Fev", "Mar", "Abr","Mai", "Jun", "Jul",
                                   "Ago", "Set", "Out", "Nov", "Dec" };

            foreach (var mes in messArray)
            {
                Console.WriteLine("Mês : {0}", mes);
                Thread.Sleep(500);
            }
        }

        static void ExibirCidades()
        {
            string[] cidadesArray = { "Londres", "New York", "Paris", "Tóquio", "Sidney" };
            foreach (var cidade in cidadesArray)
            {
                Console.WriteLine("Cidade : {0}", cidade);
                Thread.Sleep(500);
            }
        }
    }
}
