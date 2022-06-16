namespace OrientacaoObjeto.Models;

abstract class Pagamento : BaseEntity, IPagamentos
{
  public DateTime DataPagamento { get; set; }
  public DateTime DataVencimento { get; set; }
  public decimal Valor { get; set; }
  public string Descricao { get; set; }



  public decimal ConsultarSaldo()
  {
    throw new NotImplementedException();
  }

  public void Estornar()
  {
    throw new NotImplementedException();
  }

  public virtual void Pagar(decimal valor)
  {
    Console.WriteLine("Método pagar no Pagamento");
    Valor = valor;
    DataPagamento = DateTime.Now;
  }

  public virtual void Pagar(decimal valor, DateTime dataPagamento)
  {
    Console.WriteLine("Método pagar no Pagamento");
    Valor = valor;
    DataPagamento = dataPagamento;
  }
}