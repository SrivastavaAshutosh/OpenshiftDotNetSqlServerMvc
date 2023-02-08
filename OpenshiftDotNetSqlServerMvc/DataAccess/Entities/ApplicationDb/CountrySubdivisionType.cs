using System;
using System.Collections.Generic;

#nullable disable

namespace OpenshiftDotNetSqlServerMvc.DataAccess.Entities.ApplicationDb
{
    public partial class CountrySubdivisionType
    {
        public CountrySubdivisionType()
        {
            State = new HashSet<State>();
        }

        public int CountrySubdivisionTypeId { get; set; }
        public string CountrySubdivisionTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<State> State { get; set; }
    }
}
