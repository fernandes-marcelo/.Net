using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    public class ListaContext : DbContext
    {
        public DbSet<Item> Itens { get; set; }
    }
}
