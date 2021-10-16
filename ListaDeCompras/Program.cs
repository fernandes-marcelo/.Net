using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaFuncoes app = new ListaFuncoes();
            Item produto = new Item();

            Console.WriteLine("\t################################# BEM VINDO A LISTA DE COMPRAS! #################################");
            int controle = 0;

            while(controle != 4)
            {
                Console.WriteLine("\n\t#################################  ESCOLHA UMA OPÇÃO #################################\n\t\t\t\t 1-VER LISTA\t\t 2-ADICIONAR ITEM\n\t\t\t\t 3-REMOVER ITEM\t\t 4-SAIR");
                controle = Convert.ToInt32(Console.ReadLine());

                if(controle == 1 || controle == 2 || controle == 3 || controle == 4) {
                    switch (controle)
                    {
                        case 1: //função de mostrar lista
                            Console.WriteLine("\n\n\t\t Nome do Produto\n");
                            foreach (var produtosNaLista in app.Listar())
                            {
                                Console.WriteLine("\t\t{0}", produtosNaLista.NomeProduto);
                            }
                            break;

                        case 2: //função de adicionar item
                            Console.Write("Qual item deseja adicionar?\t\t");
                            produto.NomeProduto = Console.ReadLine();
                            app.AdicionarItem(produto);

                            break;

                        case 3: //função de remover item
                            Console.WriteLine("\n\n\t\t Nome do Produto\n");
                            foreach (var produtosNaLista in app.Listar())
                            {
                                Console.WriteLine("\t\t{0}", produtosNaLista.NomeProduto);
                            }
                            Console.Write("\n\t\t Qual item deseja remover da lista?");
                            produto.NomeProduto = Console.ReadLine();
                            app.RemoverItem(produto);


                            break;

                        default: //sair
                            break;
                    }
                }
                    else
                    {
                        Console.WriteLine("\n\n\nOpção Inválida!\n\n\n");
                    }
            }

            Console.WriteLine("################################# FIM DA EXECUÇÃO! #################################");
            Console.ReadKey();
        }
    }
}

//Classe principal do meu programa.
