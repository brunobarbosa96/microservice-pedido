namespace microservice_pedido.Models
{
    public class Pedido
    {
        public string IdCliente { get; set; }
        public string IdProduto { get; set; }
        public short Quantidade { get; set; }
    }
}
