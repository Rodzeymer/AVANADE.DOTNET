/*using System;

namespace Prática
{
    class Program
    {
        static void Main(string[] args)
        {   
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
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
                        Console.WriteLine("Informe a nota deste aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
                        }         
                        alunos[indiceAluno] = aluno;  
                        indiceAluno++;
                        Console.WriteLine("");

                        break;

                    case "2":
                        Console.WriteLine("2- Listar alunos!");
                        foreach (var alun in alunos)
                        {   
                            if(!string.IsNullOrEmpty(alun.Nome)){
                                Console.WriteLine($"Aluno: {alun.Nome} - Nota: {alun.Nota}");   
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("3 - Calcular média geral");
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                             if(!string.IsNullOrEmpty(alunos[i].Nome))
                             {
                                 notaTotal = notaTotal + alunos[i].Nota;
                                 nrAlunos++;
                             }
                        }

                        var mediaGeral = notaTotal / nrAlunos;

                        Conceito conceitoGeral;

                        if(mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(mediaGeral<4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if(mediaGeral<6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral<8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                         else
                        {
                            conceitoGeral = Conceito.A;
                        }
                        Console.WriteLine($"Media geral: {mediaGeral} - Conceito: {conceitoGeral}");
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

*/

using System;

class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double divisao = X / Y; // Digite aqui o calculo da divisao
                Console.WriteLine(divisao.ToString("N1"));
            }
        }
    }
}