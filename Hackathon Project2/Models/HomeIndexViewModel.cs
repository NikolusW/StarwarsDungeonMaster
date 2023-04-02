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
                return new SelectList(GetFilms(), "Id", "Title");
            }

            set { _FilmSelectList = value; }
        }

        public SelectList CharacterSelectList
        {
            get
            {
                if (_CharacterSelectList != null)
                {
                    return _Character
                }
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
    }
}
