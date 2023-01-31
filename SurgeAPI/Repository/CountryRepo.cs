using SurgeAPI.Models;

namespace SurgeAPI.Repository
{
    public class CountryRepo : ICountryRepo
    {
        private readonly SakilaContext context;

        public CountryRepo(SakilaContext context)
        {
            this.context = context;
        }
        public List<Country> GetCountryList()
        {
            var countries =  context.Countries.ToList();
            return countries;
        }
    }
}
