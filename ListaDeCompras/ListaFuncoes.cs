using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string queryInsert = "INSERT INTO ### VALUES('"+itens.NomeProduto+"');";
            var QueryResult = bancoLista.Database.SqlQuery<string>(queryInsert);
            //bancoLista.Itens.Add(itens);
            bancoLista.SaveChanges();
        }

        public void RemoverItem(Item itens)
        {
            string queryDrop = "DELETE TABLE ITENS WHERE NOME = '" + itens.NomeProduto + "';";

            var QueryResult = bancoLista.Itens.SqlQuery(queryDrop);
            bancoLista.SaveChanges();
            //

            // int query2Drop = bancoLista.Database.ExecuteSqlCommand("DELETE TABLE ##### WHERE NOME = @nome", new SqlParameter("@nome", itens.NomeProduto)); -- será que funciona ?
        }



        public IEnumerable<Item> Listar()
        {
            return bancoLista.Itens.ToList();
        }


        public IEnumerable<Item> ListarCustom()
        {
            var ResultCustomQuery = bancoLista.Itens.SqlQuery("SELECT * FROM ITENS").ToList<Item>();
            return ResultCustomQuery;
        }
    }
}



//Database.SqlQuery ()
//Database.ExecuteSqlCommand ()