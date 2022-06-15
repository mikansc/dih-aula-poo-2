using OrientacaoObjeto.Models;
namespace OrientacaoObjeto;
// DEVInPayments
class Program
{
  static void Main(string[] args)
  {
    var boleto = new PagamentoBoleto();
    boleto.DataVencimento = new DateTime(2022, 06, 14); // antiga
    boleto.Pagar(100.00M);

    var boleto2 = new PagamentoBoleto();
    boleto2.DataVencimento = new DateTime(2022, 06, 20); // futura
    boleto2.Pagar(100.00M);

    var pix = new PagamentoPix();
    pix.DataVencimento = new DateTime(2022, 06, 10); // antiga
    pix.Pagar(49.99M);

  }
}