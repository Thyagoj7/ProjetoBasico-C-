using System.Resources;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Text;
using System.ComponentModel.Design.Serialization;
using System.Data.Common;
using System.Runtime.Serialization.Json;
using System.Runtime.InteropServices;
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
                            foreach (var a in alunos)
                            {   //NEste contexto o a é um objeto
                                //Foreach Para cada a no array ou seja para cada aluno imprima
                               
                               if(!String.IsNullOrEmpty(a.Nome)) //IsNullOrEmpty é um metodo para string que ele retorna se é nulo ou vazio se for retorna true se não for retorna false
                               {
                                Console.WriteLine("ALUNO: " + a.Nome + "NOTA: " + a.Nota);
                               }
                            }

                        break;
                    case "3":
                            //TODO: Calcular média geral
                            decimal notaTotal = 0;
                            var nrAlunos = 0; //Quantidade de alunos
                    

                            for (int i=0; i < alunos.Length; i++)
                            {
                                if(!string.IsNullOrEmpty(alunos[i].Nome)) //IsNullOrEmpty é um metodo para string que ele retorna se é nulo ou vazio se for retorna true se não for retorna false,// Se não for nulo vai retornar o aluno do numero do array
                                {
                                    notaTotal=notaTotal + alunos[i].Nota; //vai somar a nota total + a nota vinda do aluno do array
                                    nrAlunos++; //vai inclementando o nrAlunos 
                                }
                            }

                            var mediaGeral = notaTotal/nrAlunos;        //Calcular a media dos alunos
                            Conceito conceitoGeral;
                            
                            if(mediaGeral < 2)
                            {
                                conceitoGeral = Conceito.E;
                            }
                            else if(mediaGeral < 4)
                            {
                                conceitoGeral = Conceito.D;
                            }
                            else if(mediaGeral < 6)
                            {
                                conceitoGeral = Conceito.C;
                            }
                            else if(mediaGeral < 8)
                            {
                                conceitoGeral = Conceito.B;
                            }
                            else 
                            {
                                conceitoGeral = Conceito.A;
                            }

                            Console.WriteLine("Media Geral: " + mediaGeral + "Conceito Geral " + conceitoGeral);


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
            Console.WriteLine();
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
