namespace Domain
{
   public class Usuario
   {
      public Guid Id { get; set; } = Guid.NewGuid();
      public string Nome { get; set; } = "";

      public string Rua { get; set; } = "";
      public string Bairro { get; set; } = "";
      public string CEP { get; set; } = "";
      public string Cidade { get; set; } = "";
      public string Estado { get; set; } = "";

      public string Email { get; set; } = "";
      public string Telefone { get; set; } = "";
   }
}

