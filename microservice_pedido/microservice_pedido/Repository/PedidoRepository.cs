using System.Collections.Generic;
using microservice_pedido.Infra;
using microservice_pedido.Models;
using Microsoft.AspNetCore.Hosting;

namespace microservice_pedido.Repository
{
    public class PedidoRepository : BaseRepository
    {
        private enum Procedures
        {
            SelecionarPedido
        }

        public IEnumerable<Pedido> Get(string idCliente, string idProduto)
        {
            ExecuteProcedure(Procedures.SelecionarPedido);
            AddParameter("@idCliente", idCliente);
            AddParameter("@idProduto", idProduto);
            var pedidos = new List<Pedido>();
            using (var r = ExecuteReader())
                while (r.Read())
                    pedidos.Add(new Pedido{
                        IdCliente = r.GetString(r.GetOrdinal("idCliente")),
                        IdProduto = r.GetString(r.GetOrdinal("idProduto")),
                        Quantidade = r.GetInt16(r.GetOrdinal("quantidade"))
                    });

            return pedidos;
        }
    }
}
