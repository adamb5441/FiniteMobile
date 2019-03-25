using FiniteMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiniteMobile
{
    class Core
    {
        public async Task<IEnumerable<Household>> GetHouseholds()
        {
            string queryString = "https://finiteapi.azurewebsites.net/api/Test/GetHouseholds";

            dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);
            var Households = new List<Household>();
            if (results["Household"] != null)
            {
                foreach (var result in results)
                {
                    var house = new Household()
                    {
                        Id = result.Id,
                        Name = results.Name,
                        Greeting = results.Greeting,
                    };
                    Households.Add(house);
                }
                return Households;
            }

            else { return null; }
        }
    }
}
