using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}