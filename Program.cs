https://web.digitalinnovation.one/course/primeiros-passos-com-net-c/learning/f8c664b8-9434-483e-bcac-9121fd9b3595

13.19
using System;

namespace Prática
{
    class Program
    {
        static void Main(string[] args)
        {   
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine(aluno.Nome);
                        Console.WriteLine("Informe a nota deste aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
                        }                        
                        Console.WriteLine("");
                        Console.WriteLine(aluno.Nota);

                        break;

                    case "2":
                        Console.WriteLine("2- Listar alunos!");
                        //TODO: listar alunos
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("3 - Calcular média geral");
                        //TODO: calcular media geral
                        Console.WriteLine("");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informa a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno!");
            Console.WriteLine("2- Listar alunos!");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}