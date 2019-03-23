using System;
using System.Collections.Generic;
using System.Text;

namespace FiniteMobile
{
    class Account
    {
        public int Id { get; set; }
        public int? HouseholdId { get; set; }
        public string Name { get; set; }
        public Decimal InitialBalance { get; set; }
        public Decimal CurrentBalance { get; set; }
        public Decimal? LowBalanceLevel { get; set; }

    }
}
