using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces;


public interface IItens_PedidoRepository
{
    void Adicionar(Itens_Pedido item);
    List<Itens_Pedido> ListarPorPedido(int pedidoId);
}