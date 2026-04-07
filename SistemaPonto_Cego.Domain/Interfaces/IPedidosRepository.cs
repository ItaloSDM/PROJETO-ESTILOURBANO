using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces;

public interface IPedidosRepository
{
    void CriarPedido(Pedido pedido);
    List<Pedido> Listar();
}