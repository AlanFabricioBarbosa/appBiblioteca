namespace Domain
{
   public class Catalogo
   {
      public Guid Id { get; set; } = Guid.NewGuid();
      public string Titulo { get; set; } = "";
      public string Autor { get; set; } = "";
      public string ISBN { get; set; } = "";
      public int CopiasDisponiveis { get; set; }

      public string Genero { get; set; } = "";
      public string Editora { get; set; } = "";
      public int AnoPublicacao { get; set; }
   }
}
