namespace OrientacaoObjeto.Models;

class PagamentoBoleto : Pagamento, IPagamentos
{
  public string Numero { get; set; }
}

