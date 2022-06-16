namespace OrientacaoObjeto.Models;

public interface IPagamentos
{
  void Pagar(decimal valor);
  void Estornar();
  decimal ConsultarSaldo();
};