using SharpTrooper.Entities;

namespace Hackathon_Project2.Services
{
    public interface IStarWarsApiService
    {
        SharpEntityResults<Film> GetAllFilms(string pageNumber = "1");
        SharpEntityResults<People> GetAllPeople(string pageNumber = "1");
        SharpEntityResults<Planet> GetAllPlanets(string pageNumber = "1");
        SharpEntityResults<Specie> GetAllSpecies(string pageNumber = "1");
        SharpEntityResults<Starship> GetAllStarships(string pageNumber = "1");
        SharpEntityResults<Vehicle> GetAllVehicles(string pageNumber = "1");
        Film GetFilm(string id);
        People GetPeople(string id);
        Planet GetPlanet(string id);
        T GetSingleByUrl<T>(string url) where T : SharpEntity;
        Specie GetSpecie(string id);
        Starship GetStarship(string id);
        Vehicle GetVehicle(string id);
    }
}