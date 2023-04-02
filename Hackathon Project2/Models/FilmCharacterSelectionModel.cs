using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hackathon_Project2.Models
{
    public class FilmCharacterSelectionModel
    {

        public string? selectedFilm { get; set; }

        public string? selectedCharacter { get; set; }

        public List<SelectListItem>? FilmSelectList  { get; set; }

        public List<SelectListItem>? CharacterSelectList { get; set; }

        [Required]
        public string? Film { get; set; }

        [Required]
        public string? Character { get; set; }
    }
}
