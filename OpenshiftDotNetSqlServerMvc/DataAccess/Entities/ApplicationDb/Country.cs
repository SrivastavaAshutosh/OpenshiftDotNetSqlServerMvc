using System;
using System.Collections.Generic;

#nullable disable

namespace OpenshiftDotNetSqlServerMvc.DataAccess.Entities.ApplicationDb
{
    public partial class Country
    {
        public Country()
        {
            State = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<State> State { get; set; }
    }
}
