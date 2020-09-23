using System.ComponentModel.DataAnnotations;

namespace Queue.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}