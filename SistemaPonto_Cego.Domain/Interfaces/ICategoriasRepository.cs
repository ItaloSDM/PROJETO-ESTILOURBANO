using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces;

public interface ICategoriasRepository
{
    List<Categoria> Listar();
}