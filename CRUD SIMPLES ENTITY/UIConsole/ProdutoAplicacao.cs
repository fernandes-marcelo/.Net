using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class ProdutoAplicacao
    {
        public DBProduto banco { get; set; }

        public ProdutoAplicacao()
        {
            banco = new DBProduto();
        }

        public void Salvar(Produto produto)
        {
            
            banco.Produtos.Add(produto);
            banco.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return banco.Produtos.ToList();
        }

      /*  public void Listar2()
        {

            // string querySelect = "SELECT * FROM DBO.Produtoes;";

            var QueryResult = banco.Database.SqlQuery<string>("SELECT * FROM DBO.Produtoes; ").ToList();

            foreach (var produtoNaLista in QueryResult)
            {
                Console.WriteLine("{0}", produtoNaLista);
            }
            //Console.WriteLine("{0}", QueryResult);
        }
*/

        public void AlterarNome(Produto produto)
        {
            Produto produtoSalvar = banco.Produtos.Where(x => x.Id == produto.Id).First();
            produtoSalvar.Nome = produto.Nome;
            banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Produto produtoExcluir = banco.Produtos.Where(x => x.Id == id).First();
            banco.Set<Produto>().Remove(produtoExcluir);
            banco.SaveChanges();

        }

        public IEnumerable<Produto> CustomSelect()
        {
            var listaProdutos = banco.Produtos.SqlQuery("SELECT * FROM PRODUTOS").ToList<Produto>();
            return listaProdutos;
        }
    }
}
