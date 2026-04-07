using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces;

public interface ICoresRepository
{
    List<Cor> Listar();
}