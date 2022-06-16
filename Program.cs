using OrientacaoObjeto.Models;
namespace OrientacaoObjeto;
// DEVInPayments
class Program
{
  static void Main(string[] args)
  {

    PagamentoPix pagamento = new PagamentoPix(DateTime.Now, 100.00M, "Pagamento pela aula do tio Mika");


    PagamentoPix pagamento1 = new PagamentoPix
    {
      Id = Guid.NewGuid(),
      DataPagamento = DateTime.Now
    };


    pagamento.Pagar(150.05M, new DateTime(2022, 06, 22));

  }
}
