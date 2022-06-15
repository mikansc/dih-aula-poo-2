using OrientacaoObjeto.Models;
namespace OrientacaoObjeto;
// DEVInPayments
class Program
{
  static void Main(string[] args)
  {
    PagamentoBoleto boleto = new PagamentoBoleto();
    boleto.DataVencimento = new DateTime(2022, 06, 14); // antiga
    boleto.Pagar(100.00M);

    PagamentoBoleto boleto2 = new PagamentoBoleto();
    boleto2.DataVencimento = new DateTime(2022, 06, 20); // futura
    boleto2.Pagar(100.00M);

    PagamentoPix pix = new PagamentoPix();
    pix.DataVencimento = new DateTime(2022, 06, 10); // antiga
    pix.Pagar(49.99M);

    Pagamento umPagamento = new PagamentoBoleto();
    Pagamento outroPagamento = new PagamentoPix();

    PagamentoBoleto pagamentoDowncasting = (PagamentoBoleto)new Pagamento();

    IList<Pagamento> listaPagamentos = new List<Pagamento>();
  }
}
