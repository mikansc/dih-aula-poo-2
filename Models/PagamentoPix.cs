namespace OrientacaoObjeto.Models;

class PagamentoPix : Pagamento, IPagamentos
{
  public string Chave { get; set; }

  public PagamentoPix()
  {
  }

  public PagamentoPix(DateTime dataPagamento, decimal valor)
  {
    base.Valor = valor;
    base.DataPagamento = dataPagamento;
  }

  public PagamentoPix(DateTime dataPagamento, decimal valor, string descricao)
  {
    base.Valor = valor;
    base.DataPagamento = dataPagamento;
    base.Descricao = descricao;
  }

}