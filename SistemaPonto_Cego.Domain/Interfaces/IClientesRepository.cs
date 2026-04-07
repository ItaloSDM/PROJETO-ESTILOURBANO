using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces;

public interface IClientesRepository
{
    void Adicionar(Cliente cliente);
    List<Cliente> Listar();
}