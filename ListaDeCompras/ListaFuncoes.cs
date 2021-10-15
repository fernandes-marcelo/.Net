using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    class ListaFuncoes
    {
        ListaContext bancoLista { get; set; }

        public ListaFuncoes()
        {
            bancoLista = new ListaContext();
        }



        public void AdicionarItem(Item itens)
        {
            bancoLista.Itens.Add(itens);
            bancoLista.SaveChanges();
        }

        public void RemoverItem(Item itens)
        {
            var obj = bancoLista.Itens.Where(x => x.NomeProduto == itens.NomeProduto);
            bancoLista.Itens.Remove(obj);
        }



        public IEnumerable<Item> Listar()
        {
            return bancoLista.Itens.ToList();
        }

    }
}
