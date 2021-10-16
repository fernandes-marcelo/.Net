using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class Program
    {
        static void Main(string[] args)
        {

            ProdutoAplicacao app = new ProdutoAplicacao();

            Produto produto01 = new Produto(); //crio o objeto da classe 'Produto' que possui somente os atributos nome e id.

            //produto01.Id = 2; 
            //produto01.Nome = "Feijão Preto";
            //produto01.Categoria = "Grãos";
            //app.Salvar(produto01); //insert no banco.
            //app.AlterarNome(produto01);
            //app.Excluir(1); //-- se n tiver o id ele da erro. Precisa de um if.

            foreach (var produtoNaLista in app.Listar())
            {
                Console.WriteLine("{0} - {1}", produtoNaLista.Id, produtoNaLista.Nome);
            }


            Console.ReadKey();
            

        }
    }
}
