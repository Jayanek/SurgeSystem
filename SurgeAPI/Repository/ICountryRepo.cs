using SurgeAPI.Models;

namespace SurgeAPI.Repository
{
    public interface ICountryRepo
    {
        List<Country> GetCountryList();
    }
}
