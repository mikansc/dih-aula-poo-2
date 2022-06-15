namespace OrientacaoObjeto.Models;

class Pagamento
{
  public Guid Id { get; set; }
  public DateTime DataPagamento { get; set; }
  public DateTime DataVencimento { get; set; }
  public decimal Valor { get; set; }
  public string Descricao { get; set; }

  public virtual void Pagar(decimal valor)
  {
    Console.WriteLine("Método pagar no Pagamento");
    Valor = valor;
    DataPagamento = DateTime.Now;
  }
}