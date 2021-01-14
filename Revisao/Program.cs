using Internal;
using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario(); //O methodo sera chamado por aqui

    
            

            while (opcaoUsuario.ToUpper() != "x") //Mesmo se o usuario coloque um x minusculo eu vou transformar em maiusculo e comparar
            {
                switch(opcaoUsuario)
                {
                    case "1":
                            //TODO: adicionar aluno
                        break;
                    case "2":
                            //TODO: Lista de Alunos
                        break;
                    case "3":
                            //TODO: Calcular média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(); //caso seja colocado um valor acima do 3
                        
            
                }
                //Se for diferente de X ele le o codigo novamente
                opcaoUsuario = ObterOpcaoUsuario();


            
            }
        }
        
        private static  string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X-sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine("");
            return opcaoUsuario;
        }
    }
}
