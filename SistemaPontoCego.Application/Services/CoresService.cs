using EstiloUrbano.Domain.Entities;
using EstiloUrbano.Domain.Interfaces;

public class CoresService
{
    private readonly ICoresRepository _repo;

    public CoresService(ICoresRepository repo)
    {
        _repo = repo;
    }

    public List<Cor> Listar()
    {
        return _repo.Listar();
    }
}