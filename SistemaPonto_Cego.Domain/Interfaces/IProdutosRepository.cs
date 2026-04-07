using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces;


public interface IProdutosRepository
{
    void Adicionar(Produto produto);
    List<Produto> Listar();
    void Remover(int id);
}