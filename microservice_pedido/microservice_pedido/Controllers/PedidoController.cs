using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservice_pedido.Models;
using microservice_pedido.Repository;
using Microsoft.AspNetCore.Mvc;

namespace microservice_pedido.Controllers
{
    [Produces("application/json")]
    //[Route("microservice/pedido")]
    public class PedidoController : Controller
    {
        private readonly PedidoRepository _repository;

        public PedidoController()
        {
            _repository = new PedidoRepository();
        }

        // GET microservice/produto
        [Route("microservice/pedido")]
        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _repository.Get(null, null);
        }

        // GET microservice/produto/cliente/{id}
        [Route("microservice/pedido/cliente/{idCliente}")]
        [HttpGet]
        public IEnumerable<Pedido> GetCliente(string idCliente)
        {
            return _repository.Get(idCliente, null);
        }

        // GET microservice/produto/produto/{id}
        [Route("microservice/pedido/produto/{idProduto}")]
        [HttpGet]
        public IEnumerable<Pedido> GetProduto(string idProduto)
        {
            return _repository.Get(null, idProduto);
        }

        // GET microservice/produto
        [Route("microservice/pedido/cliente/{idCliente}/produto/{idProduto}")]
        [HttpGet]
        public IEnumerable<Pedido> Get(string idCliente, string idProduto)
        {
            return _repository.Get(idCliente, idProduto);
        }
    }
}
