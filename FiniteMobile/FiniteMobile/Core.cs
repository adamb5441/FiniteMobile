using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiniteMobile
{
    class Core
    {
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            string queryString = "https://finiteapi.azurewebsites.net/api/Test/GetAccount";

            dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);
            var accounts = new List<Account>();
            if (results["Account"] != null)
            {
                foreach (var result in results)
                {
                    var account = new Account()
                    {
                        Id = result.Id,
                        HouseholdId = result.HouseholdId,
                        Name = results.Name,
                        InitialBalance = result.InitialBalance,
                        CurrentBalance = result.CurrentBalance,
                        LowBalanceLevel = result.LowBalanceLevel
                    };
                    accounts.Add(account);
                }
                return accounts;
            }

            else { return null; }
        }
    }
}
