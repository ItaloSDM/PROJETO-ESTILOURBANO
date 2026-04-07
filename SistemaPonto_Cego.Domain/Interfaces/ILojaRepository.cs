using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces;


public interface ILojaRepository
{
    void Adicionar(Loja loja);
    void Atualizar(Loja loja);
    Loja Obter();
}