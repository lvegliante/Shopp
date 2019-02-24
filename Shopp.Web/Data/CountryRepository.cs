
namespace Shopp.Web.Data
{
    using Shopp.Web.Data.Entities;
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {
        }
    }

}
