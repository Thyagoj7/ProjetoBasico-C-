using System.Runtime.Serialization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;
using System.Globalization;
using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5]; //Um array aluno ele precisa ser iniciado: Iniciamos com 5
            var indiceAluno = 0;  //Vai mostrar o indice do array onde sera colocado o aluno adicionado

            string opcaoUsuario = ObterOpcaoUsuario(); //O methodo sera chamado por aqui

    
            

            while (opcaoUsuario.ToUpper() != "x") //Mesmo se o usuario coloque um x minusculo eu vou transformar em maiusculo e comparar
            {
                switch(opcaoUsuario)
                {
                    case "1":
                            //TODO: adicionar aluno
                            Console.WriteLine ("Informar o nome do aluno:");
                            Aluno aluno = new Aluno(); //Instanciando um objeto do tipo aluno
                            aluno.Nome = Console.ReadLine(); //Ja vai por direto do console o valor :vai setar o valor no Objeto

                            Console.WriteLine("Informar a nota do aluno:");
                            //var nota = decimal.Parse(Console.ReadLine()); //O codigo poderia ficar sem o var nota só assim (decimal.Parse(Console.ReadLine());) Mas se tentar por um valor sem ser decimal iria dar um erro no codigo 
                            //O if vai analisar se o valor passado é realmente um decimal
                           if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                           {
                               aluno.Nota=nota;
                           } 
                           else
                           {
                               throw new ArgumentException("Valor da nota deve ser decimal");
                           }

                           alunos[indiceAluno] = aluno; //vai direcionar o aluno para o indice do array
                           indiceAluno++;   //apos a alocação do aluno damos um ++ para o procimo indice ser o proximo numero
                        
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
