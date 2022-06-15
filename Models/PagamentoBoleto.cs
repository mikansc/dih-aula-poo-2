namespace OrientacaoObjeto.Models;

class PagamentoBoleto : Pagamento
{
  public string Numero { get; set; }

  public override void Pagar(decimal valor)
  {
    if (DataVencimento < DateTime.Now)
    {
      Console.WriteLine("Não é possível pagar um boleto vencido");
    }
    else
    {
      base.Pagar(valor);
    }
  }
}

