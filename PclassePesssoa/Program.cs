using System;

namespace PclassePesssoa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[,] Cadastro = new String[3, 4];

            Console.WriteLine("******** Cadastrar de usuario *******\n");


            InserirDados();

            Console.Clear();

            ImprimirDados();



            void InserirDados()
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
                // for (int j = 0; j < 3; j++)
                // {

                Console.WriteLine();
                Pessoa pessoa1 = new Pessoa(Cadastro[0, 0], Cadastro[0, 1], Cadastro[0, 2], Cadastro[0, 3]);
                Console.WriteLine(pessoa1.ToString());
                Console.WriteLine();

                Console.WriteLine();
                Pessoa pessoa2 = new Pessoa(Cadastro[1, 0], Cadastro[1, 1], Cadastro[1, 2], Cadastro[1, 3]);
                Console.WriteLine(pessoa2.ToString());
                Console.WriteLine();
                Console.WriteLine();

                Pessoa pessoa3 = new Pessoa(Cadastro[2, 0], Cadastro[2, 1], Cadastro[2, 2], Cadastro[2, 3]);
                Console.WriteLine(pessoa3.ToString());
                Console.WriteLine();
                //}
            }


        }
    }
}
