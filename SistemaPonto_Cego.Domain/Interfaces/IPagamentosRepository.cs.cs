using EstiloUrbano.Domain.Entities;

namespace EstiloUrbano.Domain.Interfaces
{
    public interface IPagamentosRepository
    {
        List<Pagamento> Listar();
        void Adicionar(Pagamento pagamento);
    }
}