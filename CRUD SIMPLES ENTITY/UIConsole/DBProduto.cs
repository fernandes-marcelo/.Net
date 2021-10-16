using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class DBProduto : DbContext 
        /*
          A DbContext instance represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database 
         and group together changes that be written back to the stores as a unit. DbContext is conceptually similar to ObjectContext.
         */
    {
        public DbSet<Produto> Produtos { get; set; } //cria uma tabela 'Produtos' com os atributos declarados na classe 'Produto'.


    }
}
