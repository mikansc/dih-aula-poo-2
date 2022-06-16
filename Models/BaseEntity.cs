namespace OrientacaoObjeto.Models;


abstract class BaseEntity
{
  public Guid Id { get; set; }

  public BaseEntity()
  {
    Console.WriteLine("Construtor da BaseEntity");
    Id = Guid.NewGuid();
  }
}