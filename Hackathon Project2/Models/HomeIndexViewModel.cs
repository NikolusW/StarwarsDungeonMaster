using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hackathon_Project2.Models
{
    public class HomeIndexViewModel
    {
        private SelectList _FilmSelectList { get; set; }
        public SelectList _CharacterSelectList  { get; set; }
        // chubaka, han solo, jabba the hut, emeroro prop
        public SelectList FilmSelectList
        {
            get
            {
                if (_FilmSelectList != null)
                {
                    return _FilmSelectList;
                }
                return new SelectList(GetFilms(), "Title", "Title");
            }

            set { _FilmSelectList = value; }
        }

        public SelectList CharacterSelectList
        {
            get
            {
                if (_CharacterSelectList != null)
                {
                    return _CharacterSelectList;
                }
                return new SelectList(GetCharacters(), "Name", "Name");
            }
        }

        private List<FilmModel> GetFilms()
        {
            var films = new List<FilmModel>();
            films.Add(new FilmModel() { Id = "1", Title = "A New Hope" });
            films.Add(new FilmModel() { Id = "2", Title = "The Empire Strikes Back" });
            films.Add(new FilmModel() { Id = "3", Title = "Return of the Jedi" });
            films.Add(new FilmModel() { Id = "4", Title = "The Phantom Menace" });
            films.Add(new FilmModel() { Id = "5", Title = "Attack of the Clones" });
            films.Add(new FilmModel() { Id = "6", Title = "Revenge of the Sith" });

            return films;
        }

        private List<PlayerModel> GetCharacters()
        {
            var characters = new List<PlayerModel>();
            characters.Add(new PlayerModel() { Id = "1" , Name = "Luke Skywalker" });
            characters.Add(new PlayerModel() { Id = "2", Name = "R2-D2" });
            characters.Add(new PlayerModel() { Id = "3", Name = "Darth Vader" });
            characters.Add(new PlayerModel() { Id = "4", Name = "Owen Lars" });
            characters.Add(new PlayerModel() { Id = "5", Name = "Obi-Wan Kenobi" });

            return characters;
        }
    }
}
