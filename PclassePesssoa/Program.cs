using System;

namespace PclassePesssoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            String[,] Cadastro = new String[3, 4];

            Console.WriteLine("******** Cadastrar de usuario *******\n");
            
            Cadastros();
            Console.Clear();

            ImprimirDados();

            

            void Cadastros()
            {
                for (int linhas = 0; linhas < 3; linhas++)
                {
                    for (int coluna = 0; coluna < 4; coluna++)
                    {

                        switch (coluna)
                        {
                            case 0:
                                Console.Write("Digite   o   nome: ");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                                //  Console.ReadKey();
                                break;
                            case 1:
                                Console.Write("Digite   a   data: ");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                                //  Console.ReadKey();
                                break;
                            case 2:
                                Console.Write("Digite   o    CPF: ");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                                //  Console.ReadKey();
                                break;
                            case 3:
                                Console.Write("Digite o telefone: ");
                                Cadastro[linhas, coluna] = Console.ReadLine();
                                Console.WriteLine();
                                //  Console.ReadKey();
                                break;

                        
                        }

                    }

                }

            }


            void ImprimirDados()
            {
                Console.WriteLine("******** Cadastro dos usuarios *******\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine();
                    Pessoa pessoa = new Pessoa(Cadastro[j, 0], Cadastro[j, 1], Cadastro[j, 2], Cadastro[j,3]);
                    Console.WriteLine(pessoa.ToString());
                    Console.WriteLine();
                }
            }
            

        }
    }
}
