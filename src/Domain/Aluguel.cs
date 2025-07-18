namespace Domain
{
   public enum StatusAluguel
   {
      Emprestado,
      Devolvido,
      Atrasado
   }

   public class Aluguel
   {
      public Guid Id { get; set; } = Guid.NewGuid();
      public Guid LivroId { get; set; }
      public Guid UsuarioId { get; set; }
      public DateTime DataEmprestimo { get; set; } = DateTime.Now;
      public DateTime DataDevolucaoPrevista { get; set; }
      public DateTime? DataDevolucao { get; set; }
      public StatusAluguel Status { get; set; } = StatusAluguel.Emprestado;
   }
}
