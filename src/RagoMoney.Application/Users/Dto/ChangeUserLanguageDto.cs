using System.ComponentModel.DataAnnotations;

namespace RagoMoney.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}