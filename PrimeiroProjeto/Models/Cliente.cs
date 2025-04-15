using System.ComponentModel.DataAnnotations;
namespace PrimeiroProjeto.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [MinLength(4, ErrorMessage = "O nome precisa de 4 letras minimo....")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
