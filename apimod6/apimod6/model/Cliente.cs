using System.ComponentModel.DataAnnotations;

namespace apimod6.model
{ 
 
    public class Cliente
    {
        [Key] 
        public int Id_cli { get; set; }
        [Required(ErrorMessage = "Id")]

        [StringLength(40, MinimumLength = 10, ErrorMessage = "O campo cidade deve entre 10 a 50 caracteres")] 
        public string Cidade { get; set; }

        [StringLength(15, MinimumLength = 11, ErrorMessage = "O campo cpf deve entre 11 a 15 caracteres")] 
        public string Cpf { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "O campo email deve entre 1 a 50 caracteres")]
        public string Email { get; set; }
        
        [StringLength(50, MinimumLength = 20, ErrorMessage = "O campo logradouro deve entre 11 a 15 caracteres")]
        public string Logradouro { get; set; }

        [StringLength(30, MinimumLength = 10, ErrorMessage = "O campo nome deve entre 11 a 15 caracteres")]
        public string Nome { get; set; }

        [StringLength(20, MinimumLength = 10, ErrorMessage = "O campo senha deve entre 11 a 15 caracteres")]
        public string Senha { get; set; }

        [StringLength(12, MinimumLength = 11, ErrorMessage = "O campo Telefone deve entre 11 a 15 caracteres")]
        public string Telefone { get; set; }
    }
}
