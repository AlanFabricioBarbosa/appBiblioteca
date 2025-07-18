namespace Domain
{
   public class Livro
   {
      public Guid Id { get; set; } = Guid.NewGuid();
      public Guid CatalogoId { get; set; }
      public bool Disponivel { get; set; } = true;
   }
}

