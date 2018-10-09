using System.ComponentModel.DataAnnotations;

namespace ProjectBaseX.Api.ViewsModels
{
    /// <summary>
    /// View de usuario
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// Nome de usuário 
        /// </summary>
        [Required] 
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Senha de acesso
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "AccessKey")]
        public string AccessKey { get; set; }
    }
}
