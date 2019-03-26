using FiniteMobile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace FiniteMobile
{
    class Core
    {
        public async Task<IEnumerable<Household>> GetHouseholds()
        {
            string queryString = "https://finiteapi.azurewebsites.net/api/Test/GetHouseholds";

            try
            {
                dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);
                if(results != null)
                {
                    var data = JsonConvert.DeserializeObject<List<Household>>(results.ToString());
                    return data;
                }
            }
            catch(Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }
            return null;
        }

        public async Task<IEnumerable<Account>> GetAccounts(int id)
        {
            string queryString = "https://finiteapi.azurewebsites.net/api/Test/GetAccounts?id=" + id.ToString();

            try
            {
                dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);
                if (results != null)
                {
                    var data = JsonConvert.DeserializeObject<List<Account>>(results.ToString());
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }
            return null;
        }
    }
}
